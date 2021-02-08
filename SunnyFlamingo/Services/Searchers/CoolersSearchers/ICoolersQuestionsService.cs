using SunnyFlamingo.Entities.Goods.ComputerTechnologies.ComputerParts;
using SunnyFlamingo.Models;
using SunnyFlamingo.Models.Selectors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Searchers
{
    public interface ICoolersQuestionsService
    {
        Task<List<QuestionsBase<string>>> GetCoolersQuestions(
               IQueryable<Cooler> coolers,
               CoolersSelector coolersSelector);

        IQueryable<T> GetProducerCoolers<T>(
            IQueryable<T> coolers,
               CoolersSelector coolersSelector) where T : Cooler;

        IQueryable<T> GetCountryCoolers<T>(
            IQueryable<T> coolers,
               CoolersSelector coolersSelector) where T : Cooler;
        IQueryable<T> GetMaterialCoolers<T>(
            IQueryable<T> coolers,
               CoolersSelector coolersSelector) where T : Cooler;
        IQueryable<T> GetColorCoolers<T>(
            IQueryable<T> coolers,
               CoolersSelector coolersSelector) where T : Cooler;
        IQueryable<T> GetPriceCoolers<T>(
            IQueryable<T> coolers,
               CoolersSelector coolersSelector) where T : Cooler;
        IQueryable<T> GetFanSizeCoolers<T>(
            IQueryable<T> coolers,
               CoolersSelector coolersSelector) where T : Cooler;
        IQueryable<T> GetTypeCoolers<T>(
            IQueryable<T> coolers,
               CoolersSelector coolersSelector) where T : Cooler;
        IQueryable<QuestionBase<string>> GetProducerQuestion(IQueryable<Cooler> coolers, string[] producers);
        IQueryable<QuestionBase<string>> GetCountryQuestion(IQueryable<Cooler> coolers, string[] countries);
        IQueryable<QuestionBase<string>> GetMaterialQuestion(IQueryable<Cooler> coolers, string[] materials);
        IQueryable<QuestionBase<string>> GetColorQuestion(IQueryable<Cooler> coolers, string[] colors);
        IQueryable<QuestionBase<string>> GetPriceQuestion(IQueryable<Cooler> coolers);
        IQueryable<QuestionBase<string>> GetTypeQuestion(IQueryable<Cooler> coolers, string[] types);
        IQueryable<QuestionBase<string>> GetFanSizeQuestion(IQueryable<Cooler> coolers, int[] capacities);
    }
}
