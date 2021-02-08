using SunnyFlamingo.Entities.Goods.ComputerTechnologies.ComputerAccessories;
using SunnyFlamingo.Models;
using SunnyFlamingo.Models.Selectors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Searchers
{
    public interface IMiceQuestionsService
    {
        Task<List<QuestionsBase<string>>> GetMiceQuestions(
               IQueryable<Mause> mice,
               MiceSelector miceSelector);

        IQueryable<T> GetProducerMice<T>(
            IQueryable<T> mice,
               MiceSelector miceSelector) where T : Mause;
        IQueryable<T> GetCountryMice<T>(
            IQueryable<T> mice,
               MiceSelector miceSelector) where T : Mause;
        IQueryable<T> GetMaterialMice<T>(
            IQueryable<T> mice,
               MiceSelector miceSelector) where T : Mause;
        IQueryable<T> GetColorMice<T>(
            IQueryable<T> mice,
               MiceSelector miceSelector) where T : Mause;
        IQueryable<T> GetPriceMice<T>(
            IQueryable<T> mice,
               MiceSelector miceSelector) where T : Mause;
        IQueryable<T> GetTypeMice<T>(
            IQueryable<T> mice,
               MiceSelector miceSelector) where T : Mause;
        IQueryable<T> GetButtonsCountMice<T>(
            IQueryable<T> mice,
               MiceSelector miceSelector) where T : Mause;

        IQueryable<QuestionBase<string>> GetProducerQuestion(IQueryable<Mause> mice, string[] producers);
        IQueryable<QuestionBase<string>> GetCountryQuestion(IQueryable<Mause> mice, string[] countries);
        IQueryable<QuestionBase<string>> GetMaterialQuestion(IQueryable<Mause> mice, string[] materials);
        IQueryable<QuestionBase<string>> GetColorQuestion(IQueryable<Mause> mice, string[] colors);
        IQueryable<QuestionBase<string>> GetPriceQuestion(IQueryable<Mause> mice);
        IQueryable<QuestionBase<string>> GetTypeQuestion(IQueryable<Mause> mice, string[] types);
        IQueryable<QuestionBase<string>> GetButtonsCountQuestion(IQueryable<Mause> mice, int[] buttonsCount);
    }
}
