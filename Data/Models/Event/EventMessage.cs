using bookmy.games.api.Data.Models.Auth;
using bookmy.games.api.Data.Models.Shared;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace bookmy.games.api.Data.Models.Event;

public class EventMessage : EntityBase
{
    public Event Event { get; set; } = null!;
    public User User { get; set; } = null!;
    public string Message { get; set; } = null!;
}

public static class EventMessageConfig
{
    public static void Configure(EntityTypeBuilder<EventMessage> config)
    {
        //Id
        //IsDeleted
        EntityBaseConfig.Configure(config);

        //Event

        //User

        //Message
    }
}
