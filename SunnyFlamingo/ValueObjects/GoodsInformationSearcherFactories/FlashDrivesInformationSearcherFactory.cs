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
    public class FlashDrivesInformationSearcherFactory : IGoodsInformationSearcherFactory
    {
        private readonly IGoodsInformationSearcher _goodsInformationSearcher;
        private readonly IGoodCellsSearcher _goodCellsSearcher;
        private readonly ICacheKeyCreator _keyCreator;
        private readonly FlashDrivesSelector _flashDrivesSelector;
        public FlashDrivesInformationSearcherFactory(IGoodsInformationSearcher goodsInformationSearcher,
            IGoodCellsSearcher goodCellsSearcher,
            ICacheKeyCreator keyCreator,
            FlashDrivesSelector flashDrivesSelector)
        {
            _goodsInformationSearcher = goodsInformationSearcher;
            _goodCellsSearcher = goodCellsSearcher;
            _keyCreator = keyCreator;
            _flashDrivesSelector = flashDrivesSelector;
        }
        public async Task<GoodsInformation<string>> SearchGoodsInformation()
        {
            return await _goodsInformationSearcher.SearchFlashDrivesInformation(_flashDrivesSelector);
        }
        public async Task<List<GoodCellModel>> SearchGoodCells()
        {
            return await _goodCellsSearcher.SearchFlashDrivesGoodCells(_flashDrivesSelector);
        }
        public string GetKey()
        {
            return _keyCreator.CreateGoodsInformationKey(typeof(FlashDrive));
        }
    }
}
