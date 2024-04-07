using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;
using Volo.Abp.FluentValidation;

namespace AnnouncementAPI;

[DependsOn(
    typeof(AnnouncementAPIDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule),
    typeof(AbpFluentValidationModule)
    )]
public class AnnouncementAPIApplicationContractsModule : AbpModule
{

}
