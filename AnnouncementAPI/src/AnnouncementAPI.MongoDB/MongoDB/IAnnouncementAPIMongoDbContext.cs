using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace AnnouncementAPI.MongoDB;

[ConnectionStringName(AnnouncementAPIDbProperties.ConnectionStringName)]
public interface IAnnouncementAPIMongoDbContext : IAbpMongoDbContext
{
    /* Define mongo collections here. Example:
     * IMongoCollection<Question> Questions { get; }
     */
}
