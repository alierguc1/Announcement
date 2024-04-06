using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;

namespace announcements_backend;

[DependsOn(
    typeof(announcements_backendDomainModule),
    typeof(announcements_backendApplicationContractsModule),
    typeof(AbpDddApplicationModule),
    typeof(AbpAutoMapperModule)
    )]
public class announcements_backendApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<announcements_backendApplicationModule>();
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<announcements_backendApplicationModule>(validate: true);
        });
    }
}
