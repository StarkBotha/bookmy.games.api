using bookmy.games.api.Data.Models.Shared;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace bookmy.games.api.Data.Models.Clan;

public class ClanRole : EntityBase
{
    public string Name { get; set; } = null!;
}


public static class ClanRoleConfig
{
    public static void Configure(EntityTypeBuilder<ClanRole> config)
    {
        //Id
        //IsDeleted
        EntityBaseConfig.Configure(config);

        //Name
    }
}
