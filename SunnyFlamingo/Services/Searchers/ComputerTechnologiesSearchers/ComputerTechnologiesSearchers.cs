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
    public class ComputerTechnologiesSearchers : IComputerTechnologiesSearchers
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly IComputerTechnologiesQuestionsService _questionsService;
        public ComputerTechnologiesSearchers(ApplicationDbContext context, IMapper mapper, IComputerTechnologiesQuestionsService questionsService)
        {
            _context = context;
            _mapper = mapper;
            _questionsService = questionsService;
        }
        public async Task<GoodsInformation<string>> SearchComputerTechnologies(ComputerTechnologiesSelector computerTechnologiesSelector)
        {
            var computerTechnologies = _context.ComputerTechnology.AsQueryable();
            return new GoodsInformation<string>()
            {
                GoodCells = await GetGoodCells(computerTechnologiesSelector),

                Questions = !computerTechnologiesSelector.GoodsSelector.GetQuestions 
                ? null : await _questionsService.GetComputerTechnologiesQuestions(
                    computerTechnologies, computerTechnologiesSelector)
            };
        }
        private async Task<List<GoodCellModel>> GetGoodCells(ComputerTechnologiesSelector computerTechnologiesSelector)
        {
            var goodsSelector = computerTechnologiesSelector.GoodsSelector;
            return await _context.ComputerTechnology
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
