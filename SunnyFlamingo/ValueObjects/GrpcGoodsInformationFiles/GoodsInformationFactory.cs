using SunnyFlamingo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.ValueObjects.GrpcGoodsInformationFiles
{
    public class GoodsInformationFactory
    {
        public GoodsInformation<string> CreateGoodsInformation(GrpcCacheGoodsInformation cacheGoodsInformation)
        {
            var goodsInformation = new GoodsInformation<string>()
            {
                Count = cacheGoodsInformation.GoodsInformation.Count,
            };
            if (cacheGoodsInformation.GoodsInformation.GoodCells != null)
            {
                var goodCells = new List<GoodCellModel>();
                goodCells.AddRange(cacheGoodsInformation.GoodsInformation.GoodCells.Select(ggc => GetGoodCellModel(ggc)));
                goodsInformation.GoodCells = goodCells;
            }
            if (cacheGoodsInformation.GoodsInformation.Questions != null)
            {
                var questions = new List<QuestionsBase<string>>();
                questions.AddRange(cacheGoodsInformation.GoodsInformation.Questions.Select(gq => GetQuestions(gq)));
                goodsInformation.Questions = questions;
            }
            return goodsInformation;
        }
        private QuestionsBase<string> GetQuestions(GrpcQuestionsBase grpcQuestionsBase)
        {
            var questions = new QuestionsBase<string>()
            {
                Key = grpcQuestionsBase.Key,
                Order = grpcQuestionsBase.Order,
                Value = grpcQuestionsBase.Value
            };
            if (grpcQuestionsBase.QuestionBaseList != null)
            {
                var questionsList = new List<QuestionBase<string>>();
                questionsList.AddRange(grpcQuestionsBase.QuestionBaseList.Select(q => GetQuestion(q)));
                questions.QuestionBaseList = questionsList;
            }
            return questions;
        }
        private QuestionBase<string> GetQuestion(GrpcQuestionBase grpcQuestion)
        {
            var question = new QuestionBase<string>()
            {
                Key = grpcQuestion.Key,
                Order = grpcQuestion.Order,
                Checked = grpcQuestion.Checked,
                AfterBox = grpcQuestion.AfterBox,
                Label = grpcQuestion.Label,
                MethodName = grpcQuestion.MethodName,
                QuestionsKey = grpcQuestion.QuestionsKey,
                Value = grpcQuestion.Value,
                ControlType = (ControlType)grpcQuestion.ControlType,
                Type = (InputType)grpcQuestion.Type,
                Validator = GetQuestionValidator(grpcQuestion.Validator)
            };
            if (grpcQuestion.Options != null)
            {
                var options = new List<QuestionOption>();
                options.AddRange(grpcQuestion.Options.Select(o => GetQuestionOption(o)));
                question.Options = options;
            }
            switch (grpcQuestion.SelectedFromCase)
            {
                case GrpcQuestionBase.SelectedFromOneofCase.SelectedFromInt:
                    question.SelectedFrom = grpcQuestion.SelectedFromInt;
                    break;
                case GrpcQuestionBase.SelectedFromOneofCase.SelectedFromDouble:
                    question.SelectedFrom = grpcQuestion.SelectedFromDouble;
                    break;
                case GrpcQuestionBase.SelectedFromOneofCase.SelectedFromDecimal:
                    question.SelectedFrom = CustomTypes.DecimalValue.GetDecimal(grpcQuestion.SelectedFromDecimal);
                    break;
            }
            switch (grpcQuestion.SelectedToCase)
            {
                case GrpcQuestionBase.SelectedToOneofCase.SelectedToInt:
                    question.SelectedTo = grpcQuestion.SelectedToInt;
                    break;
                case GrpcQuestionBase.SelectedToOneofCase.SelectedToDouble:
                    question.SelectedTo = grpcQuestion.SelectedToDouble;
                    break;
                case GrpcQuestionBase.SelectedToOneofCase.SelectedToDecimal:
                    question.SelectedTo = CustomTypes.DecimalValue.GetDecimal(grpcQuestion.SelectedToDecimal);
                    break;
            }
            switch (grpcQuestion.FromCase)
            {
                case GrpcQuestionBase.FromOneofCase.FromInt:
                    question.From = grpcQuestion.FromInt;
                    break;
                case GrpcQuestionBase.FromOneofCase.FromDouble:
                    question.From = grpcQuestion.FromDouble;
                    break;
                case GrpcQuestionBase.FromOneofCase.FromDecimal:
                    question.From = CustomTypes.DecimalValue.GetDecimal(grpcQuestion.FromDecimal);
                    break;
            }
            switch (grpcQuestion.ToCase)
            {
                case GrpcQuestionBase.ToOneofCase.ToInt:
                    question.To = grpcQuestion.ToInt;
                    break;
                case GrpcQuestionBase.ToOneofCase.ToDouble:
                    question.To = grpcQuestion.ToDouble;
                    break;
                case GrpcQuestionBase.ToOneofCase.ToDecimal:
                    question.To = CustomTypes.DecimalValue.GetDecimal(grpcQuestion.ToDecimal);
                    break;
            }
            return question;
        }
        private QuestionValidator GetQuestionValidator(GrpcQuestionValidator grpcQuestionValidator)
        {
            if (grpcQuestionValidator == null)
            {
                return null;
            }
            return new QuestionValidator()
            {
                Max = grpcQuestionValidator.Max,
                Min = grpcQuestionValidator.Min,
                MaxLength = grpcQuestionValidator.MaxLength,
                MinLength = grpcQuestionValidator.MinLength,
                Required = grpcQuestionValidator.Required
            };
        }
        private QuestionOption GetQuestionOption(GrpcQuestionOption grpcQuestionOption)
        {
            return new QuestionOption()
            {
                Key = grpcQuestionOption.Key,
                Value = grpcQuestionOption.Value
            };
        }
        private GoodCellModel GetGoodCellModel(GrpcGoodCellModel grpcGoodCellModel)
        {
            var goodCellModel = new GoodCellModel()
            {
                Id = Guid.Parse(grpcGoodCellModel.Id),
                Name = grpcGoodCellModel.Name,
                IsAvailable = grpcGoodCellModel.IsAvailable,
                Price = CustomTypes.DecimalValue.GetDecimal(grpcGoodCellModel.Price),
                Type = grpcGoodCellModel.Type
            };
            if (!string.IsNullOrEmpty(grpcGoodCellModel.ImgId))
            {
                goodCellModel.ImgId = Guid.Parse(grpcGoodCellModel.ImgId);
            }
            return goodCellModel;
        }
    }
}
