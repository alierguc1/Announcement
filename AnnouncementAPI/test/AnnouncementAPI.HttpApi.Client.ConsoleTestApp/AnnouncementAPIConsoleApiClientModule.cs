using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace AnnouncementAPI;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AnnouncementAPIHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class AnnouncementAPIConsoleApiClientModule : AbpModule
{

}
