using bookmy.games.api.ApiClient.Authentication;
using bookmy.games.api.Requests;
using Microsoft.AspNetCore.Mvc;

namespace bookmy.games.api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthenticationController : ControllerBase
{
    private readonly IAuthenticationApiClient _client;

    public AuthenticationController(IAuthenticationApiClient client)
    {
        _client = client;
    }

    [HttpPost("register")]
    public async Task<IActionResult> RegisterAsync(RegisterUserRequest request)
    {
        await _client.RegisterAsync(request);

        return Ok();
    }

    [HttpPost("sign-in")]
    public async Task<IActionResult> SignIn(SignInUserRequest request)
    {
        var token = await _client.SignInAsync(request);

        return Ok(token);
    }
}
