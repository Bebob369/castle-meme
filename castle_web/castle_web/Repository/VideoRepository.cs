﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using castle_web.Data;
using castle_web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace castle_web.Repository
{
    public class VideoRepository : IVideoRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IConfiguration _configuration;

        public VideoRepository(ApplicationDbContext context, IConfiguration configuration)
        {
            _configuration = configuration;
            _context = context;
        }

        public async Task<VideoModel> AddNewVideo(VideoModel video)
        {
            var newVideo = new VideoModel()
            {
                DateOfPublication = DateTime.Now,
                Describe = video.Describe,
                Name = video.Name,
                Owner = video.Owner,
                Path = video.Path,
                Views = 0
            };
            await _context.Videos.AddAsync(newVideo);
            await _context.SaveChangesAsync();
            return newVideo;
        }

        public async Task<List<VideoModel>> GetAllVideosOfUser(string user)
        {
            return await _context.Videos.Where(video => video.Owner == user).Select(video => new VideoModel()
            {
                DateOfPublication = video.DateOfPublication,
                Describe = video.Describe,
                Name = video.Name,
                Owner = video.Owner,
                Path = video.Path,
                Views = video.Views
            }).ToListAsync();
        }

        public async Task<List<VideoModel>> GetTopVideosAsync(int count)
        {
            return await _context.Videos
                .Select(video => new VideoModel()
                {
                    DateOfPublication = video.DateOfPublication,
                    Describe = video.Describe,
                    Name = video.Name,
                    Owner = video.Owner,
                    Path = video.Path,
                    Views = video.Views
                }).Take(count).ToListAsync();
        }

        public async Task<List<VideoModel>> SearchVideo(string Name)
        {
            return await _context.Videos
                .Where(video => video.Name == Name)
                .Select(video => new VideoModel()
                {
                    DateOfPublication = video.DateOfPublication,
                    Describe = video.Describe,
                    Name = video.Name,
                    Owner = video.Owner,
                    Path = video.Path,
                    Views = video.Views
                }).ToListAsync();
        }

        public Task<VideoModel> DeleteVideo(Guid Url)
        {
            return null;
        }

        public Task<VideoModel> ChangeVideo(Guid Url)
        {
            return null;
        }
    }
}