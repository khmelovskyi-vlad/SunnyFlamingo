using SunnyFlamingo.Entities.Goods.ComputerTechnologies;
using SunnyFlamingo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Searchers
{
    public interface IComputerAccessoriesQuestionsService
    {
        Task<List<QuestionsBase<string>>> GetComputerAccessoriesQuestions(
               IQueryable<ComputerAccessory> computerAccessories,
               string[] producers,
               string[] countries,
               string[] materials,
               string[] colors,
               decimal? priceFrom,
               decimal? priceTo);

        IQueryable<T> GetProducerComputerAccessories<T>(
            IQueryable<T> computerAccessories,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            decimal? priceFrom,
            decimal? priceTo) where T : ComputerAccessory;

        IQueryable<T> GetCountryComputerAccessories<T>(
            IQueryable<T> computerAccessories,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            decimal? priceFrom,
            decimal? priceTo) where T : ComputerAccessory;
        IQueryable<T> GetMaterialComputerAccessories<T>(
            IQueryable<T> computerAccessories,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            decimal? priceFrom,
            decimal? priceTo) where T : ComputerAccessory;
        IQueryable<T> GetColorComputerAccessories<T>(
            IQueryable<T> computerAccessories,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            decimal? priceFrom,
            decimal? priceTo) where T : ComputerAccessory;
        IQueryable<T> GetPriceComputerAccessories<T>(
            IQueryable<T> computerAccessories,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            decimal? priceFrom,
            decimal? priceTo) where T : ComputerAccessory;
        Task<QuestionsBase<string>> GetProducerQuestion(IQueryable<ComputerAccessory> computerAccessories, string[] producers);
        Task<QuestionsBase<string>> GetCountryQuestion(IQueryable<ComputerAccessory> computerAccessories, string[] countries);
        Task<QuestionsBase<string>> GetMaterialQuestion(IQueryable<ComputerAccessory> computerAccessories, string[] materials);
        Task<QuestionsBase<string>> GetColorQuestion(IQueryable<ComputerAccessory> computerAccessories, string[] colors);
        Task<QuestionsBase<string>> GetPriceQuestion(IQueryable<ComputerAccessory> computerAccessories, decimal? selectedFrom, decimal? selectedTo);
    }
}
