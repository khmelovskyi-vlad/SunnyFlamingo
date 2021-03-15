using SunnyFlamingo.Models;
using SunnyFlamingo.Models.Selectors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Searchers
{
    public interface IGoodCellsSearcher
    {
        Task<List<GoodCellModel>> SearchGoodsNameGoodCells(GoodsSelectorName goodsSelectorName);
        Task<List<GoodCellModel>> SearchGoodCells(GoodsSelector goodsSelector);
        Task<List<GoodCellModel>> SearchComputerTechnologiesGoodCells(ComputerTechnologiesSelector computerTechnologiesSelector);
        Task<List<GoodCellModel>> SearchLaptopGoodCells(LaptopsSelector laptopsSelector);
        Task<List<GoodCellModel>> SearchComputersGoodCells(ComputersSelector computersSelector);
        Task<List<GoodCellModel>> SearchComputerAccessoriesGoodCells(ComputerAccessoriesSelector computerAccessoriesSelector);
        Task<List<GoodCellModel>> SearchComputerPartsGoodCells(ComputerPartsSelector computerPartsSelector);
        Task<List<GoodCellModel>> SearchFlashDrivesGoodCells(FlashDrivesSelector flashDrivesSelector);
        Task<List<GoodCellModel>> SearchVideoCardsGoodCells(VideoCardsSelector videoCardsSelector);
        Task<List<GoodCellModel>> SearchCPUsGoodCells(CPUsSelector cpusSelector);
        Task<List<GoodCellModel>> SearchCoolersGoodCells(CoolersSelector coolersSelector);
        Task<List<GoodCellModel>> SearchComputerDrivesGoodCells(ComputerDrivesSelector computerDrivesSelector);
        Task<List<GoodCellModel>> SearchMiceGoodCells(MiceSelector miceSelector);
        Task<List<GoodCellModel>> SearchKeyboardsGoodCells(KeyboardsSelector keyboardsSelector);
        Task<List<GoodCellModel>> SearchHeadphonesGoodCells(HeadphonesSelector headphonesSelector);
    }
}
