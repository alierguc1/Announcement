using Volo.Abp.Modularity;

namespace announcements_backend;

[DependsOn(
    typeof(announcements_backendApplicationModule),
    typeof(announcements_backendDomainTestModule)
    )]
public class announcements_backendApplicationTestModule : AbpModule
{

}
