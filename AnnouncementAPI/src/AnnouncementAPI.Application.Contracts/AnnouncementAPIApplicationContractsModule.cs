using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace AnnouncementAPI;

[DependsOn(
    typeof(AnnouncementAPIDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class AnnouncementAPIApplicationContractsModule : AbpModule
{

}
