namespace bookmy.games.api.Data.Models.Auth;

public class RoleClaim : EntityBase
{
    public Role Role { get; set; } = null!;
    public Claim Claim { get; set; } = null!;
}
