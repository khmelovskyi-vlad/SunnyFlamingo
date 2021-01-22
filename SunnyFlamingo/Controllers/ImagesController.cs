using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SunnyFlamingo.Data;
using SunnyFlamingo.ValueObjects;

namespace SunnyFlamingo.Controllers
{
    public class ImagesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ImgOptions _imageOptions;
        public ImagesController(ApplicationDbContext context, IOptions<ImgOptions> imageOptions)
        {
            _context = context;
            _imageOptions = imageOptions.Value;
        }
        [HttpGet]
        public async Task<IActionResult> GetImage(ImageType type, Guid id)
        {
            var path = await Task.Run(()=> GetPath(type, id));
            if (path == null)
            {
                return NotFound();
            }
            //var fileInformation = await GetFileInformation(type, name);
            //if (fileInformation == null)
            //{
            //    return NotFound();
            //}
            var stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
            //return File(stream, fileInformation.MimeType);
            return File(stream, "image/jpeg");
        }
        private string GetPath(ImageType type, Guid id)
        {
            switch (type)
            {
                case ImageType.Avatar:
                    //return Path.Combine(_imageOptions.ImagePartPathes.Avatars, imageName);
                case ImageType.GoodImg:
                    var partPath = $"{GetRandomNum()}.jpg";
                    return Path.Combine(_imageOptions.ImgPartPathes.GoodImg, partPath);
                    //return Path.Combine(_imageOptions.ImagePartPathes.GoodImg, imageName);
                default:
                    return null;
            }
        }
        private int GetRandomNum()
        {
            var rand = new Random();
            return rand.Next(0, 10);
        }
    }
}
