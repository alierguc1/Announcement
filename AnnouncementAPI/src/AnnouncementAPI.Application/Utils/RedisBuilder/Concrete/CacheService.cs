using AnnouncementAPI.Utils.RedisBuilder.Interface;
using Newtonsoft.Json;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AnnouncementAPI.Utils.RedisBuilder.Concrete
{
    public class CacheService : AnnouncementAPIAppService, ICacheService, ITransientDependency
    {
        private readonly IDatabase _redisDb;
        public CacheService(IConnectionMultiplexer connectionMultiplexer)
        {
            _redisDb = connectionMultiplexer.GetDatabase();

        }

        public void AddToList<T>(string listKey, T value)
        {
            var serializedValue = JsonConvert.SerializeObject(value);

            _redisDb.ListRightPush(listKey, serializedValue);
        }

        public List<T> GetFromList<T>(string listKey)
        {
            var values = _redisDb.ListRange(listKey);
            var resultList = new List<T>();
            foreach (var value in values)
            {
                var deserializedValue = JsonConvert.DeserializeObject<T>(value);
                resultList.Add(deserializedValue);
            }

            return resultList;
        }
    }
}
