using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using StackExchange.Redis;
using SunnyFlamingo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Extensions
{
    public static class IDistributedCacheExtensions
    {
        public static async Task AddGoodsInformationAsync(this IDistributedCache cache, string key, GoodsInformation<string> goodsInformation)
        {
            var options = GetDistributedCacheEntryOptions();
            await cache.SetAsync(key, goodsInformation, options);
        }

        public static async Task<GoodsInformation<string>> GetGoodsInformationAsync(this IDistributedCache cache, string key)
        {
            return await cache.GetAsync<GoodsInformation<string>>(key);
        }


        public static async Task SetAsync<T>(this IDistributedCache cache, string key, T value, DistributedCacheEntryOptions options)
        {
            var json = JsonConvert.SerializeObject(value);
            await cache.SetStringAsync(key, json, options);
        }

        public static async Task<T> GetAsync<T>(this IDistributedCache cache, string key)
        {
            var json = await cache.GetStringAsync(key);
            if (json == null)
            {
                return default(T);
            }
            return JsonConvert.DeserializeObject<T>(json);
        }

        private static DistributedCacheEntryOptions GetDistributedCacheEntryOptions()
        {
            var options = new DistributedCacheEntryOptions();
            options.SlidingExpiration = TimeSpan.FromSeconds(20);
            options.AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(30);
            return options;
        }
    }
}
