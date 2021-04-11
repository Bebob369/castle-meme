using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using castle_web.Data;
using castle_web.Models;
using castle_web.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace castle_web.Controllers
{
    public class FileUploadController : Controller
    {
        private IVideoRepository videoRepository;
        private IWebHostEnvironment _appEnvironment;

        public FileUploadController(ApplicationDbContext context, IConfiguration configuration,
            IWebHostEnvironment appEnvironment)
        {
            _appEnvironment = appEnvironment;
            videoRepository = new VideoRepository(context,configuration);
        }

        [HttpPost("FileUpload")]
        public async Task<IActionResult> Index(IFormFile videoRow, VideoModel video)
        {
            if (videoRow != null)
            {
                var filePath = Path.Combine(_appEnvironment.WebRootPath + @"\Videos", videoRow.FileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    video.Owner = User.Identity.Name;
                    video.Path = filePath;
                    await videoRow.CopyToAsync(stream);
                    await videoRepository.AddNewVideo(video);
                }
            }

            return Ok();
        }
    }
}