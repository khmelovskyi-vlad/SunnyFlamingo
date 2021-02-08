using SunnyFlamingo.Models;
using SunnyFlamingo.Models.Selectors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Searchers
{
    public interface IFlashDrivesSearcher
    {
        Task<GoodsInformation<string>> SearchFlashDrives(FlashDrivesSelector flashDrivesSelector);
    }
}
