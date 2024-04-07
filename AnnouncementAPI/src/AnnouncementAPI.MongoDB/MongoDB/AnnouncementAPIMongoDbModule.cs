using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using Volo.Abp.MongoDB;

namespace AnnouncementAPI.MongoDB;

[DependsOn(
    typeof(AnnouncementAPIDomainModule),
    typeof(AbpMongoDbModule)
    )]
public class AnnouncementAPIMongoDbModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddMongoDbContext<AnnouncementAPIMongoDbContext>(options =>
        {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, MongoQuestionRepository>();
                 */
        });
    }
}
