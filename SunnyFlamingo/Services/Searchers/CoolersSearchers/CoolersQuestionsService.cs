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
    public class CoolersQuestionsService : ICoolersQuestionsService
    {
        private readonly IComputerPartsQuestionsService _computerPartsQuestionsService;
        private readonly IQuestionsGrouper _questionsGrouper;
        public CoolersQuestionsService(
            IComputerPartsQuestionsService computerPartsQuestionsService,
            IQuestionsGrouper questionsGrouper)
        {
            _computerPartsQuestionsService = computerPartsQuestionsService;
            _questionsGrouper = questionsGrouper;
        }
        public async Task<List<QuestionsBase<string>>> GetCoolersQuestions(
            IQueryable<Cooler> coolers,
            CoolersSelector coolersSelector)
        {
            var goodsSelector = coolersSelector.ComputerPartsSelector.ComputerTechnologiesSelector.GoodsSelector;
            var result = await GetQuestionList(coolers, coolersSelector);
            return new List<QuestionsBase<string>>()
            {
                _questionsGrouper.GroupProducers(result),
                _questionsGrouper.GroupCountries(result),
                _questionsGrouper.GroupMaterials(result),
                _questionsGrouper.GroupColors(result),
                _questionsGrouper.GroupPrices(result, goodsSelector.PriceFrom, goodsSelector.PriceTo),

                _questionsGrouper.GroupCoolerTypes(result),
                _questionsGrouper.GroupFanSizes(result),

            };
        }
        private async Task<List<QuestionBase<string>>> GetQuestionList(
            IQueryable<Cooler> coolers,
            CoolersSelector coolersSelector)
        {
            var goodsSelector = coolersSelector.ComputerPartsSelector.ComputerTechnologiesSelector.GoodsSelector;
            var producerQuestions = GetProducerQuestion(GetProducerCoolers(coolers, coolersSelector), goodsSelector.Producers);
            var countryQuestions = GetCountryQuestion(GetCountryCoolers(coolers, coolersSelector), goodsSelector.Countries);
            var materialQuestions = GetMaterialQuestion(GetMaterialCoolers(coolers, coolersSelector), goodsSelector.Materials);
            var colorQuestions = GetColorQuestion(GetColorCoolers(coolers, coolersSelector), goodsSelector.Colors);
            var priceQuestions = GetPriceQuestion(GetPriceCoolers(coolers, coolersSelector));


            var capacityQuestions = GetFanSizeQuestion(GetFanSizeCoolers(coolers, coolersSelector), coolersSelector.FanSizes);
            var typeQuestions = GetTypeQuestion(GetTypeCoolers(coolers, coolersSelector), coolersSelector.Types);



            var group = producerQuestions.Union(countryQuestions).Union(materialQuestions).Union(colorQuestions).Union(priceQuestions)
                .Union(capacityQuestions).Union(typeQuestions);

            return await group.ToListAsync();
        }
        public IQueryable<T> GetProducerCoolers<T>(
            IQueryable<T> coolers,
            CoolersSelector coolersSelector) where T : Cooler
        {
            var goodsSelector = coolersSelector.ComputerPartsSelector.ComputerTechnologiesSelector.GoodsSelector;
            var computerPartsSelector = coolersSelector.ComputerPartsSelector;
            return _computerPartsQuestionsService.GetProducerComputerParts(
                coolers, computerPartsSelector)
                .Where(l => (goodsSelector.Producers != null && goodsSelector.Producers.Contains(l.Producer.Name)) ||
                ((coolersSelector.Types == null || coolersSelector.Types.Contains(l.TypeValue))
                && (coolersSelector.FanSizes == null || coolersSelector.FanSizes.Contains(l.FanSize))));
        }
        public IQueryable<T> GetCountryCoolers<T>(
            IQueryable<T> coolers,
            CoolersSelector coolersSelector) where T : Cooler
        {
            var goodsSelector = coolersSelector.ComputerPartsSelector.ComputerTechnologiesSelector.GoodsSelector;
            var computerPartsSelector = coolersSelector.ComputerPartsSelector;
            return _computerPartsQuestionsService.GetCountryComputerParts(
                coolers, computerPartsSelector)
                .Where(l => (goodsSelector.Countries != null && goodsSelector.Countries.Contains(l.Manufacturer.Country.Value)) ||
                ((coolersSelector.Types == null || coolersSelector.Types.Contains(l.TypeValue))
                && (coolersSelector.FanSizes == null || coolersSelector.FanSizes.Contains(l.FanSize))));
        }
        public IQueryable<T> GetMaterialCoolers<T>(
            IQueryable<T> coolers,
            CoolersSelector coolersSelector) where T : Cooler
        {
            var goodsSelector = coolersSelector.ComputerPartsSelector.ComputerTechnologiesSelector.GoodsSelector;
            var computerPartsSelector = coolersSelector.ComputerPartsSelector;
            return _computerPartsQuestionsService.GetMaterialComputerParts(
                coolers, computerPartsSelector)
                .Where(l => (goodsSelector.Materials != null && goodsSelector.Materials.Contains(l.Material.Value)) ||
                ((coolersSelector.Types == null || coolersSelector.Types.Contains(l.TypeValue))
                && (coolersSelector.FanSizes == null || coolersSelector.FanSizes.Contains(l.FanSize))));
        }
        public IQueryable<T> GetColorCoolers<T>(
            IQueryable<T> coolers,
            CoolersSelector coolersSelector) where T : Cooler
        {
            var goodsSelector = coolersSelector.ComputerPartsSelector.ComputerTechnologiesSelector.GoodsSelector;
            var computerPartsSelector = coolersSelector.ComputerPartsSelector;
            return _computerPartsQuestionsService.GetColorComputerParts(
                coolers, computerPartsSelector)
                .Where(l => (goodsSelector.Colors != null && goodsSelector.Colors.Contains(l.Color.Value)) ||
                ((coolersSelector.Types == null || coolersSelector.Types.Contains(l.TypeValue))
                && (coolersSelector.FanSizes == null || coolersSelector.FanSizes.Contains(l.FanSize))));
        }
        public IQueryable<T> GetPriceCoolers<T>(
            IQueryable<T> coolers,
            CoolersSelector coolersSelector) where T : Cooler
        {
            var goodsSelector = coolersSelector.ComputerPartsSelector.ComputerTechnologiesSelector.GoodsSelector;
            var computerPartsSelector = coolersSelector.ComputerPartsSelector;
            return _computerPartsQuestionsService.GetPriceComputerParts(
                coolers, computerPartsSelector)
                .Where(l => (coolersSelector.Types == null || coolersSelector.Types.Contains(l.TypeValue))
                && (coolersSelector.FanSizes == null || coolersSelector.FanSizes.Contains(l.FanSize)));
        }
        public IQueryable<T> GetFanSizeCoolers<T>(
            IQueryable<T> coolers,
            CoolersSelector coolersSelector) where T : Cooler
        {
            var goodsSelector = coolersSelector.ComputerPartsSelector.ComputerTechnologiesSelector.GoodsSelector;
            return coolers
                .Where(l => (coolersSelector.FanSizes != null && coolersSelector.FanSizes.Contains(l.FanSize)) ||
                ((goodsSelector.PriceFrom == null || l.Price >= goodsSelector.PriceFrom)
                && (goodsSelector.PriceTo == null || l.Price <= goodsSelector.PriceTo)
                && (coolersSelector.Types == null || coolersSelector.Types.Contains(l.TypeValue))
                && (goodsSelector.Producers == null || goodsSelector.Producers.Contains(l.Producer.Name))
                && (goodsSelector.Countries == null || goodsSelector.Countries.Contains(l.Manufacturer.Country.Value))
                && (goodsSelector.Materials == null || goodsSelector.Materials.Contains(l.MaterialValue))
                && (goodsSelector.Colors == null || goodsSelector.Colors.Contains(l.ColorValue))));
        }
        public IQueryable<T> GetTypeCoolers<T>(
            IQueryable<T> coolers,
            CoolersSelector coolersSelector) where T : Cooler
        {
            var goodsSelector = coolersSelector.ComputerPartsSelector.ComputerTechnologiesSelector.GoodsSelector;
            return coolers
                .Where(l => (coolersSelector.Types != null && coolersSelector.Types.Contains(l.TypeValue)) ||
                ((goodsSelector.PriceFrom == null || l.Price >= goodsSelector.PriceFrom)
                && (goodsSelector.PriceTo == null || l.Price <= goodsSelector.PriceTo)
                && (coolersSelector.FanSizes == null || coolersSelector.FanSizes.Contains(l.FanSize))
                && (goodsSelector.Producers == null || goodsSelector.Producers.Contains(l.Producer.Name))
                && (goodsSelector.Countries == null || goodsSelector.Countries.Contains(l.Manufacturer.Country.Value))
                && (goodsSelector.Materials == null || goodsSelector.Materials.Contains(l.MaterialValue))
                && (goodsSelector.Colors == null || goodsSelector.Colors.Contains(l.ColorValue))));
        }

        public IQueryable<QuestionBase<string>> GetProducerQuestion(IQueryable<Cooler> coolers, string[] producers)
        {
            return _computerPartsQuestionsService.GetProducerQuestion(coolers, producers);
        }
        public IQueryable<QuestionBase<string>> GetCountryQuestion(IQueryable<Cooler> coolers, string[] countries)
        {
            return _computerPartsQuestionsService.GetCountryQuestion(coolers, countries);
        }
        public IQueryable<QuestionBase<string>> GetMaterialQuestion(IQueryable<Cooler> coolers, string[] materials)
        {
            return _computerPartsQuestionsService.GetMaterialQuestion(coolers, materials);
        }
        public IQueryable<QuestionBase<string>> GetColorQuestion(IQueryable<Cooler> coolers, string[] colors)
        {
            return _computerPartsQuestionsService.GetColorQuestion(coolers, colors);
        }
        public IQueryable<QuestionBase<string>> GetPriceQuestion(IQueryable<Cooler> coolers)
        {
            return _computerPartsQuestionsService.GetPriceQuestion(coolers);
        }
        public IQueryable<QuestionBase<string>> GetTypeQuestion(IQueryable<Cooler> coolers, string[] types)
        {
            return coolers
                        .Select(g => g.TypeValue)
                        .GroupBy(p => p)
                        .Select(p => new { Count = p.Count(), Value = Convert.ToString(p.Key) })
                        .Select(type => new QuestionBase<string>()
                        {
                            QuestionsKey = "coolerType",
                            AfterBox = (types != null && types.Contains(type.Value)) ? (int?)null : type.Count,
                            Checked = types != null && types.Contains(type.Value),
                            ControlType = ControlType.Checkbox,
                            Key = type.Value,
                            Label = type.Value,
                            Required = false,
                            Type = InputType.Checkbox,
                        });
        }
        public IQueryable<QuestionBase<string>> GetFanSizeQuestion(IQueryable<Cooler> coolers, int[] fanSizes)
        {
            var stringList = fanSizes?.Select(item => item.ToString()).ToList();
            return coolers
                        .Select(g => g.FanSize)
                        .GroupBy(p => p)
                        .Select(p => new { Count = p.Count(), Value = Convert.ToString(p.Key) })
                        .Select(fanSize => new QuestionBase<string>()
                        {
                            QuestionsKey = "fanSize",
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
