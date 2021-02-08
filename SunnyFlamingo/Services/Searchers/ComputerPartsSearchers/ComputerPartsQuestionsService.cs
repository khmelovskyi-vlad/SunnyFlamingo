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
    public class ComputerPartsQuestionsService : IComputerPartsQuestionsService
    {
        private readonly IComputerTechnologiesQuestionsService _computerTechnologiesQuestionsService;
        private readonly IQuestionsGrouper _questionsGrouper;
        public ComputerPartsQuestionsService(
            IComputerTechnologiesQuestionsService computerTechnologiesQuestionsService, 
            IQuestionsGrouper questionsGrouper)
        {
            _computerTechnologiesQuestionsService = computerTechnologiesQuestionsService;
            _questionsGrouper = questionsGrouper;
        }
        public async Task<List<QuestionsBase<string>>> GetComputerPartsQuestions(
            IQueryable<ComputerPart> computerParts,
            ComputerPartsSelector computerPartsSelector)
        {
            var goodsSelector = computerPartsSelector.ComputerTechnologiesSelector.GoodsSelector;
            var result = await GetQuestionList(computerParts, computerPartsSelector);
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
            IQueryable<ComputerPart> computerParts,
            ComputerPartsSelector computerPartsSelector)
        {
            var goodsSelector = computerPartsSelector.ComputerTechnologiesSelector.GoodsSelector;
            var producerQuestions = GetProducerQuestion(GetProducerComputerParts(computerParts, computerPartsSelector), goodsSelector.Producers);
            var countryQuestions = GetCountryQuestion(GetCountryComputerParts(computerParts, computerPartsSelector), goodsSelector.Countries);
            var materialQuestions = GetMaterialQuestion(GetMaterialComputerParts(computerParts, computerPartsSelector), goodsSelector.Materials);
            var colorQuestions = GetColorQuestion(GetColorComputerParts(computerParts, computerPartsSelector), goodsSelector.Colors);
            var priceQuestions = GetPriceQuestion(GetPriceComputerParts(computerParts, computerPartsSelector));

            var group = producerQuestions.Union(countryQuestions).Union(materialQuestions).Union(colorQuestions).Union(priceQuestions);
            return await group.ToListAsync();
        }

        public IQueryable<T> GetProducerComputerParts<T>(
            IQueryable<T> computerParts,
            ComputerPartsSelector computerPartsSelector) where T : ComputerPart
        {
            return _computerTechnologiesQuestionsService.GetProducerComputerTechnologies(
                computerParts, computerPartsSelector.ComputerTechnologiesSelector);
        }
        public IQueryable<T> GetCountryComputerParts<T>(
            IQueryable<T> computerParts,
            ComputerPartsSelector computerPartsSelector) where T : ComputerPart
        {
            return _computerTechnologiesQuestionsService.GetCountryComputerTechnologies(
                computerParts, computerPartsSelector.ComputerTechnologiesSelector);
        }
        public IQueryable<T> GetMaterialComputerParts<T>(
            IQueryable<T> computers,
            ComputerPartsSelector computerPartsSelector) where T : ComputerPart
        {
            return _computerTechnologiesQuestionsService.GetMaterialComputerTechnologies(
                computers, computerPartsSelector.ComputerTechnologiesSelector);
        }
        public IQueryable<T> GetColorComputerParts<T>(
            IQueryable<T> computerParts,
            ComputerPartsSelector computerPartsSelector) where T : ComputerPart
        {
            return _computerTechnologiesQuestionsService.GetColorComputerTechnologies(
                computerParts, computerPartsSelector.ComputerTechnologiesSelector);
        }
        public IQueryable<T> GetPriceComputerParts<T>(
            IQueryable<T> computerParts,
            ComputerPartsSelector computerPartsSelector) where T : ComputerPart
        {
            return _computerTechnologiesQuestionsService.GetPriceComputerTechnologies(
                computerParts, computerPartsSelector.ComputerTechnologiesSelector);
        }






        public IQueryable<QuestionBase<string>> GetProducerQuestion(IQueryable<ComputerPart> computerParts, string[] producers)
        {
            return _computerTechnologiesQuestionsService.GetProducerQuestion(computerParts, producers);
        }
        public IQueryable<QuestionBase<string>> GetCountryQuestion(IQueryable<ComputerPart> computerParts, string[] countries)
        {
            return _computerTechnologiesQuestionsService.GetCountryQuestion(computerParts, countries);
        }
        public IQueryable<QuestionBase<string>> GetMaterialQuestion(IQueryable<ComputerPart> computerParts, string[] materials)
        {
            return _computerTechnologiesQuestionsService.GetMaterialQuestion(computerParts, materials);
        }
        public IQueryable<QuestionBase<string>> GetColorQuestion(IQueryable<ComputerPart> computerParts, string[] colors)
        {
            return _computerTechnologiesQuestionsService.GetColorQuestion(computerParts, colors);
        }
        public IQueryable<QuestionBase<string>> GetPriceQuestion(IQueryable<ComputerPart> computerParts)
        {
            return _computerTechnologiesQuestionsService.GetPriceQuestion(computerParts);
        }
    }
}
