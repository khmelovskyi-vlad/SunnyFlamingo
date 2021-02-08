using SunnyFlamingo.Entities.Goods.ComputerTechnologies.ComputerAccessories;
using SunnyFlamingo.Models;
using SunnyFlamingo.Models.Selectors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Searchers
{
    public interface IHeadphonesQuestionsService
    {
        Task<List<QuestionsBase<string>>> GetHeadphonesQuestions(
               IQueryable<Headphones> headphones,
               HeadphonesSelector headphonesSelector);

        IQueryable<T> GetProducerHeadphones<T>(
            IQueryable<T> headphones,
               HeadphonesSelector headphonesSelector) where T : Headphones;

        IQueryable<T> GetCountryHeadphones<T>(
            IQueryable<T> headphones,
               HeadphonesSelector headphonesSelector) where T : Headphones;
        IQueryable<T> GetMaterialHeadphones<T>(
            IQueryable<T> headphones,
               HeadphonesSelector headphonesSelector) where T : Headphones;
        IQueryable<T> GetColorHeadphones<T>(
            IQueryable<T> headphones,
               HeadphonesSelector headphonesSelector) where T : Headphones;
        IQueryable<T> GetPriceHeadphones<T>(
            IQueryable<T> headphones,
               HeadphonesSelector headphonesSelector) where T : Headphones;
        IQueryable<T> GetTypeHeadphones<T>(
            IQueryable<T> headphones,
               HeadphonesSelector headphonesSelector) where T : Headphones;
        IQueryable<T> GetWirelessTypeHeadphones<T>(
            IQueryable<T> headphones,
               HeadphonesSelector headphonesSelector) where T : Headphones;
        IQueryable<T> GetConnectorTypeHeadphones<T>(
            IQueryable<T> headphones,
               HeadphonesSelector headphonesSelector) where T : Headphones;

        IQueryable<QuestionBase<string>> GetProducerQuestion(IQueryable<Headphones> headphones, string[] producers);
        IQueryable<QuestionBase<string>> GetCountryQuestion(IQueryable<Headphones> headphones, string[] countries);
        IQueryable<QuestionBase<string>> GetMaterialQuestion(IQueryable<Headphones> headphones, string[] materials);
        IQueryable<QuestionBase<string>> GetColorQuestion(IQueryable<Headphones> headphones, string[] colors);
        IQueryable<QuestionBase<string>> GetPriceQuestion(IQueryable<Headphones> headphones);
        IQueryable<QuestionBase<string>> GetTypeQuestion(IQueryable<Headphones> headphones, string[] types);
        IQueryable<QuestionBase<string>> GetWirelessTypeQuestion(IQueryable<Headphones> headphones, string[] wirelessTypes);
        IQueryable<QuestionBase<string>> GetConnectorTypeQuestion(IQueryable<Headphones> headphones, string[] connectorTypes);
    }
}