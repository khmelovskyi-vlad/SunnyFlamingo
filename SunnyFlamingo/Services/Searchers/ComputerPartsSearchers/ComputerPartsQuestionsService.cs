using SunnyFlamingo.Entities.Goods.ComputerTechnologies;
using SunnyFlamingo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Searchers
{
    public class ComputerPartsQuestionsService : IComputerPartsQuestionsService
    {
        private readonly IComputerTechnologiesQuestionsService _computerTechnologiesQuestionsService;
        public ComputerPartsQuestionsService(IComputerTechnologiesQuestionsService computerTechnologiesQuestionsService)
        {
            _computerTechnologiesQuestionsService = computerTechnologiesQuestionsService;
        }
        public async Task<List<QuestionsBase<string>>> GetComputerPartsQuestions(
            IQueryable<ComputerPart> computerParts,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            decimal? priceFrom,
            decimal? priceTo)
        {
            return new List<QuestionsBase<string>>()
                {
                    await GetProducerQuestion(GetProducerComputerParts(computerParts, producers, countries, materials, colors,
                    priceFrom, priceTo), producers),
                    await GetCountryQuestion(GetCountryComputerParts(computerParts, producers, countries, materials, colors,
                    priceFrom, priceTo), countries),
                    await GetMaterialQuestion(GetMaterialComputerParts(computerParts, producers, countries, materials, colors,
                    priceFrom, priceTo), materials),
                    await GetColorQuestion(GetColorComputerParts(computerParts, producers, countries, materials, colors,
                    priceFrom, priceTo), colors),
                    await GetPriceQuestion(GetPriceComputerParts(computerParts, producers, countries, materials, colors,
                    priceFrom, priceTo), priceFrom, priceTo)
                };
        }

        public IQueryable<T> GetProducerComputerParts<T>(
            IQueryable<T> computerParts,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            decimal? priceFrom,
            decimal? priceTo) where T : ComputerPart
        {
            return _computerTechnologiesQuestionsService.GetProducerComputerTechnologies(
                computerParts, producers, countries, materials, colors, priceFrom, priceTo);
        }
        public IQueryable<T> GetCountryComputerParts<T>(
            IQueryable<T> computerParts,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            decimal? priceFrom,
            decimal? priceTo) where T : ComputerPart
        {
            return _computerTechnologiesQuestionsService.GetCountryComputerTechnologies(
                computerParts, producers, countries, materials, colors, priceFrom, priceTo);
        }
        public IQueryable<T> GetMaterialComputerParts<T>(
            IQueryable<T> computers,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            decimal? priceFrom,
            decimal? priceTo) where T : ComputerPart
        {
            return _computerTechnologiesQuestionsService.GetMaterialComputerTechnologies(
                computers, producers, countries, materials, colors, priceFrom, priceTo);
        }
        public IQueryable<T> GetColorComputerParts<T>(
            IQueryable<T> computerParts,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            decimal? priceFrom,
            decimal? priceTo) where T : ComputerPart
        {
            return _computerTechnologiesQuestionsService.GetColorComputerTechnologies(
                computerParts, producers, countries, materials, colors, priceFrom, priceTo);
        }
        public IQueryable<T> GetPriceComputerParts<T>(
            IQueryable<T> computerParts,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            decimal? priceFrom,
            decimal? priceTo) where T : ComputerPart
        {
            return _computerTechnologiesQuestionsService.GetPriceComputerTechnologies(
                computerParts, producers, countries, materials, colors, priceFrom, priceTo);
        }






        public async Task<QuestionsBase<string>> GetProducerQuestion(IQueryable<ComputerPart> computerParts, string[] producers)
        {
            return await _computerTechnologiesQuestionsService.GetProducerQuestion(computerParts, producers);
        }
        public async Task<QuestionsBase<string>> GetCountryQuestion(IQueryable<ComputerPart> computerParts, string[] countries)
        {
            return await _computerTechnologiesQuestionsService.GetCountryQuestion(computerParts, countries);
        }
        public async Task<QuestionsBase<string>> GetMaterialQuestion(IQueryable<ComputerPart> computerParts, string[] materials)
        {
            return await _computerTechnologiesQuestionsService.GetMaterialQuestion(computerParts, materials);
        }
        public async Task<QuestionsBase<string>> GetColorQuestion(IQueryable<ComputerPart> computerParts, string[] colors)
        {
            return await _computerTechnologiesQuestionsService.GetColorQuestion(computerParts, colors);
        }
        public async Task<QuestionsBase<string>> GetPriceQuestion(IQueryable<ComputerPart> computerParts, decimal? selectedFrom, decimal? selectedTo)
        {
            return await _computerTechnologiesQuestionsService.GetPriceQuestion(computerParts, selectedFrom, selectedTo);
        }
    }
}
