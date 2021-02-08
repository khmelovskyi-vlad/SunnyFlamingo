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
    public interface IComputersQuestionsService
    {
        Task<List<QuestionsBase<string>>> GetComputersQuestions(
               IQueryable<Computer> computers,
               ComputersSelector computersSelector);

        IQueryable<T> GetProducerComputers<T>(
            IQueryable<T> computers,
               ComputersSelector computersSelector) where T : Computer;

        IQueryable<T> GetCountryComputers<T>(
            IQueryable<T> computers,
               ComputersSelector computersSelector) where T : Computer;
        IQueryable<T> GetMaterialComputers<T>(
            IQueryable<T> computers,
               ComputersSelector computersSelector) where T : Computer;
        IQueryable<T> GetColorComputers<T>(
            IQueryable<T> computers,
               ComputersSelector computersSelector) where T : Computer;
        IQueryable<T> GetPriceComputers<T>(
            IQueryable<T> computers,
               ComputersSelector computersSelector) where T : Computer;
        IQueryable<T> GetAmountOfRAMComputers<T>(
            IQueryable<T> computers,
               ComputersSelector computersSelector) where T : Computer;
        IQueryable<T> GetCPUFrequencyComputers<T>(
            IQueryable<T> computers,
               ComputersSelector computersSelector) where T : Computer;
        IQueryable<T> GetLengthComputers<T>(
            IQueryable<T> computers,
               ComputersSelector computersSelector) where T : Computer;
        IQueryable<T> GetHeightComputers<T>(
            IQueryable<T> computers,
               ComputersSelector computersSelector) where T : Computer;
        IQueryable<T> GetWidthComputers<T>(
            IQueryable<T> computers,
               ComputersSelector computersSelector) where T : Computer;
        IQueryable<T> GetSSDMemoryComputers<T>(
            IQueryable<T> computers,
               ComputersSelector computersSelector) where T : Computer;
        IQueryable<T> GetHardDiskMemoryComputers<T>(
            IQueryable<T> computers,
               ComputersSelector computersSelector) where T : Computer;
        IQueryable<T> GetCPUSocketTypeComputers<T>(
            IQueryable<T> computers,
               ComputersSelector computersSelector) where T : Computer;
        IQueryable<T> GetComputerDriveTypeComputers<T>(
            IQueryable<T> computers,
               ComputersSelector computersSelector) where T : Computer;
        IQueryable<T> GetNumberOfCoresComputers<T>(
            IQueryable<T> computers,
               ComputersSelector computersSelector) where T : Computer;
        IQueryable<T> GetFloppyDrivesCountComputers<T>(
            IQueryable<T> computers,
               ComputersSelector computersSelector) where T : Computer;
        IQueryable<T> GetHaveFloppyDrivesComputers<T>(
            IQueryable<T> computers,
               ComputersSelector computersSelector) where T : Computer;
        IQueryable<QuestionBase<string>> GetProducerQuestion(IQueryable<Computer> computers, string[] producers);
        IQueryable<QuestionBase<string>> GetCountryQuestion(IQueryable<Computer> computers, string[] countries);
        IQueryable<QuestionBase<string>> GetMaterialQuestion(IQueryable<Computer> computers, string[] materials);
        IQueryable<QuestionBase<string>> GetColorQuestion(IQueryable<Computer> computers, string[] colors);
        IQueryable<QuestionBase<string>> GetPriceQuestion(IQueryable<Computer> computers);
        IQueryable<QuestionBase<string>> GetAmountOfRAMQuestion(IQueryable<Computer> computers, int[] amountOfRAMs);
        IQueryable<QuestionBase<string>> GetCPUFrequencyQuestion(IQueryable<Computer> computers, int[] CPUFrequencies);
        IQueryable<QuestionBase<string>> GetHeightQuestion(IQueryable<Computer> computers, float[] heights);
        IQueryable<QuestionBase<string>> GetWidthQuestion(IQueryable<Computer> computers, float[] widths);
        IQueryable<QuestionBase<string>> GetLengthQuestion(IQueryable<Computer> computers, float[] lengthes);
        IQueryable<QuestionBase<string>> GetHaveFloppyDrivesQuestion(IQueryable<Computer> computers, bool[] haveFloppyDrives);
        IQueryable<QuestionBase<string>> GetSSDMemoryQuestion(IQueryable<Computer> computers, int?[] SSDMemories);
        IQueryable<QuestionBase<string>> GetHardDiskMemoryQuestion(IQueryable<Computer> computers, int?[] hardDiskMemories);
        IQueryable<QuestionBase<string>> GetCPUSocketTypeQuestion(IQueryable<Computer> computers, string[] CPUSocketTypes);
        IQueryable<QuestionBase<string>> GetComputerDriveTypeQuestion(IQueryable<Computer> computers, string[] computerDriveTypes);
        IQueryable<QuestionBase<string>> GetNumberOfCoreQuestion(IQueryable<Computer> computers, int[] numberOfCores);
        IQueryable<QuestionBase<string>> GetFloppyDrivesCountQuestion(IQueryable<Computer> computers, int?[] floppyDrivesCountArray);
    }
}
