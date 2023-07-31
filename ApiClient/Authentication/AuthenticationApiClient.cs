using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Authentication;
using System.Security.Claims;
using System.Text;
using bookmy.games.api.Data;
using bookmy.games.api.Data.Models.Auth;
using bookmy.games.api.Requests;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace bookmy.games.api.ApiClient.Authentication;

public class AuthenticationApiClient : IAuthenticationApiClient
{
    private readonly DataContext _context;
    private readonly IConfiguration _config;

    public AuthenticationApiClient(DataContext context, IConfiguration config)
    {
        _context = context;
        _config = config;
    }

    public async Task RegisterAsync(RegisterUserRequest request)
    {
        //check if user exists
        var existingUser = _context.Users.Any(u => u.Email == request.Username);
        if (existingUser) throw new EvaluateException("A user with this email address already exists");

        //Create the password hash which also contains a generated salt.
        var passwordHash = BCrypt.Net.BCrypt.HashPassword(request.Password);

        //Create the User object
        var newUser = new User()
        {
            Email = request.Username,
            PasswordHash = passwordHash
        };

        //Add the user and save
        _context.Users.Add(newUser);
        await _context.SaveChangesAsync();
    }


    public async Task<string> SignInAsync(SignInUserRequest request)
    {
        //Check if user exists
        var existingUser = await _context.Users
            .Include(u => u.Role)
            .ThenInclude(r => r.Claims)
            .ThenInclude(r => r.AuthClaim)
            .FirstOrDefaultAsync(u => u.Email == request.Username);
        if (existingUser == null) throw new UnauthorizedAccessException("User does not exist");

        //Check password
        if (!BCrypt.Net.BCrypt.Verify(request.Password, existingUser.PasswordHash))
        {
            throw new AuthenticationException("Password incorrect");
        }

        return GenerateToken(existingUser);
    }

    private string GenerateToken(User existingUser)
    {
        //Get a list of claims for the user
        var authClaims = existingUser.Role.Claims;

        var claims = new List<Claim>
        {
            new Claim(JwtRegisteredClaimNames.Sub, existingUser.ExternalId.ToString()),
            new Claim(JwtRegisteredClaimNames.Email, existingUser.Email)
        };

        claims.AddRange(authClaims.Select(authClaim => new Claim(authClaim.AuthClaim.Name, "true")));

        //Get expiration setting from config
        var expirationMinutes = _config["Jwt:ExpirationMinutes"];
        if (expirationMinutes == null) throw new ApplicationException("Jwt Expiration not configured");
        var tokenLifeSpan = TimeSpan.FromMinutes(int.Parse(expirationMinutes));

        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.UTF8.GetBytes(_config["Jwt:Key"]!);

        //Create the token descriptor
        var tokenDescriptor = new SecurityTokenDescriptor()
        {
            Subject = new ClaimsIdentity(claims),
            Expires = DateTime.UtcNow.Add(tokenLifeSpan),
            Issuer = _config["Jwt:Issuer"],
            Audience = _config["Jwt:Audience"],
            SigningCredentials =
                new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha512Signature)
        };


        var securityToken = tokenHandler.CreateToken(tokenDescriptor);

        return tokenHandler.WriteToken(securityToken);
    }
}
