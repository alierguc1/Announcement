using AnnouncementAPI.Announcement.Dto;
using AnnouncementAPI.Announcements.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnouncementAPI.Repositories.Interface
{
    public interface IAnnouncementRepositories
    {
        public Announcements.Announcements GetAnnouchmentById(int @AnnouchementId);
        void DeleteOlderAnnouchement();
        List<Announcements.Announcements> GetAllAnnouchment();
        Announcements.Announcements AddAnnouchement(AddAnnouncement @addAnnouchment);
    }
}
