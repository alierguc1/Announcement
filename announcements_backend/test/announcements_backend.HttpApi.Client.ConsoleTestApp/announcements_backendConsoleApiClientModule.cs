using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace announcements_backend;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(announcements_backendHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class announcements_backendConsoleApiClientModule : AbpModule
{

}
