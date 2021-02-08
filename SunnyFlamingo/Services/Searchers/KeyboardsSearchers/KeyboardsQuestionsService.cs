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
    public class KeyboardsQuestionsService : IKeyboardsQuestionsService
    {
        private readonly IComputerAccessoriesQuestionsService _computerAccessoriesQuestionsService;
        private readonly IQuestionsGrouper _questionsGrouper;
        public KeyboardsQuestionsService(
            IComputerAccessoriesQuestionsService computerAccessoriesQuestionsService,
            IQuestionsGrouper questionsGrouper)
        {
            _computerAccessoriesQuestionsService = computerAccessoriesQuestionsService;
            _questionsGrouper = questionsGrouper;
        }
        public async Task<List<QuestionsBase<string>>> GetKeyboardsQuestions(
            IQueryable<Keyboard> keyboards,
            KeyboardsSelector keyboardsSelector)
        {
            var goodsSelector = keyboardsSelector.ComputerAccessoriesSelector.ComputerTechnologiesSelector.GoodsSelector;
            var result = await GetQuestionList(keyboards, keyboardsSelector);
            return new List<QuestionsBase<string>>()
            {
                _questionsGrouper.GroupProducers(result),
                _questionsGrouper.GroupCountries(result),
                _questionsGrouper.GroupMaterials(result),
                _questionsGrouper.GroupColors(result),
                _questionsGrouper.GroupPrices(result, goodsSelector.PriceFrom, goodsSelector.PriceTo),

                _questionsGrouper.GroupKeyboardTypes(result),

            };
        }
        private async Task<List<QuestionBase<string>>> GetQuestionList(
            IQueryable<Keyboard> keyboards,
            KeyboardsSelector keyboardsSelector)
        {
            var goodsSelector = keyboardsSelector.ComputerAccessoriesSelector.ComputerTechnologiesSelector.GoodsSelector;
            var producerQuestions = GetProducerQuestion(GetProducerKeyboards(keyboards, keyboardsSelector), goodsSelector.Producers);
            var countryQuestions = GetCountryQuestion(GetCountryKeyboards(keyboards, keyboardsSelector), goodsSelector.Countries);
            var materialQuestions = GetMaterialQuestion(GetMaterialKeyboards(keyboards, keyboardsSelector), goodsSelector.Materials);
            var colorQuestions = GetColorQuestion(GetColorKeyboards(keyboards, keyboardsSelector), goodsSelector.Colors);
            var priceQuestions = GetPriceQuestion(GetPriceKeyboards(keyboards, keyboardsSelector));


            var typeQuestions = GetTypeQuestion(GetTypeKeyboards(keyboards, keyboardsSelector), keyboardsSelector.Types);



            var group = producerQuestions.Union(countryQuestions).Union(materialQuestions).Union(colorQuestions).Union(priceQuestions)
                .Union(typeQuestions);

            return await group.ToListAsync();
        }
        public IQueryable<T> GetProducerKeyboards<T>(
            IQueryable<T> keyboards,
            KeyboardsSelector keyboardsSelector) where T : Keyboard
        {
            var goodsSelector = keyboardsSelector.ComputerAccessoriesSelector.ComputerTechnologiesSelector.GoodsSelector;
            var computerAccessoriesSelector = keyboardsSelector.ComputerAccessoriesSelector;
            return _computerAccessoriesQuestionsService.GetProducerComputerAccessories(
                keyboards, computerAccessoriesSelector)
                .Where(l => (goodsSelector.Producers != null && goodsSelector.Producers.Contains(l.Producer.Name)) ||
                ((keyboardsSelector.Types == null || keyboardsSelector.Types.Contains(l.TypeValue))));
        }
        public IQueryable<T> GetCountryKeyboards<T>(
            IQueryable<T> keyboards,
            KeyboardsSelector keyboardsSelector) where T : Keyboard
        {
            var goodsSelector = keyboardsSelector.ComputerAccessoriesSelector.ComputerTechnologiesSelector.GoodsSelector;
            var computerAccessoriesSelector = keyboardsSelector.ComputerAccessoriesSelector;
            return _computerAccessoriesQuestionsService.GetCountryComputerAccessories(
                keyboards, computerAccessoriesSelector)
                .Where(l => (goodsSelector.Countries != null && goodsSelector.Countries.Contains(l.Manufacturer.Country.Value)) ||
                ((keyboardsSelector.Types == null || keyboardsSelector.Types.Contains(l.TypeValue))));
        }
        public IQueryable<T> GetMaterialKeyboards<T>(
            IQueryable<T> keyboards,
            KeyboardsSelector keyboardsSelector) where T : Keyboard
        {
            var goodsSelector = keyboardsSelector.ComputerAccessoriesSelector.ComputerTechnologiesSelector.GoodsSelector;
            var computerAccessoriesSelector = keyboardsSelector.ComputerAccessoriesSelector;
            return _computerAccessoriesQuestionsService.GetMaterialComputerAccessories(
                keyboards, computerAccessoriesSelector)
                .Where(l => (goodsSelector.Materials != null && goodsSelector.Materials.Contains(l.Material.Value)) ||
                ((keyboardsSelector.Types == null || keyboardsSelector.Types.Contains(l.TypeValue))));
        }
        public IQueryable<T> GetColorKeyboards<T>(
            IQueryable<T> keyboards,
            KeyboardsSelector keyboardsSelector) where T : Keyboard
        {
            var goodsSelector = keyboardsSelector.ComputerAccessoriesSelector.ComputerTechnologiesSelector.GoodsSelector;
            var computerAccessoriesSelector = keyboardsSelector.ComputerAccessoriesSelector;
            return _computerAccessoriesQuestionsService.GetColorComputerAccessories(
                keyboards, computerAccessoriesSelector)
                .Where(l => (goodsSelector.Colors != null && goodsSelector.Colors.Contains(l.Color.Value)) ||
                ((keyboardsSelector.Types == null || keyboardsSelector.Types.Contains(l.TypeValue))));
        }
        public IQueryable<T> GetPriceKeyboards<T>(
            IQueryable<T> keyboards,
            KeyboardsSelector keyboardsSelector) where T : Keyboard
        {
            var goodsSelector = keyboardsSelector.ComputerAccessoriesSelector.ComputerTechnologiesSelector.GoodsSelector;
            var computerAccessoriesSelector = keyboardsSelector.ComputerAccessoriesSelector;
            return _computerAccessoriesQuestionsService.GetPriceComputerAccessories(
                keyboards, computerAccessoriesSelector)
                .Where(l => (keyboardsSelector.Types == null || keyboardsSelector.Types.Contains(l.TypeValue)));
        }
        public IQueryable<T> GetTypeKeyboards<T>(
            IQueryable<T> keyboards,
            KeyboardsSelector keyboardsSelector) where T : Keyboard
        {
            var goodsSelector = keyboardsSelector.ComputerAccessoriesSelector.ComputerTechnologiesSelector.GoodsSelector;
            return keyboards
                .Where(l => (keyboardsSelector.Types != null && keyboardsSelector.Types.Contains(l.TypeValue)) ||
                ((goodsSelector.PriceFrom == null || l.Price >= goodsSelector.PriceFrom)
                && (goodsSelector.PriceTo == null || l.Price <= goodsSelector.PriceTo)
                && (goodsSelector.Producers == null || goodsSelector.Producers.Contains(l.Producer.Name))
                && (goodsSelector.Countries == null || goodsSelector.Countries.Contains(l.Manufacturer.Country.Value))
                && (goodsSelector.Materials == null || goodsSelector.Materials.Contains(l.MaterialValue))
                && (goodsSelector.Colors == null || goodsSelector.Colors.Contains(l.ColorValue))));
        }

        public IQueryable<QuestionBase<string>> GetProducerQuestion(IQueryable<Keyboard> keyboards, string[] producers)
        {
            return _computerAccessoriesQuestionsService.GetProducerQuestion(keyboards, producers);
        }
        public IQueryable<QuestionBase<string>> GetCountryQuestion(IQueryable<Keyboard> keyboards, string[] countries)
        {
            return _computerAccessoriesQuestionsService.GetCountryQuestion(keyboards, countries);
        }
        public IQueryable<QuestionBase<string>> GetMaterialQuestion(IQueryable<Keyboard> keyboards, string[] materials)
        {
            return _computerAccessoriesQuestionsService.GetMaterialQuestion(keyboards, materials);
        }
        public IQueryable<QuestionBase<string>> GetColorQuestion(IQueryable<Keyboard> keyboards, string[] colors)
        {
            return _computerAccessoriesQuestionsService.GetColorQuestion(keyboards, colors);
        }
        public IQueryable<QuestionBase<string>> GetPriceQuestion(IQueryable<Keyboard> keyboards)
        {
            return _computerAccessoriesQuestionsService.GetPriceQuestion(keyboards);
        }
        public IQueryable<QuestionBase<string>> GetTypeQuestion(IQueryable<Keyboard> keyboards, string[] types)
        {
            return keyboards
                        .Select(g => g.TypeValue)
                        .GroupBy(p => p)
                        .Select(p => new { Count = p.Count(), Value = Convert.ToString(p.Key) })
                        .Select(type => new QuestionBase<string>()
                        {
                            QuestionsKey = "keyboardType",
                            AfterBox = (types != null && types.Contains(type.Value)) ? (int?)null : type.Count,
                            Checked = types != null && types.Contains(type.Value),
                            ControlType = ControlType.Checkbox,
                            Key = type.Value,
                            Label = type.Value,
                            Required = false,
                            Type = InputType.Checkbox,
                        });
        }
    }
}
