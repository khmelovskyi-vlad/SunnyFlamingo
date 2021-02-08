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
    public class HeadphonesQuestionsService : IHeadphonesQuestionsService
    {
        private readonly IComputerAccessoriesQuestionsService _computerAccessoriesQuestionsService;
        private readonly IQuestionsGrouper _questionsGrouper;
        public HeadphonesQuestionsService(
            IComputerAccessoriesQuestionsService computerAccessoriesQuestionsService,
            IQuestionsGrouper questionsGrouper)
        {
            _computerAccessoriesQuestionsService = computerAccessoriesQuestionsService;
            _questionsGrouper = questionsGrouper;
        }
        public async Task<List<QuestionsBase<string>>> GetHeadphonesQuestions(
            IQueryable<Headphones> headphones,
            HeadphonesSelector headphonesSelector)
        {
            var goodsSelector = headphonesSelector.ComputerAccessoriesSelector.ComputerTechnologiesSelector.GoodsSelector;
            var result = await GetQuestionList(headphones, headphonesSelector);
            return new List<QuestionsBase<string>>()
            {
                _questionsGrouper.GroupProducers(result),
                _questionsGrouper.GroupCountries(result),
                _questionsGrouper.GroupMaterials(result),
                _questionsGrouper.GroupColors(result),
                _questionsGrouper.GroupPrices(result, goodsSelector.PriceFrom, goodsSelector.PriceTo),

                _questionsGrouper.GroupHeadphonesTypes(result),
                _questionsGrouper.GroupWirelessTypes(result),
                _questionsGrouper.GroupConnectorTypes(result),

            };
        }
        private async Task<List<QuestionBase<string>>> GetQuestionList(
            IQueryable<Headphones> headphones,
            HeadphonesSelector headphonesSelector)
        {
            var goodsSelector = headphonesSelector.ComputerAccessoriesSelector.ComputerTechnologiesSelector.GoodsSelector;
            var producerQuestions = GetProducerQuestion(GetProducerHeadphones(headphones, headphonesSelector), goodsSelector.Producers);
            var countryQuestions = GetCountryQuestion(GetCountryHeadphones(headphones, headphonesSelector), goodsSelector.Countries);
            var materialQuestions = GetMaterialQuestion(GetMaterialHeadphones(headphones, headphonesSelector), goodsSelector.Materials);
            var colorQuestions = GetColorQuestion(GetColorHeadphones(headphones, headphonesSelector), goodsSelector.Colors);
            var priceQuestions = GetPriceQuestion(GetPriceHeadphones(headphones, headphonesSelector));


            var typeQuestions = GetTypeQuestion(GetTypeHeadphones(headphones, headphonesSelector), headphonesSelector.Types);
            var wirelessTypeQuestions = GetWirelessTypeQuestion(GetWirelessTypeHeadphones(headphones, headphonesSelector), headphonesSelector.WirelessTypes);
            var connectorTypeQuestions = GetConnectorTypeQuestion(GetConnectorTypeHeadphones(headphones, headphonesSelector), headphonesSelector.ConnectorTypes);



            var group = producerQuestions.Union(countryQuestions).Union(materialQuestions).Union(colorQuestions).Union(priceQuestions)
                .Union(typeQuestions).Union(wirelessTypeQuestions).Union(connectorTypeQuestions);

            return await group.ToListAsync();
        }
        public IQueryable<T> GetProducerHeadphones<T>(
            IQueryable<T> headphones,
            HeadphonesSelector headphonesSelector) where T : Headphones
        {
            var goodsSelector = headphonesSelector.ComputerAccessoriesSelector.ComputerTechnologiesSelector.GoodsSelector;
            var computerAccessoriesSelector = headphonesSelector.ComputerAccessoriesSelector;
            return _computerAccessoriesQuestionsService.GetProducerComputerAccessories(
                headphones, computerAccessoriesSelector)
                .Where(l => (goodsSelector.Producers != null && goodsSelector.Producers.Contains(l.Producer.Name)) ||
                ((headphonesSelector.Types == null || headphonesSelector.Types.Contains(l.TypeValue))
                && (headphonesSelector.WirelessTypes == null || headphonesSelector.WirelessTypes.Contains(l.WirelessTypeValue))
                && (headphonesSelector.ConnectorTypes == null || headphonesSelector.ConnectorTypes.Contains(l.ConnectorTypeValue))));
        }
        public IQueryable<T> GetCountryHeadphones<T>(
            IQueryable<T> headphones,
            HeadphonesSelector headphonesSelector) where T : Headphones
        {
            var goodsSelector = headphonesSelector.ComputerAccessoriesSelector.ComputerTechnologiesSelector.GoodsSelector;
            var computerAccessoriesSelector = headphonesSelector.ComputerAccessoriesSelector;
            return _computerAccessoriesQuestionsService.GetCountryComputerAccessories(
                headphones, computerAccessoriesSelector)
                .Where(l => (goodsSelector.Countries != null && goodsSelector.Countries.Contains(l.Manufacturer.Country.Value)) ||
                ((headphonesSelector.Types == null || headphonesSelector.Types.Contains(l.TypeValue))
                && (headphonesSelector.WirelessTypes == null || headphonesSelector.WirelessTypes.Contains(l.WirelessTypeValue))
                && (headphonesSelector.ConnectorTypes == null || headphonesSelector.ConnectorTypes.Contains(l.ConnectorTypeValue))));
        }
        public IQueryable<T> GetMaterialHeadphones<T>(
            IQueryable<T> headphones,
            HeadphonesSelector headphonesSelector) where T : Headphones
        {
            var goodsSelector = headphonesSelector.ComputerAccessoriesSelector.ComputerTechnologiesSelector.GoodsSelector;
            var computerAccessoriesSelector = headphonesSelector.ComputerAccessoriesSelector;
            return _computerAccessoriesQuestionsService.GetMaterialComputerAccessories(
                headphones, computerAccessoriesSelector)
                .Where(l => (goodsSelector.Materials != null && goodsSelector.Materials.Contains(l.Material.Value)) ||
                ((headphonesSelector.Types == null || headphonesSelector.Types.Contains(l.TypeValue))
                && (headphonesSelector.WirelessTypes == null || headphonesSelector.WirelessTypes.Contains(l.WirelessTypeValue))
                && (headphonesSelector.ConnectorTypes == null || headphonesSelector.ConnectorTypes.Contains(l.ConnectorTypeValue))));
        }
        public IQueryable<T> GetColorHeadphones<T>(
            IQueryable<T> headphones,
            HeadphonesSelector headphonesSelector) where T : Headphones
        {
            var goodsSelector = headphonesSelector.ComputerAccessoriesSelector.ComputerTechnologiesSelector.GoodsSelector;
            var computerAccessoriesSelector = headphonesSelector.ComputerAccessoriesSelector;
            return _computerAccessoriesQuestionsService.GetColorComputerAccessories(
                headphones, computerAccessoriesSelector)
                .Where(l => (goodsSelector.Colors != null && goodsSelector.Colors.Contains(l.Color.Value)) ||
                ((headphonesSelector.Types == null || headphonesSelector.Types.Contains(l.TypeValue))
                && (headphonesSelector.WirelessTypes == null || headphonesSelector.WirelessTypes.Contains(l.WirelessTypeValue))
                && (headphonesSelector.ConnectorTypes == null || headphonesSelector.ConnectorTypes.Contains(l.ConnectorTypeValue))));
        }
        public IQueryable<T> GetPriceHeadphones<T>(
            IQueryable<T> headphones,
            HeadphonesSelector headphonesSelector) where T : Headphones
        {
            var goodsSelector = headphonesSelector.ComputerAccessoriesSelector.ComputerTechnologiesSelector.GoodsSelector;
            var computerAccessoriesSelector = headphonesSelector.ComputerAccessoriesSelector;
            return _computerAccessoriesQuestionsService.GetPriceComputerAccessories(
                headphones, computerAccessoriesSelector)
                .Where(l => 
                (headphonesSelector.Types == null || headphonesSelector.Types.Contains(l.TypeValue))
                && (headphonesSelector.WirelessTypes == null || headphonesSelector.WirelessTypes.Contains(l.WirelessTypeValue))
                && (headphonesSelector.ConnectorTypes == null || headphonesSelector.ConnectorTypes.Contains(l.ConnectorTypeValue)));
        }
        public IQueryable<T> GetConnectorTypeHeadphones<T>(
            IQueryable<T> headphones,
            HeadphonesSelector headphonesSelector) where T : Headphones
        {
            var goodsSelector = headphonesSelector.ComputerAccessoriesSelector.ComputerTechnologiesSelector.GoodsSelector;
            return headphones
                .Where(l => (headphonesSelector.ConnectorTypes != null && headphonesSelector.ConnectorTypes.Contains(l.ConnectorTypeValue)) ||
                ((goodsSelector.PriceFrom == null || l.Price >= goodsSelector.PriceFrom)
                && (goodsSelector.PriceTo == null || l.Price <= goodsSelector.PriceTo)
                && (headphonesSelector.Types == null || headphonesSelector.Types.Contains(l.TypeValue))
                && (headphonesSelector.WirelessTypes == null || headphonesSelector.WirelessTypes.Contains(l.WirelessTypeValue))
                && (goodsSelector.Producers == null || goodsSelector.Producers.Contains(l.Producer.Name))
                && (goodsSelector.Countries == null || goodsSelector.Countries.Contains(l.Manufacturer.Country.Value))
                && (goodsSelector.Materials == null || goodsSelector.Materials.Contains(l.MaterialValue))
                && (goodsSelector.Colors == null || goodsSelector.Colors.Contains(l.ColorValue))));
        }
        public IQueryable<T> GetTypeHeadphones<T>(
            IQueryable<T> headphones,
            HeadphonesSelector headphonesSelector) where T : Headphones
        {
            var goodsSelector = headphonesSelector.ComputerAccessoriesSelector.ComputerTechnologiesSelector.GoodsSelector;
            return headphones
                .Where(l => (headphonesSelector.Types != null && headphonesSelector.Types.Contains(l.TypeValue)) ||
                ((goodsSelector.PriceFrom == null || l.Price >= goodsSelector.PriceFrom)
                && (goodsSelector.PriceTo == null || l.Price <= goodsSelector.PriceTo)
                && (headphonesSelector.ConnectorTypes == null || headphonesSelector.ConnectorTypes.Contains(l.ConnectorTypeValue))
                && (headphonesSelector.WirelessTypes == null || headphonesSelector.WirelessTypes.Contains(l.WirelessTypeValue))
                && (goodsSelector.Producers == null || goodsSelector.Producers.Contains(l.Producer.Name))
                && (goodsSelector.Countries == null || goodsSelector.Countries.Contains(l.Manufacturer.Country.Value))
                && (goodsSelector.Materials == null || goodsSelector.Materials.Contains(l.MaterialValue))
                && (goodsSelector.Colors == null || goodsSelector.Colors.Contains(l.ColorValue))));
        }
        public IQueryable<T> GetWirelessTypeHeadphones<T>(
            IQueryable<T> headphones,
            HeadphonesSelector headphonesSelector) where T : Headphones
        {
            var goodsSelector = headphonesSelector.ComputerAccessoriesSelector.ComputerTechnologiesSelector.GoodsSelector;
            return headphones
                .Where(l => (headphonesSelector.WirelessTypes != null && headphonesSelector.WirelessTypes.Contains(l.WirelessTypeValue)) ||
                ((goodsSelector.PriceFrom == null || l.Price >= goodsSelector.PriceFrom)
                && (goodsSelector.PriceTo == null || l.Price <= goodsSelector.PriceTo)
                && (headphonesSelector.ConnectorTypes == null || headphonesSelector.ConnectorTypes.Contains(l.ConnectorTypeValue))
                && (headphonesSelector.Types == null || headphonesSelector.Types.Contains(l.TypeValue))
                && (goodsSelector.Producers == null || goodsSelector.Producers.Contains(l.Producer.Name))
                && (goodsSelector.Countries == null || goodsSelector.Countries.Contains(l.Manufacturer.Country.Value))
                && (goodsSelector.Materials == null || goodsSelector.Materials.Contains(l.MaterialValue))
                && (goodsSelector.Colors == null || goodsSelector.Colors.Contains(l.ColorValue))));
        }



        public IQueryable<QuestionBase<string>> GetProducerQuestion(IQueryable<Headphones> headphones, string[] producers)
        {
            return _computerAccessoriesQuestionsService.GetProducerQuestion(headphones, producers);
        }
        public IQueryable<QuestionBase<string>> GetCountryQuestion(IQueryable<Headphones> headphones, string[] countries)
        {
            return _computerAccessoriesQuestionsService.GetCountryQuestion(headphones, countries);
        }
        public IQueryable<QuestionBase<string>> GetMaterialQuestion(IQueryable<Headphones> headphones, string[] materials)
        {
            return _computerAccessoriesQuestionsService.GetMaterialQuestion(headphones, materials);
        }
        public IQueryable<QuestionBase<string>> GetColorQuestion(IQueryable<Headphones> headphones, string[] colors)
        {
            return _computerAccessoriesQuestionsService.GetColorQuestion(headphones, colors);
        }
        public IQueryable<QuestionBase<string>> GetPriceQuestion(IQueryable<Headphones> headphones)
        {
            return _computerAccessoriesQuestionsService.GetPriceQuestion(headphones);
        }
        public IQueryable<QuestionBase<string>> GetTypeQuestion(IQueryable<Headphones> headphones, string[] types)
        {
            return headphones
                        .Select(g => g.TypeValue)
                        .GroupBy(p => p)
                        .Select(p => new { Count = p.Count(), Value = Convert.ToString(p.Key) })
                        .Select(type => new QuestionBase<string>()
                        {
                            QuestionsKey = "headphonesType",
                            AfterBox = (types != null && types.Contains(type.Value)) ? (int?)null : type.Count,
                            Checked = types != null && types.Contains(type.Value),
                            ControlType = ControlType.Checkbox,
                            Key = type.Value,
                            Label = type.Value,
                            Required = false,
                            Type = InputType.Checkbox,
                        });
        }
        public IQueryable<QuestionBase<string>> GetWirelessTypeQuestion(IQueryable<Headphones> headphones, string[] wirelessTypes)
        {
            return headphones
                        .Select(g => g.WirelessTypeValue)
                        .GroupBy(p => p)
                        .Select(p => new { Count = p.Count(), Value = Convert.ToString(p.Key) })
                        .Select(wirelessType => new QuestionBase<string>()
                        {
                            QuestionsKey = "wirelessType",
                            AfterBox = (wirelessTypes != null && wirelessTypes.Contains(wirelessType.Value)) ? (int?)null : wirelessType.Count,
                            Checked = wirelessTypes != null && wirelessTypes.Contains(wirelessType.Value),
                            ControlType = ControlType.Checkbox,
                            Key = wirelessType.Value,
                            Label = wirelessType.Value,
                            Required = false,
                            Type = InputType.Checkbox,
                        });
        }
        public IQueryable<QuestionBase<string>> GetConnectorTypeQuestion(IQueryable<Headphones> headphones, string[] connectorTypes)
        {
            return headphones
                        .Select(g => g.ConnectorTypeValue)
                        .GroupBy(p => p)
                        .Select(p => new { Count = p.Count(), Value = Convert.ToString(p.Key) })
                        .Select(connectorType => new QuestionBase<string>()
                        {
                            QuestionsKey = "connectorType",
                            AfterBox = (connectorTypes != null && connectorTypes.Contains(connectorType.Value)) ? (int?)null : connectorType.Count,
                            Checked = connectorTypes != null && connectorTypes.Contains(connectorType.Value),
                            ControlType = ControlType.Checkbox,
                            Key = connectorType.Value,
                            Label = connectorType.Value,
                            Required = false,
                            Type = InputType.Checkbox,
                        });
        }
    }
}
