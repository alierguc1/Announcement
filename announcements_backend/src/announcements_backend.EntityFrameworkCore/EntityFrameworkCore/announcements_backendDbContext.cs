using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace announcements_backend.EntityFrameworkCore;

[ConnectionStringName(announcements_backendDbProperties.ConnectionStringName)]
public class announcements_backendDbContext : AbpDbContext<announcements_backendDbContext>, Iannouncements_backendDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public announcements_backendDbContext(DbContextOptions<announcements_backendDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Configureannouncements_backend();
    }
}
