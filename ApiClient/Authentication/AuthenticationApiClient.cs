using System.Data;
using bookmy.games.api.Data;
using bookmy.games.api.Data.Models.Auth;
using bookmy.games.api.Requests;

namespace bookmy.games.api.ApiClient.Authentication;

public class AuthenticationApiClient : IAuthenticationApiClient
{
    private readonly DataContext _context;

    public AuthenticationApiClient(DataContext context)
    {
        _context = context;
    }

    public async Task Register(RegisterUserRequest request)
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
}
