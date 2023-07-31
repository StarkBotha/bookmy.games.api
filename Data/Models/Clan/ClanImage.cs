using bookmy.games.api.Data.Models.Shared;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace bookmy.games.api.Data.Models.Clan;

public class ClanImage : EntityBase
{
    public Clan Clan { get; set; } = null!;
    public byte[] ImageData { get; set; } = null!;
}

public static class ClanImageConfig
{
    public static void Configure(EntityTypeBuilder<ClanImage> config)
    {
        //Id
        //IsDeleted
        EntityBaseConfig.Configure(config);

        //Clan

        //ImageData
    }
}
