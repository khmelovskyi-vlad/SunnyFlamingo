using SunnyFlamingo.Models;
using SunnyFlamingo.Models.Selectors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Searchers
{
    public interface IGoodsInformationSearcher
    {
        Task<GoodsInformation<string>> SearchGoodsNameInformation(GoodsSelectorName goodsSelectorName);
        Task<GoodsInformation<string>> SearchGoodsInformation(GoodsSelector goodsSelector);
        Task<GoodsInformation<string>> SearchComputerTechnologiesInformation(ComputerTechnologiesSelector computerTechnologiesSelector);
        Task<GoodsInformation<string>> SearchLaptopsInformation(LaptopsSelector laptopsSelector);
        Task<GoodsInformation<string>> SearchComputersInformation(ComputersSelector computersSelector);
        Task<GoodsInformation<string>> SearchComputerAccessoriesInformation(ComputerAccessoriesSelector computerAccessoriesSelector);
        Task<GoodsInformation<string>> SearchComputerPartsInformation(ComputerPartsSelector computerPartsSelector);
        Task<GoodsInformation<string>> SearchFlashDrivesInformation(FlashDrivesSelector flashDrivesSelector);
        Task<GoodsInformation<string>> SearchVideoCardsInformation(VideoCardsSelector videoCardsSelector);
        Task<GoodsInformation<string>> SearchCPUsInformation(CPUsSelector cpusSelector);
        Task<GoodsInformation<string>> SearchCoolersInformation(CoolersSelector coolersSelector);
        Task<GoodsInformation<string>> SearchComputerDrivesInformation(ComputerDrivesSelector computerDrivesSelector);
        Task<GoodsInformation<string>> SearchMiceInformation(MiceSelector miceSelector);
        Task<GoodsInformation<string>> SearchKeyboardsInformation(KeyboardsSelector keyboardsSelector);
        Task<GoodsInformation<string>> SearchHeadphonesInformation(HeadphonesSelector headphonesSelector);
    }
}
