using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;
using AnnouncementAPI.Repositories.Concrete;
using AnnouncementAPI.Utils.RedisBuilder.Concrete;
using StackExchange.Redis;
using AnnouncementAPI.Mapping;
using Volo.Abp.BackgroundWorkers;
using Volo.Abp.Caching.StackExchangeRedis;

namespace AnnouncementAPI;

[DependsOn(
    typeof(AnnouncementAPIDomainModule),
    typeof(AnnouncementAPIApplicationContractsModule),
    typeof(AbpDddApplicationModule),
    typeof(AbpBackgroundWorkersModule),
    typeof(AbpCachingStackExchangeRedisModule),
    typeof(AbpAutoMapperModule)
    )]
public class AnnouncementAPIApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        var configuration = context.Services.GetConfiguration();
        var redisConnectionString = ConfigurationOptions.Parse(configuration["Redis:Configuration"]!);
        context.Services.AddSingleton<IConnectionMultiplexer>(provider =>
            ConnectionMultiplexer.Connect(redisConnectionString));


        context.Services.AddAssemblyOf<AnnouncementRepositories>();
        context.Services.AddAssemblyOf<CacheService>();

        context.Services.AddAutoMapperObjectMapper<AnnouncementAPIApplicationModule>();
        Configure<AbpAutoMapperOptions>(options =>
        {
            //options.AddMaps<AnnouncementAPIApplicationModule>(validate: true);
            options.AddMaps<AnnouncementAPIAutoMapperProfile>();
        });
    }
}
