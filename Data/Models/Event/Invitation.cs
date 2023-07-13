using bookmy.games.api.Data.Models.Auth;

namespace bookmy.games.api.Data.Models.Event;

public class Invitation : External
{
    public Event Event { get; set; } = null!;
    public User User { get; set; } = null!;
    public InvitationStatus Status { get; set; } = null!;
}
