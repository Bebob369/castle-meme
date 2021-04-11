using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Permissions;
using System.Web;
using castle_web.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace castle_web.Models
{
    public class VideoModel
    {
        [Key]
        public string Url { get; set; }
        public string Owner { get; set; }
        public string Path { get; set; }
        public string Name { get; set; }
        public string Describe { get; set; }
        public int Views { get; set; }
        public DateTime DateOfPublication { get; set; }
    }
}
