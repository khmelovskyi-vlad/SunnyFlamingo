using Microsoft.Extensions.DependencyInjection;
using SunnyFlamingo.Services.Cache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Extensions
{
    public static class CacheExtensions
    {
        public static void AddCache(this IServiceCollection services)
        {
            services.AddScoped<IGoodsInformationCache, GoodsInformationCache>();
            services.AddSingleton<ICacheGoodsInformationTypeCreator, CacheGoodsInformationTypeCreator>();
            services.AddSingleton<ICacheKeyCreator, CacheKeyCreator>();
        }
    }
}
