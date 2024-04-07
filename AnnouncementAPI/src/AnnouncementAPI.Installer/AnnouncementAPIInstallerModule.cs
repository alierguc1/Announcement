using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace AnnouncementAPI;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class AnnouncementAPIInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<AnnouncementAPIInstallerModule>();
        });
    }
}
