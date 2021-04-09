using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using castle_web.Data;
using castle_web.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace castle_web.Controllers
{
    public class FileUploadController : Controller
    {
        private ApplicationDbContext _context;
        IWebHostEnvironment _appEnvironment;

        public FileUploadController(ApplicationDbContext context, IWebHostEnvironment appEnvironment)
        {
            _appEnvironment = appEnvironment;
            _context = context;
        }

        [HttpPost("FileUpload")]
        public async Task<IActionResult> Index(IFormFile videoRow,VideoModel video)
        {
            if (videoRow != null)
            {
                var filePath = Path.Combine(_appEnvironment.WebRootPath + @"\Videos", videoRow.FileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    video.Owner = User.Identity.Name;
                    video.DateOfPublication = DateTime.Now;
                    video.Path = filePath;
                    video.Views = 0;
                    video.Url = Guid.NewGuid();
                    await videoRow.CopyToAsync(stream);
                    await _context.Videos.AddAsync(video);
                }
            }
            return Ok();
        }
    }
}