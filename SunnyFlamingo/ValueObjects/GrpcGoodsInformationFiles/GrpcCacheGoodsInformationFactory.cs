using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;
using SunnyFlamingo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.ValueObjects.GrpcGoodsInformationFiles
{
    public class GrpcCacheGoodsInformationFactory
    {
        public GrpcCacheGoodsInformation CreateGrpcCacheGoodsInformation(string key, GoodsInformation<string> goodsInformation)
        {
            var cacheGoodsInformation = new GrpcCacheGoodsInformation()
            {
                Key = new Key() { Key_ = key },
                GoodsInformation = new GrpcGoodsInformation()
                {
                    Count = goodsInformation.Count,
                }
            };
            if (goodsInformation.GoodCells != null)
            {
                cacheGoodsInformation.GoodsInformation.GoodCells.AddRange(goodsInformation.GoodCells.Select(gc => GetGrpcGoodCellModel(gc)));
            }
            if (goodsInformation.Questions != null)
            {
                cacheGoodsInformation.GoodsInformation.Questions.AddRange(goodsInformation.Questions.Select(q => GetGrpcQuestions(q)));
            }
            return cacheGoodsInformation;
        }
        private GrpcQuestionsBase GetGrpcQuestions(QuestionsBase<string> questions)
        {
            var grpcQuestionsBase = new GrpcQuestionsBase()
            {
                Key = questions.Key,
                Order = questions.Order,
                Value = questions.Value
            };
            if (questions.QuestionBaseList != null)
            {
                grpcQuestionsBase.QuestionBaseList.AddRange(questions.QuestionBaseList.Select(q => GetGrpcQuestion(q)));
            }
            return grpcQuestionsBase;
        }
        private GrpcQuestionBase GetGrpcQuestion(QuestionBase<string> question)
        {
            var grpcQuestionsBase = new GrpcQuestionBase()
            {
                Key = question.Key ?? "",
                Order = question.Order,
                Checked = question.Checked,
                AfterBox = question.AfterBox,
                Label = question.Label ?? "",
                MethodName = question.MethodName ?? "",
                QuestionsKey = question.QuestionsKey ?? "",
                Value = question.Value ?? "",
                ControlType = (GrpcControlType)question.ControlType,
                Type = (GrpcInputType)question.Type,
                Validator = GetGrpcQuestionValidator(question.Validator)
            };
            if (question.Options != null)
            {
                grpcQuestionsBase.Options.AddRange(question.Options.Select(o => GetGrpcQuestionOption(o)));
            }
            if (question.SelectedFrom != null)
            {
                if (question.SelectedFrom.GetType() == typeof(int))
                {
                    grpcQuestionsBase.SelectedFromInt = (int)question.SelectedFrom;
                }
                else if (question.SelectedFrom.GetType() == typeof(double))
                {
                    grpcQuestionsBase.SelectedFromDouble = (double)question.SelectedFrom;
                }
                else if (question.SelectedFrom.GetType() == typeof(decimal))
                {
                    CustomTypes.DecimalValue selectedFrom = (decimal)question.SelectedFrom;
                    grpcQuestionsBase.SelectedFromDecimal = new DecimalValue() { Nanos = selectedFrom.Nanos, Units = selectedFrom.Units };
                }
            }
            if (question.SelectedTo != null)
            {
                if (question.SelectedTo.GetType() == typeof(int))
                {
                    grpcQuestionsBase.SelectedToInt = (int)question.SelectedTo;
                }
                else if (question.SelectedTo.GetType() == typeof(double))
                {
                    grpcQuestionsBase.SelectedToDouble = (double)question.SelectedTo;
                }
                else if (question.SelectedTo.GetType() == typeof(decimal))
                {
                    CustomTypes.DecimalValue selectedTo = (decimal)question.SelectedTo;
                    grpcQuestionsBase.SelectedToDecimal = new DecimalValue() { Nanos = selectedTo.Nanos, Units = selectedTo.Units };
                }
            }
            if (question.From != null)
            {
                if (question.From.GetType() == typeof(int))
                {
                    grpcQuestionsBase.FromInt = (int)question.From;
                }
                else if (question.From.GetType() == typeof(double))
                {
                    grpcQuestionsBase.FromDouble = (double)question.From;
                }
                else if (question.From.GetType() == typeof(decimal))
                {
                    CustomTypes.DecimalValue from = (decimal)question.From;
                    grpcQuestionsBase.FromDecimal = new DecimalValue() { Nanos = from.Nanos, Units = from.Units };
                }
            }
            if (question.To != null)
            {
                if (question.To.GetType() == typeof(int))
                {
                    grpcQuestionsBase.ToInt = (int)question.To;
                }
                else if (question.To.GetType() == typeof(double))
                {
                    grpcQuestionsBase.ToDouble = (double)question.To;
                }
                else if (question.To.GetType() == typeof(decimal))
                {
                    CustomTypes.DecimalValue to = (decimal)question.To;
                    grpcQuestionsBase.ToDecimal = new DecimalValue() { Nanos = to.Nanos, Units = to.Units };
                }
            }
            return grpcQuestionsBase;
        }
        private GrpcQuestionValidator GetGrpcQuestionValidator(QuestionValidator questionValidator)
        {
            if (questionValidator == null)
            {
                return null;
            }
            return new GrpcQuestionValidator()
            {
                Max = questionValidator.Max,
                Min = questionValidator.Min,
                MaxLength = questionValidator.MaxLength,
                MinLength = questionValidator.MinLength,
                Required = questionValidator.Required
            };
        }
        private GrpcQuestionOption GetGrpcQuestionOption(QuestionOption questionOption)
        {
            return new GrpcQuestionOption()
            {
                Key = questionOption.Key,
                Value = questionOption.Value
            };
        }
        private GrpcGoodCellModel GetGrpcGoodCellModel(GoodCellModel goodCellModel)
        {
            CustomTypes.DecimalValue price = goodCellModel.Price;
            var grpcGoodCellModel = new GrpcGoodCellModel()
            {
                Id = goodCellModel.Id.ToString(),
                Name = goodCellModel.Name,
                IsAvailable = goodCellModel.IsAvailable,
                Price = new DecimalValue() { Nanos = price.Nanos, Units = price.Units },
                Type = goodCellModel.Type
            };
            if (goodCellModel.ImgId != null)
            {
                grpcGoodCellModel.ImgId = goodCellModel.ImgId.ToString();
            }
            return grpcGoodCellModel;
        }
    }
}
