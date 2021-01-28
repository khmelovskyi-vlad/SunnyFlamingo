using AutoMapper;
using SunnyFlamingo.Entities;
using SunnyFlamingo.Models;
using SunnyFlamingo.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Data.Profiles
{
    class Foo
    {
        public int Count { get; set; }
        public string Value { get; set; }
    }
    public class GoodsProfile : Profile
    {
        public GoodsProfile()
        {
            CreateMap<Good, GoodCellModel>()
                .ForMember(p => p.ImgId,
                opt => opt.MapFrom(goods => goods.ImageInfo.FirstOrDefault().Id)
                );
            CreateMap<Goods, GoodsInformation<string>>()
                .ForMember(p => p.Questions,
                opt => opt.MapFrom(goods => new List<QuestionsBase<string>>()
                {
                    new QuestionsBase<string>()
                    {
                        Key = "Producer",
                        Value = "Select producer",
                        Order = 1,
                        QuestionBaseList =
                        goods.GoodList
                        .Select(g => g.Producer.Name)
                        .GroupBy(p => p)
                        .Select(p => new Foo() { Count = p.Count(), Value = p.Key } )
                        .Select(producer => new QuestionBase<string>()
                        {
                            AfterBox = $"({producer.Count})",
                            Checked = false,
                            ControlType = ControlType.Checkbox,
                            Key = producer.Value,
                            Label = producer.Value,
                            Required = false,
                            Type = InputType.Checkbox,
                        }).ToList()
                    },
                    new QuestionsBase<string>()
                    {
                        Key = "Country",
                        Value = "Select country",
                        Order = 2,
                        QuestionBaseList =
                        goods.GoodList
                        .Select(g => g.Manufacturer.Country.Value)
                        .GroupBy(c => c)
                        .Select(c => new Foo() { Count = c.Count(), Value = c.Key } )
                        .Select(country => new QuestionBase<string>()
                        {
                            AfterBox = $"({country.Count})",
                            Checked = false,
                            ControlType = ControlType.Checkbox,
                            Key = country.Value,
                            Label = country.Value,
                            Required = false,
                            Type = InputType.Checkbox,
                        }).ToList()
                    },
                    new QuestionsBase<string>()
                    {
                        Key = "Material",
                        Value = "Select material",
                        Order = 3,
                        QuestionBaseList =
                        goods.GoodList
                        .Select(g => g.MaterialValue)
                        .GroupBy(m => m)
                        .Select(m => new Foo() { Count = m.Count(), Value = m.Key } )
                        .Select(material => new QuestionBase<string>()
                        {
                            AfterBox = $"({material.Count})",
                            Checked = false,
                            ControlType = ControlType.Checkbox,
                            Key = material.Value,
                            Label = material.Value,
                            Required = false,
                            Type = InputType.Checkbox,
                        }).ToList()
                    },
                    new QuestionsBase<string>()
                    {
                        Key = "Color",
                        Value = "Select color",
                        Order = 4,
                        QuestionBaseList =
                        goods.GoodList
                        .Select(g => g.ColorValue)
                        .GroupBy(c => c)
                        .Select(c => new Foo() { Count = c.Count(), Value = c.Key } )
                        .Select(color => new QuestionBase<string>()
                        {
                            AfterBox = $"({color.Count})",
                            Checked = false,
                            ControlType = ControlType.Checkbox,
                            Key = color.Value,
                            Label = color.Value,
                            Required = false,
                            Type = InputType.Checkbox,
                        }).ToList()
                    }
                }
                ));
        }
    }
}
