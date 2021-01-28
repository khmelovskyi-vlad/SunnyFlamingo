using SunnyFlamingo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Searchers
{
    public interface IAllGoodsSearcher
    {
        Task<GoodsInformation<string>> SearchGoods(
            string producer,
            string country,
            string material,
            string color,
            decimal? priceFrom,
            decimal? priceTo,
            int from,
            int to,
            bool getQuestions);
        Task<GoodsInformation<string>> SearchComputerTechnologies(
            string producer,
            string country,
            string material,
            string color,
            decimal? priceFrom,
            decimal? priceTo,
            int from,
            int to,
            bool getQuestions);
        Task<GoodsInformation<string>> SearchLaptops(
            string producer,
            string country,
            string material,
            string color,
            string amountOfRAM,
            string CPUFrequency,
            string length,
            string height,
            string width,
            bool? haveFloppyDrives,
            string SSDMemory,
            string hardDiskMemory,
            string CPUSocketType,
            string computerDriveType,
            string numberOfCores,
            string floppyDrivesCount,
            string display,
            decimal? priceFrom,
            decimal? priceTo,
            int from,
            int to,
            bool getQuestions);
    }
}
