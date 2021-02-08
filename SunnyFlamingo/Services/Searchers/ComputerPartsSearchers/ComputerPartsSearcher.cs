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
    public class ComputerPartsSearcher : IComputerPartsSearcher
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly IComputerPartsQuestionsService _questionsService;
        public ComputerPartsSearcher(ApplicationDbContext context, IMapper mapper, IComputerPartsQuestionsService questionsService)
        {
            _context = context;
            _mapper = mapper;
            _questionsService = questionsService;
        }
        public async Task<GoodsInformation<string>> SearchComputerParts(ComputerPartsSelector computerPartsSelector)
        {
            var computerParts = _context.ComputerParts.AsQueryable();
            return new GoodsInformation<string>()
            {
                GoodCells = await GetGoodCells(computerPartsSelector),

                Questions = !computerPartsSelector.ComputerTechnologiesSelector.GoodsSelector.GetQuestions
                ? null : await _questionsService.GetComputerPartsQuestions(
                    computerParts, computerPartsSelector)
            };
        }
        private async Task<List<GoodCellModel>> GetGoodCells(ComputerPartsSelector computerPartsSelector)
        {
            var goodsSelector = computerPartsSelector.ComputerTechnologiesSelector.GoodsSelector;
            return await _context.ComputerParts
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
