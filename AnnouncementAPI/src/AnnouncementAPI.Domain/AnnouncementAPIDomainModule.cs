using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace AnnouncementAPI;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(AnnouncementAPIDomainSharedModule)
)]
public class AnnouncementAPIDomainModule : AbpModule
{

}
