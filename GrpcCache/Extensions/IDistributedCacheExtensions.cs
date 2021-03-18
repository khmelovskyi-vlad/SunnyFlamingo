using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace GrpcCache.Extensions
{
    public static class IDistributedCacheExtensions
    {
        public static async Task AddGoodsInformationAsync(this IDistributedCache cache, Key key, GrpcCacheGoodsInformation goodsInformation)
        {
            var options = GetDistributedCacheEntryOptions();
            await cache.SetAsync(key.Key_, goodsInformation, options);
        }

        public static async Task<GrpcCacheGoodsInformation> GetGoodsInformationAsync(this IDistributedCache cache, Key key)
        {
            return await cache.GetAsync<GrpcCacheGoodsInformation>(key.Key_);
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
