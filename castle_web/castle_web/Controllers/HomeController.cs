using System.Collections.Generic;
using castle_web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Web;
using castle_web.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.IdentityModel.Protocols;
using Newtonsoft.Json.Linq;

namespace castle_web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationDbContext _context;
        public HomeController(ILogger<HomeController> logger,ApplicationDbContext context)
        {
            _context = context;
            _logger = logger;
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
            return View();
        }
        [Authorize]
        [HttpPost]
        public IActionResult UploadVideo()
        {

            //CurrentVideo.Owner = User.Identity.;
            return View();
        }
    }
}
