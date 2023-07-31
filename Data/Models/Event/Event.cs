using bookmy.games.api.Data.Models.Shared;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace bookmy.games.api.Data.Models.Event;

public class Event : External
{
    public string Name { get; set; } = null!;
    public DateTime When { get; set; }
    public int DurationMinutes { get; set; }
    public List<Invitation> Invitations { get; set; } = null!;
    public List<EventMessage> MessagesList { get; set; } = null!;
}

public static class EventConfig
{
    public static void Configure(EntityTypeBuilder<Event> config)
    {
        //Id
        //IsDeleted
        EntityBaseConfig.Configure(config);

        //ExternalId
        ExternalConfig.Configure(config);

        //Name

        //When

        //DurationMinutes

        //Invitations

        //MessagesList
    }
}
