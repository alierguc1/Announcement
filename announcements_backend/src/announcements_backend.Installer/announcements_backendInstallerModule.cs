using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace announcements_backend;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class announcements_backendInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<announcements_backendInstallerModule>();
        });
    }
}
