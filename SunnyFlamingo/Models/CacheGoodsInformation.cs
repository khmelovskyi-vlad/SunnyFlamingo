using SunnyFlamingo.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Models
{
    public class CacheGoodsInformation<T>
    {
        public GoodsInformation<T> GoodsInformation { get; set; }
        public CacheGoodsInformationType Type { get; set; }
        public CacheGoodsInformation(GoodsInformation<T> goodsInformation, CacheGoodsInformationType type)
        {
            GoodsInformation = goodsInformation;

        }
        public CacheGoodsInformation()
        {

        }
    }
}
