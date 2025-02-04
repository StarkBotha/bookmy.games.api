using bookmy.games.api.Data.Models.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace bookmy.games.api.Data.Models.Auth;

/// <summary>
/// Link table between Role and Claims
/// </summary>
public class RoleClaim : EntityBase
{
    public AuthRole AuthRole { get; set; } = null!;
    public AuthClaim AuthClaim { get; set; } = null!;
}

public static class RoleClaimConfig
{
    public static void Configure(EntityTypeBuilder<RoleClaim> config)
    {
        //Id
        //Identity
        //Auto Generate
        //default: clustered index
        config.Property(p => p.Id)
            .ValueGeneratedOnAdd()
            .UseIdentityColumn();

        //IsDeleted
        config.Property(c => c.IsDeleted)
            .HasDefaultValue(false);

        //AuthRole

        //AuthClaim

        //Seed
        config.HasData(
            //Overlord
            new {Id = 1, AuthRoleId = 1, AuthClaimId = 1}
            );
    }
}
