using announcements_backend.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace announcements_backend;

public abstract class announcements_backendController : AbpControllerBase
{
    protected announcements_backendController()
    {
        LocalizationResource = typeof(announcements_backendResource);
    }
}
