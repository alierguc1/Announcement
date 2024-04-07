using Volo.Abp;
using Volo.Abp.MongoDB;

namespace AnnouncementAPI.MongoDB;

public static class AnnouncementAPIMongoDbContextExtensions
{
    public static void ConfigureAnnouncementAPI(
        this IMongoModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
    }
}
