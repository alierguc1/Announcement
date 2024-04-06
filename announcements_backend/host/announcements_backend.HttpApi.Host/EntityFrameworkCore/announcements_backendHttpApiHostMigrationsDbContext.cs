using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace announcements_backend.EntityFrameworkCore;

public class announcements_backendHttpApiHostMigrationsDbContext : AbpDbContext<announcements_backendHttpApiHostMigrationsDbContext>
{
    public announcements_backendHttpApiHostMigrationsDbContext(DbContextOptions<announcements_backendHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Configureannouncements_backend();
    }
}
