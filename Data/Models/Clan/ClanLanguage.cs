using bookmy.games.api.Data.Models.Shared;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace bookmy.games.api.Data.Models.Clan;

public class ClanLanguage : EntityBase
{
    public Clan Clan { get; set; } = null!;
    public Language Language { get; set; } = null!;
}

public static class ClanLanguageConfig
{
    public static void Configure(EntityTypeBuilder<ClanLanguage> config)
    {
        //Id
        //IsDeleted
        EntityBaseConfig.Configure(config);

        //Clan

        //Language
    }
}
