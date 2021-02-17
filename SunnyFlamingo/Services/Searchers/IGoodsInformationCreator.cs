using SunnyFlamingo.Models;
using SunnyFlamingo.Models.Selectors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Searchers
{
    public interface IGoodsInformationCreator
    {
        Task<GoodsInformation<string>> CreateGoodsInformation(GoodsSelector goodsSelector);
        Task<GoodsInformation<string>> CreateComputerTechnologiesInformation(ComputerTechnologiesSelector computerTechnologiesSelector);
        Task<GoodsInformation<string>> CreateLaptopsInformation(LaptopsSelector laptopsSelector);
        Task<GoodsInformation<string>> CreateComputersInformation(ComputersSelector computersSelector);
        Task<GoodsInformation<string>> CreateComputerAccessoriesInformation(ComputerAccessoriesSelector computerAccessoriesSelector);
        Task<GoodsInformation<string>> CreateComputerPartsInformation(ComputerPartsSelector computerPartsSelector);
        Task<GoodsInformation<string>> CreateFlashDrivesInformation(FlashDrivesSelector flashDrivesSelector);
        Task<GoodsInformation<string>> CreateVideoCardsInformation(VideoCardsSelector videoCardsSelector);
        Task<GoodsInformation<string>> CreateCPUsInformation(CPUsSelector cpusSelector);
        Task<GoodsInformation<string>> CreateCoolersInformation(CoolersSelector coolersSelector);
        Task<GoodsInformation<string>> CreateComputerDrivesInformation(ComputerDrivesSelector computerDrivesSelector);
        Task<GoodsInformation<string>> CreateMiceInformation(MiceSelector miceSelector);
        Task<GoodsInformation<string>> CreateKeyboardsInformation(KeyboardsSelector keyboardsSelector);
        Task<GoodsInformation<string>> CreateHeadphonesInformation(HeadphonesSelector headphonesSelector);
    }
}
