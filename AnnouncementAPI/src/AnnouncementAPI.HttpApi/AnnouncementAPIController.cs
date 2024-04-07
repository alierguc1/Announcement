using AnnouncementAPI.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AnnouncementAPI;

public abstract class AnnouncementAPIController : AbpControllerBase
{
    protected AnnouncementAPIController()
    {
        LocalizationResource = typeof(AnnouncementAPIResource);
    }
}
