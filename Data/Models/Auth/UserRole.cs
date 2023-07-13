namespace bookmy.games.api.Data.Models.Auth;

public class UserRole : EntityBase
{
    public User User { get; set; } = null!;
    public Role Role { get; set; } = null!;
}
