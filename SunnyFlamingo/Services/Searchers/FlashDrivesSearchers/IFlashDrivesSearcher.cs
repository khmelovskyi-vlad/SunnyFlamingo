using SunnyFlamingo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Searchers
{
    public interface IFlashDrivesSearcher
    {
        Task<GoodsInformation<string>> SearchFlashDrives(
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            int[] capacities,
            string[] USBSpecificationTypes,
            decimal? priceFrom,
            decimal? priceTo,
            int from,
            int to,
            bool getQuestions);
    }
}
