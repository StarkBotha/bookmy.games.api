using bookmy.games.api.Data;
using Microsoft.EntityFrameworkCore;

namespace bookmy.games.api.Configuration;

public static class DatabaseConfig
{
    public static void ConfigureDatabase(this WebApplicationBuilder builder)
    {
        builder.Services.AddDbContext<DataContext>(o => o.UseNpgsql(
            builder.Configuration.GetConnectionString("DataContext")
        ));
    }
}
