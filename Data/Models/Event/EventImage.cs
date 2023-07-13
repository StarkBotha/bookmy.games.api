using bookmy.games.api.Data.Models.Shared;

namespace bookmy.games.api.Data.Models.Event;

public class EventImage : EntityBase
{
    public Event Event { get; set; } = null!;
    public byte[] ImageData { get; set; } = null!;
}
