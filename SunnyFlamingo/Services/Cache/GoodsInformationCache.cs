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
using Newtonsoft.Json;
using SunnyFlamingo.ValueObjects.GrpcGoodsInformationFiles;

namespace SunnyFlamingo.Services.Cache
{
    public class GoodsInformationCache : IGoodsInformationCache
    {
        private readonly ICacheGoodsInformationTypeCreator _cacheGoodsInformationTypeCreator;
        private readonly GrpcGoodsInformationCache.GrpcGoodsInformationCacheClient _client;
        public GoodsInformationCache(ICacheGoodsInformationTypeCreator cacheGoodsInformationTypeCreator,
            GrpcGoodsInformationCache.GrpcGoodsInformationCacheClient client)
        {
            _cacheGoodsInformationTypeCreator = cacheGoodsInformationTypeCreator;
            _client = client;
        }
        public async Task AddGoodsInformation(string key, GoodsInformation<string> goodsInformation)
        {
            var grpcCacheGoodsInformationFactory = new GrpcCacheGoodsInformationFactory();
            var grpcCacheGoodsInformation = grpcCacheGoodsInformationFactory.CreateGrpcCacheGoodsInformation(key, goodsInformation);
            await _client.AddGoodsInformationAsync(grpcCacheGoodsInformation);
        }
        public async Task<CacheGoodsInformation<string>> GetGoodsInformation(string key, GoodsSelector selector)
        {
            var cacheGoodsInformationType = _cacheGoodsInformationTypeCreator.GetCacheGoodsInformationType(selector);
            var cacheGoodsInformation = new CacheGoodsInformation<string>() { Type = cacheGoodsInformationType };
            switch (cacheGoodsInformationType)
            {
                case CacheGoodsInformationType.GoodsInformation:
                case CacheGoodsInformationType.GoodsQuestions:
                    var goodsInformationFactory = new GoodsInformationFactory();
                    var json = await _client.GetGoodsInformationAsync(new Key() { Key_ = key });
                    if (json.Equals(new GrpcCacheGoodsInformation()))
                    {
                        return new CacheGoodsInformation<string>() { Type = CacheGoodsInformationType.AddNew };
                    }
                    var goodsInformation = goodsInformationFactory.CreateGoodsInformation(json);
                    cacheGoodsInformation.GoodsInformation = goodsInformation;
                    break;
            }
            return cacheGoodsInformation;
        }
    }
}
