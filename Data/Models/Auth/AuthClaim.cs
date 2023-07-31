using bookmy.games.api.Data.Models.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace bookmy.games.api.Data.Models.Auth;

public class AuthClaim : EntityBase
{
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
}

public static class AuthClaimConfig
{
    public static void Configure(EntityTypeBuilder<AuthClaim> config)
    {
        //Id
        //IsDeleted
        EntityBaseConfig.Configure(config);

        //Name

        //Description


        //Seed
        config.HasData(
            new AuthClaim() { Id = 1, Name = "Overlord", Description = "Can do anything"}
        );
    }
}
