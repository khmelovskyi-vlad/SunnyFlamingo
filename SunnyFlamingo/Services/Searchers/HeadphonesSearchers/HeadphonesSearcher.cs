using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using SunnyFlamingo.Data;
using SunnyFlamingo.Models;
using SunnyFlamingo.Models.Selectors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Searchers
{
    public class HeadphonesSearcher : IHeadphonesSearcher
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly IHeadphonesQuestionsService _questionsService;
        public HeadphonesSearcher(ApplicationDbContext context, IMapper mapper, IHeadphonesQuestionsService questionsService)
        {
            _context = context;
            _mapper = mapper;
            _questionsService = questionsService;
        }
        public async Task<GoodsInformation<string>> SearchHeadphones(HeadphonesSelector headphonesSelector)
        {
            var headphones = _context.Headphones.AsQueryable();
            return new GoodsInformation<string>()
            {
                GoodCells = await GetGoodCells(headphonesSelector),

                Questions = !headphonesSelector.ComputerAccessoriesSelector.ComputerTechnologiesSelector.GoodsSelector.GetQuestions
                ? null : await _questionsService.GetHeadphonesQuestions(headphones, headphonesSelector)
            };
        }
        private async Task<List<GoodCellModel>> GetGoodCells(HeadphonesSelector headphonesSelector)
        {
            var goodsSelector = headphonesSelector.ComputerAccessoriesSelector.ComputerTechnologiesSelector.GoodsSelector;
            return await _context.Headphones
                .Where(g => (goodsSelector.PriceFrom == null || g.Price >= goodsSelector.PriceFrom)
                && (goodsSelector.PriceTo == null || g.Price <= goodsSelector.PriceTo))
                .Where(g => goodsSelector.Producers == null || goodsSelector.Producers.Contains(g.Producer.Name))
                .Where(g => goodsSelector.Countries == null || goodsSelector.Countries.Contains(g.Manufacturer.Country.Value))
                .Where(g => goodsSelector.Materials == null || goodsSelector.Materials.Contains(g.MaterialValue))
                .Where(g => goodsSelector.Colors == null || goodsSelector.Colors.Contains(g.ColorValue))

                .Where(g => headphonesSelector.Types == null || headphonesSelector.Types.Contains(g.TypeValue))
                .Where(g => headphonesSelector.WirelessTypes == null || headphonesSelector.WirelessTypes.Contains(g.WirelessTypeValue))
                .Where(g => headphonesSelector.ConnectorTypes == null || headphonesSelector.ConnectorTypes.Contains(g.ConnectorTypeValue))
                .Skip(goodsSelector.From)
                .Take(goodsSelector.To)
                .ProjectTo<GoodCellModel>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }
    }
}
