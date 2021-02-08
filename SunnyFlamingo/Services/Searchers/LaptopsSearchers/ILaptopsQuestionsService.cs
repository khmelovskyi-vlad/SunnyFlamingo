using SunnyFlamingo.Entities.Goods.ComputerTechnologies;
using SunnyFlamingo.Models;
using SunnyFlamingo.Models.Selectors;
using SunnyFlamingo.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Searchers
{
    public interface ILaptopsQuestionsService
    {
        Task<List<QuestionsBase<string>>> GetLaptopsQuestions(
               IQueryable<Laptop> laptops,
               LaptopsSelector laptopsSelector);

        IQueryable<T> GetProducerLaptops<T>(
            IQueryable<T> laptops,
               LaptopsSelector laptopsSelector) where T : Laptop;

        IQueryable<T> GetCountryLaptops<T>(
            IQueryable<T> laptops,
               LaptopsSelector laptopsSelector) where T : Laptop;
        IQueryable<T> GetMaterialLaptops<T>(
            IQueryable<T> laptops,
               LaptopsSelector laptopsSelector) where T : Laptop;
        IQueryable<T> GetColorLaptops<T>(
            IQueryable<T> laptops,
               LaptopsSelector laptopsSelector) where T : Laptop;
        IQueryable<T> GetPriceLaptops<T>(
            IQueryable<T> laptops,
               LaptopsSelector laptopsSelector) where T : Laptop;
        IQueryable<T> GetAmountOfRAMLaptops<T>(
            IQueryable<T> laptops,
               LaptopsSelector laptopsSelector) where T : Laptop;
        IQueryable<T> GetCPUFrequencyLaptops<T>(
            IQueryable<T> laptops,
               LaptopsSelector laptopsSelector) where T : Laptop;
        IQueryable<T> GetLengthLaptops<T>(
            IQueryable<T> laptops,
               LaptopsSelector laptopsSelector) where T : Laptop;
        IQueryable<T> GetHeightLaptops<T>(
            IQueryable<T> laptops,
               LaptopsSelector laptopsSelector) where T : Laptop;
        IQueryable<T> GetWidthLaptops<T>(
            IQueryable<T> laptops,
               LaptopsSelector laptopsSelector) where T : Laptop;
        IQueryable<T> GetSSDMemoryLaptops<T>(
            IQueryable<T> laptops,
               LaptopsSelector laptopsSelector) where T : Laptop;
        IQueryable<T> GetHardDiskMemoryLaptops<T>(
            IQueryable<T> laptops,
               LaptopsSelector laptopsSelector) where T : Laptop;
        IQueryable<T> GetCPUSocketTypeLaptops<T>(
            IQueryable<T> laptops,
               LaptopsSelector laptopsSelector) where T : Laptop;
        IQueryable<T> GetComputerDriveTypeLaptops<T>(
            IQueryable<T> laptops,
               LaptopsSelector laptopsSelector) where T : Laptop;
        IQueryable<T> GetNumberOfCoresLaptops<T>(
            IQueryable<T> laptops,
               LaptopsSelector laptopsSelector) where T : Laptop;
        IQueryable<T> GetFloppyDrivesCountLaptops<T>(
            IQueryable<T> laptops,
               LaptopsSelector laptopsSelector) where T : Laptop;
        IQueryable<T> GetDisplayLaptops<T>(
            IQueryable<T> laptops,
               LaptopsSelector laptopsSelector) where T : Laptop;
        IQueryable<T> GetHaveFloppyDrivesLaptops<T>(
            IQueryable<T> laptops,
               LaptopsSelector laptopsSelector) where T : Laptop;
        IQueryable<QuestionBase<string>> GetProducerQuestion(IQueryable<Laptop> laptops, string[] producers);
        IQueryable<QuestionBase<string>> GetCountryQuestion(IQueryable<Laptop> laptops, string[] countries);
        IQueryable<QuestionBase<string>> GetMaterialQuestion(IQueryable<Laptop> laptops, string[] materials);
        IQueryable<QuestionBase<string>> GetColorQuestion(IQueryable<Laptop> laptops, string[] colors);
        IQueryable<QuestionBase<string>> GetPriceQuestion(IQueryable<Laptop> laptops);
        IQueryable<QuestionBase<string>> GetAmountOfRAMQuestion(IQueryable<Laptop> laptops, int[] amountOfRAMs);
        IQueryable<QuestionBase<string>> GetCPUFrequencyQuestion(IQueryable<Laptop> laptops, int[] CPUFrequencies);
        IQueryable<QuestionBase<string>> GetHeightQuestion(IQueryable<Laptop> laptops, float[] heights);
        IQueryable<QuestionBase<string>> GetWidthQuestion(IQueryable<Laptop> laptops, float[] widths);
        IQueryable<QuestionBase<string>> GetLengthQuestion(IQueryable<Laptop> laptops, float[] lengthes);
        IQueryable<QuestionBase<string>> GetHaveFloppyDrivesQuestion(IQueryable<Laptop> laptops, bool[] haveFloppyDrives);
        IQueryable<QuestionBase<string>> GetSSDMemoryQuestion(IQueryable<Laptop> laptops, int?[] SSDMemories);
        IQueryable<QuestionBase<string>> GetHardDiskMemoryQuestion(IQueryable<Laptop> laptops, int?[] hardDiskMemories);
        IQueryable<QuestionBase<string>> GetCPUSocketTypeQuestion(IQueryable<Laptop> laptops, string[] CPUSocketTypes);
        IQueryable<QuestionBase<string>> GetComputerDriveTypeQuestion(IQueryable<Laptop> laptops, string[] computerDriveTypes);
        IQueryable<QuestionBase<string>> GetNumberOfCoreQuestion(IQueryable<Laptop> laptops, int[] numberOfCores);
        IQueryable<QuestionBase<string>> GetFloppyDrivesCountQuestion(IQueryable<Laptop> laptops, int?[] floppyDrivesCountArray);
        IQueryable<QuestionBase<string>> GetDisplayQuestion(IQueryable<Laptop> laptops, int[] displays);
    }
}
