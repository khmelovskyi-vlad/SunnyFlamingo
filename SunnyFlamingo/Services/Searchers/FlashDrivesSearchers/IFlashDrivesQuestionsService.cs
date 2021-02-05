using SunnyFlamingo.Entities.Goods.ComputerTechnologies;
using SunnyFlamingo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Searchers
{
    public interface IFlashDrivesQuestionsService
    {
        Task<List<QuestionsBase<string>>> GetFlashDrivesQuestions(IQueryable<FlashDrive> goods,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            int[] capacities,
            string[] USBSpecificationTypes,
            decimal? priceFrom,
            decimal? priceTo);
        IQueryable<T> GetProducerFlashDrives<T>(
            IQueryable<T> flashDrives,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            int[] capacities,
            string[] USBSpecificationTypes,
            decimal? from,
            decimal? to) where T : FlashDrive;

        IQueryable<T> GetCountryFlashDrives<T>(
            IQueryable<T> flashDrives,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            int[] capacities,
            string[] USBSpecificationTypes,
            decimal? from,
            decimal? to) where T : FlashDrive;

        IQueryable<T> GetMaterialFlashDrives<T>(
            IQueryable<T> flashDrives,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            int[] capacities,
            string[] USBSpecificationTypes,
            decimal? from,
            decimal? to) where T : FlashDrive;
        IQueryable<T> GetColorFlashDrives<T>(
            IQueryable<T> flashDrives,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            int[] capacities,
            string[] USBSpecificationTypes,
            decimal? from,
            decimal? to) where T : FlashDrive;
        IQueryable<T> GetPriceFlashDrives<T>(
            IQueryable<T> flashDrives,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            int[] capacities,
            string[] USBSpecificationTypes,
            decimal? from,
            decimal? to) where T : FlashDrive;
        IQueryable<T> GetCapacityFlashDrives<T>(
            IQueryable<T> flashDrives,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            int[] capacities,
            string[] USBSpecificationTypes,
            decimal? from,
            decimal? to) where T : FlashDrive;
        IQueryable<T> GetUSBSpecificationTypeFlashDrives<T>(
            IQueryable<T> flashDrives,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            int[] capacities,
            string[] USBSpecificationTypes,
            decimal? from,
            decimal? to) where T : FlashDrive;

        Task<QuestionsBase<string>> GetPriceQuestion(IQueryable<FlashDrive> flashDrives, decimal? selectedFrom, decimal? selectedTo);
        Task<QuestionsBase<string>> GetProducerQuestion(IQueryable<FlashDrive> flashDrives, string[] producers);
        Task<QuestionsBase<string>> GetCountryQuestion(IQueryable<FlashDrive> flashDrives, string[] countries);
        Task<QuestionsBase<string>> GetMaterialQuestion(IQueryable<FlashDrive> flashDrives, string[] materials);
        Task<QuestionsBase<string>> GetColorQuestion(IQueryable<FlashDrive> flashDrives, string[] colors);
        Task<QuestionsBase<string>> GetCapacityQuestion(IQueryable<FlashDrive> flashDrives, int[] capacities);
        Task<QuestionsBase<string>> GetUSBSpecificationTypeQuestion(IQueryable<FlashDrive> flashDrives, string[] USBSpecificationTypes);
    }
}
