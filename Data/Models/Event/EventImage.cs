using bookmy.games.api.Data.Models.Shared;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace bookmy.games.api.Data.Models.Event;

public class EventImage : EntityBase
{
    public Event Event { get; set; } = null!;
    public byte[] ImageData { get; set; } = null!;
}

public static class EventImageConfig
{
    public static void Configure(EntityTypeBuilder<EventImage> config)
    {
        //Id
        //IsDeleted
        EntityBaseConfig.Configure(config);

        //Event

        //ImageData
    }
}
