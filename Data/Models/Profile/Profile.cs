using bookmy.games.api.Data.Models.Auth;
using bookmy.games.api.Data.Models.Clan;
using bookmy.games.api.Data.Models.Event;

namespace bookmy.games.api.Data.Models.Profile;

public class Profile : External
{
    public User User { get; set; } = null!;
    public List<ProfileLanguage> Languages { get; set; } = null!;
    public List<Invitation> Invitations { get; set; } = null!;
    public List<ClanMember> Memberships { get; set; } = null!;
    public List<ProfileImage> ProfileImages { get; set; } = null!;
}
