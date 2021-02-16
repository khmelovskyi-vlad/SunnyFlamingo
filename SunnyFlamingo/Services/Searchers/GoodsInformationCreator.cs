using Microsoft.Data.SqlClient;
using SunnyFlamingo.Data;
using SunnyFlamingo.Extensions;
using SunnyFlamingo.Models;
using SunnyFlamingo.Models.Selectors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Searchers
{
    public class GoodsInformationCreator : IGoodsInformationCreator
    {
        private readonly ApplicationDbContext _context;
        private readonly IParametersCreator _parametersCreator;
        private readonly IQuestionsCreator _questionsCreator;
        public GoodsInformationCreator(ApplicationDbContext context, IParametersCreator parametersCreator, IQuestionsCreator questionsCreator)
        {
            _context = context;
            _parametersCreator = parametersCreator;
            _questionsCreator = questionsCreator;
        }
        public async Task<GoodsInformation<string>> CreateGoodsInformation(GoodsSelector goodsSelector)
        {
            var normalParameters = _parametersCreator.GetGoodsParameters(goodsSelector);
            var goodsDbInformation = await _context.GetGoodsDbInformation("GetGoods", normalParameters);
            return new GoodsInformation<string>(GetCount(normalParameters), goodsDbInformation.GoodCells, new List<QuestionsBase<string>>() 
            {
                _questionsCreator.GroupProducers(goodsDbInformation.DBQuestions),
                _questionsCreator.GroupCountries(goodsDbInformation.DBQuestions),
                _questionsCreator.GroupMaterials(goodsDbInformation.DBQuestions),
                _questionsCreator.GroupColors(goodsDbInformation.DBQuestions),
                _questionsCreator.GroupPrices(goodsDbInformation.DBQuestions),
            });
        }

        private int GetCount(SqlParameter[] sqlParameters)
        {
            return Convert.ToInt32(sqlParameters.FirstOrDefault(par => par.ParameterName == "@count").Value);
        }


    }
}
