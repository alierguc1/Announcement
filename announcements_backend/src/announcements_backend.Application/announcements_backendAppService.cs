using announcements_backend.Localization;
using Volo.Abp.Application.Services;

namespace announcements_backend;

public abstract class announcements_backendAppService : ApplicationService
{
    protected announcements_backendAppService()
    {
        LocalizationResource = typeof(announcements_backendResource);
        ObjectMapperContext = typeof(announcements_backendApplicationModule);
    }
}
