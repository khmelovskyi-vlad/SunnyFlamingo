using Microsoft.EntityFrameworkCore;
using SunnyFlamingo.Data;
using SunnyFlamingo.Entities;
using SunnyFlamingo.Entities.Goods;
using SunnyFlamingo.Entities.Goods.ComputerTechnologies;
using SunnyFlamingo.Models;
using SunnyFlamingo.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Searchers
{
    public class GoodsQuestionsService: IGoodsQuestionsService
    {
        private readonly ApplicationDbContext _context;
        public GoodsQuestionsService(ApplicationDbContext context)
        {
            _context = context;
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


        private IQueryable<Good> GetProducerGoods(
            IQueryable<Good> goods,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            decimal? from,
            decimal? to)
        {
            if (colors == null && countries == null && materials == null && from == null && to == null)
            {
                return goods;
            }
            return goods
                .Where(g => (producers != null && producers.Contains(g.Producer.Name)) ||
                (((from == null || g.Price >= from) && (to == null || g.Price <= to))
                && ((producers == null && countries == null && materials == null)
                || (countries != null && countries.Contains(g.Manufacturer.Country.Value))
                || (materials != null && materials.Contains(g.MaterialValue))
                || (colors != null && colors.Contains(g.ColorValue))))
                );
        }
        private IQueryable<Good> GetCountryGoods(
            IQueryable<Good> goods,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            decimal? from,
            decimal? to)
        {
            if (producers == null && colors == null && materials == null && from == null && to == null)
            {
                return goods;
            }
            return goods
                .Where(g => (countries != null && countries.Contains(g.Manufacturer.Country.Value)) ||
                (((from == null || g.Price >= from) && (to == null || g.Price <= to))
                && ((producers == null && materials == null && colors == null)
                || (producers != null && producers.Contains(g.Producer.Name))
                || (materials != null && materials.Contains(g.MaterialValue))
                || (colors != null && colors.Contains(g.ColorValue))))
                );
        }
        private IQueryable<Good> GetMaterialGoods(
            IQueryable<Good> goods,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            decimal? from,
            decimal? to)
        {
            if (producers == null && countries == null && colors == null && from == null && to == null)
            {
                return goods;
            }
            return goods
                .Where(g => (materials != null && materials.Contains(g.MaterialValue)) ||
                (((from == null || g.Price >= from) && (to == null || g.Price <= to))
                && ((producers == null && countries == null && colors == null)
                || (producers != null && producers.Contains(g.Producer.Name))
                || (countries != null && countries.Contains(g.Manufacturer.Country.Value))
                || (colors != null && colors.Contains(g.ColorValue))))
                );
        }
        private IQueryable<Good> GetColorGoods(
            IQueryable<Good> goods,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            decimal? from,
            decimal? to)
        {
            if (producers == null && countries == null && materials == null && from == null && to == null)
            {
                return goods;
            }
            return goods
                .Where(g => (colors != null && colors.Contains(g.ColorValue)) ||
                (((from == null || g.Price >= from) && (to == null || g.Price <= to))
                && ((producers == null && countries == null && materials == null)
                || (producers != null && producers.Contains(g.Producer.Name))
                || (countries != null && countries.Contains(g.Manufacturer.Country.Value))
                || (materials != null && materials.Contains(g.MaterialValue))))
                );
        }
        private IQueryable<Good> GetPriceGoods(
            IQueryable<Good> goods,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            decimal? from,
            decimal? to)
        {
            if (producers == null && countries == null && materials == null && colors == null)
            {
                return goods;
            }
            return goods
                .Where(g => (producers != null && producers.Contains(g.Producer.Name))
                || (countries != null && countries.Contains(g.Manufacturer.Country.Value))
                || (materials != null && materials.Contains(g.MaterialValue)
                || (colors != null && colors.Contains(g.ColorValue)))
                );
        }




        private async Task<QuestionsBase<string>> GetPriceQuestion(IQueryable<Good> goods, decimal? selectedFrom, decimal? selectedTo)
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
        private async Task<QuestionsBase<string>> GetProducerQuestion(IQueryable<Good> goods, string[] producers)
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
        private async Task<QuestionsBase<string>> GetCountryQuestion(IQueryable<Good> goods, string[] countries)
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
        private async Task<QuestionsBase<string>> GetMaterialQuestion(IQueryable<Good> goods, string[] materials)
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
        private async Task<QuestionsBase<string>> GetColorQuestion(IQueryable<Good> goods, string[] colors)
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
    }
}
