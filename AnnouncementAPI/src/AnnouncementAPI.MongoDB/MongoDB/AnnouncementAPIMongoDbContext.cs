using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace AnnouncementAPI.MongoDB;

[ConnectionStringName(AnnouncementAPIDbProperties.ConnectionStringName)]
public class AnnouncementAPIMongoDbContext : AbpMongoDbContext, IAnnouncementAPIMongoDbContext
{
    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        modelBuilder.ConfigureAnnouncementAPI();
    }
}
