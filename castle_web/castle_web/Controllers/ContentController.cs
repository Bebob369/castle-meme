using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using castle_web.Data;
using castle_web.Models;
using castle_web.Repository;
using Microsoft.Extensions.Configuration;

namespace castle_web.Controllers
{
    public class ContentController : Controller
    {
        private IVideoRepository videoRepository;

        public ContentController(IConfiguration configuration, ApplicationDbContext context)
        {
            videoRepository = new VideoRepository(context, configuration);
        }
        public IActionResult Video(VideoModel video)
        {
            
            return View(videoRepository.GetVideoByUrl(video.Url));
        }
    }
}
