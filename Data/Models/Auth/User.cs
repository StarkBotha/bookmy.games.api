namespace bookmy.games.api.Data.Models.Auth;

public class User : External
{
    public string Email { get; set; } = null!;
    public string PasswordHash { get; set; } = null!;
    public string PasswordSalt { get; set; } = null!;
    public bool IsSystemUser { get; set; }
}
