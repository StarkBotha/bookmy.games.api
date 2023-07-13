using Microsoft.EntityFrameworkCore;

namespace bookmy.games.api.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base (options)
    {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // base.OnModelCreating(modelBuilder);
        modelBuilder.UseIdentityColumns();
    }
}
