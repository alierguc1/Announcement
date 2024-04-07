using AnnouncementAPI.Entities;
using AnnouncementAPI.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Services;

namespace AnnouncementAPI.Services
{
    public interface IAnnouchmentAppService : IApplicationService
    {
        List<Annouchment> GetAllAnnouchment();
        Annouchment AddAnnouchement(AddAnnouchment @addAnnouchment);
    }
}
