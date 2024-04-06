using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace announcements_backend;

[DependsOn(
    typeof(announcements_backendApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class announcements_backendHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(announcements_backendApplicationContractsModule).Assembly,
            announcements_backendRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<announcements_backendHttpApiClientModule>();
        });

    }
}
