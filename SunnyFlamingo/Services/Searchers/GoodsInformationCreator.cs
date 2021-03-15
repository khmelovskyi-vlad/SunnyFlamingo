using Microsoft.Data.SqlClient;
using SunnyFlamingo.Data;
using SunnyFlamingo.Entities;
using SunnyFlamingo.Entities.Goods;
using SunnyFlamingo.Entities.Goods.ComputerTechnologies;
using SunnyFlamingo.Entities.Goods.ComputerTechnologies.ComputerAccessories;
using SunnyFlamingo.Entities.Goods.ComputerTechnologies.ComputerParts;
using SunnyFlamingo.Extensions;
using SunnyFlamingo.Models;
using SunnyFlamingo.Models.Selectors;
using SunnyFlamingo.Services.Cache;
using SunnyFlamingo.ValueObjects;
using SunnyFlamingo.ValueObjects.GoodsInformationSearcherFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Searchers
{
    public class GoodsInformationCreator : IGoodsInformationCreator
    {
        private readonly IGoodsInformationCache _cache;
        public GoodsInformationCreator(IGoodsInformationCache cache)
        {
            _cache = cache;
        }
        public async Task<GoodsInformation<string>> CreateGoodsInformation(GoodsSelector goodsSelector, IGoodsInformationSearcherFactory goodsInformationSearcherFactory)
        {
            var cacheGoodsInformation = await _cache.GetGoodsInformation(goodsInformationSearcherFactory.GetKey(), goodsSelector);
            if (cacheGoodsInformation == null)
            {
                cacheGoodsInformation = new CacheGoodsInformation<string>();
            }
            if (cacheGoodsInformation.Type == CacheGoodsInformationType.No || cacheGoodsInformation.Type == CacheGoodsInformationType.AddNew)
            {
                cacheGoodsInformation.GoodsInformation = await goodsInformationSearcherFactory.SearchGoodsInformation();
                if (cacheGoodsInformation.Type == CacheGoodsInformationType.AddNew)
                {
                    await _cache.AddGoodsInformation(goodsInformationSearcherFactory.GetKey(), cacheGoodsInformation.GoodsInformation);
                }
            }
            else if (cacheGoodsInformation.Type == CacheGoodsInformationType.GoodsQuestions)
            {
                cacheGoodsInformation.GoodsInformation.GoodCells = await goodsInformationSearcherFactory.SearchGoodCells();
            }
            return cacheGoodsInformation.GoodsInformation;
        }
    }
}
