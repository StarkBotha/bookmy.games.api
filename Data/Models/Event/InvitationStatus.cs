using bookmy.games.api.Data.Models.Shared;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace bookmy.games.api.Data.Models.Event;

public class InvitationStatus : EntityBase
{
    public string Name { get; set; } = null!;
}

public static class InvitationStatusConfig
{
    public static void Configure(EntityTypeBuilder<InvitationStatus> config)
    {
        //Id
        //IsDeleted
        EntityBaseConfig.Configure(config);

        //Name
    }
}
