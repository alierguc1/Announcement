using AnnouncementAPI.Localization;
using Volo.Abp.Application.Services;

namespace AnnouncementAPI;

public abstract class AnnouncementAPIAppService : ApplicationService
{
    protected AnnouncementAPIAppService()
    {
        LocalizationResource = typeof(AnnouncementAPIResource);
        ObjectMapperContext = typeof(AnnouncementAPIApplicationModule);
    }
}
