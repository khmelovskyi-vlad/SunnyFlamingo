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
    public class ComputerDrivesQuestionsService : IComputerDrivesQuestionsService
    {
        private readonly IComputerPartsQuestionsService _computerPartsQuestionsService;
        private readonly IQuestionsGrouper _questionsGrouper;
        public ComputerDrivesQuestionsService(
            IComputerPartsQuestionsService computerPartsQuestionsService,
            IQuestionsGrouper questionsGrouper)
        {
            _computerPartsQuestionsService = computerPartsQuestionsService;
            _questionsGrouper = questionsGrouper;
        }
        public async Task<List<QuestionsBase<string>>> GetComputerDrivesQuestions(
            IQueryable<ComputerDrive> computerDrives, 
            ComputerDrivesSelector computerDrivesSelector)
        {
            var goodsSelector = computerDrivesSelector.ComputerPartsSelector.ComputerTechnologiesSelector.GoodsSelector;
            var result = await GetQuestionList(computerDrives, computerDrivesSelector);
            return new List<QuestionsBase<string>>()
            {
                _questionsGrouper.GroupProducers(result),
                _questionsGrouper.GroupCountries(result),
                _questionsGrouper.GroupMaterials(result),
                _questionsGrouper.GroupColors(result),
                _questionsGrouper.GroupPrices(result, goodsSelector.PriceFrom, goodsSelector.PriceTo),

                _questionsGrouper.GroupCapacities(result),
                _questionsGrouper.GroupComputerDriveTypes(result),
                _questionsGrouper.GroupFormFactorTypes(result),

            };
        }
        private async Task<List<QuestionBase<string>>> GetQuestionList(
            IQueryable<ComputerDrive> computerDrives,
            ComputerDrivesSelector computerDrivesSelector)
        {
            var goodsSelector = computerDrivesSelector.ComputerPartsSelector.ComputerTechnologiesSelector.GoodsSelector;
            var producerQuestions = GetProducerQuestion(GetProducerComputerDrives(computerDrives, computerDrivesSelector), goodsSelector.Producers);
            var countryQuestions = GetCountryQuestion(GetCountryComputerDrives(computerDrives, computerDrivesSelector), goodsSelector.Countries);
            var materialQuestions = GetMaterialQuestion(GetMaterialComputerDrives(computerDrives, computerDrivesSelector), goodsSelector.Materials);
            var colorQuestions = GetColorQuestion(GetColorComputerDrives(computerDrives, computerDrivesSelector), goodsSelector.Colors);
            var priceQuestions = GetPriceQuestion(GetPriceComputerDrives(computerDrives, computerDrivesSelector));


            var capacityQuestions = GetCapacityQuestion(GetCapacityComputerDrives(computerDrives, computerDrivesSelector), computerDrivesSelector.Capacities);
            var typeyQuestions = GetTypeQuestion(GetTypeComputerDrives(computerDrives, computerDrivesSelector), computerDrivesSelector.Types);
            var formFactorTypeQuestions = GetFormFactorTypeQuestion(GetFormFactorTypeComputerDrives(computerDrives, computerDrivesSelector), computerDrivesSelector.FormFactorTypes);
            


            var group = producerQuestions.Union(countryQuestions).Union(materialQuestions).Union(colorQuestions).Union(priceQuestions)
                .Union(capacityQuestions).Union(typeyQuestions).Union(formFactorTypeQuestions);

            return await group.ToListAsync();
        }
        public IQueryable<T> GetProducerComputerDrives<T>(
            IQueryable<T> computerDrives,
            ComputerDrivesSelector computerDrivesSelector) where T : ComputerDrive
        {
            var goodsSelector = computerDrivesSelector.ComputerPartsSelector.ComputerTechnologiesSelector.GoodsSelector;
            var computerPartsSelector = computerDrivesSelector.ComputerPartsSelector;
            return _computerPartsQuestionsService.GetProducerComputerParts(
                computerDrives, computerPartsSelector)
                .Where(l => (goodsSelector.Producers != null && goodsSelector.Producers.Contains(l.Producer.Name)) ||
                ((computerDrivesSelector.Capacities == null || computerDrivesSelector.Capacities.Contains(l.Capacity))
                && (computerDrivesSelector.Types == null || computerDrivesSelector.Types.Contains(l.TypeValue))
                && (computerDrivesSelector.FormFactorTypes == null || computerDrivesSelector.FormFactorTypes.Contains(l.FormFactorTypeValue))));
        }
        public IQueryable<T> GetCountryComputerDrives<T>(
            IQueryable<T> computerDrives,
            ComputerDrivesSelector computerDrivesSelector) where T : ComputerDrive
        {
            var goodsSelector = computerDrivesSelector.ComputerPartsSelector.ComputerTechnologiesSelector.GoodsSelector;
            var computerPartsSelector = computerDrivesSelector.ComputerPartsSelector;
            return _computerPartsQuestionsService.GetCountryComputerParts(
                computerDrives, computerPartsSelector)
                .Where(l => (goodsSelector.Countries != null && goodsSelector.Countries.Contains(l.Manufacturer.Country.Value)) ||
                ((computerDrivesSelector.Capacities == null || computerDrivesSelector.Capacities.Contains(l.Capacity))
                && (computerDrivesSelector.Types == null || computerDrivesSelector.Types.Contains(l.TypeValue))
                && (computerDrivesSelector.FormFactorTypes == null || computerDrivesSelector.FormFactorTypes.Contains(l.FormFactorTypeValue))));
        }
        public IQueryable<T> GetMaterialComputerDrives<T>(
            IQueryable<T> computerDrives,
            ComputerDrivesSelector computerDrivesSelector) where T : ComputerDrive
        {
            var goodsSelector = computerDrivesSelector.ComputerPartsSelector.ComputerTechnologiesSelector.GoodsSelector;
            var computerPartsSelector = computerDrivesSelector.ComputerPartsSelector;
            return _computerPartsQuestionsService.GetMaterialComputerParts(
                computerDrives, computerPartsSelector)
                .Where(l => (goodsSelector.Materials != null && goodsSelector.Materials.Contains(l.Material.Value)) ||
                ((computerDrivesSelector.Capacities == null || computerDrivesSelector.Capacities.Contains(l.Capacity))
                && (computerDrivesSelector.Types == null || computerDrivesSelector.Types.Contains(l.TypeValue))
                && (computerDrivesSelector.FormFactorTypes == null || computerDrivesSelector.FormFactorTypes.Contains(l.FormFactorTypeValue))));
        }
        public IQueryable<T> GetColorComputerDrives<T>(
            IQueryable<T> computerDrives,
            ComputerDrivesSelector computerDrivesSelector) where T : ComputerDrive
        {
            var goodsSelector = computerDrivesSelector.ComputerPartsSelector.ComputerTechnologiesSelector.GoodsSelector;
            var computerPartsSelector = computerDrivesSelector.ComputerPartsSelector;
            return _computerPartsQuestionsService.GetColorComputerParts(
                computerDrives, computerPartsSelector)
                .Where(l => (goodsSelector.Colors != null && goodsSelector.Colors.Contains(l.Color.Value)) ||
                ((computerDrivesSelector.Capacities == null || computerDrivesSelector.Capacities.Contains(l.Capacity))
                && (computerDrivesSelector.Types == null || computerDrivesSelector.Types.Contains(l.TypeValue))
                && (computerDrivesSelector.FormFactorTypes == null || computerDrivesSelector.FormFactorTypes.Contains(l.FormFactorTypeValue))));
        }
        public IQueryable<T> GetPriceComputerDrives<T>(
            IQueryable<T> computerDrives,
            ComputerDrivesSelector computerDrivesSelector) where T : ComputerDrive
        {
            var goodsSelector = computerDrivesSelector.ComputerPartsSelector.ComputerTechnologiesSelector.GoodsSelector;
            var computerPartsSelector = computerDrivesSelector.ComputerPartsSelector;
            return _computerPartsQuestionsService.GetPriceComputerParts(
                computerDrives, computerPartsSelector)
                .Where(l =>
                (computerDrivesSelector.Capacities == null || computerDrivesSelector.Capacities.Contains(l.Capacity))
                && (computerDrivesSelector.Types == null || computerDrivesSelector.Types.Contains(l.TypeValue))
                && (computerDrivesSelector.FormFactorTypes == null || computerDrivesSelector.FormFactorTypes.Contains(l.FormFactorTypeValue)));
        }
        public IQueryable<T> GetCapacityComputerDrives<T>(
            IQueryable<T> computerDrives,
            ComputerDrivesSelector computerDrivesSelector) where T : ComputerDrive
        {
            var goodsSelector = computerDrivesSelector.ComputerPartsSelector.ComputerTechnologiesSelector.GoodsSelector;
            return computerDrives
                .Where(l => (computerDrivesSelector.Capacities != null && computerDrivesSelector.Capacities.Contains(l.Capacity)) ||
                ((goodsSelector.PriceFrom == null || l.Price >= goodsSelector.PriceFrom)
                && (goodsSelector.PriceTo == null || l.Price <= goodsSelector.PriceTo)
                && (computerDrivesSelector.Types == null || computerDrivesSelector.Types.Contains(l.TypeValue))
                && (computerDrivesSelector.FormFactorTypes == null || computerDrivesSelector.FormFactorTypes.Contains(l.FormFactorTypeValue))
                && (goodsSelector.Producers == null || goodsSelector.Producers.Contains(l.Producer.Name))
                && (goodsSelector.Countries == null || goodsSelector.Countries.Contains(l.Manufacturer.Country.Value))
                && (goodsSelector.Materials == null || goodsSelector.Materials.Contains(l.MaterialValue))
                && (goodsSelector.Colors == null || goodsSelector.Colors.Contains(l.ColorValue))));
        }
        public IQueryable<T> GetTypeComputerDrives<T>(
            IQueryable<T> computerDrives,
            ComputerDrivesSelector computerDrivesSelector) where T : ComputerDrive
        {
            var goodsSelector = computerDrivesSelector.ComputerPartsSelector.ComputerTechnologiesSelector.GoodsSelector;
            return computerDrives
                .Where(l => (computerDrivesSelector.Types != null && computerDrivesSelector.Types.Contains(l.TypeValue)) ||
                ((goodsSelector.PriceFrom == null || l.Price >= goodsSelector.PriceFrom)
                && (goodsSelector.PriceTo == null || l.Price <= goodsSelector.PriceTo)
                && (computerDrivesSelector.Capacities == null || computerDrivesSelector.Capacities.Contains(l.Capacity))
                && (computerDrivesSelector.FormFactorTypes == null || computerDrivesSelector.FormFactorTypes.Contains(l.FormFactorTypeValue))
                && (goodsSelector.Producers == null || goodsSelector.Producers.Contains(l.Producer.Name))
                && (goodsSelector.Countries == null || goodsSelector.Countries.Contains(l.Manufacturer.Country.Value))
                && (goodsSelector.Materials == null || goodsSelector.Materials.Contains(l.MaterialValue))
                && (goodsSelector.Colors == null || goodsSelector.Colors.Contains(l.ColorValue))));
        }
        public IQueryable<T> GetFormFactorTypeComputerDrives<T>(
            IQueryable<T> computerDrives,
            ComputerDrivesSelector computerDrivesSelector) where T : ComputerDrive
        {
            var goodsSelector = computerDrivesSelector.ComputerPartsSelector.ComputerTechnologiesSelector.GoodsSelector;
            return computerDrives
                .Where(l => (computerDrivesSelector.FormFactorTypes != null && computerDrivesSelector.FormFactorTypes.Contains(l.FormFactorTypeValue)) ||
                ((goodsSelector.PriceFrom == null || l.Price >= goodsSelector.PriceFrom)
                && (goodsSelector.PriceTo == null || l.Price <= goodsSelector.PriceTo)
                && (computerDrivesSelector.Capacities == null || computerDrivesSelector.Capacities.Contains(l.Capacity))
                && (computerDrivesSelector.Types == null || computerDrivesSelector.Types.Contains(l.TypeValue))
                && (goodsSelector.Producers == null || goodsSelector.Producers.Contains(l.Producer.Name))
                && (goodsSelector.Countries == null || goodsSelector.Countries.Contains(l.Manufacturer.Country.Value))
                && (goodsSelector.Materials == null || goodsSelector.Materials.Contains(l.MaterialValue))
                && (goodsSelector.Colors == null || goodsSelector.Colors.Contains(l.ColorValue))));
        }

        public IQueryable<QuestionBase<string>> GetProducerQuestion(IQueryable<ComputerDrive> computerDrives, string[] producers)
        {
            return _computerPartsQuestionsService.GetProducerQuestion(computerDrives, producers);
        }
        public IQueryable<QuestionBase<string>> GetCountryQuestion(IQueryable<ComputerDrive> computerDrives, string[] countries)
        {
            return _computerPartsQuestionsService.GetCountryQuestion(computerDrives, countries);
        }
        public IQueryable<QuestionBase<string>> GetMaterialQuestion(IQueryable<ComputerDrive> computerDrives, string[] materials)
        {
            return _computerPartsQuestionsService.GetMaterialQuestion(computerDrives, materials);
        }
        public IQueryable<QuestionBase<string>> GetColorQuestion(IQueryable<ComputerDrive> computerDrives, string[] colors)
        {
            return _computerPartsQuestionsService.GetColorQuestion(computerDrives, colors);
        }
        public IQueryable<QuestionBase<string>> GetPriceQuestion(IQueryable<ComputerDrive> computerDrives)
        {
            return _computerPartsQuestionsService.GetPriceQuestion(computerDrives);
        }
        public IQueryable<QuestionBase<string>> GetCapacityQuestion(IQueryable<ComputerDrive> computerDrives, int[] capacities)
        {
            var stringList = capacities?.Select(item => item.ToString()).ToList();
            return computerDrives
                        .Select(g => g.Capacity)
                        .GroupBy(p => p)
                        .Select(p => new { Count = p.Count(), Value = Convert.ToString(p.Key) })
                        .Select(capacity => new QuestionBase<string>()
                        {
                            QuestionsKey = "capacity",
                            AfterBox = (stringList != null && stringList.Contains(capacity.Value)) ? (int?)null : capacity.Count,
                            Checked = stringList != null && stringList.Contains(capacity.Value),
                            ControlType = ControlType.Checkbox,
                            Key = capacity.Value,
                            Label = capacity.Value,
                            Required = false,
                            Type = InputType.Checkbox,
                        });
        }
        public IQueryable<QuestionBase<string>> GetTypeQuestion(IQueryable<ComputerDrive> computerDrives, string[] types)
        {
            return computerDrives
                        .Select(g => g.TypeValue)
                        .GroupBy(p => p)
                        .Select(p => new { Count = p.Count(), Value = Convert.ToString(p.Key) })
                        .Select(type => new QuestionBase<string>()
                        {
                            QuestionsKey = "computerDriveType",
                            AfterBox = (types != null && types.Contains(type.Value)) ? (int?)null : type.Count,
                            Checked = types != null && types.Contains(type.Value),
                            ControlType = ControlType.Checkbox,
                            Key = type.Value,
                            Label = type.Value,
                            Required = false,
                            Type = InputType.Checkbox,
                        });
        }
        public IQueryable<QuestionBase<string>> GetFormFactorTypeQuestion(IQueryable<ComputerDrive> computerDrives, string[] formFactorTypes)
        {
            return computerDrives
                        .Select(g => g.FormFactorTypeValue)
                        .GroupBy(p => p)
                        .Select(p => new { Count = p.Count(), Value = Convert.ToString(p.Key) })
                        .Select(formFactorType => new QuestionBase<string>()
                        {
                            QuestionsKey = "formFactorType",
                            AfterBox = (formFactorTypes != null && formFactorTypes.Contains(formFactorType.Value)) ? (int?)null : formFactorType.Count,
                            Checked = formFactorTypes != null && formFactorTypes.Contains(formFactorType.Value),
                            ControlType = ControlType.Checkbox,
                            Key = formFactorType.Value,
                            Label = formFactorType.Value,
                            Required = false,
                            Type = InputType.Checkbox,
                        });
        }
    }
}
