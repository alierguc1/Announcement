using Volo.Abp.Modularity;

namespace AnnouncementAPI;

/* Inherit from this class for your domain layer tests.
 * See SampleManager_Tests for example.
 */
public abstract class AnnouncementAPIDomainTestBase<TStartupModule> : AnnouncementAPITestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
