using SunnyFlamingo.Entities.Goods;
using SunnyFlamingo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Searchers
{
    public interface IComputerTechnologiesQuestionsService
    {
        public Task<List<QuestionsBase<string>>> GetComputerTechnologiesQuestions(IQueryable<ComputerTechnology> computerTechnologies,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            decimal? priceFrom,
            decimal? priceTo);
    }
}
