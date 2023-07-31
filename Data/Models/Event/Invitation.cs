using bookmy.games.api.Data.Models.Auth;
using bookmy.games.api.Data.Models.Shared;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace bookmy.games.api.Data.Models.Event;

public class Invitation : External
{
    public Event Event { get; set; } = null!;
    public User User { get; set; } = null!;
    public InvitationStatus Status { get; set; } = null!;
}

public static class InvitationConfig
{
    public static void Configure(EntityTypeBuilder<Invitation> config)
    {
        //Id
        //IsDeleted
        EntityBaseConfig.Configure(config);

        //ExternalId
        ExternalConfig.Configure(config);

        //Event

        //User

        //Status
    }
}
