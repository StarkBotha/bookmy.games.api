using bookmy.games.api.Data.Models.Shared;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace bookmy.games.api.Data.Models.Clan;

public class Clan : External
{
    public string Name { get; set; } = null!;
    public string DiscordUrl { get; set; } = null!;
    public List<ClanLanguage> Languages { get; set; } = null!;
    public List<ClanMember> Members { get; set; } = null!;
}

public static class ClanConfig
{
    public static void Configure(EntityTypeBuilder<Clan> config)
    {
        //Id
        //IsDeleted
        EntityBaseConfig.Configure(config);

        //ExternalId
        ExternalConfig.Configure(config);

        //Name

        //DiscordUrl

        //Fk Languages - ClanLanguage
        //Fk Members - ClanMembers
    }
}
