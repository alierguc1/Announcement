using AnnouncementAPI.Entities;
using AnnouncementAPI.Entities.Dto;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnouncementAPI.Mapping
{
    public class AnnouncementAPIAutoMapperProfile : Profile
    {
        public AnnouncementAPIAutoMapperProfile()
        {

            this.CreateMap<Annouchment, AddAnnouchment>();
            this.CreateMap<AddAnnouchment, Annouchment>();

            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
        }
    }
}
