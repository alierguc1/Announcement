using AnnouncementAPI.Entities;
using AnnouncementAPI.Entities.Dto;
using AnnouncementAPI.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnouncementAPI.Services
{
    public class AnnouchmentAppService : AnnouncementAPIAppService, IAnnouchmentAppService
    {
        private readonly IAnnouncementRepositories _annouchementRepositories;
        public AnnouchmentAppService(IAnnouncementRepositories annouchementRepositories)
        {
            _annouchementRepositories = annouchementRepositories;
        }

        public Annouchment AddAnnouchement(AddAnnouchment addAnnouchment)
        {
            return _annouchementRepositories.AddAnnouchement(addAnnouchment);
        }
        public List<Annouchment> GetAllAnnouchment()
        {
            return _annouchementRepositories.GetAllAnnouchment();
        }
    }
}
