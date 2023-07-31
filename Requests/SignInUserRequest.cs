namespace bookmy.games.api.Requests;

public class SignInUserRequest
{
    public required string Username { get; set; }
    public required string Password { get; set; }
}
