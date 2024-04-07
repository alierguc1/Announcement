using AnnouncementAPI.Entities;
using AnnouncementAPI.Entities.Dto;
using AnnouncementAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnouncementAPI.Announcement;

[Route("api/")]
public class AnnouncementController : AnnouncementAPIController, IAnnouchmentAppService
{
    private readonly IAnnouchmentAppService _annouchmentAppService;

    public AnnouncementController(IAnnouchmentAppService annouchmentAppService)
    {
        _annouchmentAppService = annouchmentAppService;
    }

    [HttpGet]
    [Route("announcements")]
    public List<Annouchment> GetAllAnnouchment()
    {
        return _annouchmentAppService.GetAllAnnouchment();
    }
    [HttpPost]
    [Route("announcements")]
    public Annouchment AddAnnouchement(AddAnnouchment addAnnouchment)
    {
        return _annouchmentAppService.AddAnnouchement(addAnnouchment);
    }
}

