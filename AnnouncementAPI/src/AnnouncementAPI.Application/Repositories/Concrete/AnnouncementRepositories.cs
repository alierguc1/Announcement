using AnnouncementAPI.Announcements.Dto;
using AnnouncementAPI.Entities;
using AnnouncementAPI.Entities.Dto;
using AnnouncementAPI.EntityFrameworkCore;
using AnnouncementAPI.Repositories.Interface;
using AnnouncementAPI.Utils.RedisBuilder.Interface;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.ObjectMapping;

namespace AnnouncementAPI.Repositories.Concrete
{
    public class AnnouncementRepositories : AnnouncementAPIAppService, IAnnouncementRepositories
    {
        private readonly AnnouncementAPIDbContext _appContext;
        private readonly IDatabase _database;
        private readonly ICacheService _cacheService;

        public AnnouncementRepositories(AnnouncementAPIDbContext appContext, ICacheService cacheService)
        {
            _appContext = appContext;
            _cacheService = cacheService;
        }

        public Annouchment AddAnnouchement(AddAnnouchment addAnnouchment)
        {
            var Annouchement = ObjectMapper.Map<AddAnnouchment, Annouchment>(addAnnouchment);
            _appContext.Annouchments.Add(Annouchement);
            _appContext.SaveChanges();
            _cacheService.AddToList<Annouchment>("Data", Annouchement);
            return Annouchement;
        }

        public void DeleteOlderAnnouchement()
        {
            var yesterday = DateTime.Today.AddDays(-1);
            var oldData = _appContext.Annouchments.Where(x => x.CreatedDate < yesterday).ToList();
            _appContext.Annouchments.RemoveRange(oldData);
            _appContext.SaveChanges();
        }

        public List<Annouchment> GetAllAnnouchment()
        {
            var getCache = _cacheService.GetFromList<Annouchment>("Data");
            if (getCache.Count > 0)
            {
                var yesterday = DateTime.Today.AddDays(-1);
                return getCache.Where(x => x.CreatedDate > yesterday).ToList();
            }
            else
            {
                return _appContext.Annouchments.ToList();

            }
        }

        public Annouchment GetAnnouchmentById(int AnnouchementId)
        {
            return _appContext.Annouchments.Where(x => x.Id == AnnouchementId).FirstOrDefault();
        }
    }
}
