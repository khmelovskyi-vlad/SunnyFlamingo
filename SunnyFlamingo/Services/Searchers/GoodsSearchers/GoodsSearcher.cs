using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SunnyFlamingo.Data;
using SunnyFlamingo.Entities;
using SunnyFlamingo.Extensions;
using SunnyFlamingo.Models;
using SunnyFlamingo.Models.Selectors;
using SunnyFlamingo.ValueObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Dynamic;
using System.Linq;
using System.Runtime.Remoting;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Searchers
{
    public class GoodsSearcher : IGoodsSearcher
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly IGoodsQuestionsService _questionsService;
        private readonly IParametersCreator _parametersCreator;
        private readonly IGoodsInformationCreator _goodsInformationCreator;
        public GoodsSearcher(ApplicationDbContext context,
            IMapper mapper, 
            IGoodsQuestionsService questionsService, 
            IParametersCreator parametersCreator,
            IGoodsInformationCreator goodsInformationCreator)
        {
            _context = context;
            _mapper = mapper;
            _questionsService = questionsService;
            _parametersCreator = parametersCreator;
            _goodsInformationCreator = goodsInformationCreator;
        }
        //vf
        public async Task<GoodsInformation<string>> SearchGoods(GoodsSelector goodsSelector)
        {
            var goodTypes = AppDomain.CurrentDomain.GetAssemblies()
                       .SelectMany(assembly => assembly.GetTypes())
                       .Where(type => type.IsSubclassOf(typeof(Good)))
                       .ToList();
            var result = await _goodsInformationCreator.CreateGoodsInformation(goodsSelector);
            return result;
            //var goods = _context.Goods.AsQueryable();
            //return new GoodsInformation<string>()
            //{
            //    GoodCells = await GetGoodCells(goodsSelector),

            //    Questions = !goodsSelector.GetQuestions ? null : await _questionsService.GetGoodsQuestions(goods, goodsSelector)
            //};
        }
        private async Task<List<GoodCellModel>> GetGoodCells(GoodsSelector goodsSelector)
        {
            return await _context.Goods
                .Where(g => (goodsSelector.PriceFrom == null || g.Price >= goodsSelector.PriceFrom)
                && (goodsSelector.PriceTo == null || g.Price <= goodsSelector.PriceTo))
                .Where(g => goodsSelector.Producers == null || goodsSelector.Producers.Contains(g.Producer.Name))
                .Where(g => goodsSelector.Countries == null || goodsSelector.Countries.Contains(g.Manufacturer.Country.Value))
                .Where(g => goodsSelector.Materials == null || goodsSelector.Materials.Contains(g.MaterialValue))
                .Where(g => goodsSelector.Colors == null || goodsSelector.Colors.Contains(g.ColorValue))
                .Skip(goodsSelector.From)
                .Take(goodsSelector.To)
                .ProjectTo<GoodCellModel>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }

    }
}
