using bookmy.games.api.Data.Models.Shared;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace bookmy.games.api.Data.Models.Auth;

public class UserRole : EntityBase
{
    public User User { get; set; } = null!;
    public AuthRole AuthRole { get; set; } = null!;
}

public static class UserRoleConfig
{
    public static void Configure(EntityTypeBuilder<UserRole> config)
    {
        //Id
        //IsDeleted
        EntityBaseConfig.Configure(config);

        //Seed
        config.HasData(
            new {Id = 1, UserId = 1, AuthRoleId = 1}
        );
    }
}
