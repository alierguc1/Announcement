using Volo.Abp.Modularity;

namespace AnnouncementAPI;

/* Inherit from this class for your application layer tests.
 * See SampleAppService_Tests for example.
 */
public abstract class AnnouncementAPIApplicationTestBase<TStartupModule> : AnnouncementAPITestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
