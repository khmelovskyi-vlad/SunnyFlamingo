using SunnyFlamingo.Entities.Goods;
using SunnyFlamingo.Models;
using SunnyFlamingo.Models.Selectors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Searchers
{
    public interface IComputerTechnologiesQuestionsService
    {
        Task<List<QuestionsBase<string>>> GetComputerTechnologiesQuestions(IQueryable<ComputerTechnology> computerTechnologies,
            ComputerTechnologiesSelector computerTechnologiesSelector);
        IQueryable<T> GetProducerComputerTechnologies<T>(
            IQueryable<T> computerTechnologies,
            ComputerTechnologiesSelector computerTechnologiesSelector) where T : ComputerTechnology;

        IQueryable<T> GetCountryComputerTechnologies<T>(
            IQueryable<T> computerTechnologies,
            ComputerTechnologiesSelector computerTechnologiesSelector) where T : ComputerTechnology;

        IQueryable<T> GetMaterialComputerTechnologies<T>(
            IQueryable<T> computerTechnologies,
            ComputerTechnologiesSelector computerTechnologiesSelector) where T : ComputerTechnology;
        IQueryable<T> GetColorComputerTechnologies<T>(
            IQueryable<T> computerTechnologies,
            ComputerTechnologiesSelector computerTechnologiesSelector) where T : ComputerTechnology;
        IQueryable<T> GetPriceComputerTechnologies<T>(
            IQueryable<T> computerTechnologies,
            ComputerTechnologiesSelector computerTechnologiesSelector) where T : ComputerTechnology;

        IQueryable<QuestionBase<string>> GetPriceQuestion(IQueryable<ComputerTechnology> computerTechnologies);
        IQueryable<QuestionBase<string>> GetProducerQuestion(IQueryable<ComputerTechnology> computerTechnologies, string[] producers);
        IQueryable<QuestionBase<string>> GetCountryQuestion(IQueryable<ComputerTechnology> computerTechnologies, string[] countries);
        IQueryable<QuestionBase<string>> GetMaterialQuestion(IQueryable<ComputerTechnology> computerTechnologies, string[] materials);
        IQueryable<QuestionBase<string>> GetColorQuestion(IQueryable<ComputerTechnology> computerTechnologies, string[] colors);
    }
}
