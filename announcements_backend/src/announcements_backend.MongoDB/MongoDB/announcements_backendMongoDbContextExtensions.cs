using Volo.Abp;
using Volo.Abp.MongoDB;

namespace announcements_backend.MongoDB;

public static class announcements_backendMongoDbContextExtensions
{
    public static void Configureannouncements_backend(
        this IMongoModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
    }
}
