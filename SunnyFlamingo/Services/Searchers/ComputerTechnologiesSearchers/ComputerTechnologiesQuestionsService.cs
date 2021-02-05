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
            return new List<QuestionsBase<string>>()
                {
                    await GetProducerQuestion(GetProducerComputerTechnologies(computerTechnologies, producers, countries, materials, colors, priceFrom, priceTo), producers),
                    await GetCountryQuestion(GetCountryComputerTechnologies(computerTechnologies, producers, countries, materials, colors, priceFrom, priceTo), countries),
                    await GetMaterialQuestion(GetMaterialComputerTechnologies(computerTechnologies, producers, countries, materials, colors, priceFrom, priceTo), materials),
                    await GetColorQuestion(GetColorComputerTechnologies(computerTechnologies, producers, countries, materials, colors, priceFrom, priceTo), colors),
                    await GetPriceQuestion(GetPriceComputerTechnologies(computerTechnologies, producers, countries, materials, colors, priceFrom, priceTo), priceFrom, priceTo)
                };
        }
        public IQueryable<T> GetProducerComputerTechnologies<T>(
            IQueryable<T> computerTechnologies,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            decimal? priceFrom,
            decimal? priceTo) where T : ComputerTechnology
        {
            return _goodsQuestionsService.GetProducerGoods(computerTechnologies, producers, countries, materials, colors, priceFrom, priceTo);
        }
        public IQueryable<T> GetCountryComputerTechnologies<T>(
            IQueryable<T> computerTechnologies,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            decimal? priceFrom,
            decimal? priceTo) where T : ComputerTechnology
        {
            return _goodsQuestionsService.GetCountryGoods(computerTechnologies, producers, countries, materials, colors, priceFrom, priceTo);
        }
        public IQueryable<T> GetMaterialComputerTechnologies<T>(
            IQueryable<T> computerTechnologies,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            decimal? priceFrom,
            decimal? priceTo) where T : ComputerTechnology
        {
            return _goodsQuestionsService.GetMaterialGoods(computerTechnologies, producers, countries, materials, colors, priceFrom, priceTo);
        }
        public IQueryable<T> GetColorComputerTechnologies<T>(
            IQueryable<T> computerTechnologies,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            decimal? priceFrom,
            decimal? priceTo) where T : ComputerTechnology
        {
            return _goodsQuestionsService.GetColorGoods(computerTechnologies, producers, countries, materials, colors, priceFrom, priceTo);
        }
        public IQueryable<T> GetPriceComputerTechnologies<T>(
            IQueryable<T> computerTechnologies,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            decimal? priceFrom,
            decimal? priceTo) where T : ComputerTechnology
        {
            return _goodsQuestionsService.GetPriceGoods(computerTechnologies, producers, countries, materials, colors, priceFrom, priceTo);
        }
        public async Task<QuestionsBase<string>> GetPriceQuestion(IQueryable<ComputerTechnology> goods, decimal? selectedFrom, decimal? selectedTo)
        {
            return new QuestionsBase<string>();
            //return await _goodsQuestionsService.GetPriceQuestion(goods, selectedFrom, selectedTo);
        }
        public async Task<QuestionsBase<string>> GetProducerQuestion(IQueryable<ComputerTechnology> computerTechnologies, string[] producers)
        {
            return new QuestionsBase<string>();
            //return await _goodsQuestionsService.GetProducerQuestion(computerTechnologies, producers);
        }
        public async Task<QuestionsBase<string>> GetCountryQuestion(IQueryable<ComputerTechnology> computerTechnologies, string[] countries)
        {
            return new QuestionsBase<string>();
            //return await _goodsQuestionsService.GetCountryQuestion(computerTechnologies, countries);
        }
        public async Task<QuestionsBase<string>> GetMaterialQuestion(IQueryable<ComputerTechnology> computerTechnologies, string[] materials)
        {
            return new QuestionsBase<string>();
            //return await _goodsQuestionsService.GetMaterialQuestion(computerTechnologies, materials);
        }
        public async Task<QuestionsBase<string>> GetColorQuestion(IQueryable<ComputerTechnology> computerTechnologies, string[] colors)
        {
            return new QuestionsBase<string>();
            //return await _goodsQuestionsService.GetColorQuestion(computerTechnologies, colors);
        }
    }
}
