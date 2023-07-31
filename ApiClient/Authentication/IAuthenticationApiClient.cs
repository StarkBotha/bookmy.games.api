using bookmy.games.api.Requests;

namespace bookmy.games.api.ApiClient.Authentication;

public interface IAuthenticationApiClient
{
    Task RegisterAsync(RegisterUserRequest request);
    Task<string> SignInAsync(SignInUserRequest request);
}
