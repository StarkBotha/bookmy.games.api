using bookmy.games.api.Data.Models.Auth;

namespace bookmy.games.api.Data.Models.Clan;

public class ClanMember : EntityBase
{
    public User User { get; set; } = null!;
    public Clan Clan { get; set; } = null!;
    public ClanRole Role { get; set; } = null!;
}
