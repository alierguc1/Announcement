using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace announcements_backend.EntityFrameworkCore;

[DependsOn(
    typeof(announcements_backendDomainModule),
    typeof(AbpEntityFrameworkCoreModule)
)]
public class announcements_backendEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<announcements_backendDbContext>(options =>
        {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
        });
    }
}
