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
                            AfterBox = producer.Count.ToString(),
                            Checked = false,
                            ControlType = ControlType.Checkbox,
                            Key = producer.Value,
                            Label = producer.Value,
                            Required = false,
                            Type = InputType.Checkbox,
                            //Order = i
                        }).ToList()
                    }
                }
                ));
        }
    }
}
