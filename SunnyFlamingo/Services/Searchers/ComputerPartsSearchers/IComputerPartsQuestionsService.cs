using SunnyFlamingo.Entities.Goods.ComputerTechnologies;
using SunnyFlamingo.Models;
using SunnyFlamingo.Models.Selectors;
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
               ComputerPartsSelector computerPartsSelector);

        IQueryable<T> GetProducerComputerParts<T>(
            IQueryable<T> computerParts,
               ComputerPartsSelector computerPartsSelector) where T : ComputerPart;

        IQueryable<T> GetCountryComputerParts<T>(
            IQueryable<T> computerParts,
               ComputerPartsSelector computerPartsSelector) where T : ComputerPart;
        IQueryable<T> GetMaterialComputerParts<T>(
            IQueryable<T> computerParts,
               ComputerPartsSelector computerPartsSelector) where T : ComputerPart;
        IQueryable<T> GetColorComputerParts<T>(
            IQueryable<T> computerParts,
               ComputerPartsSelector computerPartsSelector) where T : ComputerPart;
        IQueryable<T> GetPriceComputerParts<T>(
            IQueryable<T> computerParts,
               ComputerPartsSelector computerPartsSelector) where T : ComputerPart;
        IQueryable<QuestionBase<string>> GetPriceQuestion(IQueryable<ComputerPart> computerParts);
        IQueryable<QuestionBase<string>> GetProducerQuestion(IQueryable<ComputerPart> computerParts, string[] producers);
        IQueryable<QuestionBase<string>> GetCountryQuestion(IQueryable<ComputerPart> computerParts, string[] countries);
        IQueryable<QuestionBase<string>> GetMaterialQuestion(IQueryable<ComputerPart> computerParts, string[] materials);
        IQueryable<QuestionBase<string>> GetColorQuestion(IQueryable<ComputerPart> computerParts, string[] colors);
    }
}
