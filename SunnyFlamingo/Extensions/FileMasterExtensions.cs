using Microsoft.Extensions.DependencyInjection;
using SunnyFlamingo.Services.FileMasters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Extensions
{
    public static class FileMasterExtensions
    {
        public static void AddFileMasters(this IServiceCollection services)
        {
            services.AddScoped<IFileMaster, FileMaster> ();
        }
    }
}
