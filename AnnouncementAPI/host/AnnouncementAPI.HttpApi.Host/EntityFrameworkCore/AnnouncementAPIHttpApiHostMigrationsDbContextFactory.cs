using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace AnnouncementAPI.EntityFrameworkCore;

public class AnnouncementAPIHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<AnnouncementAPIHttpApiHostMigrationsDbContext>
{
    public AnnouncementAPIHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<AnnouncementAPIHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("AnnouncementAPI"));

        return new AnnouncementAPIHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
