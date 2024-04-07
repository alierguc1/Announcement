using AnnouncementAPI.Announcements.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Services;

namespace AnnouncementAPI.Announcement
{
    internal interface IAnnouncementAppService : IApplicationService
    {
        List<Announcements.Announcements> GetAllAnnouchment();
        Announcements.Announcements AddAnnouchement(AddAnnouncement @addAnnouchment);

    }
}
