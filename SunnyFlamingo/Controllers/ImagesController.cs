using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SunnyFlamingo.Data;
using SunnyFlamingo.Entities;
using SunnyFlamingo.Entities.Goods;
using SunnyFlamingo.Models;
using SunnyFlamingo.Services;
using SunnyFlamingo.Services.FileMasters;
using SunnyFlamingo.Services.Searchers;
using SunnyFlamingo.ValueObjects;

namespace SunnyFlamingo.Controllers
{
    public class ImagesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ImgOptions _imageOptions;
        private readonly IFileMaster _fileMaster;
        public ImagesController(
            ApplicationDbContext context,
            IOptions<ImgOptions> imageOptions,
            IFileMaster fileMaster)
        {
            _context = context;
            _imageOptions = imageOptions.Value;
            _fileMaster = fileMaster;
        }
        [HttpGet]
        public async Task<IActionResult> GetImage(ImageType type, Guid id)
        {
            //var imageInfo = await GetImageInfo(id);
            //if (imageInfo == null)
            //{
            //    return NotFound();
            //}
            //var path = await Task.Run(() => GetPath(type, imageInfo.Name));
            var path = await Task.Run(() => GetPath(type, ""));
            if (path == null)
            {
                return NotFound();
            }
            var stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
            //return File(stream, imageInfo.MimeType);
            return File(stream, "image/jpeg");
        }
        private string GetPath(ImageType type, string imageName)
        {
            switch (type)
            {
                case ImageType.Avatar:
                    //return Path.Combine(_imageOptions.Avatars, imageName);
                case ImageType.GoodImg:
                    var partPath = $"{GetRandomNum()}.jpg";
                    return Path.Combine(_imageOptions.ImgPartPathes.GoodImg, partPath);
                    //return Path.Combine(_imageOptions.GoodImages, imageName);
                default:
                    return null;
            }
        }
        private async Task<ImageInfo> GetImageInfo(Guid id)
        {
            return await _context.ImageInfo.FirstOrDefaultAsync(ii => ii.Id == id);
        }
        private int GetRandomNum()
        {
            var rand = new Random();
            return rand.Next(0, 10);
        }
    }
}
