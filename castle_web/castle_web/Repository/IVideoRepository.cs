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
        Task<VideoModel> AddNewVideo(VideoModel video);
        Task<List<VideoModel>> GetAllVideosOfUser(string user);
        Task<List<VideoModel>> GetTopVideosAsync(int count);
        Task<List<VideoModel>> SearchVideo(string Name);
        Task<VideoModel> DeleteVideo(Guid Url);
        Task<VideoModel> ChangeVideo(Guid Url);
    }
}
