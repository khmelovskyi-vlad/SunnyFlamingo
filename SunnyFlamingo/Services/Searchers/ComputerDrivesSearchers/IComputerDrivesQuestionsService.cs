using SunnyFlamingo.Entities.Goods.ComputerTechnologies.ComputerParts;
using SunnyFlamingo.Models;
using SunnyFlamingo.Models.Selectors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Searchers
{
    public interface IComputerDrivesQuestionsService
    {
        Task<List<QuestionsBase<string>>> GetComputerDrivesQuestions(
               IQueryable<ComputerDrive> computerDrives,
               ComputerDrivesSelector computerDrivesSelector);

        IQueryable<T> GetProducerComputerDrives<T>(
            IQueryable<T> computerDrives,
               ComputerDrivesSelector computerDrivesSelector) where T : ComputerDrive;

        IQueryable<T> GetCountryComputerDrives<T>(
            IQueryable<T> computerDrives,
               ComputerDrivesSelector computerDrivesSelector) where T : ComputerDrive;
        IQueryable<T> GetMaterialComputerDrives<T>(
            IQueryable<T> computerDrives,
               ComputerDrivesSelector computerDrivesSelector) where T : ComputerDrive;
        IQueryable<T> GetColorComputerDrives<T>(
            IQueryable<T> computerDrives,
               ComputerDrivesSelector computerDrivesSelector) where T : ComputerDrive;
        IQueryable<T> GetPriceComputerDrives<T>(
            IQueryable<T> computerDrives,
               ComputerDrivesSelector computerDrivesSelector) where T : ComputerDrive;
        IQueryable<T> GetCapacityComputerDrives<T>(
            IQueryable<T> computerDrives,
               ComputerDrivesSelector computerDrivesSelector) where T : ComputerDrive;
        IQueryable<T> GetTypeComputerDrives<T>(
            IQueryable<T> computerDrives,
               ComputerDrivesSelector computerDrivesSelector) where T : ComputerDrive;
        IQueryable<T> GetFormFactorTypeComputerDrives<T>(
            IQueryable<T> computerDrives,
               ComputerDrivesSelector computerDrivesSelector) where T : ComputerDrive;
        IQueryable<QuestionBase<string>> GetProducerQuestion(IQueryable<ComputerDrive> computerDrives, string[] producers);
        IQueryable<QuestionBase<string>> GetCountryQuestion(IQueryable<ComputerDrive> computerDrives, string[] countries);
        IQueryable<QuestionBase<string>> GetMaterialQuestion(IQueryable<ComputerDrive> computerDrives, string[] materials);
        IQueryable<QuestionBase<string>> GetColorQuestion(IQueryable<ComputerDrive> computerDrives, string[] colors);
        IQueryable<QuestionBase<string>> GetPriceQuestion(IQueryable<ComputerDrive> computerDrives);
        IQueryable<QuestionBase<string>> GetCapacityQuestion(IQueryable<ComputerDrive> computerDrives, int[] capacities);
        IQueryable<QuestionBase<string>> GetTypeQuestion(IQueryable<ComputerDrive> computerDrives, string[] types);
        IQueryable<QuestionBase<string>> GetFormFactorTypeQuestion(IQueryable<ComputerDrive> computerDrives, string[] formFactorTypes);
    }
}
