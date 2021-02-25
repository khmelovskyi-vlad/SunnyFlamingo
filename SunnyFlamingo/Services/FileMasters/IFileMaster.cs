using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.FileMasters
{
    public interface IFileMaster
    {
        Task SaveFile(IFormFile postedFile, string fileName, string path);
    }
}
