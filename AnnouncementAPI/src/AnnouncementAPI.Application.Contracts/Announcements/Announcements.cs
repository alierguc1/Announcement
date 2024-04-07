using System;
using System.Collections.Generic;
using System.Text;

namespace AnnouncementAPI.Announcements
{
    public class Announcements
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
