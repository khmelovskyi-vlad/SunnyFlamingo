using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Cache
{
    public class CacheKeyCreator : ICacheKeyCreator
    {
        public string CreateGoodsInformationKey(Type type)
        {
            return $"{type.Name}-list";
        }
        public string CreateGoodsNameInformationKey(Type type, string name)
        {
            return $"{type.Name}-name-{name}";
        }
    }
}
