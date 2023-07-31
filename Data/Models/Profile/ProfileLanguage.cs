using bookmy.games.api.Data.Models.Shared;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace bookmy.games.api.Data.Models.Profile;

public class ProfileLanguage : EntityBase
{
    public Profile Profile { get; set; } = null!;
    public Language Language { get; set; } = null!;
}

public static class ProfileLanguageConfig
{
    public static void Configure(EntityTypeBuilder<ProfileLanguage> config)
    {
        //EntityBase
        EntityBaseConfig.Configure(config);


    }
}
