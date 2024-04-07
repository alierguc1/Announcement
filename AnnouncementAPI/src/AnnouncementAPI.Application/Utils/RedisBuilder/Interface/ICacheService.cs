using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnouncementAPI.Utils.RedisBuilder.Interface
{
    public interface ICacheService
    {
        void AddToList<T>(string listKey, T value);
        List<T> GetFromList<T>(string listKey);
    }
}
