using bookmy.games.api.Data.Models.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace bookmy.games.api.Data.Models.Auth;

/// <summary>
/// Auth Role - a role is a grouping of claims
/// </summary>
public class AuthRole : EntityBase
{
    public string Name { get; set; } = null!;
}

public static class AuthRoleConfig
{
    public static void Configure(EntityTypeBuilder<AuthRole> config)
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

        //Name

        //Seed
        config.HasData(new AuthRole() { Id = 1, Name = "Administrator" });
    }
}
