using SunnyFlamingo.Entities.Goods.ComputerTechnologies;
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
    public class ComputerPartsInformationSearcherFactory : IGoodsInformationSearcherFactory
    {
        private readonly IGoodsInformationSearcher _goodsInformationSearcher;
        private readonly IGoodCellsSearcher _goodCellsSearcher;
        private readonly ICacheKeyCreator _keyCreator;
        private readonly ComputerPartsSelector _computerPartsSelector;
        public ComputerPartsInformationSearcherFactory(IGoodsInformationSearcher goodsInformationSearcher,
            IGoodCellsSearcher goodCellsSearcher,
            ICacheKeyCreator keyCreator,
            ComputerPartsSelector computerPartsSelector)
        {
            _goodsInformationSearcher = goodsInformationSearcher;
            _goodCellsSearcher = goodCellsSearcher;
            _keyCreator = keyCreator;
            _computerPartsSelector = computerPartsSelector;
        }
        public async Task<GoodsInformation<string>> SearchGoodsInformation()
        {
            return await _goodsInformationSearcher.SearchComputerPartsInformation(_computerPartsSelector);
        }
        public async Task<List<GoodCellModel>> SearchGoodCells()
        {
            return await _goodCellsSearcher.SearchComputerPartsGoodCells(_computerPartsSelector);
        }
        public string GetKey()
        {
            return _keyCreator.CreateGoodsInformationKey(typeof(ComputerPart));
        }
    }
}
