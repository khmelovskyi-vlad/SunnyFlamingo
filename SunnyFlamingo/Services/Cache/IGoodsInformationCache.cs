using SunnyFlamingo.Models;
using SunnyFlamingo.Models.Selectors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Cache
{
    public interface IGoodsInformationCache
    {
        Task AddGoodsInformation(string key, GoodsInformation<string> goodsInformation);
        Task<CacheGoodsInformation<string>> GetGoodsInformation(string key, GoodsSelector selector);
    }
}
