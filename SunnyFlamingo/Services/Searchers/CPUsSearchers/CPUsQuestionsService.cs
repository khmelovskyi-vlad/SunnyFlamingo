using Microsoft.EntityFrameworkCore;
using SunnyFlamingo.Entities.Goods.ComputerTechnologies.ComputerParts;
using SunnyFlamingo.Models;
using SunnyFlamingo.Models.Selectors;
using SunnyFlamingo.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Searchers
{
    public class CPUsQuestionsService : ICPUsQuestionsService
    {
        private readonly IComputerPartsQuestionsService _computerPartsQuestionsService;
        private readonly IQuestionsGrouper _questionsGrouper;
        public CPUsQuestionsService(
            IComputerPartsQuestionsService computerPartsQuestionsService,
            IQuestionsGrouper questionsGrouper)
        {
            _computerPartsQuestionsService = computerPartsQuestionsService;
            _questionsGrouper = questionsGrouper;
        }
        public async Task<List<QuestionsBase<string>>> GetCPUsQuestions(
            IQueryable<CPU> CPUs,
            CPUsSelector CPUsSelector)
        {
            var goodsSelector = CPUsSelector.ComputerPartsSelector.ComputerTechnologiesSelector.GoodsSelector;
            var result = await GetQuestionList(CPUs, CPUsSelector);
            return new List<QuestionsBase<string>>()
            {
                _questionsGrouper.GroupProducers(result),
                _questionsGrouper.GroupCountries(result),
                _questionsGrouper.GroupMaterials(result),
                _questionsGrouper.GroupColors(result),
                _questionsGrouper.GroupPrices(result, goodsSelector.PriceFrom, goodsSelector.PriceTo),

                _questionsGrouper.GroupCPUSocketTypes(result),

                _questionsGrouper.GroupThermalDesignPowers(result),
                _questionsGrouper.GroupNumberOfCores(result),
                _questionsGrouper.GroupNumberOfThreads(result),

            };
        }
        private async Task<List<QuestionBase<string>>> GetQuestionList(
            IQueryable<CPU> CPUs,
            CPUsSelector CPUsSelector)
        {
            var goodsSelector = CPUsSelector.ComputerPartsSelector.ComputerTechnologiesSelector.GoodsSelector;
            var producerQuestions = GetProducerQuestion(GetProducerCPUs(CPUs, CPUsSelector), goodsSelector.Producers);
            var countryQuestions = GetCountryQuestion(GetCountryCPUs(CPUs, CPUsSelector), goodsSelector.Countries);
            var materialQuestions = GetMaterialQuestion(GetMaterialCPUs(CPUs, CPUsSelector), goodsSelector.Materials);
            var colorQuestions = GetColorQuestion(GetColorCPUs(CPUs, CPUsSelector), goodsSelector.Colors);
            var priceQuestions = GetPriceQuestion(GetPriceCPUs(CPUs, CPUsSelector));


            var CPUSocketTypeQuestions = GetCPUSocketTypeQuestion(GetCPUSocketTypeCPUs(CPUs, CPUsSelector), CPUsSelector.CPUSocketTypes);
            var thermalDesignPowerQuestions = GetThermalDesignPowerQuestion(GetThermalDesignPowerCPUs(CPUs, CPUsSelector), CPUsSelector.ThermalDesignPowers);
            var numberOfCoresQuestions = GetNumberOfCoresQuestion(GetNumberOfCoresCPUs(CPUs, CPUsSelector), CPUsSelector.NumberOfCores);
            var numberOfThreadsQuestions = GetNumberOfThreadsQuestion(GetNumberOfThreadsCPUs(CPUs, CPUsSelector), CPUsSelector.NumberOfThreads);



            var group = producerQuestions.Union(countryQuestions).Union(materialQuestions).Union(colorQuestions).Union(priceQuestions)
                .Union(CPUSocketTypeQuestions).Union(thermalDesignPowerQuestions)
                .Union(numberOfCoresQuestions).Union(numberOfThreadsQuestions);

            return await group.ToListAsync();
        }
        public IQueryable<T> GetProducerCPUs<T>(
            IQueryable<T> CPUs,
            CPUsSelector CPUsSelector) where T : CPU
        {
            var goodsSelector = CPUsSelector.ComputerPartsSelector.ComputerTechnologiesSelector.GoodsSelector;
            var computerPartsSelector = CPUsSelector.ComputerPartsSelector;
            return _computerPartsQuestionsService.GetProducerComputerParts(
                CPUs, computerPartsSelector)
                .Where(l => (goodsSelector.Producers != null && goodsSelector.Producers.Contains(l.Producer.Name)) ||
                ((CPUsSelector.CPUSocketTypes == null || CPUsSelector.CPUSocketTypes.Contains(l.CPUSocketTypeValue))
                && (CPUsSelector.ThermalDesignPowers == null || CPUsSelector.ThermalDesignPowers.Contains(l.ThermalDesignPower))
                && (CPUsSelector.NumberOfCores == null || CPUsSelector.NumberOfCores.Contains(l.NumberOfCores))
                && (CPUsSelector.NumberOfThreads == null || CPUsSelector.NumberOfThreads.Contains(l.NumberOfThreads))));
        }
        public IQueryable<T> GetCountryCPUs<T>(
            IQueryable<T> CPUs,
            CPUsSelector CPUsSelector) where T : CPU
        {
            var goodsSelector = CPUsSelector.ComputerPartsSelector.ComputerTechnologiesSelector.GoodsSelector;
            var computerPartsSelector = CPUsSelector.ComputerPartsSelector;
            return _computerPartsQuestionsService.GetCountryComputerParts(
                CPUs, computerPartsSelector)
                .Where(l => (goodsSelector.Countries != null && goodsSelector.Countries.Contains(l.Manufacturer.Country.Value)) ||
                ((CPUsSelector.CPUSocketTypes == null || CPUsSelector.CPUSocketTypes.Contains(l.CPUSocketTypeValue))
                && (CPUsSelector.ThermalDesignPowers == null || CPUsSelector.ThermalDesignPowers.Contains(l.ThermalDesignPower))
                && (CPUsSelector.NumberOfCores == null || CPUsSelector.NumberOfCores.Contains(l.NumberOfCores))
                && (CPUsSelector.NumberOfThreads == null || CPUsSelector.NumberOfThreads.Contains(l.NumberOfThreads))));
        }
        public IQueryable<T> GetMaterialCPUs<T>(
            IQueryable<T> CPUs,
            CPUsSelector CPUsSelector) where T : CPU
        {
            var goodsSelector = CPUsSelector.ComputerPartsSelector.ComputerTechnologiesSelector.GoodsSelector;
            var computerPartsSelector = CPUsSelector.ComputerPartsSelector;
            return _computerPartsQuestionsService.GetMaterialComputerParts(
                CPUs, computerPartsSelector)
                .Where(l => (goodsSelector.Materials != null && goodsSelector.Materials.Contains(l.Material.Value)) ||
                ((CPUsSelector.CPUSocketTypes == null || CPUsSelector.CPUSocketTypes.Contains(l.CPUSocketTypeValue))
                && (CPUsSelector.ThermalDesignPowers == null || CPUsSelector.ThermalDesignPowers.Contains(l.ThermalDesignPower))
                && (CPUsSelector.NumberOfCores == null || CPUsSelector.NumberOfCores.Contains(l.NumberOfCores))
                && (CPUsSelector.NumberOfThreads == null || CPUsSelector.NumberOfThreads.Contains(l.NumberOfThreads))));
        }
        public IQueryable<T> GetColorCPUs<T>(
            IQueryable<T> CPUs,
            CPUsSelector CPUsSelector) where T : CPU
        {
            var goodsSelector = CPUsSelector.ComputerPartsSelector.ComputerTechnologiesSelector.GoodsSelector;
            var computerPartsSelector = CPUsSelector.ComputerPartsSelector;
            return _computerPartsQuestionsService.GetColorComputerParts(
                CPUs, computerPartsSelector)
                .Where(l => (goodsSelector.Colors != null && goodsSelector.Colors.Contains(l.Color.Value)) ||
                ((CPUsSelector.CPUSocketTypes == null || CPUsSelector.CPUSocketTypes.Contains(l.CPUSocketTypeValue))
                && (CPUsSelector.ThermalDesignPowers == null || CPUsSelector.ThermalDesignPowers.Contains(l.ThermalDesignPower))
                && (CPUsSelector.NumberOfCores == null || CPUsSelector.NumberOfCores.Contains(l.NumberOfCores))
                && (CPUsSelector.NumberOfThreads == null || CPUsSelector.NumberOfThreads.Contains(l.NumberOfThreads))));
        }
        public IQueryable<T> GetPriceCPUs<T>(
            IQueryable<T> CPUs,
            CPUsSelector CPUsSelector) where T : CPU
        {
            var goodsSelector = CPUsSelector.ComputerPartsSelector.ComputerTechnologiesSelector.GoodsSelector;
            var computerPartsSelector = CPUsSelector.ComputerPartsSelector;
            return _computerPartsQuestionsService.GetPriceComputerParts(
                CPUs, computerPartsSelector)
                .Where(l => 
                (CPUsSelector.CPUSocketTypes == null || CPUsSelector.CPUSocketTypes.Contains(l.CPUSocketTypeValue))
                && (CPUsSelector.ThermalDesignPowers == null || CPUsSelector.ThermalDesignPowers.Contains(l.ThermalDesignPower))
                && (CPUsSelector.NumberOfCores == null || CPUsSelector.NumberOfCores.Contains(l.NumberOfCores))
                && (CPUsSelector.NumberOfThreads == null || CPUsSelector.NumberOfThreads.Contains(l.NumberOfThreads)));
        }
        public IQueryable<T> GetCPUSocketTypeCPUs<T>(
            IQueryable<T> CPUs,
            CPUsSelector CPUsSelector) where T : CPU
        {
            var goodsSelector = CPUsSelector.ComputerPartsSelector.ComputerTechnologiesSelector.GoodsSelector;
            return CPUs
                .Where(l => (CPUsSelector.CPUSocketTypes != null && CPUsSelector.CPUSocketTypes.Contains(l.CPUSocketTypeValue)) ||
                ((goodsSelector.PriceFrom == null || l.Price >= goodsSelector.PriceFrom)
                && (goodsSelector.PriceTo == null || l.Price <= goodsSelector.PriceTo)
                && (CPUsSelector.ThermalDesignPowers == null || CPUsSelector.ThermalDesignPowers.Contains(l.ThermalDesignPower))
                && (CPUsSelector.NumberOfCores == null || CPUsSelector.NumberOfCores.Contains(l.NumberOfCores))
                && (CPUsSelector.NumberOfThreads == null || CPUsSelector.NumberOfThreads.Contains(l.NumberOfThreads))
                && (goodsSelector.Producers == null || goodsSelector.Producers.Contains(l.Producer.Name))
                && (goodsSelector.Countries == null || goodsSelector.Countries.Contains(l.Manufacturer.Country.Value))
                && (goodsSelector.Materials == null || goodsSelector.Materials.Contains(l.MaterialValue))
                && (goodsSelector.Colors == null || goodsSelector.Colors.Contains(l.ColorValue))));
        }
        public IQueryable<T> GetThermalDesignPowerCPUs<T>(
            IQueryable<T> CPUs,
            CPUsSelector CPUsSelector) where T : CPU
        {
            var goodsSelector = CPUsSelector.ComputerPartsSelector.ComputerTechnologiesSelector.GoodsSelector;
            return CPUs
                .Where(l => (CPUsSelector.ThermalDesignPowers != null && CPUsSelector.ThermalDesignPowers.Contains(l.ThermalDesignPower)) ||
                ((goodsSelector.PriceFrom == null || l.Price >= goodsSelector.PriceFrom)
                && (goodsSelector.PriceTo == null || l.Price <= goodsSelector.PriceTo)
                && (CPUsSelector.CPUSocketTypes == null || CPUsSelector.CPUSocketTypes.Contains(l.CPUSocketTypeValue))
                && (CPUsSelector.NumberOfCores == null || CPUsSelector.NumberOfCores.Contains(l.NumberOfCores))
                && (CPUsSelector.NumberOfThreads == null || CPUsSelector.NumberOfThreads.Contains(l.NumberOfThreads))
                && (goodsSelector.Producers == null || goodsSelector.Producers.Contains(l.Producer.Name))
                && (goodsSelector.Countries == null || goodsSelector.Countries.Contains(l.Manufacturer.Country.Value))
                && (goodsSelector.Materials == null || goodsSelector.Materials.Contains(l.MaterialValue))
                && (goodsSelector.Colors == null || goodsSelector.Colors.Contains(l.ColorValue))));
        }
        public IQueryable<T> GetNumberOfCoresCPUs<T>(
            IQueryable<T> CPUs,
            CPUsSelector CPUsSelector) where T : CPU
        {
            var goodsSelector = CPUsSelector.ComputerPartsSelector.ComputerTechnologiesSelector.GoodsSelector;
            return CPUs
                .Where(l => (CPUsSelector.NumberOfCores != null && CPUsSelector.NumberOfCores.Contains(l.NumberOfCores)) ||
                ((goodsSelector.PriceFrom == null || l.Price >= goodsSelector.PriceFrom)
                && (goodsSelector.PriceTo == null || l.Price <= goodsSelector.PriceTo)
                && (CPUsSelector.ThermalDesignPowers == null || CPUsSelector.ThermalDesignPowers.Contains(l.ThermalDesignPower))
                && (CPUsSelector.CPUSocketTypes == null || CPUsSelector.CPUSocketTypes.Contains(l.CPUSocketTypeValue))
                && (CPUsSelector.NumberOfThreads == null || CPUsSelector.NumberOfThreads.Contains(l.NumberOfThreads))
                && (goodsSelector.Producers == null || goodsSelector.Producers.Contains(l.Producer.Name))
                && (goodsSelector.Countries == null || goodsSelector.Countries.Contains(l.Manufacturer.Country.Value))
                && (goodsSelector.Materials == null || goodsSelector.Materials.Contains(l.MaterialValue))
                && (goodsSelector.Colors == null || goodsSelector.Colors.Contains(l.ColorValue))));
        }
        public IQueryable<T> GetNumberOfThreadsCPUs<T>(
            IQueryable<T> CPUs,
            CPUsSelector CPUsSelector) where T : CPU
        {
            var goodsSelector = CPUsSelector.ComputerPartsSelector.ComputerTechnologiesSelector.GoodsSelector;
            return CPUs
                .Where(l => (CPUsSelector.NumberOfThreads != null && CPUsSelector.NumberOfThreads.Contains(l.NumberOfThreads)) ||
                ((goodsSelector.PriceFrom == null || l.Price >= goodsSelector.PriceFrom)
                && (goodsSelector.PriceTo == null || l.Price <= goodsSelector.PriceTo)
                && (CPUsSelector.CPUSocketTypes == null || CPUsSelector.CPUSocketTypes.Contains(l.CPUSocketTypeValue))
                && (CPUsSelector.NumberOfCores == null || CPUsSelector.NumberOfCores.Contains(l.NumberOfCores))
                && (CPUsSelector.ThermalDesignPowers == null || CPUsSelector.ThermalDesignPowers.Contains(l.ThermalDesignPower))
                && (goodsSelector.Producers == null || goodsSelector.Producers.Contains(l.Producer.Name))
                && (goodsSelector.Countries == null || goodsSelector.Countries.Contains(l.Manufacturer.Country.Value))
                && (goodsSelector.Materials == null || goodsSelector.Materials.Contains(l.MaterialValue))
                && (goodsSelector.Colors == null || goodsSelector.Colors.Contains(l.ColorValue))));
        }





        public IQueryable<QuestionBase<string>> GetProducerQuestion(IQueryable<CPU> CPUs, string[] producers)
        {
            return _computerPartsQuestionsService.GetProducerQuestion(CPUs, producers);
        }
        public IQueryable<QuestionBase<string>> GetCountryQuestion(IQueryable<CPU> CPUs, string[] countries)
        {
            return _computerPartsQuestionsService.GetCountryQuestion(CPUs, countries);
        }
        public IQueryable<QuestionBase<string>> GetMaterialQuestion(IQueryable<CPU> CPUs, string[] materials)
        {
            return _computerPartsQuestionsService.GetMaterialQuestion(CPUs, materials);
        }
        public IQueryable<QuestionBase<string>> GetColorQuestion(IQueryable<CPU> CPUs, string[] colors)
        {
            return _computerPartsQuestionsService.GetColorQuestion(CPUs, colors);
        }
        public IQueryable<QuestionBase<string>> GetPriceQuestion(IQueryable<CPU> CPUs)
        {
            return _computerPartsQuestionsService.GetPriceQuestion(CPUs);
        }
        public IQueryable<QuestionBase<string>> GetCPUSocketTypeQuestion(IQueryable<CPU> CPUs, string[] CPUSocketTypes)
        {
            return CPUs
                        .Select(g => g.CPUSocketTypeValue)
                        .GroupBy(p => p)
                        .Select(p => new { Count = p.Count(), Value = Convert.ToString(p.Key) })
                        .Select(type => new QuestionBase<string>()
                        {
                            QuestionsKey = "CPUSocketType",
                            AfterBox = (CPUSocketTypes != null && CPUSocketTypes.Contains(type.Value)) ? (int?)null : type.Count,
                            Checked = CPUSocketTypes != null && CPUSocketTypes.Contains(type.Value),
                            ControlType = ControlType.Checkbox,
                            Key = type.Value,
                            Label = type.Value,
                            Required = false,
                            Type = InputType.Checkbox,
                        });
        }
        public IQueryable<QuestionBase<string>> GetThermalDesignPowerQuestion(IQueryable<CPU> CPUs, int[] thermalDesignPowers)
        {
            var stringList = thermalDesignPowers?.Select(item => item.ToString()).ToList();
            return CPUs
                        .Select(g => g.ThermalDesignPower)
                        .GroupBy(p => p)
                        .Select(p => new { Count = p.Count(), Value = Convert.ToString(p.Key) })
                        .Select(fanSize => new QuestionBase<string>()
                        {
                            QuestionsKey = "thermalDesignPower",
                            AfterBox = (stringList != null && stringList.Contains(fanSize.Value)) ? (int?)null : fanSize.Count,
                            Checked = stringList != null && stringList.Contains(fanSize.Value),
                            ControlType = ControlType.Checkbox,
                            Key = fanSize.Value,
                            Label = fanSize.Value,
                            Required = false,
                            Type = InputType.Checkbox,
                        });
        }
        public IQueryable<QuestionBase<string>> GetNumberOfCoresQuestion(IQueryable<CPU> CPUs, int[] numberOfCores)
        {
            var stringList = numberOfCores?.Select(item => item.ToString()).ToList();
            return CPUs
                        .Select(g => g.NumberOfCores)
                        .GroupBy(p => p)
                        .Select(p => new { Count = p.Count(), Value = Convert.ToString(p.Key) })
                        .Select(fanSize => new QuestionBase<string>()
                        {
                            QuestionsKey = "numberOfCores",
                            AfterBox = (stringList != null && stringList.Contains(fanSize.Value)) ? (int?)null : fanSize.Count,
                            Checked = stringList != null && stringList.Contains(fanSize.Value),
                            ControlType = ControlType.Checkbox,
                            Key = fanSize.Value,
                            Label = fanSize.Value,
                            Required = false,
                            Type = InputType.Checkbox,
                        });
        }
        public IQueryable<QuestionBase<string>> GetNumberOfThreadsQuestion(IQueryable<CPU> CPUs, int[] numberOfThreads)
        {
            var stringList = numberOfThreads?.Select(item => item.ToString()).ToList();
            return CPUs
                        .Select(g => g.NumberOfThreads)
                        .GroupBy(p => p)
                        .Select(p => new { Count = p.Count(), Value = Convert.ToString(p.Key) })
                        .Select(fanSize => new QuestionBase<string>()
                        {
                            QuestionsKey = "numberOfThreads",
                            AfterBox = (stringList != null && stringList.Contains(fanSize.Value)) ? (int?)null : fanSize.Count,
                            Checked = stringList != null && stringList.Contains(fanSize.Value),
                            ControlType = ControlType.Checkbox,
                            Key = fanSize.Value,
                            Label = fanSize.Value,
                            Required = false,
                            Type = InputType.Checkbox,
                        });
        }
    }
}
