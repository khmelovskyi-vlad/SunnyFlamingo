using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SunnyFlamingo.Data;
using SunnyFlamingo.Entities;
using SunnyFlamingo.Entities.Goods;
using SunnyFlamingo.Entities.Goods.ComputerTechnologies;
using SunnyFlamingo.Models;
using SunnyFlamingo.Models.Selectors;
using SunnyFlamingo.ValueObjects;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Searchers
{
    public class GoodsQuestionsService : IGoodsQuestionsService
    {
        private readonly IQuestionsGrouper _questionsGrouper;
        public GoodsQuestionsService(IQuestionsGrouper questionsGrouper)
        {
            _questionsGrouper = questionsGrouper;
        }

        public async Task<List<QuestionsBase<string>>> GetGoodsQuestions(
            IQueryable<Good> goods,
            GoodsSelector goodsSelector)
        {
            var result = await GetQuestionList(goods, goodsSelector);
            return new List<QuestionsBase<string>>()
            {
                _questionsGrouper.GroupProducers(result),
                _questionsGrouper.GroupCountries(result),
                _questionsGrouper.GroupMaterials(result),
                _questionsGrouper.GroupColors(result),
                _questionsGrouper.GroupPrices(result, goodsSelector.PriceFrom, goodsSelector.PriceTo),
            };
        }
        private async Task<List<QuestionBase<string>>> GetQuestionList(
            IQueryable<Good> goods,
            GoodsSelector goodsSelector)
        {
            var producerQuestions = GetProducerQuestion(GetProducerGoods(goods, goodsSelector), goodsSelector.Producers);
            var countryQuestions = GetCountryQuestion(GetCountryGoods(goods, goodsSelector), goodsSelector.Countries);
            var materialQuestions = GetMaterialQuestion(GetMaterialGoods(goods, goodsSelector), goodsSelector.Materials);
            var colorQuestions = GetColorQuestion(GetColorGoods(goods, goodsSelector), goodsSelector.Colors);
            var priceQuestions = GetPriceQuestion(GetPriceGoods(goods, goodsSelector));

            var group = producerQuestions.Union(countryQuestions).Union(materialQuestions).Union(colorQuestions).Union(priceQuestions);
            return await group.ToListAsync();
        }


        public IQueryable<T> GetProducerGoods<T>(
            IQueryable<T> goods,
            GoodsSelector goodsSelector) where T : Good
        {
            return goods
                .Where(g => (goodsSelector.Producers != null && goodsSelector.Producers.Contains(g.Producer.Name)) ||
                ((goodsSelector.PriceFrom == null || g.Price >= goodsSelector.PriceFrom) 
                && (goodsSelector.PriceTo == null || g.Price <= goodsSelector.PriceTo)
                && (goodsSelector.Countries == null || goodsSelector.Countries.Contains(g.Manufacturer.Country.Value))
                && (goodsSelector.Materials == null || goodsSelector.Materials.Contains(g.MaterialValue))
                && (goodsSelector.Colors == null || goodsSelector.Colors.Contains(g.ColorValue)))
                );
        }
        public IQueryable<T> GetCountryGoods<T>(
            IQueryable<T> goods,
            GoodsSelector goodsSelector) where T : Good
        {
            return goods
                .Where(g => (goodsSelector.Countries != null && goodsSelector.Countries.Contains(g.Manufacturer.Country.Value)) ||
                ((goodsSelector.PriceFrom == null || g.Price >= goodsSelector.PriceFrom) 
                && (goodsSelector.PriceTo == null || g.Price <= goodsSelector.PriceTo)
                && (goodsSelector.Producers == null || goodsSelector.Producers.Contains(g.Producer.Name))
                && (goodsSelector.Materials == null || goodsSelector.Materials.Contains(g.MaterialValue))
                & (goodsSelector.Colors == null || goodsSelector.Colors.Contains(g.ColorValue)))
                );
        }
        public IQueryable<T> GetMaterialGoods<T>(
            IQueryable<T> goods,
            GoodsSelector goodsSelector) where T : Good
        {
            return goods
                .Where(g => (goodsSelector.Materials != null && goodsSelector.Materials.Contains(g.MaterialValue)) ||
                ((goodsSelector.PriceFrom == null || g.Price >= goodsSelector.PriceFrom) 
                && (goodsSelector.PriceTo == null || g.Price <= goodsSelector.PriceTo)
                && (goodsSelector.Producers == null || goodsSelector.Producers.Contains(g.Producer.Name))
                && (goodsSelector.Countries == null || goodsSelector.Countries.Contains(g.Manufacturer.Country.Value))
                && (goodsSelector.Colors == null || goodsSelector.Colors.Contains(g.ColorValue)))
                );
        }
        public IQueryable<T> GetColorGoods<T>(
            IQueryable<T> goods,
            GoodsSelector goodsSelector) where T : Good
        {
            return goods
                .Where(g => (goodsSelector.Colors != null && goodsSelector.Colors.Contains(g.ColorValue)) ||
                ((goodsSelector.PriceFrom == null || g.Price >= goodsSelector.PriceFrom) 
                && (goodsSelector.PriceTo == null || g.Price <= goodsSelector.PriceTo)
                && (goodsSelector.Producers == null || goodsSelector.Producers.Contains(g.Producer.Name))
                && (goodsSelector.Countries == null || goodsSelector.Countries.Contains(g.Manufacturer.Country.Value))
                && (goodsSelector.Materials == null || goodsSelector.Materials.Contains(g.MaterialValue)))
                );
        }
        public IQueryable<T> GetPriceGoods<T>(
            IQueryable<T> goods,
            GoodsSelector goodsSelector) where T : Good
        {
            return goods
                .Where(g => (goodsSelector.Producers == null || goodsSelector.Producers.Contains(g.Producer.Name))
                && (goodsSelector.Countries == null || goodsSelector.Countries.Contains(g.Manufacturer.Country.Value))
                && (goodsSelector.Materials == null || goodsSelector.Materials.Contains(g.MaterialValue)
                && (goodsSelector.Colors == null || goodsSelector.Colors.Contains(g.ColorValue)))
                );
        }

        public IQueryable<QuestionBase<string>> GetProducerQuestion(IQueryable<Good> goods, string[] producers)
        {
            return goods
                        .Select(g => g.Producer.Name)
                        .GroupBy(p => p)
                        .Select(p => new { Count = p.Count(), Value = Convert.ToString(p.Key) })
                        .Select(producer => new QuestionBase<string>()
                        {
                            QuestionsKey = "producer",
                            AfterBox = (producers != null && producers.Contains(producer.Value)) ? (int?)null : producer.Count,
                            Checked = producers != null && producers.Contains(producer.Value),
                            ControlType = ControlType.Checkbox,
                            Key = producer.Value,
                            Label = producer.Value,
                            Required = false,
                            Type = InputType.Checkbox
                        });
        }
        public IQueryable<QuestionBase<string>> GetCountryQuestion(IQueryable<Good> goods, string[] countries)
        {
            return goods
                        .Select(g => g.Manufacturer.Country.Value)
                        .GroupBy(c => c)
                        .Select(c => new { Count = c.Count(), Value = Convert.ToString(c.Key) })
                        .Select(country => new QuestionBase<string>()
                        {
                            QuestionsKey = "country",
                            AfterBox = (countries != null && countries.Contains(country.Value)) ? (int?)null : country.Count,
                            Checked = countries != null && countries.Contains(country.Value),
                            ControlType = ControlType.Checkbox,
                            Key = country.Value,
                            Label = country.Value,
                            Required = false,
                            Type = InputType.Checkbox,
                        });
        }
        public IQueryable<QuestionBase<string>> GetMaterialQuestion(IQueryable<Good> goods, string[] materials)
        {
            return goods
                        .Select(g => g.Material.Value)
                        .GroupBy(c => c)
                        .Select(c => new { Count = c.Count(), Value = Convert.ToString(c.Key) })
                        .Select(material => new QuestionBase<string>()
                        {
                            QuestionsKey = "material",
                            AfterBox = (materials != null && materials.Contains(material.Value)) ? (int?)null : material.Count,
                            Checked = materials != null && materials.Contains(material.Value),
                            ControlType = ControlType.Checkbox,
                            Key = material.Value,
                            Label = material.Value,
                            Required = false,
                            Type = InputType.Checkbox,
                        });
        }
        public IQueryable<QuestionBase<string>> GetColorQuestion(IQueryable<Good> goods, string[] colors)
        {
            return goods
                        .Select(g => g.Color.Value)
                        .GroupBy(c => c)
                        .Select(c => new { Count = c.Count(), Value = Convert.ToString(c.Key) })
                        .Select(color => new QuestionBase<string>()
                        {
                            QuestionsKey = "color",
                            AfterBox = (colors != null && colors.Contains(color.Value)) ? (int?)null : color.Count,
                            Checked = colors != null && colors.Contains(color.Value),
                            ControlType = ControlType.Checkbox,
                            Key = color.Value,
                            Label = color.Value,
                            Required = false,
                            Type = InputType.Checkbox,
                        });
        }
        public IQueryable<QuestionBase<string>> GetPriceQuestion(IQueryable<Good> goods)
        {
            var max = goods
                .Select(g => g.Price)
                .OrderByDescending(p => p)
                .Take(1)
                .Select(price => new QuestionBase<string>()
                {
                    QuestionsKey = "price",
                    AfterBox = null,
                    Checked = null,
                    ControlType = ControlType.RangeSlider,
                    Key = "maxPrice",
                    Label = Convert.ToString(price),
                    Required = false,
                    Type = InputType.Checkbox,
                });
            var min = goods
                .Select(g => g.Price)
                .OrderBy(p => p)
                .Take(1)
                .Select(price => new QuestionBase<string>()
                {
                    QuestionsKey = "price",
                    AfterBox = null,
                    Checked = null,
                    ControlType = ControlType.RangeSlider,
                    Key = "minPrice",
                    Label = Convert.ToString(price),
                    Required = false,
                    Type = InputType.Checkbox,
                });
            var result = min.Union(max);
            return result;
        }
    }
}
