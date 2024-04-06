using Localization.Resources.AbpUi;
using announcements_backend.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace announcements_backend;

[DependsOn(
    typeof(announcements_backendApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class announcements_backendHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(announcements_backendHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<announcements_backendResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
