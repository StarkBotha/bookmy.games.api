using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace bookmy.games.api.Data.Models.Shared;

public class External : EntityBase
{
    public Guid ExternalId { get; set; }
}


public static class ExternalConfig
{
    public static void Configure<T>(EntityTypeBuilder<T> config) where T : class
    {
        //ExternalId
        //Auto Generate
        config.Property<Guid>("ExternalId")
            .ValueGeneratedOnAdd()
            .HasDefaultValueSql("gen_random_uuid()");
        //Index and unique constraint
        config.HasIndex("ExternalId")
            .IsUnique();
    }
}
