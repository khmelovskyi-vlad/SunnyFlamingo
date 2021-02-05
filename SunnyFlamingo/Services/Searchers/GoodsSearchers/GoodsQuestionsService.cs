using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SunnyFlamingo.Data;
using SunnyFlamingo.Entities;
using SunnyFlamingo.Entities.Goods;
using SunnyFlamingo.Entities.Goods.ComputerTechnologies;
using SunnyFlamingo.Models;
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


        public IQueryable<T> GetProducerGoods<T>(
            IQueryable<T> goods,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            decimal? from,
            decimal? to) where T : Good
        {
            if (colors == null && countries == null && materials == null && from == null && to == null)
            {
                return goods;
            }
            return goods
                .Where(g => (producers != null && producers.Contains(g.Producer.Name)) ||
                ((from == null || g.Price >= from) && (to == null || g.Price <= to)
                && (countries == null || countries.Contains(g.Manufacturer.Country.Value))
                && (materials == null || materials.Contains(g.MaterialValue))
                && (colors == null || colors.Contains(g.ColorValue)))
                );
        }
        public IQueryable<T> GetCountryGoods<T>(
            IQueryable<T> goods,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            decimal? from,
            decimal? to) where T : Good
        {
            if (producers == null && colors == null && materials == null && from == null && to == null)
            {
                return goods;
            }
            return goods
                .Where(g => (countries != null && countries.Contains(g.Manufacturer.Country.Value)) ||
                ((from == null || g.Price >= from) && (to == null || g.Price <= to)
                && (producers == null || producers.Contains(g.Producer.Name))
                && (materials == null || materials.Contains(g.MaterialValue))
                & (colors == null || colors.Contains(g.ColorValue)))
                );
        }
        public IQueryable<T> GetMaterialGoods<T>(
            IQueryable<T> goods,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            decimal? from,
            decimal? to) where T : Good
        {
            if (producers == null && countries == null && colors == null && from == null && to == null)
            {
                return goods;
            }
            return goods
                .Where(g => (materials != null && materials.Contains(g.MaterialValue)) ||
                ((from == null || g.Price >= from) && (to == null || g.Price <= to)
                && (producers == null || producers.Contains(g.Producer.Name))
                && (countries == null || countries.Contains(g.Manufacturer.Country.Value))
                && (colors == null || colors.Contains(g.ColorValue)))
                );
        }
        public IQueryable<T> GetColorGoods<T>(
            IQueryable<T> goods,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            decimal? from,
            decimal? to) where T : Good
        {
            if (producers == null && countries == null && materials == null && from == null && to == null)
            {
                return goods;
            }
            return goods
                .Where(g => (colors != null && colors.Contains(g.ColorValue)) ||
                ((from == null || g.Price >= from) && (to == null || g.Price <= to)
                && (producers == null || producers.Contains(g.Producer.Name))
                && (countries == null || countries.Contains(g.Manufacturer.Country.Value))
                && (materials == null || materials.Contains(g.MaterialValue)))
                );
        }
        public IQueryable<T> GetPriceGoods<T>(
            IQueryable<T> goods,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            decimal? from,
            decimal? to) where T : Good
        {
            if (producers == null && countries == null && materials == null && colors == null)
            {
                return goods;
            }
            return goods
                .Where(g => (producers == null || producers.Contains(g.Producer.Name))
                && (countries == null || countries.Contains(g.Manufacturer.Country.Value))
                && (materials == null || materials.Contains(g.MaterialValue)
                && (colors == null || colors.Contains(g.ColorValue)))
                );
        }





        public async Task<List<QuestionBase<string>>> GetQuestionList(
            IQueryable<Good> goods,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            decimal? priceFrom,
            decimal? priceTo)
        {
            var producerQuestions = GetProducerQuestion2(GetProducerGoods(goods, producers, countries, materials, colors, priceFrom, priceTo), producers);
            var countryQuestions = GetCountryQuestion2(GetCountryGoods(goods, producers, countries, materials, colors, priceFrom, priceTo), countries);
            var materialQuestions = GetMaterialQuestion2(GetMaterialGoods(goods, producers, countries, materials, colors, priceFrom, priceTo), materials);
            var colorQuestions = GetColorQuestion2(GetColorGoods(goods, producers, countries, materials, colors, priceFrom, priceTo), colors);
            var priceQuestions = GetPriceQuestion2(GetPriceGoods(goods, producers, countries, materials, colors, priceFrom, priceTo));

            var group = producerQuestions.Union(countryQuestions).Union(materialQuestions).Union(colorQuestions).Union(priceQuestions);
            return await group.ToListAsync();
        }

        public async Task<List<QuestionsBase<string>>> GetGoodsQuestions2(
            IQueryable<Good> goods,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            decimal? priceFrom,
            decimal? priceTo)
        {
            var result = await GetQuestionList(goods, producers, countries, materials, colors, priceFrom, priceTo);
            return new List<QuestionsBase<string>>()
            {
                _questionsGrouper.GroupProducers(result),
                _questionsGrouper.GroupCountries(result),
                _questionsGrouper.GroupMaterials(result),
                _questionsGrouper.GroupColors(result),
                _questionsGrouper.GroupPrices(result, priceFrom, priceTo),
            };
        }
        private IQueryable<QuestionBase<string>> GetProducerQuestion2(IQueryable<Good> goods, string[] producers)
        {
            return goods
                        .Select(g => g.Producer.Name)
                        .GroupBy(p => p)
                        .Select(p => new { Count = p.Count(), Value = Convert.ToString(p.Key) })
                        .Select(producer => new QuestionBase<string>()
                        {
                            QuestionsKey = "producer",
                            AfterBox2 = producer.Count,
                            Checked = producers != null && producers.Contains(producer.Value),
                            ControlType = ControlType.Checkbox,
                            Key = producer.Value,
                            Label = producer.Value,
                            Required = false,
                            Type = InputType.Checkbox
                        });
        }
        private IQueryable<QuestionBase<string>> GetCountryQuestion2(IQueryable<Good> goods, string[] countries)
        {
            return goods
                        .Select(g => g.Manufacturer.Country.Value)
                        .GroupBy(c => c)
                        .Select(c => new { Count = c.Count(), Value = Convert.ToString(c.Key) })
                        .Select(country => new QuestionBase<string>()
                        {
                            QuestionsKey = "country",
                            AfterBox2 = country.Count,
                            Checked = countries != null && countries.Contains(country.Value),
                            ControlType = ControlType.Checkbox,
                            Key = country.Value,
                            Label = country.Value,
                            Required = false,
                            Type = InputType.Checkbox,
                        });
        }
        private IQueryable<QuestionBase<string>> GetMaterialQuestion2(IQueryable<Good> goods, string[] materials)
        {
            return goods
                        .Select(g => g.Material.Value)
                        .GroupBy(c => c)
                        .Select(c => new { Count = c.Count(), Value = Convert.ToString(c.Key) })
                        .Select(country => new QuestionBase<string>()
                        {
                            QuestionsKey = "material",
                            AfterBox2 = country.Count,
                            Checked = materials != null && materials.Contains(country.Value),
                            ControlType = ControlType.Checkbox,
                            Key = country.Value,
                            Label = country.Value,
                            Required = false,
                            Type = InputType.Checkbox,
                        });
        }
        private IQueryable<QuestionBase<string>> GetColorQuestion2(IQueryable<Good> goods, string[] colors)
        {
            return goods
                        .Select(g => g.Color.Value)
                        .GroupBy(c => c)
                        .Select(c => new { Count = c.Count(), Value = Convert.ToString(c.Key) })
                        .Select(color => new QuestionBase<string>()
                        {
                            QuestionsKey = "color",
                            AfterBox2 = color.Count,
                            Checked = colors != null && colors.Contains(color.Value),
                            ControlType = ControlType.Checkbox,
                            Key = color.Value,
                            Label = color.Value,
                            Required = false,
                            Type = InputType.Checkbox,
                        });
        }
        public IQueryable<QuestionBase<string>> GetPriceQuestion2(IQueryable<Good> goods)
        {
            var max = goods
                .Select(g => g.Price)
                .OrderByDescending(p => p)
                .Take(1)
                .Select(price => new QuestionBase<string>()
                {
                    QuestionsKey = "price",
                    AfterBox2 = null,
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
                    AfterBox2 = null,
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


















        public async Task<QuestionsBase<string>> GetPriceQuestion(IQueryable<Good> goods, decimal? selectedFrom, decimal? selectedTo)
        {
            var min = await goods.Select(good => good.Price).MinAsync();
            var max = await goods.Select(good => good.Price).MaxAsync();
            //var minDecimal = decimal.MinValue;
            //var maxDecimal = decimal.MaxValue;
            //var maxAndMin = goods
            //            .Select(g => g.Price)
            //            .Aggregate(new
            //            {
            //                Min = maxDecimal,
            //                Max = minDecimal
            //            }, (accumulator, o) => new
            //            {
            //                Min = o < accumulator.Min ? o : accumulator.Min,
            //                Max = o > accumulator.Max ? o : accumulator.Max
            //            });
            return new QuestionsBase<string>()
            {
                Key = "price",
                Value = "Select price",
                Order = 1,
                QuestionBaseList = new List<QuestionBase<string>>()
                {
                    new QuestionBase<string>()
                        {
                            ControlType = ControlType.RangeSlider,
                            From = min,
                            To = max,
                            SelectedFrom = selectedFrom == null ? min : selectedFrom,
                            SelectedTo = selectedTo == null ? max : selectedTo,
                            Required = false,
                            Type = InputType.Checkbox,
                        }
                }
            };
        }
        public async Task<QuestionsBase<string>> GetProducerQuestion(IQueryable<Good> goods, string[] producers)
        {
            return new QuestionsBase<string>()
            {
                Key = "producer",
                Value = "Select producer",
                Order = 1,
                QuestionBaseList = await goods
                        .Select(g => g.Producer.Name)
                        .GroupBy(p => p)
                        .Select(p => new { Count = p.Count(), Value = p.Key })
                        .Select(producer => new QuestionBase<string>()
                        {
                            AfterBox = $"({producer.Count})",
                            Checked = producers != null && producers.Contains(producer.Value),
                            ControlType = ControlType.Checkbox,
                            Key = producer.Value,
                            Label = producer.Value,
                            Required = false,
                            Type = InputType.Checkbox,
                        }).ToListAsync()
            };
        }
        public async Task<QuestionsBase<string>> GetCountryQuestion(IQueryable<Good> goods, string[] countries)
        {
            return new QuestionsBase<string>()
            {
                Key = "country",
                Value = "Select country",
                Order = 2,
                QuestionBaseList = await goods
                        .Select(g => g.Manufacturer.Country.Value)
                        .GroupBy(c => c)
                        .Select(c => new { Count = c.Count(), Value = c.Key })
                        .Select(country => new QuestionBase<string>()
                        {
                            AfterBox = $"({country.Count})",
                            Checked = countries != null && countries.Contains(country.Value),
                            ControlType = ControlType.Checkbox,
                            Key = country.Value,
                            Label = country.Value,
                            Required = false,
                            Type = InputType.Checkbox,
                        }).ToListAsync()
            };
        }
        public async Task<QuestionsBase<string>> GetMaterialQuestion(IQueryable<Good> goods, string[] materials)
        {
            return new QuestionsBase<string>()
            {
                Key = "material",
                Value = "Select material",
                Order = 3,
                QuestionBaseList = await goods
                        .Select(g => g.MaterialValue)
                        .GroupBy(m => m)
                        .Select(m => new { Count = m.Count(), Value = m.Key })
                        .Select(material => new QuestionBase<string>()
                        {
                            AfterBox = $"({material.Count})",
                            Checked = materials != null && materials.Contains(material.Value),
                            ControlType = ControlType.Checkbox,
                            Key = material.Value,
                            Label = material.Value,
                            Required = false,
                            Type = InputType.Checkbox,
                        }).ToListAsync()
            };
        }
        public async Task<QuestionsBase<string>> GetColorQuestion(IQueryable<Good> goods, string[] colors)
        {
            return new QuestionsBase<string>()
            {
                Key = "color",
                Value = "Select color",
                Order = 4,
                QuestionBaseList = await goods
                        .Select(g => g.ColorValue)
                        .GroupBy(c => c)
                        .Select(c => new { Count = c.Count(), Value = c.Key })
                        .Select(color => new QuestionBase<string>()
                        {
                            AfterBox = $"({color.Count})",
                            Checked = colors != null && colors.Contains(color.Value),
                            ControlType = ControlType.Checkbox,
                            Key = color.Value,
                            Label = color.Value,
                            Required = false,
                            Type = InputType.Checkbox,
                        }).ToListAsync()
            };
        }
        public async Task<List<QuestionsBase<string>>> GetGoodsQuestions(
            IQueryable<Good> goods,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            decimal? priceFrom,
            decimal? priceTo)
        {
            return new List<QuestionsBase<string>>()
                {
                    await GetProducerQuestion(GetProducerGoods(goods, producers, countries, materials, colors, priceFrom, priceTo), producers),
                    await GetCountryQuestion(GetCountryGoods(goods, producers, countries, materials, colors, priceFrom, priceTo), countries),
                    await GetMaterialQuestion(GetMaterialGoods(goods, producers, countries, materials, colors, priceFrom, priceTo), materials),
                    await GetColorQuestion(GetColorGoods(goods, producers, countries, materials, colors, priceFrom, priceTo), colors),
                    await GetPriceQuestion(GetPriceGoods(goods, producers, countries, materials, colors, priceFrom, priceTo), priceFrom, priceTo)
                };
        }
    }
}
