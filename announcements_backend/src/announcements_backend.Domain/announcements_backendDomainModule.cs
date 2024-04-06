using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace announcements_backend;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(announcements_backendDomainSharedModule)
)]
public class announcements_backendDomainModule : AbpModule
{

}
