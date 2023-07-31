using bookmy.games.api.Data.Models.Auth;
using bookmy.games.api.Data.Models.Shared;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace bookmy.games.api.Data.Models.Clan;

public class ClanMember : EntityBase
{
    public User User { get; set; } = null!;
    public Clan Clan { get; set; } = null!;
    public ClanRole Role { get; set; } = null!;
}

public static class ClanMemberConfig
{
    public static void Configure(EntityTypeBuilder<ClanMember> config)
    {
        //Id
        //IsDeleted
        EntityBaseConfig.Configure(config);

        //User

        //Clan

        //Role
    }
}
