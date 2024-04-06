using System;
using Volo.Abp.Data;
using Volo.Abp.Modularity;
using Volo.Abp.Uow;

namespace announcements_backend.MongoDB;

[DependsOn(
    typeof(announcements_backendApplicationTestModule),
    typeof(announcements_backendMongoDbModule)
)]
public class announcements_backendMongoDbTestModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpDbConnectionOptions>(options =>
        {
            options.ConnectionStrings.Default = MongoDbFixture.GetRandomConnectionString();
        });
    }
}
