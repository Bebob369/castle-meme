using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using castle_web.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace castle_web.Models
{
    public class VideoModel : IdentityUser
    {
        public Guid Url { get; set; }
        public string Owner { get; set; }
        public string Path { get; set; }
        public string Name { get; set; }
        public string Describe { get; set; }
        public DateTime DateOfPublication { get; set; }
    }
}
