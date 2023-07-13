namespace bookmy.games.api.Data.Models.Event;

public class Event : External
{
    public string Name { get; set; } = null!;
    public DateTime When { get; set; }
    public int DurationMinutes { get; set; }
    public List<Invitation> Invitations { get; set; } = null!;
    public List<EventMessage> MessagesList { get; set; } = null!;
}
