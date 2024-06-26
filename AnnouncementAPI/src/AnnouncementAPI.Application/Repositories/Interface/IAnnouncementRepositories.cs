﻿using AnnouncementAPI.Entities;
using AnnouncementAPI.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnouncementAPI.Repositories.Interface
{
    public interface IAnnouncementRepositories
    {
        public Annouchment GetAnnouchmentById(int @AnnouchementId);
        void DeleteOlderAnnouchement();
        List<Annouchment> GetAllAnnouchment();
        Annouchment AddAnnouchement(AddAnnouchment @addAnnouchment);
    }
}
