using Volo.Abp.Modularity;

namespace announcements_backend;

/* Inherit from this class for your application layer tests.
 * See SampleAppService_Tests for example.
 */
public abstract class announcements_backendApplicationTestBase<TStartupModule> : announcements_backendTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
