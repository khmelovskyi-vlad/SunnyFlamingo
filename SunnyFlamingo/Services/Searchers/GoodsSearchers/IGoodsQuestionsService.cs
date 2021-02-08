using SunnyFlamingo.Entities;
using SunnyFlamingo.Entities.Goods;
using SunnyFlamingo.Entities.Goods.ComputerTechnologies;
using SunnyFlamingo.Models;
using SunnyFlamingo.Models.Selectors;
using SunnyFlamingo.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Searchers
{
    public interface IGoodsQuestionsService
    {
        Task<List<QuestionsBase<string>>> GetGoodsQuestions(IQueryable<Good> goods,
            GoodsSelector goodsSelector);
        IQueryable<T> GetProducerGoods<T>(
            IQueryable<T> goods,
            GoodsSelector goodsSelector) where T : Good;

        IQueryable<T> GetCountryGoods<T>(
            IQueryable<T> goods,
            GoodsSelector goodsSelector) where T : Good;

        IQueryable<T> GetMaterialGoods<T>(
            IQueryable<T> goods,
            GoodsSelector goodsSelector) where T : Good;
        IQueryable<T> GetColorGoods<T>(
            IQueryable<T> goods,
            GoodsSelector goodsSelector) where T : Good;
        IQueryable<T> GetPriceGoods<T>(
            IQueryable<T> goods,
            GoodsSelector goodsSelector) where T : Good;

        IQueryable<QuestionBase<string>> GetPriceQuestion(IQueryable<Good> goods);
        IQueryable<QuestionBase<string>> GetProducerQuestion(IQueryable<Good> goods, string[] producers);
        IQueryable<QuestionBase<string>> GetCountryQuestion(IQueryable<Good> goods, string[] countries);
        IQueryable<QuestionBase<string>> GetMaterialQuestion(IQueryable<Good> goods, string[] materials);
        IQueryable<QuestionBase<string>> GetColorQuestion(IQueryable<Good> goods, string[] colors);
    }
}
