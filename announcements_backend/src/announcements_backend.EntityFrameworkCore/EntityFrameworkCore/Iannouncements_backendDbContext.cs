using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace announcements_backend.EntityFrameworkCore;

[ConnectionStringName(announcements_backendDbProperties.ConnectionStringName)]
public interface Iannouncements_backendDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
