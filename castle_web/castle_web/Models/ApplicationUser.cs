using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace castle_web.Models
{
    public class ApplicationUser : IdentityUser
    {
        public List<VideoModel> Videos { get; set; }
        public long Rating { get; set; }
    }
}
