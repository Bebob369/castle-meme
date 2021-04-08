using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using castle_web.Models;

namespace castle_web.Repository
{
    public class VideoRepository : IVideoRepository
    {
        public Task AddVideo(VideoModel video)
        {
            throw new NotImplementedException();
        }

        public Task DeleteVideo(Guid Url)
        {
            throw new NotImplementedException();
        }

        public Task ChangeVideo(Guid Url)
        {
            throw new NotImplementedException();
        }
    }
}
