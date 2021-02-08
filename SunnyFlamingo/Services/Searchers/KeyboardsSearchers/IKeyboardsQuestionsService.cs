using SunnyFlamingo.Entities.Goods.ComputerTechnologies.ComputerAccessories;
using SunnyFlamingo.Models;
using SunnyFlamingo.Models.Selectors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Searchers
{
    public interface IKeyboardsQuestionsService
    {
        Task<List<QuestionsBase<string>>> GetKeyboardsQuestions(
               IQueryable<Keyboard> keyboards,
               KeyboardsSelector keyboardsSelector);

        IQueryable<T> GetProducerKeyboards<T>(
            IQueryable<T> keyboards,
               KeyboardsSelector keyboardsSelector) where T : Keyboard;
        IQueryable<T> GetCountryKeyboards<T>(
            IQueryable<T> keyboards,
               KeyboardsSelector keyboardsSelector) where T : Keyboard;
        IQueryable<T> GetMaterialKeyboards<T>(
            IQueryable<T> keyboards,
               KeyboardsSelector keyboardsSelector) where T : Keyboard;
        IQueryable<T> GetColorKeyboards<T>(
            IQueryable<T> keyboards,
               KeyboardsSelector keyboardsSelector) where T : Keyboard;
        IQueryable<T> GetPriceKeyboards<T>(
            IQueryable<T> keyboards,
               KeyboardsSelector keyboardsSelector) where T : Keyboard;
        IQueryable<T> GetTypeKeyboards<T>(
            IQueryable<T> keyboards,
               KeyboardsSelector keyboardsSelector) where T : Keyboard;

        IQueryable<QuestionBase<string>> GetProducerQuestion(IQueryable<Keyboard> keyboards, string[] producers);
        IQueryable<QuestionBase<string>> GetCountryQuestion(IQueryable<Keyboard> keyboards, string[] countries);
        IQueryable<QuestionBase<string>> GetMaterialQuestion(IQueryable<Keyboard> keyboards, string[] materials);
        IQueryable<QuestionBase<string>> GetColorQuestion(IQueryable<Keyboard> keyboards, string[] colors);
        IQueryable<QuestionBase<string>> GetPriceQuestion(IQueryable<Keyboard> keyboards);
        IQueryable<QuestionBase<string>> GetTypeQuestion(IQueryable<Keyboard> keyboards, string[] types);
    }
}
