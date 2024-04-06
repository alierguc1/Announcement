using Volo.Abp.Modularity;

namespace announcements_backend;

/* Inherit from this class for your domain layer tests.
 * See SampleManager_Tests for example.
 */
public abstract class announcements_backendDomainTestBase<TStartupModule> : announcements_backendTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
