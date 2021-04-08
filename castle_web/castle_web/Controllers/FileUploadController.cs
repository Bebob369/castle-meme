using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using castle_web.Data;
using castle_web.Models;
using Microsoft.AspNetCore.Http;

namespace castle_web.Controllers
{
    public class FileUploadController : Controller
    {
        private ApplicationDbContext _context;
        public FileUploadController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpPost("FileUpload")]
        public async Task<IActionResult> Index(List<IFormFile> videos)
        {
            var size = videos.Sum(f => f.Length);
            var filePaths = new List<String>();
            foreach (var video in videos)
            {
                if (video.Length > 0)
                {
                    var filePath = Path.Combine(Directory.GetCurrentDirectory() + @"\Videos", video.FileName);
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await video.CopyToAsync(stream);
                    }
                }
            }

            return Ok(new {videos.Count});
        }
    }
}
