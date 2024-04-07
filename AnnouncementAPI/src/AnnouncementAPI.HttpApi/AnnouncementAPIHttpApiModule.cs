using Localization.Resources.AbpUi;
using AnnouncementAPI.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace AnnouncementAPI;

[DependsOn(
    typeof(AnnouncementAPIApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class AnnouncementAPIHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(AnnouncementAPIHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<AnnouncementAPIResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
