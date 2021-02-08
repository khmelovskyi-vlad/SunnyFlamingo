using SunnyFlamingo.Entities.Goods.ComputerTechnologies;
using SunnyFlamingo.Models;
using SunnyFlamingo.Models.Selectors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Searchers
{
    public interface IFlashDrivesQuestionsService
    {
        Task<List<QuestionsBase<string>>> GetFlashDrivesQuestions(IQueryable<FlashDrive> goods,
            FlashDrivesSelector flashDrivesSelector);
        IQueryable<T> GetProducerFlashDrives<T>(
            IQueryable<T> flashDrives,
            FlashDrivesSelector flashDrivesSelector) where T : FlashDrive;

        IQueryable<T> GetCountryFlashDrives<T>(
            IQueryable<T> flashDrives,
            FlashDrivesSelector flashDrivesSelector) where T : FlashDrive;

        IQueryable<T> GetMaterialFlashDrives<T>(
            IQueryable<T> flashDrives,
            FlashDrivesSelector flashDrivesSelector) where T : FlashDrive;
        IQueryable<T> GetColorFlashDrives<T>(
            IQueryable<T> flashDrives,
            FlashDrivesSelector flashDrivesSelector) where T : FlashDrive;
        IQueryable<T> GetPriceFlashDrives<T>(
            IQueryable<T> flashDrives,
            FlashDrivesSelector flashDrivesSelector) where T : FlashDrive;
        IQueryable<T> GetCapacityFlashDrives<T>(
            IQueryable<T> flashDrives,
            FlashDrivesSelector flashDrivesSelector) where T : FlashDrive;
        IQueryable<T> GetUSBSpecificationTypeFlashDrives<T>(
            IQueryable<T> flashDrives,
            FlashDrivesSelector flashDrivesSelector) where T : FlashDrive;

        IQueryable<QuestionBase<string>> GetPriceQuestion(IQueryable<FlashDrive> flashDrives);
        IQueryable<QuestionBase<string>> GetProducerQuestion(IQueryable<FlashDrive> flashDrives, string[] producers);
        IQueryable<QuestionBase<string>> GetCountryQuestion(IQueryable<FlashDrive> flashDrives, string[] countries);
        IQueryable<QuestionBase<string>> GetMaterialQuestion(IQueryable<FlashDrive> flashDrives, string[] materials);
        IQueryable<QuestionBase<string>> GetColorQuestion(IQueryable<FlashDrive> flashDrives, string[] colors);
        IQueryable<QuestionBase<string>> GetCapacityQuestion(IQueryable<FlashDrive> flashDrives, int[] capacities);
        IQueryable<QuestionBase<string>> GetUSBSpecificationTypeQuestion(IQueryable<FlashDrive> flashDrives, string[] USBSpecificationTypes);
    }
}
