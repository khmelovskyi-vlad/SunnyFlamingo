using SunnyFlamingo.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Searchers
{
    public class QuestionsGrouper : IQuestionsGrouper
    {
        public QuestionsBase<string> GroupProducers(List<QuestionBase<string>> questions)
        {
            return new QuestionsBase<string>()
            {
                Key = "producer",
                Value = "Select producer",
                Order = 1,
                QuestionBaseList = questions.Where(el => el.QuestionsKey == "producer").ToList()
            };
        }
        public QuestionsBase<string> GroupCountries(List<QuestionBase<string>> questions)
        {
            return new QuestionsBase<string>()
            {
                Key = "country",
                Value = "Select country",
                Order = 2,
                QuestionBaseList = questions.Where(el => el.QuestionsKey == "country").ToList()
            };
        }
        public QuestionsBase<string> GroupMaterials(List<QuestionBase<string>> questions)
        {
            return new QuestionsBase<string>()
            {
                Key = "material",
                Value = "Select material",
                Order = 3,
                QuestionBaseList = questions.Where(el => el.QuestionsKey == "material").ToList()
            };
        }
        public QuestionsBase<string> GroupColors(List<QuestionBase<string>> questions)
        {
            return new QuestionsBase<string>()
            {
                Key = "color",
                Value = "Select color",
                Order = 4,
                QuestionBaseList = questions.Where(el => el.QuestionsKey == "color").ToList()
            };
        }
        public QuestionsBase<string> GroupPrices(List<QuestionBase<string>> questions, decimal? priceFrom, decimal? priceTo)
        {
            return new QuestionsBase<string>()
            {
                Key = "price",
                Value = "Select price",
                Order = 5,
                QuestionBaseList = questions.Where(el => el.QuestionsKey == "price")
                .GroupBy(q => q.QuestionsKey)
                .Select(q => new QuestionBase<string>()
                {
                    ControlType = q.First().ControlType,
                    From = Convert.ToDecimal(q.First(el => el.Key == "minPrice").Label, new CultureInfo("en-US")),
                    To = Convert.ToDecimal(q.First(el => el.Key == "maxPrice").Label, new CultureInfo("en-US")),
                    SelectedFrom = priceFrom == null ? Convert.ToDecimal(q.First(el => el.Key == "minPrice").Label, new CultureInfo("en-US")) : priceFrom,
                    SelectedTo = priceTo == null ? Convert.ToDecimal(q.First(el => el.Key == "maxPrice").Label, new CultureInfo("en-US")) : priceTo,
                    Required = false,
                }).ToList()
            };
        }
    }
}
