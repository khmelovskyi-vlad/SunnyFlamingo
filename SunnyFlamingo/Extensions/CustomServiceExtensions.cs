using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Extensions
{
    public static class CustomServiceExtensions
    {
        public static void AddCustomServices(this IServiceCollection services)
        {
            services.AddSearchers();
            services.AddCreators();
            services.AddFileMasters();
            services.AddPermissions();
            services.AddCache();
        }
    }
}
