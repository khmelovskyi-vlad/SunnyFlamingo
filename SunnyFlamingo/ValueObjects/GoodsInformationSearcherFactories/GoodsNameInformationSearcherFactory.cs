using SunnyFlamingo.Entities;
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
    public class GoodsNameInformationSearcherFactory : IGoodsInformationSearcherFactory
    {
        private readonly IGoodsInformationSearcher _goodsInformationSearcher;
        private readonly IGoodCellsSearcher _goodCellsSearcher;
        private readonly ICacheKeyCreator _keyCreator;
        private readonly GoodsSelectorName _goodsSelectorName;
        public GoodsNameInformationSearcherFactory(IGoodsInformationSearcher goodsInformationSearcher,
            IGoodCellsSearcher goodCellsSearcher,
            ICacheKeyCreator keyCreator,
            GoodsSelectorName goodsSelectorName)
        {
            _goodsInformationSearcher = goodsInformationSearcher;
            _goodCellsSearcher = goodCellsSearcher;
            _keyCreator = keyCreator;
            _goodsSelectorName = goodsSelectorName;
        }
        public async Task<GoodsInformation<string>> SearchGoodsInformation()
        {
            return await _goodsInformationSearcher.SearchGoodsNameInformation(_goodsSelectorName);
        }
        public async Task<List<GoodCellModel>> SearchGoodCells()
        {
            return await _goodCellsSearcher.SearchGoodsNameGoodCells(_goodsSelectorName);
        }
        public string GetKey()
        {
            return _keyCreator.CreateGoodsNameInformationKey(typeof(Good), _goodsSelectorName.Name);
        }
    }
}
