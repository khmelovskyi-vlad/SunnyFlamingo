using Microsoft.Extensions.Caching.Distributed;
using SunnyFlamingo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using SunnyFlamingo.Extensions;
using SunnyFlamingo.Models.Selectors;
using SunnyFlamingo.Entities;
using SunnyFlamingo.ValueObjects;

namespace SunnyFlamingo.Services.Cache
{
    public class GoodsInformationCache : IGoodsInformationCache
    {
        private readonly IDistributedCache _cache;
        private readonly ICacheGoodsInformationTypeCreator _cacheGoodsInformationTypeCreator;
        public GoodsInformationCache(IDistributedCache cache, ICacheGoodsInformationTypeCreator cacheGoodsInformationTypeCreator)
        {
            _cache = cache;
            _cacheGoodsInformationTypeCreator = cacheGoodsInformationTypeCreator;
        }
        public async Task AddGoodsInformation(string key, GoodsInformation<string> goodsInformation)
        {
            await _cache.AddGoodsInformationAsync(key, goodsInformation);
        }
        public async Task<CacheGoodsInformation<string>> GetGoodsInformation(string key, GoodsSelector selector)
        {
            var cacheGoodsInformationType = _cacheGoodsInformationTypeCreator.GetCacheGoodsInformationType(selector);
            var cacheGoodsInformation = new CacheGoodsInformation<string>() { Type = cacheGoodsInformationType };
            switch (cacheGoodsInformationType)
            {
                case CacheGoodsInformationType.GoodsInformation:
                case CacheGoodsInformationType.GoodsQuestions:
                    var goodsInformation = await _cache.GetGoodsInformationAsync(key);
                    if (goodsInformation == null)
                    {
                        return new CacheGoodsInformation<string>() { Type = CacheGoodsInformationType.AddNew };
                    }
                    cacheGoodsInformation.GoodsInformation = goodsInformation;
                    break;
            }
            return cacheGoodsInformation;
        }
    }
}
