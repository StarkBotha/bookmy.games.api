using bookmy.games.api.Requests;

namespace bookmy.games.api.ApiClient.Authentication;

public interface IAuthenticationApiClient
{
    Task Register(RegisterUserRequest request);
}
