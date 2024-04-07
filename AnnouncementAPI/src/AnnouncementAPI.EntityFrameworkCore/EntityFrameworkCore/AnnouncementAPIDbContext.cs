using AnnouncementAPI.Entities;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace AnnouncementAPI.EntityFrameworkCore;

[ConnectionStringName(AnnouncementAPIDbProperties.ConnectionStringName)]
public class AnnouncementAPIDbContext : AbpDbContext<AnnouncementAPIDbContext>, IAnnouncementAPIDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public AnnouncementAPIDbContext(DbContextOptions<AnnouncementAPIDbContext> options)
        : base(options)
    {

    }
    public DbSet<Annouchment> Annouchments { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        AnnouncementAPIDbContextModelCreatingExtensions.ConfigureAnnouncementAPI(builder);
        builder.ConfigureAnnouncementAPI();
    }
}
