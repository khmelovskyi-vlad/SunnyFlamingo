using Microsoft.EntityFrameworkCore;
using SunnyFlamingo.Entities.Goods.ComputerTechnologies.ComputerAccessories;
using SunnyFlamingo.Models;
using SunnyFlamingo.Models.Selectors;
using SunnyFlamingo.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Searchers
{
    public class MiceQuestionsService : IMiceQuestionsService
    {
        private readonly IComputerAccessoriesQuestionsService _computerAccessoriesQuestionsService;
        private readonly IQuestionsGrouper _questionsGrouper;
        public MiceQuestionsService(
            IComputerAccessoriesQuestionsService computerAccessoriesQuestionsService,
            IQuestionsGrouper questionsGrouper)
        {
            _computerAccessoriesQuestionsService = computerAccessoriesQuestionsService;
            _questionsGrouper = questionsGrouper;
        }
        public async Task<List<QuestionsBase<string>>> GetMiceQuestions(
            IQueryable<Mause> mice,
            MiceSelector miceSelector)
        {
            var goodsSelector = miceSelector.ComputerAccessoriesSelector.ComputerTechnologiesSelector.GoodsSelector;
            var result = await GetQuestionList(mice, miceSelector);
            return new List<QuestionsBase<string>>()
            {
                _questionsGrouper.GroupProducers(result),
                _questionsGrouper.GroupCountries(result),
                _questionsGrouper.GroupMaterials(result),
                _questionsGrouper.GroupColors(result),
                _questionsGrouper.GroupPrices(result, goodsSelector.PriceFrom, goodsSelector.PriceTo),

                _questionsGrouper.GroupMauseTypes(result),
                _questionsGrouper.GroupButtonsCount(result),

            };
        }
        private async Task<List<QuestionBase<string>>> GetQuestionList(
            IQueryable<Mause> mice,
            MiceSelector miceSelector)
        {
            var goodsSelector = miceSelector.ComputerAccessoriesSelector.ComputerTechnologiesSelector.GoodsSelector;
            var producerQuestions = GetProducerQuestion(GetProducerMice(mice, miceSelector), goodsSelector.Producers);
            var countryQuestions = GetCountryQuestion(GetCountryMice(mice, miceSelector), goodsSelector.Countries);
            var materialQuestions = GetMaterialQuestion(GetMaterialMice(mice, miceSelector), goodsSelector.Materials);
            var colorQuestions = GetColorQuestion(GetColorMice(mice, miceSelector), goodsSelector.Colors);
            var priceQuestions = GetPriceQuestion(GetPriceMice(mice, miceSelector));


            var typeQuestions = GetTypeQuestion(GetTypeMice(mice, miceSelector), miceSelector.Types);
            var buttonsCountQuestions = GetButtonsCountQuestion(GetButtonsCountMice(mice, miceSelector), miceSelector.ButtonsCount);



            var group = producerQuestions.Union(countryQuestions).Union(materialQuestions).Union(colorQuestions).Union(priceQuestions)
                .Union(typeQuestions).Union(buttonsCountQuestions);

            return await group.ToListAsync();
        }
        public IQueryable<T> GetProducerMice<T>(
            IQueryable<T> mice,
            MiceSelector miceSelector) where T : Mause
        {
            var goodsSelector = miceSelector.ComputerAccessoriesSelector.ComputerTechnologiesSelector.GoodsSelector;
            var computerAccessoriesSelector = miceSelector.ComputerAccessoriesSelector;
            return _computerAccessoriesQuestionsService.GetProducerComputerAccessories(
                mice, computerAccessoriesSelector)
                .Where(l => (goodsSelector.Producers != null && goodsSelector.Producers.Contains(l.Producer.Name)) ||
                ((miceSelector.Types == null || miceSelector.Types.Contains(l.TypeValue))
                && (miceSelector.ButtonsCount == null || miceSelector.ButtonsCount.Contains(l.ButtonsCount))));
        }
        public IQueryable<T> GetCountryMice<T>(
            IQueryable<T> mice,
            MiceSelector miceSelector) where T : Mause
        {
            var goodsSelector = miceSelector.ComputerAccessoriesSelector.ComputerTechnologiesSelector.GoodsSelector;
            var computerAccessoriesSelector = miceSelector.ComputerAccessoriesSelector;
            return _computerAccessoriesQuestionsService.GetCountryComputerAccessories(
                mice, computerAccessoriesSelector)
                .Where(l => (goodsSelector.Countries != null && goodsSelector.Countries.Contains(l.Manufacturer.Country.Value)) ||
                ((miceSelector.Types == null || miceSelector.Types.Contains(l.TypeValue))
                && (miceSelector.ButtonsCount == null || miceSelector.ButtonsCount.Contains(l.ButtonsCount))));
        }
        public IQueryable<T> GetMaterialMice<T>(
            IQueryable<T> mice,
            MiceSelector miceSelector) where T : Mause
        {
            var goodsSelector = miceSelector.ComputerAccessoriesSelector.ComputerTechnologiesSelector.GoodsSelector;
            var computerAccessoriesSelector = miceSelector.ComputerAccessoriesSelector;
            return _computerAccessoriesQuestionsService.GetMaterialComputerAccessories(
                mice, computerAccessoriesSelector)
                .Where(l => (goodsSelector.Materials != null && goodsSelector.Materials.Contains(l.Material.Value)) ||
                ((miceSelector.Types == null || miceSelector.Types.Contains(l.TypeValue))
                && (miceSelector.ButtonsCount == null || miceSelector.ButtonsCount.Contains(l.ButtonsCount))));
        }
        public IQueryable<T> GetColorMice<T>(
            IQueryable<T> mice,
            MiceSelector miceSelector) where T : Mause
        {
            var goodsSelector = miceSelector.ComputerAccessoriesSelector.ComputerTechnologiesSelector.GoodsSelector;
            var computerAccessoriesSelector = miceSelector.ComputerAccessoriesSelector;
            return _computerAccessoriesQuestionsService.GetColorComputerAccessories(
                mice, computerAccessoriesSelector)
                .Where(l => (goodsSelector.Colors != null && goodsSelector.Colors.Contains(l.Color.Value)) ||
                ((miceSelector.Types == null || miceSelector.Types.Contains(l.TypeValue))
                && (miceSelector.ButtonsCount == null || miceSelector.ButtonsCount.Contains(l.ButtonsCount))));
        }
        public IQueryable<T> GetPriceMice<T>(
            IQueryable<T> mice,
            MiceSelector miceSelector) where T : Mause
        {
            var goodsSelector = miceSelector.ComputerAccessoriesSelector.ComputerTechnologiesSelector.GoodsSelector;
            var computerAccessoriesSelector = miceSelector.ComputerAccessoriesSelector;
            return _computerAccessoriesQuestionsService.GetPriceComputerAccessories(
                mice, computerAccessoriesSelector)
                .Where(l => (miceSelector.Types == null || miceSelector.Types.Contains(l.TypeValue))
                && (miceSelector.ButtonsCount == null || miceSelector.ButtonsCount.Contains(l.ButtonsCount)));
        }
        public IQueryable<T> GetButtonsCountMice<T>(
            IQueryable<T> mice,
            MiceSelector miceSelector) where T : Mause
        {
            var goodsSelector = miceSelector.ComputerAccessoriesSelector.ComputerTechnologiesSelector.GoodsSelector;
            return mice
                .Where(l => (miceSelector.ButtonsCount != null && miceSelector.ButtonsCount.Contains(l.ButtonsCount)) ||
                ((goodsSelector.PriceFrom == null || l.Price >= goodsSelector.PriceFrom)
                && (goodsSelector.PriceTo == null || l.Price <= goodsSelector.PriceTo)
                && (miceSelector.Types == null || miceSelector.Types.Contains(l.TypeValue))
                && (goodsSelector.Producers == null || goodsSelector.Producers.Contains(l.Producer.Name))
                && (goodsSelector.Countries == null || goodsSelector.Countries.Contains(l.Manufacturer.Country.Value))
                && (goodsSelector.Materials == null || goodsSelector.Materials.Contains(l.MaterialValue))
                && (goodsSelector.Colors == null || goodsSelector.Colors.Contains(l.ColorValue))));
        }
        public IQueryable<T> GetTypeMice<T>(
            IQueryable<T> mice,
            MiceSelector miceSelector) where T : Mause
        {
            var goodsSelector = miceSelector.ComputerAccessoriesSelector.ComputerTechnologiesSelector.GoodsSelector;
            return mice
                .Where(l => (miceSelector.Types != null && miceSelector.Types.Contains(l.TypeValue)) ||
                ((goodsSelector.PriceFrom == null || l.Price >= goodsSelector.PriceFrom)
                && (goodsSelector.PriceTo == null || l.Price <= goodsSelector.PriceTo)
                && (miceSelector.ButtonsCount == null || miceSelector.ButtonsCount.Contains(l.ButtonsCount))
                && (goodsSelector.Producers == null || goodsSelector.Producers.Contains(l.Producer.Name))
                && (goodsSelector.Countries == null || goodsSelector.Countries.Contains(l.Manufacturer.Country.Value))
                && (goodsSelector.Materials == null || goodsSelector.Materials.Contains(l.MaterialValue))
                && (goodsSelector.Colors == null || goodsSelector.Colors.Contains(l.ColorValue))));
        }

        public IQueryable<QuestionBase<string>> GetProducerQuestion(IQueryable<Mause> mice, string[] producers)
        {
            return _computerAccessoriesQuestionsService.GetProducerQuestion(mice, producers);
        }
        public IQueryable<QuestionBase<string>> GetCountryQuestion(IQueryable<Mause> mice, string[] countries)
        {
            return _computerAccessoriesQuestionsService.GetCountryQuestion(mice, countries);
        }
        public IQueryable<QuestionBase<string>> GetMaterialQuestion(IQueryable<Mause> mice, string[] materials)
        {
            return _computerAccessoriesQuestionsService.GetMaterialQuestion(mice, materials);
        }
        public IQueryable<QuestionBase<string>> GetColorQuestion(IQueryable<Mause> mice, string[] colors)
        {
            return _computerAccessoriesQuestionsService.GetColorQuestion(mice, colors);
        }
        public IQueryable<QuestionBase<string>> GetPriceQuestion(IQueryable<Mause> mice)
        {
            return _computerAccessoriesQuestionsService.GetPriceQuestion(mice);
        }
        public IQueryable<QuestionBase<string>> GetTypeQuestion(IQueryable<Mause> mice, string[] types)
        {
            return mice
                        .Select(g => g.TypeValue)
                        .GroupBy(p => p)
                        .Select(p => new { Count = p.Count(), Value = Convert.ToString(p.Key) })
                        .Select(type => new QuestionBase<string>()
                        {
                            QuestionsKey = "mauseType",
                            AfterBox = (types != null && types.Contains(type.Value)) ? (int?)null : type.Count,
                            Checked = types != null && types.Contains(type.Value),
                            ControlType = ControlType.Checkbox,
                            Key = type.Value,
                            Label = type.Value,
                            Required = false,
                            Type = InputType.Checkbox,
                        });
        }
        public IQueryable<QuestionBase<string>> GetButtonsCountQuestion(IQueryable<Mause> mice, int[] buttonsCount)
        {
            var stringList = buttonsCount?.Select(item => item.ToString()).ToList();
            return mice
                        .Select(g => g.ButtonsCount)
                        .GroupBy(p => p)
                        .Select(p => new { Count = p.Count(), Value = Convert.ToString(p.Key) })
                        .Select(button => new QuestionBase<string>()
                        {
                            QuestionsKey = "buttonsCount",
                            AfterBox = (stringList != null && stringList.Contains(button.Value)) ? (int?)null : button.Count,
                            Checked = stringList != null && stringList.Contains(button.Value),
                            ControlType = ControlType.Checkbox,
                            Key = button.Value,
                            Label = button.Value,
                            Required = false,
                            Type = InputType.Checkbox,
                        });
        }
    }
}
