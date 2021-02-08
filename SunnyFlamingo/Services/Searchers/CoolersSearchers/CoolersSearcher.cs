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
    public class CoolersSearcher : ICoolersSearcher
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly ICoolersQuestionsService _questionsService;
        public CoolersSearcher(ApplicationDbContext context, IMapper mapper, ICoolersQuestionsService questionsService)
        {
            _context = context;
            _mapper = mapper;
            _questionsService = questionsService;
        }
        public async Task<GoodsInformation<string>> SearchCoolers(CoolersSelector coolersSelector)
        {
            var coolers = _context.Coolers.AsQueryable();
            return new GoodsInformation<string>()
            {
                GoodCells = await GetGoodCells(coolersSelector),

                Questions = !coolersSelector.ComputerPartsSelector.ComputerTechnologiesSelector.GoodsSelector.GetQuestions
                ? null : await _questionsService.GetCoolersQuestions(coolers, coolersSelector)
            };
        }
        private async Task<List<GoodCellModel>> GetGoodCells(CoolersSelector coolersSelector)
        {
            var goodsSelector = coolersSelector.ComputerPartsSelector.ComputerTechnologiesSelector.GoodsSelector;
            return await _context.Coolers
                .Where(g => (goodsSelector.PriceFrom == null || g.Price >= goodsSelector.PriceFrom)
                && (goodsSelector.PriceTo == null || g.Price <= goodsSelector.PriceTo))
                .Where(g => goodsSelector.Producers == null || goodsSelector.Producers.Contains(g.Producer.Name))
                .Where(g => goodsSelector.Countries == null || goodsSelector.Countries.Contains(g.Manufacturer.Country.Value))
                .Where(g => goodsSelector.Materials == null || goodsSelector.Materials.Contains(g.MaterialValue))
                .Where(g => goodsSelector.Colors == null || goodsSelector.Colors.Contains(g.ColorValue))

                .Where(g => coolersSelector.Types == null || coolersSelector.Types.Contains(g.TypeValue))
                .Where(g => coolersSelector.FanSizes == null || coolersSelector.FanSizes.Contains(g.FanSize))
                .Skip(goodsSelector.From)
                .Take(goodsSelector.To)
                .ProjectTo<GoodCellModel>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }
    }
}
