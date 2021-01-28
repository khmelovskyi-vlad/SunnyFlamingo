using SunnyFlamingo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Searchers
{
    public interface IComputerTechnologiesSearchers
    {
        Task<GoodsInformation<string>> SearchComputerTechnologies(
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            decimal? priceFrom,
            decimal? priceTo,
            int from,
            int to,
            bool getQuestions);
    }
}
