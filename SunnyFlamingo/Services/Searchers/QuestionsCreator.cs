using SunnyFlamingo.Models;
using SunnyFlamingo.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Searchers
{
    public class QuestionsCreator : IQuestionsCreator
    {
        public QuestionsBase<string> GroupProducers(List<DBQuestionBase> dBQuestions)
        {
            var questions = dBQuestions.Where(el => el.QuestionsKey == "producer")
                .Select(question => new QuestionBase<string>(question)
                {
                    Required = false,
                    ControlType = ControlType.Checkbox,
                    Type = InputType.Checkbox
                }).ToList();
            return new QuestionsBase<string>()
            {
                Key = "producer",
                Value = "Select producer",
                Order = 1,
                QuestionBaseList = questions
            };
        }
        public QuestionsBase<string> GroupCountries(List<DBQuestionBase> dBQuestions)
        {
            var questions = dBQuestions.Where(el => el.QuestionsKey == "country")
                .Select(question => new QuestionBase<string>(question)
                {
                    Required = false,
                    ControlType = ControlType.Checkbox,
                    Type = InputType.Checkbox
                }).ToList();
            return new QuestionsBase<string>()
            {
                Key = "country",
                Value = "Select country",
                Order = 2,
                QuestionBaseList = questions.ToList()
            };
        }
        public QuestionsBase<string> GroupMaterials(List<DBQuestionBase> dBQuestions)
        {
            var questions = dBQuestions.Where(el => el.QuestionsKey == "material")
                .Select(question => new QuestionBase<string>(question)
                {
                    Required = false,
                    ControlType = ControlType.Checkbox,
                    Type = InputType.Checkbox
                }).ToList();
            return new QuestionsBase<string>()
            {
                Key = "material",
                Value = "Select material",
                Order = 3,
                QuestionBaseList = questions.ToList()
            };
        }
        public QuestionsBase<string> GroupColors(List<DBQuestionBase> dBQuestions)
        {
            var questions = dBQuestions.Where(el => el.QuestionsKey == "color")
                .Select(question => new QuestionBase<string>(question)
                {
                    Required = false,
                    ControlType = ControlType.Checkbox,
                    Type = InputType.Checkbox
                }).ToList();
            return new QuestionsBase<string>()
            {
                Key = "color",
                Value = "Select color",
                Order = 4,
                QuestionBaseList = questions.ToList()
            };
        }
        public QuestionsBase<string> GroupPrices(List<DBQuestionBase> dBQuestions)
        {
            var questions = dBQuestions.Where(el => el.QuestionsKey == "price")
                .Select(question => new QuestionBase<string>(question)
                {
                    Required = false,
                    ControlType = ControlType.RangeSlider,
                    Key = "price"
                }).ToList();
            return new QuestionsBase<string>()
            {
                Key = "price",
                Value = "Select price",
                Order = 5,
                QuestionBaseList = questions
            };
        }
    }
}
