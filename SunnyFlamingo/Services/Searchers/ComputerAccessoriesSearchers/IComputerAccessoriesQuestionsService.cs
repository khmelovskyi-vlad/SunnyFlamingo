using SunnyFlamingo.Entities.Goods.ComputerTechnologies;
using SunnyFlamingo.Models;
using SunnyFlamingo.Models.Selectors;
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
               ComputerAccessoriesSelector computerAccessoriesSelector);

        IQueryable<T> GetProducerComputerAccessories<T>(
            IQueryable<T> computerAccessories,
               ComputerAccessoriesSelector computerAccessoriesSelector) where T : ComputerAccessory;

        IQueryable<T> GetCountryComputerAccessories<T>(
            IQueryable<T> computerAccessories,
               ComputerAccessoriesSelector computerAccessoriesSelector) where T : ComputerAccessory;
        IQueryable<T> GetMaterialComputerAccessories<T>(
            IQueryable<T> computerAccessories,
               ComputerAccessoriesSelector computerAccessoriesSelector) where T : ComputerAccessory;
        IQueryable<T> GetColorComputerAccessories<T>(
            IQueryable<T> computerAccessories,
               ComputerAccessoriesSelector computerAccessoriesSelector) where T : ComputerAccessory;
        IQueryable<T> GetPriceComputerAccessories<T>(
            IQueryable<T> computerAccessories,
               ComputerAccessoriesSelector computerAccessoriesSelector) where T : ComputerAccessory;
        IQueryable<QuestionBase<string>> GetProducerQuestion(IQueryable<ComputerAccessory> computerAccessories, string[] producers);
        IQueryable<QuestionBase<string>> GetCountryQuestion(IQueryable<ComputerAccessory> computerAccessories, string[] countries);
        IQueryable<QuestionBase<string>> GetMaterialQuestion(IQueryable<ComputerAccessory> computerAccessories, string[] materials);
        IQueryable<QuestionBase<string>> GetColorQuestion(IQueryable<ComputerAccessory> computerAccessories, string[] colors);
        IQueryable<QuestionBase<string>> GetPriceQuestion(IQueryable<ComputerAccessory> computerAccessories);
    }
}
