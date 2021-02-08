using SunnyFlamingo.Models;
using SunnyFlamingo.Models.Selectors;
using SunnyFlamingo.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Searchers
{
    public interface IComputersSearcher
    {
        Task<GoodsInformation<string>> SearchComputers(ComputersSelector computersSelector);
    }
}
