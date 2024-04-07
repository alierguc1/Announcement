using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace AnnouncementAPI.EntityFrameworkCore;

[ConnectionStringName(AnnouncementAPIDbProperties.ConnectionStringName)]
public interface IAnnouncementAPIDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
