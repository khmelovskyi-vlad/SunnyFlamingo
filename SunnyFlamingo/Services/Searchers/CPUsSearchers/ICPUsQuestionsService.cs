using SunnyFlamingo.Entities.Goods.ComputerTechnologies.ComputerParts;
using SunnyFlamingo.Models;
using SunnyFlamingo.Models.Selectors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Searchers
{
    public interface ICPUsQuestionsService
    {
        Task<List<QuestionsBase<string>>> GetCPUsQuestions(
               IQueryable<CPU> CPUs,
               CPUsSelector CPUsSelector);

        IQueryable<T> GetProducerCPUs<T>(
            IQueryable<T> CPUs,
               CPUsSelector CPUsSelector) where T : CPU;

        IQueryable<T> GetCountryCPUs<T>(
            IQueryable<T> CPUs,
               CPUsSelector CPUsSelector) where T : CPU;
        IQueryable<T> GetMaterialCPUs<T>(
            IQueryable<T> CPUs,
               CPUsSelector CPUsSelector) where T : CPU;
        IQueryable<T> GetColorCPUs<T>(
            IQueryable<T> CPUs,
               CPUsSelector CPUsSelector) where T : CPU;
        IQueryable<T> GetPriceCPUs<T>(
            IQueryable<T> CPUs,
               CPUsSelector CPUsSelector) where T : CPU;
        IQueryable<T> GetCPUSocketTypeCPUs<T>(
            IQueryable<T> CPUs,
               CPUsSelector CPUsSelector) where T : CPU;
        IQueryable<T> GetThermalDesignPowerCPUs<T>(
            IQueryable<T> CPUs,
               CPUsSelector CPUsSelector) where T : CPU;
        IQueryable<T> GetNumberOfCoresCPUs<T>(
            IQueryable<T> CPUs,
               CPUsSelector CPUsSelector) where T : CPU;
        IQueryable<T> GetNumberOfThreadsCPUs<T>(
            IQueryable<T> CPUs,
               CPUsSelector CPUsSelector) where T : CPU;
        IQueryable<QuestionBase<string>> GetProducerQuestion(IQueryable<CPU> CPUs, string[] producers);
        IQueryable<QuestionBase<string>> GetCountryQuestion(IQueryable<CPU> CPUs, string[] countries);
        IQueryable<QuestionBase<string>> GetMaterialQuestion(IQueryable<CPU> CPUs, string[] materials);
        IQueryable<QuestionBase<string>> GetColorQuestion(IQueryable<CPU> CPUs, string[] colors);
        IQueryable<QuestionBase<string>> GetPriceQuestion(IQueryable<CPU> CPUs);
        IQueryable<QuestionBase<string>> GetCPUSocketTypeQuestion(IQueryable<CPU> CPUs, string[] CPUSocketTypes);
        IQueryable<QuestionBase<string>> GetThermalDesignPowerQuestion(IQueryable<CPU> CPUs, int[] thermalDesignPower);
        IQueryable<QuestionBase<string>> GetNumberOfCoresQuestion(IQueryable<CPU> CPUs, int[] numberOfCores);
        IQueryable<QuestionBase<string>> GetNumberOfThreadsQuestion(IQueryable<CPU> CPUs, int[] numberOfThreads);
    }
}
