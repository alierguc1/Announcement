using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace announcements_backend.MongoDB;

[ConnectionStringName(announcements_backendDbProperties.ConnectionStringName)]
public interface Iannouncements_backendMongoDbContext : IAbpMongoDbContext
{
    /* Define mongo collections here. Example:
     * IMongoCollection<Question> Questions { get; }
     */
}
