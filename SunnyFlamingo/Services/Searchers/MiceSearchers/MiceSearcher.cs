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
    public class MiceSearcher : IMiceSearcher
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly IMiceQuestionsService _questionsService;
        public MiceSearcher(ApplicationDbContext context, IMapper mapper, IMiceQuestionsService questionsService)
        {
            _context = context;
            _mapper = mapper;
            _questionsService = questionsService;
        }
        public async Task<GoodsInformation<string>> SearchMice(MiceSelector miceSelector)
        {
            var mice = _context.Mice.AsQueryable();
            return new GoodsInformation<string>()
            {
                GoodCells = await GetGoodCells(miceSelector),

                Questions = !miceSelector.ComputerAccessoriesSelector.ComputerTechnologiesSelector.GoodsSelector.GetQuestions
                ? null : await _questionsService.GetMiceQuestions(mice, miceSelector)
            };
        }
        private async Task<List<GoodCellModel>> GetGoodCells(MiceSelector miceSelector)
        {
            var goodsSelector = miceSelector.ComputerAccessoriesSelector.ComputerTechnologiesSelector.GoodsSelector;
            return await _context.Mice
                .Where(g => (goodsSelector.PriceFrom == null || g.Price >= goodsSelector.PriceFrom)
                && (goodsSelector.PriceTo == null || g.Price <= goodsSelector.PriceTo))
                .Where(g => goodsSelector.Producers == null || goodsSelector.Producers.Contains(g.Producer.Name))
                .Where(g => goodsSelector.Countries == null || goodsSelector.Countries.Contains(g.Manufacturer.Country.Value))
                .Where(g => goodsSelector.Materials == null || goodsSelector.Materials.Contains(g.MaterialValue))
                .Where(g => goodsSelector.Colors == null || goodsSelector.Colors.Contains(g.ColorValue))

                .Where(g => miceSelector.Types == null || miceSelector.Types.Contains(g.TypeValue))
                .Where(g => miceSelector.ButtonsCount == null || miceSelector.ButtonsCount.Contains(g.ButtonsCount))
                .Skip(goodsSelector.From)
                .Take(goodsSelector.To)
                .ProjectTo<GoodCellModel>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }
    }
}
