using SunnyFlamingo.Entities.Goods;
using SunnyFlamingo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Searchers
{
    public class ComputerTechnologiesQuestionsService : IComputerTechnologiesQuestionsService
    {
        private readonly IGoodsQuestionsService _goodsQuestionsService;
        public ComputerTechnologiesQuestionsService(IGoodsQuestionsService goodsQuestionsService)
        {
            _goodsQuestionsService = goodsQuestionsService;
        }
        public async Task<List<QuestionsBase<string>>> GetComputerTechnologiesQuestions(
            IQueryable<ComputerTechnology> computerTechnologies,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            decimal? priceFrom,
            decimal? priceTo)
        {
            var result = new List<QuestionsBase<string>>()
            {
            };
            result.AddRange(await _goodsQuestionsService.GetGoodsQuestions(computerTechnologies, producers, countries, materials, colors, priceFrom, priceTo));
            return result;
        }
    }
}
