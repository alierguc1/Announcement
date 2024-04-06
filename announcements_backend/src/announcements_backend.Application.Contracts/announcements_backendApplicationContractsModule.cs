using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace announcements_backend;

[DependsOn(
    typeof(announcements_backendDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class announcements_backendApplicationContractsModule : AbpModule
{

}
