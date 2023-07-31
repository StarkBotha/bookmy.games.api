using bookmy.games.api.Data.Models.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace bookmy.games.api.Data.Models.Auth;

public class User : External
{
    public string Email { get; set; } = null!;
    public string PasswordHash { get; set; } = null!;
    public bool IsSystemUser { get; set; }

    public Guid? ReferredBy { get; set; }

    public int RoleId { get; set; }
    public AuthRole Role { get; set; } = null!;
}

public static class UserConfig
{
    public static void Configure(EntityTypeBuilder<User> config, string adminEmail, string adminPassword)
    {
        //Id
        //IsDeleted
        EntityBaseConfig.Configure(config);

        //ExternalId
        ExternalConfig.Configure(config);

        //Email
        config.Property(c => c.Email)
            .IsRequired()
            .HasMaxLength(256);
        //Unique constraint
        config.HasIndex(c => c.Email)
            .IsUnique();

        //PasswordHash
        config.Property(c => c.PasswordHash)
            .IsRequired();

        //IsSystemUser
        config.Property(c => c.IsSystemUser)
            .HasDefaultValue(false);

        //Relationship configuration
        // config.HasOne(u => u.Role)
        //     .WithOne(ur => ur.User)
        //     .HasForeignKey<UserRole>(ur => ur.Id);

        config.HasOne(u => u.Role)
            .WithMany(r => r.Users)
            .HasForeignKey(u => u.RoleId);

        //seed
        var passwordHash = BCrypt.Net.BCrypt.HashPassword(adminPassword);
        config.HasData(
            new {Id = 1, Email = adminEmail, PasswordHash = passwordHash, IsSystemUser = true, RoleId = 1}
        );
    }
}
