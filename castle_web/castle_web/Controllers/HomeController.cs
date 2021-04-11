using System.Collections.Generic;
using castle_web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using castle_web.Data;
using castle_web.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;
using Newtonsoft.Json.Linq;

namespace castle_web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationDbContext _context;
        private IVideoRepository videoRepository;
        private IConfiguration _configuration;
        public HomeController(ILogger<HomeController> logger,ApplicationDbContext context,IConfiguration configuration)
        {
            _context = context;
            _logger = logger;
            videoRepository = new VideoRepository(context, configuration);
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [Authorize]
        public IActionResult Profile()
        {
            return View(GetVideoOfUserAsync());
        }
        [Authorize]
        [HttpPost]
        public IActionResult UploadVideo()
        {
            return View();
        }

        private List<VideoModel> GetVideoOfUserAsync()
        {
            return videoRepository.GetAllVideosOfUser(User.Identity.Name).Result;
        }
    }
}
