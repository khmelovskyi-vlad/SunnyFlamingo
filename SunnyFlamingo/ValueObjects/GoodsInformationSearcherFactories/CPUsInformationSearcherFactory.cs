using SunnyFlamingo.Entities.Goods.ComputerTechnologies.ComputerParts;
using SunnyFlamingo.Models;
using SunnyFlamingo.Models.Selectors;
using SunnyFlamingo.Services.Cache;
using SunnyFlamingo.Services.Searchers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.ValueObjects.GoodsInformationSearcherFactories
{
    public class CPUsInformationSearcherFactory : IGoodsInformationSearcherFactory
    {
        private readonly IGoodsInformationSearcher _goodsInformationSearcher;
        private readonly IGoodCellsSearcher _goodCellsSearcher;
        private readonly ICacheKeyCreator _keyCreator;
        private readonly CPUsSelector _cpusSelector;
        public CPUsInformationSearcherFactory(IGoodsInformationSearcher goodsInformationSearcher,
            IGoodCellsSearcher goodCellsSearcher,
            ICacheKeyCreator keyCreator,
            CPUsSelector cpusSelector)
        {
            _goodsInformationSearcher = goodsInformationSearcher;
            _goodCellsSearcher = goodCellsSearcher;
            _keyCreator = keyCreator;
            _cpusSelector = cpusSelector;
        }
        public async Task<GoodsInformation<string>> SearchGoodsInformation()
        {
            return await _goodsInformationSearcher.SearchCPUsInformation(_cpusSelector);
        }
        public async Task<List<GoodCellModel>> SearchGoodCells()
        {
            return await _goodCellsSearcher.SearchCPUsGoodCells(_cpusSelector);
        }
        public string GetKey()
        {
            return _keyCreator.CreateGoodsInformationKey(typeof(CPU));
        }
    }
}
