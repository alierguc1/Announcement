using AnnouncementAPI.Announcement.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Services;

namespace AnnouncementAPI.Announcement
{
    internal interface IAnnouncementAppService : IApplicationService
    {
        List<Announcement> GetAllAnnouchment();
        Announcement AddAnnouchement(AddAnnouncement @addAnnouchment);

    }
}
