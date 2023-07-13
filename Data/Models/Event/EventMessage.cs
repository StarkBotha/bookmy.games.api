using bookmy.games.api.Data.Models.Auth;

namespace bookmy.games.api.Data.Models.Event;

public class EventMessage
{
    public Event Event { get; set; } = null!;
    public User User { get; set; } = null!;
    public string Message { get; set; } = null!;
}
