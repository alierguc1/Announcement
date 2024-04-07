using AnnouncementAPI.MongoDB;
using AnnouncementAPI.Samples;
using Xunit;

namespace AnnouncementAPI.MongoDb.Applications;

[Collection(MongoTestCollection.Name)]
public class MongoDBSampleAppService_Tests : SampleAppService_Tests<AnnouncementAPIMongoDbTestModule>
{

}
