using SunnyFlamingo.Models;
using SunnyFlamingo.Models.Selectors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.ValueObjects.GoodsInformationSearcherFactories
{
    public interface IGoodsInformationSearcherFactory
    {
        Task<GoodsInformation<string>> SearchGoodsInformation();
        Task<List<GoodCellModel>> SearchGoodCells();
        string GetKey();
    }
}
