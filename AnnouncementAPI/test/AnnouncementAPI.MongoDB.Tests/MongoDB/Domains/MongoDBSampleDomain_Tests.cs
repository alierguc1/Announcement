using AnnouncementAPI.Samples;
using Xunit;

namespace AnnouncementAPI.MongoDB.Domains;

[Collection(MongoTestCollection.Name)]
public class MongoDBSampleDomain_Tests : SampleManager_Tests<AnnouncementAPIMongoDbTestModule>
{

}
