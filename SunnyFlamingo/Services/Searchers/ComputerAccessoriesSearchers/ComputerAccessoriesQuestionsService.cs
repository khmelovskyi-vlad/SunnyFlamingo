using Microsoft.EntityFrameworkCore;
using SunnyFlamingo.Entities.Goods.ComputerTechnologies;
using SunnyFlamingo.Models;
using SunnyFlamingo.Models.Selectors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Searchers
{
    public class ComputerAccessoriesQuestionsService : IComputerAccessoriesQuestionsService
    {
        private readonly IComputerTechnologiesQuestionsService _computerTechnologiesQuestionsService;
        private readonly IQuestionsGrouper _questionsGrouper;
        public ComputerAccessoriesQuestionsService(
            IComputerTechnologiesQuestionsService computerTechnologiesQuestionsService,
            IQuestionsGrouper questionsGrouper)
        {
            _computerTechnologiesQuestionsService = computerTechnologiesQuestionsService;
            _questionsGrouper = questionsGrouper;
        }
        public async Task<List<QuestionsBase<string>>> GetComputerAccessoriesQuestions(
            IQueryable<ComputerAccessory> computerAccessories,
            ComputerAccessoriesSelector computerAccessoriesSelector)
        {
            var goodsSelector = computerAccessoriesSelector.ComputerTechnologiesSelector.GoodsSelector;
            var result = await GetQuestionList(computerAccessories, computerAccessoriesSelector);
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
            IQueryable<ComputerAccessory> computerAccessories,
            ComputerAccessoriesSelector computerAccessoriesSelector)
        {
            var goodsSelector = computerAccessoriesSelector.ComputerTechnologiesSelector.GoodsSelector;

            var producerQuestions = GetProducerQuestion(GetProducerComputerAccessories(computerAccessories, computerAccessoriesSelector), goodsSelector.Producers);
            var countryQuestions = GetCountryQuestion(GetCountryComputerAccessories(computerAccessories, computerAccessoriesSelector), goodsSelector.Countries);
            var materialQuestions = GetMaterialQuestion(GetMaterialComputerAccessories(computerAccessories, computerAccessoriesSelector), goodsSelector.Materials);
            var colorQuestions = GetColorQuestion(GetColorComputerAccessories(computerAccessories, computerAccessoriesSelector), goodsSelector.Colors);
            var priceQuestions = GetPriceQuestion(GetPriceComputerAccessories(computerAccessories, computerAccessoriesSelector));

            var group = producerQuestions.Union(countryQuestions).Union(materialQuestions).Union(colorQuestions).Union(priceQuestions);
            return await group.ToListAsync();
        }

        public IQueryable<T> GetProducerComputerAccessories<T>(
            IQueryable<T> computerAccessories,
            ComputerAccessoriesSelector computerAccessoriesSelector) where T : ComputerAccessory
        {
            return _computerTechnologiesQuestionsService.GetProducerComputerTechnologies(
                computerAccessories, computerAccessoriesSelector.ComputerTechnologiesSelector);
        }
        public IQueryable<T> GetCountryComputerAccessories<T>(
            IQueryable<T> computerAccessories,
            ComputerAccessoriesSelector computerAccessoriesSelector) where T : ComputerAccessory
        {
            return _computerTechnologiesQuestionsService.GetCountryComputerTechnologies(
                computerAccessories, computerAccessoriesSelector.ComputerTechnologiesSelector);
        }
        public IQueryable<T> GetMaterialComputerAccessories<T>(
            IQueryable<T> computerAccessories,
            ComputerAccessoriesSelector computerAccessoriesSelector) where T : ComputerAccessory
        {
            return _computerTechnologiesQuestionsService.GetMaterialComputerTechnologies(
                computerAccessories, computerAccessoriesSelector.ComputerTechnologiesSelector);
        }
        public IQueryable<T> GetColorComputerAccessories<T>(
            IQueryable<T> computerAccessories,
            ComputerAccessoriesSelector computerAccessoriesSelector) where T : ComputerAccessory
        {
            return _computerTechnologiesQuestionsService.GetColorComputerTechnologies(
                computerAccessories, computerAccessoriesSelector.ComputerTechnologiesSelector);
        }
        public IQueryable<T> GetPriceComputerAccessories<T>(
            IQueryable<T> computerAccessories,
            ComputerAccessoriesSelector computerAccessoriesSelector) where T : ComputerAccessory
        {
            return _computerTechnologiesQuestionsService.GetPriceComputerTechnologies(
                computerAccessories, computerAccessoriesSelector.ComputerTechnologiesSelector);
        }






        public IQueryable<QuestionBase<string>> GetProducerQuestion(IQueryable<ComputerAccessory> computerAccessories, string[] producers)
        {
            return _computerTechnologiesQuestionsService.GetProducerQuestion(computerAccessories, producers);
        }
        public IQueryable<QuestionBase<string>> GetCountryQuestion(IQueryable<ComputerAccessory> computerAccessories, string[] countries)
        {
            return _computerTechnologiesQuestionsService.GetCountryQuestion(computerAccessories, countries);
        }
        public IQueryable<QuestionBase<string>> GetMaterialQuestion(IQueryable<ComputerAccessory> computerAccessories, string[] materials)
        {
            return _computerTechnologiesQuestionsService.GetMaterialQuestion(computerAccessories, materials);
        }
        public IQueryable<QuestionBase<string>> GetColorQuestion(IQueryable<ComputerAccessory> computerAccessories, string[] colors)
        {
            return _computerTechnologiesQuestionsService.GetColorQuestion(computerAccessories, colors);
        }
        public IQueryable<QuestionBase<string>> GetPriceQuestion(IQueryable<ComputerAccessory> computerAccessories)
        {
            return _computerTechnologiesQuestionsService.GetPriceQuestion(computerAccessories);
        }
    }
}
