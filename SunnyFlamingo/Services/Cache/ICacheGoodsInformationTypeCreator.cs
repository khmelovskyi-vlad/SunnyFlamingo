using SunnyFlamingo.Models.Selectors;
using SunnyFlamingo.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Cache
{
    public interface ICacheGoodsInformationTypeCreator
    {
        CacheGoodsInformationType GetCacheGoodsInformationType(GoodsSelector goodsSelector);
    }
}
