using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using castle_web.Models;
using Microsoft.AspNetCore.Identity;

namespace castle_web.Repository
{
    interface IVideoRepository
    {
        Task AddVideo(VideoModel video);
        Task DeleteVideo(Guid Url);
        Task ChangeVideo(Guid Url);
    }
}
