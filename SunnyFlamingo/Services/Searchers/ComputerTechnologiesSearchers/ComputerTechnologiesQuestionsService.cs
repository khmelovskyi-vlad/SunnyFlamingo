using Microsoft.EntityFrameworkCore;
using SunnyFlamingo.Entities.Goods;
using SunnyFlamingo.Models;
using SunnyFlamingo.Models.Selectors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Searchers
{
    public class ComputerTechnologiesQuestionsService : IComputerTechnologiesQuestionsService
    {
        private readonly IGoodsQuestionsService _goodsQuestionsService;
        private readonly IQuestionsGrouper _questionsGrouper;
        public ComputerTechnologiesQuestionsService(IGoodsQuestionsService goodsQuestionsService, IQuestionsGrouper questionsGrouper)
        {
            _goodsQuestionsService = goodsQuestionsService;
            _questionsGrouper = questionsGrouper;
        }
        public async Task<List<QuestionsBase<string>>> GetComputerTechnologiesQuestions(
            IQueryable<ComputerTechnology> computerTechnologies,
            ComputerTechnologiesSelector computerTechnologiesSelector)
        {
            var goodsSelector = computerTechnologiesSelector.GoodsSelector;
            var result = await GetQuestionList(computerTechnologies, computerTechnologiesSelector);
            return new List<QuestionsBase<string>>()
            {
                _questionsGrouper.GroupProducers(result),
                _questionsGrouper.GroupCountries(result),
                _questionsGrouper.GroupMaterials(result),
                _questionsGrouper.GroupColors(result),
                _questionsGrouper.GroupPrices(result, goodsSelector.PriceFrom, goodsSelector.PriceTo),
            };
        }
        private async Task<List<QuestionBase<string>>> GetQuestionList(
            IQueryable<ComputerTechnology> computerTechnologies,
            ComputerTechnologiesSelector computerTechnologiesSelector)
        {
            var goodsSelector = computerTechnologiesSelector.GoodsSelector;
            var producerQuestions = GetProducerQuestion(GetProducerComputerTechnologies(computerTechnologies, computerTechnologiesSelector), goodsSelector.Producers);
            var countryQuestions = GetCountryQuestion(GetCountryComputerTechnologies(computerTechnologies, computerTechnologiesSelector), goodsSelector.Countries);
            var materialQuestions = GetMaterialQuestion(GetMaterialComputerTechnologies(computerTechnologies, computerTechnologiesSelector), goodsSelector.Materials);
            var colorQuestions = GetColorQuestion(GetColorComputerTechnologies(computerTechnologies, computerTechnologiesSelector), goodsSelector.Colors);
            var priceQuestions = GetPriceQuestion(GetPriceComputerTechnologies(computerTechnologies, computerTechnologiesSelector));

            var group = producerQuestions.Union(countryQuestions).Union(materialQuestions).Union(colorQuestions).Union(priceQuestions);
            return await group.ToListAsync();
        }
        public IQueryable<T> GetProducerComputerTechnologies<T>(
            IQueryable<T> computerTechnologies,
            ComputerTechnologiesSelector computerTechnologiesSelector) where T : ComputerTechnology
        {
            return _goodsQuestionsService.GetProducerGoods(computerTechnologies, computerTechnologiesSelector.GoodsSelector);
        }
        public IQueryable<T> GetCountryComputerTechnologies<T>(
            IQueryable<T> computerTechnologies,
            ComputerTechnologiesSelector computerTechnologiesSelector) where T : ComputerTechnology
        {
            return _goodsQuestionsService.GetCountryGoods(computerTechnologies, computerTechnologiesSelector.GoodsSelector);
        }
        public IQueryable<T> GetMaterialComputerTechnologies<T>(
            IQueryable<T> computerTechnologies,
            ComputerTechnologiesSelector computerTechnologiesSelector) where T : ComputerTechnology
        {
            return _goodsQuestionsService.GetMaterialGoods(computerTechnologies, computerTechnologiesSelector.GoodsSelector);
        }
        public IQueryable<T> GetColorComputerTechnologies<T>(
            IQueryable<T> computerTechnologies,
            ComputerTechnologiesSelector computerTechnologiesSelector) where T : ComputerTechnology
        {
            return _goodsQuestionsService.GetColorGoods(computerTechnologies, computerTechnologiesSelector.GoodsSelector);
        }
        public IQueryable<T> GetPriceComputerTechnologies<T>(
            IQueryable<T> computerTechnologies,
            ComputerTechnologiesSelector computerTechnologiesSelector) where T : ComputerTechnology
        {
            return _goodsQuestionsService.GetPriceGoods(computerTechnologies, computerTechnologiesSelector.GoodsSelector);
        }
        public IQueryable<QuestionBase<string>> GetPriceQuestion(IQueryable<ComputerTechnology> goods)
        {
            return _goodsQuestionsService.GetPriceQuestion(goods);
        }
        public IQueryable<QuestionBase<string>> GetProducerQuestion(IQueryable<ComputerTechnology> computerTechnologies, string[] producers)
        {
            return _goodsQuestionsService.GetProducerQuestion(computerTechnologies, producers);
        }
        public IQueryable<QuestionBase<string>> GetCountryQuestion(IQueryable<ComputerTechnology> computerTechnologies, string[] countries)
        {
            return _goodsQuestionsService.GetCountryQuestion(computerTechnologies, countries);
        }
        public IQueryable<QuestionBase<string>> GetMaterialQuestion(IQueryable<ComputerTechnology> computerTechnologies, string[] materials)
        {
            return _goodsQuestionsService.GetMaterialQuestion(computerTechnologies, materials);
        }
        public IQueryable<QuestionBase<string>> GetColorQuestion(IQueryable<ComputerTechnology> computerTechnologies, string[] colors)
        {
            return _goodsQuestionsService.GetColorQuestion(computerTechnologies, colors);
        }
    }
}
