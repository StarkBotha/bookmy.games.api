using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace bookmy.games.api.Data.Models.Shared;

public class EntityBase
{
    public int Id { get; set; }
    public bool IsDeleted { get; set; }
}

public static class EntityBaseConfig
{
    public static void Configure<T>(EntityTypeBuilder<T> config) where T : class
    {
        //Id
        //Identity
        //Auto Generate
        //default : unique B-tree index
        config.Property<int>("Id")
            .ValueGeneratedOnAdd()
            .UseIdentityColumn();

        //IsDeleted
        config.Property<bool>("IsDeleted")
            .HasDefaultValue(false);
    }
}
