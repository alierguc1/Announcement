using announcements_backend.Samples;
using Xunit;

namespace announcements_backend.MongoDB.Domains;

[Collection(MongoTestCollection.Name)]
public class MongoDBSampleDomain_Tests : SampleManager_Tests<announcements_backendMongoDbTestModule>
{

}
