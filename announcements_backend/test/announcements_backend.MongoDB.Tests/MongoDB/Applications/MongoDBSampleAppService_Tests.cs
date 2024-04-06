using announcements_backend.MongoDB;
using announcements_backend.Samples;
using Xunit;

namespace announcements_backend.MongoDb.Applications;

[Collection(MongoTestCollection.Name)]
public class MongoDBSampleAppService_Tests : SampleAppService_Tests<announcements_backendMongoDbTestModule>
{

}
