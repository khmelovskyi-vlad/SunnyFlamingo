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
        Task<List<QuestionsBase<string>>> GetComputerTechnologiesQuestions(IQueryable<ComputerTechnology> computerTechnologies,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            decimal? priceFrom,
            decimal? priceTo);
        IQueryable<T> GetProducerComputerTechnologies<T>(
            IQueryable<T> computerTechnologies,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            decimal? from,
            decimal? to) where T : ComputerTechnology;

        IQueryable<T> GetCountryComputerTechnologies<T>(
            IQueryable<T> computerTechnologies,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            decimal? from,
            decimal? to) where T : ComputerTechnology;

        IQueryable<T> GetMaterialComputerTechnologies<T>(
            IQueryable<T> computerTechnologies,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            decimal? from,
            decimal? to) where T : ComputerTechnology;
        IQueryable<T> GetColorComputerTechnologies<T>(
            IQueryable<T> computerTechnologies,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            decimal? from,
            decimal? to) where T : ComputerTechnology;
        IQueryable<T> GetPriceComputerTechnologies<T>(
            IQueryable<T> computerTechnologies,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            decimal? from,
            decimal? to) where T : ComputerTechnology;

        Task<QuestionsBase<string>> GetPriceQuestion(IQueryable<ComputerTechnology> computerTechnologies, decimal? selectedFrom, decimal? selectedTo);
        Task<QuestionsBase<string>> GetProducerQuestion(IQueryable<ComputerTechnology> computerTechnologies, string[] producers);
        Task<QuestionsBase<string>> GetCountryQuestion(IQueryable<ComputerTechnology> computerTechnologies, string[] countries);
        Task<QuestionsBase<string>> GetMaterialQuestion(IQueryable<ComputerTechnology> computerTechnologies, string[] materials);
        Task<QuestionsBase<string>> GetColorQuestion(IQueryable<ComputerTechnology> computerTechnologies, string[] colors);
    }
}
