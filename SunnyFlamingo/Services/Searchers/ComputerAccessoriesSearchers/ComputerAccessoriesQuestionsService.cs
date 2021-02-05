using SunnyFlamingo.Entities.Goods.ComputerTechnologies;
using SunnyFlamingo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Searchers
{
    public class ComputerAccessoriesQuestionsService : IComputerAccessoriesQuestionsService
    {
        private readonly IComputerTechnologiesQuestionsService _computerTechnologiesQuestionsService;
        public ComputerAccessoriesQuestionsService(IComputerTechnologiesQuestionsService computerTechnologiesQuestionsService)
        {
            _computerTechnologiesQuestionsService = computerTechnologiesQuestionsService;
        }
        public async Task<List<QuestionsBase<string>>> GetComputerAccessoriesQuestions(
            IQueryable<ComputerAccessory> computerAccessories,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            decimal? priceFrom,
            decimal? priceTo)
        {
            return new List<QuestionsBase<string>>()
                {
                    await GetProducerQuestion(GetProducerComputerAccessories(computerAccessories, producers, countries, materials, colors,
                    priceFrom, priceTo), producers),
                    await GetCountryQuestion(GetCountryComputerAccessories(computerAccessories, producers, countries, materials, colors,
                    priceFrom, priceTo), countries),
                    await GetMaterialQuestion(GetMaterialComputerAccessories(computerAccessories, producers, countries, materials, colors,
                    priceFrom, priceTo), materials),
                    await GetColorQuestion(GetColorComputerAccessories(computerAccessories, producers, countries, materials, colors,
                    priceFrom, priceTo), colors),
                    await GetPriceQuestion(GetPriceComputerAccessories(computerAccessories, producers, countries, materials, colors,
                    priceFrom, priceTo), priceFrom, priceTo)
                };
        }

        public IQueryable<T> GetProducerComputerAccessories<T>(
            IQueryable<T> computerAccessories,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            decimal? priceFrom,
            decimal? priceTo) where T : ComputerAccessory
        {
            return _computerTechnologiesQuestionsService.GetProducerComputerTechnologies(
                computerAccessories, producers, countries, materials, colors, priceFrom, priceTo);
        }
        public IQueryable<T> GetCountryComputerAccessories<T>(
            IQueryable<T> computerAccessories,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            decimal? priceFrom,
            decimal? priceTo) where T : ComputerAccessory
        {
            return _computerTechnologiesQuestionsService.GetCountryComputerTechnologies(
                computerAccessories, producers, countries, materials, colors, priceFrom, priceTo);
        }
        public IQueryable<T> GetMaterialComputerAccessories<T>(
            IQueryable<T> computerAccessories,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            decimal? priceFrom,
            decimal? priceTo) where T : ComputerAccessory
        {
            return _computerTechnologiesQuestionsService.GetMaterialComputerTechnologies(
                computerAccessories, producers, countries, materials, colors, priceFrom, priceTo);
        }
        public IQueryable<T> GetColorComputerAccessories<T>(
            IQueryable<T> computerAccessories,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            decimal? priceFrom,
            decimal? priceTo) where T : ComputerAccessory
        {
            return _computerTechnologiesQuestionsService.GetColorComputerTechnologies(
                computerAccessories, producers, countries, materials, colors, priceFrom, priceTo);
        }
        public IQueryable<T> GetPriceComputerAccessories<T>(
            IQueryable<T> computerAccessories,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            decimal? priceFrom,
            decimal? priceTo) where T : ComputerAccessory
        {
            return _computerTechnologiesQuestionsService.GetPriceComputerTechnologies(
                computerAccessories, producers, countries, materials, colors, priceFrom, priceTo);
        }






        public async Task<QuestionsBase<string>> GetProducerQuestion(IQueryable<ComputerAccessory> computerAccessories, string[] producers)
        {
            return await _computerTechnologiesQuestionsService.GetProducerQuestion(computerAccessories, producers);
        }
        public async Task<QuestionsBase<string>> GetCountryQuestion(IQueryable<ComputerAccessory> computerAccessories, string[] countries)
        {
            return await _computerTechnologiesQuestionsService.GetCountryQuestion(computerAccessories, countries);
        }
        public async Task<QuestionsBase<string>> GetMaterialQuestion(IQueryable<ComputerAccessory> computerAccessories, string[] materials)
        {
            return await _computerTechnologiesQuestionsService.GetMaterialQuestion(computerAccessories, materials);
        }
        public async Task<QuestionsBase<string>> GetColorQuestion(IQueryable<ComputerAccessory> computerAccessories, string[] colors)
        {
            return await _computerTechnologiesQuestionsService.GetColorQuestion(computerAccessories, colors);
        }
        public async Task<QuestionsBase<string>> GetPriceQuestion(IQueryable<ComputerAccessory> computerAccessories, decimal? selectedFrom, decimal? selectedTo)
        {
            return await _computerTechnologiesQuestionsService.GetPriceQuestion(computerAccessories, selectedFrom, selectedTo);
        }
    }
}
