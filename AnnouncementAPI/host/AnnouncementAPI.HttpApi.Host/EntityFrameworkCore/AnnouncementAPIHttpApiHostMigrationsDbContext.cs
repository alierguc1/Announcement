using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace AnnouncementAPI.EntityFrameworkCore;

public class AnnouncementAPIHttpApiHostMigrationsDbContext : AbpDbContext<AnnouncementAPIHttpApiHostMigrationsDbContext>
{
    public AnnouncementAPIHttpApiHostMigrationsDbContext(DbContextOptions<AnnouncementAPIHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureAnnouncementAPI();
    }
}
