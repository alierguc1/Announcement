using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace AnnouncementAPI;

[DependsOn(
    typeof(AnnouncementAPIApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class AnnouncementAPIHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(AnnouncementAPIApplicationContractsModule).Assembly,
            AnnouncementAPIRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<AnnouncementAPIHttpApiClientModule>();
        });

    }
}
