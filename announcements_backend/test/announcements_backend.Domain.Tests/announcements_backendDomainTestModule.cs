using Volo.Abp.Modularity;

namespace announcements_backend;

[DependsOn(
    typeof(announcements_backendDomainModule),
    typeof(announcements_backendTestBaseModule)
)]
public class announcements_backendDomainTestModule : AbpModule
{

}
