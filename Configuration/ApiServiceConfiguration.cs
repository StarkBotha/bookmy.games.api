using bookmy.games.api.ApiClient.Authentication;

namespace bookmy.games.api.Configuration;

public static class ApiServiceConfiguration
{
    public static void ConfigureApiServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddTransient<IAuthenticationApiClient, AuthenticationApiClient>();
    }
}
