using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SunnyFlamingo.Data;
using SunnyFlamingo.Entities;
using SunnyFlamingo.Services.FileMasters;
using SunnyFlamingo.ValueObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesCreatorController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly ImgOptions _imageOptions;
        private readonly IFileMaster _fileMaster;
        public ImagesCreatorController(
            ApplicationDbContext context,
            IOptions<ImgOptions> imageOptions,
            IFileMaster fileMaster)
        {
            _context = context;
            _imageOptions = imageOptions.Value;
            _fileMaster = fileMaster;
        }
        [HttpPost("sentImages")]
        public async Task<List<Guid>> PostSentImages([FromForm] List<IFormFile> files)
        {
            try
            {
                if (files != null || files.Count != 0)
                {
                    List<Guid> ids = new List<Guid>();
                    List<ImageInfo> imageInfo = new List<ImageInfo>();
                    foreach (var file in files)
                    {
                        var fileId = Guid.NewGuid();
                        var fileExtension = Path.GetExtension(file.FileName).ToLower();
                        if (fileExtension == null)
                        {
                            throw new Exception(StatusCodes.Status404NotFound.ToString());
                        }
                        else
                        {
                            ids.Add(fileId);
                            var fileName = $"{fileId}{fileExtension}";
                            await _fileMaster.SaveFile(file, fileName, _imageOptions.GoodImages);
                            imageInfo.Add(CreateImageInfo(fileId, fileName, file));
                        }
                    }
                    await SaveImageInfo(imageInfo);
                    return ids;
                }
                throw new Exception(StatusCodes.Status404NotFound.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private ImageInfo CreateImageInfo(Guid fileId, string fileName, IFormFile file)
        {
            return new ImageInfo()
            {
                Id = fileId,
                Name = fileName,
                MimeType = file.ContentType,
                Size = file.Length,
            };
        }
        private async Task SaveImageInfo(List<ImageInfo> imageInfo)
        {
            await _context.ImageInfo.AddRangeAsync(imageInfo);
            await _context.SaveChangesAsync();
        }
    }
}
