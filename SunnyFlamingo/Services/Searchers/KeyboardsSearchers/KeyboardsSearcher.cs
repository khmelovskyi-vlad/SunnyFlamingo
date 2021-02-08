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
    public class KeyboardsSearcher : IKeyboardsSearcher
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly IKeyboardsQuestionsService _questionsService;
        public KeyboardsSearcher(ApplicationDbContext context, IMapper mapper, IKeyboardsQuestionsService questionsService)
        {
            _context = context;
            _mapper = mapper;
            _questionsService = questionsService;
        }
        public async Task<GoodsInformation<string>> SearchKeyboards(KeyboardsSelector keyboardsSelector)
        {
            var keyboards = _context.Keyboards.AsQueryable();
            return new GoodsInformation<string>()
            {
                GoodCells = await GetGoodCells(keyboardsSelector),

                Questions = !keyboardsSelector.ComputerAccessoriesSelector.ComputerTechnologiesSelector.GoodsSelector.GetQuestions
                ? null : await _questionsService.GetKeyboardsQuestions(keyboards, keyboardsSelector)
            };
        }
        private async Task<List<GoodCellModel>> GetGoodCells(KeyboardsSelector keyboardsSelector)
        {
            var goodsSelector = keyboardsSelector.ComputerAccessoriesSelector.ComputerTechnologiesSelector.GoodsSelector;
            return await _context.Keyboards
                .Where(g => (goodsSelector.PriceFrom == null || g.Price >= goodsSelector.PriceFrom)
                && (goodsSelector.PriceTo == null || g.Price <= goodsSelector.PriceTo))
                .Where(g => goodsSelector.Producers == null || goodsSelector.Producers.Contains(g.Producer.Name))
                .Where(g => goodsSelector.Countries == null || goodsSelector.Countries.Contains(g.Manufacturer.Country.Value))
                .Where(g => goodsSelector.Materials == null || goodsSelector.Materials.Contains(g.MaterialValue))
                .Where(g => goodsSelector.Colors == null || goodsSelector.Colors.Contains(g.ColorValue))

                .Where(g => keyboardsSelector.Types == null || keyboardsSelector.Types.Contains(g.TypeValue))
                .Skip(goodsSelector.From)
                .Take(goodsSelector.To)
                .ProjectTo<GoodCellModel>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }
    }
}
