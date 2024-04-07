using System;
using Volo.Abp.Data;
using Volo.Abp.Modularity;
using Volo.Abp.Uow;

namespace AnnouncementAPI.MongoDB;

[DependsOn(
    typeof(AnnouncementAPIApplicationTestModule),
    typeof(AnnouncementAPIMongoDbModule)
)]
public class AnnouncementAPIMongoDbTestModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpDbConnectionOptions>(options =>
        {
            options.ConnectionStrings.Default = MongoDbFixture.GetRandomConnectionString();
        });
    }
}
