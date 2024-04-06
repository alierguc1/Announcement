using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace announcements_backend.MongoDB;

[ConnectionStringName(announcements_backendDbProperties.ConnectionStringName)]
public class announcements_backendMongoDbContext : AbpMongoDbContext, Iannouncements_backendMongoDbContext
{
    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        modelBuilder.Configureannouncements_backend();
    }
}
