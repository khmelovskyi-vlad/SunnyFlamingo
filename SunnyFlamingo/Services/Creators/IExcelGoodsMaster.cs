using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Creators
{
    public interface IExcelGoodsMaster
    {
        Task<int> AddGoods();
    }
}
