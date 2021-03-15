using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Cache
{
    public interface ICacheKeyCreator
    {
        string CreateGoodsInformationKey(Type type);
        string CreateGoodsNameInformationKey(Type type, string name);
    }
}
