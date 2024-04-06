using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace announcements_backend.EntityFrameworkCore;

public class announcements_backendHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<announcements_backendHttpApiHostMigrationsDbContext>
{
    public announcements_backendHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<announcements_backendHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("announcements_backend"));

        return new announcements_backendHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
