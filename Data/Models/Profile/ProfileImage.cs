using bookmy.games.api.Data.Models.Shared;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace bookmy.games.api.Data.Models.Profile;

public class ProfileImage : EntityBase
{
    public Profile Profile { get; set; } = null!;
    public byte[] ImageData { get; set; } = null!;
}

public static class ProfileImageConfig
{
    public static void Configure(EntityTypeBuilder<ProfileImage> config)
    {
        //Id
        //IsDeleted
        EntityBaseConfig.Configure(config);

        //Profile

        //ImageData
    }
}
