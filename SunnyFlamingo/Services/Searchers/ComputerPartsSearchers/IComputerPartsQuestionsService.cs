using SunnyFlamingo.Entities.Goods.ComputerTechnologies;
using SunnyFlamingo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Searchers
{
    public interface IComputerPartsQuestionsService
    {
        Task<List<QuestionsBase<string>>> GetComputerPartsQuestions(
               IQueryable<ComputerPart> computerParts,
               string[] producers,
               string[] countries,
               string[] materials,
               string[] colors,
               decimal? priceFrom,
               decimal? priceTo);

        IQueryable<T> GetProducerComputerParts<T>(
            IQueryable<T> computerParts,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            decimal? priceFrom,
            decimal? priceTo) where T : ComputerPart;

        IQueryable<T> GetCountryComputerParts<T>(
            IQueryable<T> computerParts,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            decimal? priceFrom,
            decimal? priceTo) where T : ComputerPart;
        IQueryable<T> GetMaterialComputerParts<T>(
            IQueryable<T> computerParts,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            decimal? priceFrom,
            decimal? priceTo) where T : ComputerPart;
        IQueryable<T> GetColorComputerParts<T>(
            IQueryable<T> computerParts,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            decimal? priceFrom,
            decimal? priceTo) where T : ComputerPart;
        IQueryable<T> GetPriceComputerParts<T>(
            IQueryable<T> computerParts,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            decimal? priceFrom,
            decimal? priceTo) where T : ComputerPart;
        Task<QuestionsBase<string>> GetProducerQuestion(IQueryable<ComputerPart> computerParts, string[] producers);
        Task<QuestionsBase<string>> GetCountryQuestion(IQueryable<ComputerPart> computerParts, string[] countries);
        Task<QuestionsBase<string>> GetMaterialQuestion(IQueryable<ComputerPart> computerParts, string[] materials);
        Task<QuestionsBase<string>> GetColorQuestion(IQueryable<ComputerPart> computerParts, string[] colors);
        Task<QuestionsBase<string>> GetPriceQuestion(IQueryable<ComputerPart> computerParts, decimal? selectedFrom, decimal? selectedTo);
    }
}
