using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace announcements_backend.Samples;

public interface ISampleAppService : IApplicationService
{
    Task<SampleDto> GetAsync();

    Task<SampleDto> GetAuthorizedAsync();
}
