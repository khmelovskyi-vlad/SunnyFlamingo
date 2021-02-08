using Microsoft.EntityFrameworkCore;
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
    public class FlashDrivesQuestionsService : IFlashDrivesQuestionsService
    {
        private readonly IComputerTechnologiesQuestionsService _computerTechnologiesQuestionsService;
        private readonly IQuestionsGrouper _questionsGrouper;
        public FlashDrivesQuestionsService(IComputerTechnologiesQuestionsService computerTechnologiesQuestionsService,
            IQuestionsGrouper questionsGrouper)
        {
            _computerTechnologiesQuestionsService = computerTechnologiesQuestionsService;
            _questionsGrouper = questionsGrouper;
        }
        public async Task<List<QuestionsBase<string>>> GetFlashDrivesQuestions(
            IQueryable<FlashDrive> flashDrives,
            FlashDrivesSelector flashDrivesSelector)
        {
            var goodsSelector = flashDrivesSelector.ComputerTechnologiesSelector.GoodsSelector;

            var result = await GetQuestionList(flashDrives, flashDrivesSelector);
            return new List<QuestionsBase<string>>()
            {
                _questionsGrouper.GroupProducers(result),
                _questionsGrouper.GroupCountries(result),
                _questionsGrouper.GroupMaterials(result),
                _questionsGrouper.GroupColors(result),
                _questionsGrouper.GroupPrices(result, goodsSelector.PriceFrom, goodsSelector.PriceTo),
                _questionsGrouper.GroupCapacities(result),
                _questionsGrouper.GroupUSBSpecificationTypes(result),
            };
        }
        private async Task<List<QuestionBase<string>>> GetQuestionList(
            IQueryable<FlashDrive> flashDrives, 
            FlashDrivesSelector flashDrivesSelector)
        {
            var goodsSelector = flashDrivesSelector.ComputerTechnologiesSelector.GoodsSelector;
            var producerQuestions = GetProducerQuestion(GetProducerFlashDrives(flashDrives, flashDrivesSelector), goodsSelector.Producers);
            var countryQuestions = GetCountryQuestion(GetCountryFlashDrives(flashDrives, flashDrivesSelector), goodsSelector.Countries);
            var materialQuestions = GetMaterialQuestion(GetMaterialFlashDrives(flashDrives, flashDrivesSelector), goodsSelector.Materials);
            var colorQuestions = GetColorQuestion(GetColorFlashDrives(flashDrives, flashDrivesSelector), goodsSelector.Colors);
            var priceQuestions = GetPriceQuestion(GetPriceFlashDrives(flashDrives, flashDrivesSelector));


            var capacityQuestions = GetCapacityQuestion(GetCapacityFlashDrives(flashDrives, flashDrivesSelector), flashDrivesSelector.Capacities);
            var USBSpecificationTypeQuestions = GetUSBSpecificationTypeQuestion(GetUSBSpecificationTypeFlashDrives(flashDrives, flashDrivesSelector), flashDrivesSelector.USBSpecificationTypes);


            var group = producerQuestions.Union(countryQuestions).Union(materialQuestions).Union(colorQuestions).Union(priceQuestions)
                .Union(capacityQuestions).Union(USBSpecificationTypeQuestions);
            return await group.ToListAsync();
        }

        public IQueryable<T> GetProducerFlashDrives<T>(
            IQueryable<T> flashDrives,
            FlashDrivesSelector flashDrivesSelector) where T : FlashDrive
        {
            var goodsSelector = flashDrivesSelector.ComputerTechnologiesSelector.GoodsSelector;
            var computerTechnologiesSelector = flashDrivesSelector.ComputerTechnologiesSelector;
            return _computerTechnologiesQuestionsService.GetProducerComputerTechnologies(
                flashDrives, computerTechnologiesSelector)
                .Where(f => (goodsSelector.Producers != null && goodsSelector.Producers.Contains(f.Producer.Name)) ||
                ((flashDrivesSelector.Capacities == null || flashDrivesSelector.Capacities.Contains(f.Capacity))
                && (flashDrivesSelector.USBSpecificationTypes == null
                || flashDrivesSelector.USBSpecificationTypes.Contains(f.USBSpecificationTypeValue))));
        }
        public IQueryable<T> GetCountryFlashDrives<T>(
            IQueryable<T> flashDrives,
            FlashDrivesSelector flashDrivesSelector) where T : FlashDrive
        {
            var goodsSelector = flashDrivesSelector.ComputerTechnologiesSelector.GoodsSelector;
            var computerTechnologiesSelector = flashDrivesSelector.ComputerTechnologiesSelector;
            return _computerTechnologiesQuestionsService.GetCountryComputerTechnologies(
                flashDrives, computerTechnologiesSelector)
                .Where(f => (goodsSelector.Countries != null && goodsSelector.Countries.Contains(f.Manufacturer.Country.Value)) ||
                ((flashDrivesSelector.Capacities == null || flashDrivesSelector.Capacities.Contains(f.Capacity))
                && (flashDrivesSelector.USBSpecificationTypes == null
                || flashDrivesSelector.USBSpecificationTypes.Contains(f.USBSpecificationTypeValue))));
        }
        public IQueryable<T> GetMaterialFlashDrives<T>(
            IQueryable<T> flashDrives,
            FlashDrivesSelector flashDrivesSelector) where T : FlashDrive
        {
            var goodsSelector = flashDrivesSelector.ComputerTechnologiesSelector.GoodsSelector;
            var computerTechnologiesSelector = flashDrivesSelector.ComputerTechnologiesSelector;
            return _computerTechnologiesQuestionsService.GetMaterialComputerTechnologies(
                flashDrives, computerTechnologiesSelector)
                .Where(f => (goodsSelector.Materials != null && goodsSelector.Materials.Contains(f.MaterialValue)) ||
                ((flashDrivesSelector.Capacities == null || flashDrivesSelector.Capacities.Contains(f.Capacity))
                && (flashDrivesSelector.USBSpecificationTypes == null
                || flashDrivesSelector.USBSpecificationTypes.Contains(f.USBSpecificationTypeValue))));
        }
        public IQueryable<T> GetColorFlashDrives<T>(
            IQueryable<T> flashDrives,
            FlashDrivesSelector flashDrivesSelector) where T : FlashDrive
        {
            var goodsSelector = flashDrivesSelector.ComputerTechnologiesSelector.GoodsSelector;
            var computerTechnologiesSelector = flashDrivesSelector.ComputerTechnologiesSelector;
            return _computerTechnologiesQuestionsService.GetColorComputerTechnologies(
                flashDrives, computerTechnologiesSelector)
                .Where(f => (goodsSelector.Colors != null && goodsSelector.Colors.Contains(f.ColorValue)) ||
                ((flashDrivesSelector.Capacities == null || flashDrivesSelector.Capacities.Contains(f.Capacity))
                && (flashDrivesSelector.USBSpecificationTypes == null
                || flashDrivesSelector.USBSpecificationTypes.Contains(f.USBSpecificationTypeValue))));
        }
        public IQueryable<T> GetPriceFlashDrives<T>(
            IQueryable<T> flashDrives,
            FlashDrivesSelector flashDrivesSelector) where T : FlashDrive
        {
            var goodsSelector = flashDrivesSelector.ComputerTechnologiesSelector.GoodsSelector;
            var computerTechnologiesSelector = flashDrivesSelector.ComputerTechnologiesSelector;
            return _computerTechnologiesQuestionsService.GetPriceComputerTechnologies(
                flashDrives, computerTechnologiesSelector)
                .Where(f =>
                (flashDrivesSelector.Capacities == null || flashDrivesSelector.Capacities.Contains(f.Capacity))
                && (flashDrivesSelector.USBSpecificationTypes == null
                || flashDrivesSelector.USBSpecificationTypes.Contains(f.USBSpecificationTypeValue)));
        }
        public IQueryable<T> GetCapacityFlashDrives<T>(
            IQueryable<T> flashDrives,
            FlashDrivesSelector flashDrivesSelector) where T : FlashDrive
        {
            var goodsSelector = flashDrivesSelector.ComputerTechnologiesSelector.GoodsSelector;
            return flashDrives
                .Where(f => (flashDrivesSelector.Capacities != null && flashDrivesSelector.Capacities.Contains(f.Capacity)) ||
                ((goodsSelector.PriceFrom == null || f.Price >= goodsSelector.PriceFrom) 
                && (goodsSelector.PriceTo == null || f.Price <= goodsSelector.PriceTo)
                && (flashDrivesSelector.USBSpecificationTypes == null
                || flashDrivesSelector.USBSpecificationTypes.Contains(f.USBSpecificationTypeValue))
                && (goodsSelector.Producers == null || goodsSelector.Producers.Contains(f.Producer.Name))
                && (goodsSelector.Countries == null || goodsSelector.Countries.Contains(f.Manufacturer.Country.Value))
                && (goodsSelector.Materials == null || goodsSelector.Materials.Contains(f.MaterialValue))
                && (goodsSelector.Colors == null || goodsSelector.Colors.Contains(f.ColorValue))));
        }
        public IQueryable<T> GetUSBSpecificationTypeFlashDrives<T>(
            IQueryable<T> flashDrives,
            FlashDrivesSelector flashDrivesSelector) where T : FlashDrive
        {
            var goodsSelector = flashDrivesSelector.ComputerTechnologiesSelector.GoodsSelector;
            return flashDrives
                .Where(f => (flashDrivesSelector.USBSpecificationTypes != null 
                && flashDrivesSelector.USBSpecificationTypes.Contains(f.USBSpecificationTypeValue)) ||
                ((goodsSelector.PriceFrom == null || f.Price >= goodsSelector.PriceFrom)
                && (goodsSelector.PriceTo == null || f.Price <= goodsSelector.PriceTo)
                && (flashDrivesSelector.Capacities == null || flashDrivesSelector.Capacities.Contains(f.Capacity))
                && (goodsSelector.Producers == null || goodsSelector.Producers.Contains(f.Producer.Name))
                && (goodsSelector.Countries == null || goodsSelector.Countries.Contains(f.Manufacturer.Country.Value))
                && (goodsSelector.Materials == null || goodsSelector.Materials.Contains(f.MaterialValue))
                && (goodsSelector.Colors == null || goodsSelector.Colors.Contains(f.ColorValue))));
        }






        public IQueryable<QuestionBase<string>> GetProducerQuestion(IQueryable<FlashDrive> flashDrives, string[] producers)
        {
            return _computerTechnologiesQuestionsService.GetProducerQuestion(flashDrives, producers);
        }
        public IQueryable<QuestionBase<string>> GetCountryQuestion(IQueryable<FlashDrive> flashDrives, string[] countries)
        {
            return _computerTechnologiesQuestionsService.GetCountryQuestion(flashDrives, countries);
        }
        public IQueryable<QuestionBase<string>> GetMaterialQuestion(IQueryable<FlashDrive> flashDrives, string[] materials)
        {
            return _computerTechnologiesQuestionsService.GetMaterialQuestion(flashDrives, materials);
        }
        public IQueryable<QuestionBase<string>> GetColorQuestion(IQueryable<FlashDrive> flashDrives, string[] colors)
        {
            return _computerTechnologiesQuestionsService.GetColorQuestion(flashDrives, colors);
        }
        public IQueryable<QuestionBase<string>> GetPriceQuestion(IQueryable<FlashDrive> flashDrives)
        {
            return _computerTechnologiesQuestionsService.GetPriceQuestion(flashDrives);
        }

        public IQueryable<QuestionBase<string>> GetCapacityQuestion(IQueryable<FlashDrive> flashDrives, int[] capacities)
        {
            var stringList = capacities?.Select(item => item.ToString()).ToList();
            return flashDrives
                        .Select(g => g.Capacity)
                        .GroupBy(p => p)
                        .Select(p => new { Count = p.Count(), Value = Convert.ToString(p.Key) })
                        .Select(capacity => new QuestionBase<string>()
                        {
                            QuestionsKey = "capacity",
                            AfterBox = (stringList != null && stringList.Contains(capacity.Value)) ? (int?)null : capacity.Count,
                            Checked = capacities != null && stringList.Contains(capacity.Value),
                            ControlType = ControlType.Checkbox,
                            Key = capacity.Value,
                            Label = capacity.Value,
                            Required = false,
                            Type = InputType.Checkbox,
                        });
        }
        public IQueryable<QuestionBase<string>> GetUSBSpecificationTypeQuestion(IQueryable<FlashDrive> flashDrives, string[] USBSpecificationTypes)
        {
            return flashDrives
                        .Select(g => g.USBSpecificationTypeValue)
                        .GroupBy(p => p)
                        .Select(p => new { Count = p.Count(), Value = Convert.ToString(p.Key) })
                        .Select(USBSpecificationType => new QuestionBase<string>()
                        {
                            QuestionsKey = "USBSpecificationType",
                            AfterBox = (USBSpecificationTypes != null && USBSpecificationTypes.Contains(USBSpecificationType.Value)) ? (int?)null : USBSpecificationType.Count,
                            Checked = USBSpecificationTypes != null && USBSpecificationTypes.Contains(USBSpecificationType.Value),
                            ControlType = ControlType.Checkbox,
                            Key = USBSpecificationType.Value,
                            Label = USBSpecificationType.Value,
                            Required = false,
                            Type = InputType.Checkbox,
                        });
        }
    }
}
