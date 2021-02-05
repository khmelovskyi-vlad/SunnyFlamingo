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
    public interface IGoodsQuestionsService
    {
        Task<List<QuestionsBase<string>>> GetGoodsQuestions(IQueryable<Good> goods,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            decimal? priceFrom,
            decimal? priceTo);
        IQueryable<T> GetProducerGoods<T>(
            IQueryable<T> goods,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            decimal? from,
            decimal? to) where T : Good;

        IQueryable<T> GetCountryGoods<T>(
            IQueryable<T> goods,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            decimal? from,
            decimal? to) where T : Good;

        IQueryable<T> GetMaterialGoods<T>(
            IQueryable<T> goods,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            decimal? from,
            decimal? to) where T : Good;
        IQueryable<T> GetColorGoods<T>(
            IQueryable<T> goods,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            decimal? from,
            decimal? to) where T : Good;
        IQueryable<T> GetPriceGoods<T>(
            IQueryable<T> goods,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            decimal? from,
            decimal? to) where T : Good;

        Task<QuestionsBase<string>> GetPriceQuestion(IQueryable<Good> goods, decimal? selectedFrom, decimal? selectedTo);
        Task<QuestionsBase<string>> GetProducerQuestion(IQueryable<Good> goods, string[] producers);
        Task<QuestionsBase<string>> GetCountryQuestion(IQueryable<Good> goods, string[] countries);
        Task<QuestionsBase<string>> GetMaterialQuestion(IQueryable<Good> goods, string[] materials);
        Task<QuestionsBase<string>> GetColorQuestion(IQueryable<Good> goods, string[] colors);
    }
}
