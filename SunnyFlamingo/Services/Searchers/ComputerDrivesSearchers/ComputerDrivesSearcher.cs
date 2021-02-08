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
    public class ComputerDrivesSearcher : IComputerDrivesSearcher
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly IComputerDrivesQuestionsService _questionsService;
        public ComputerDrivesSearcher(ApplicationDbContext context, IMapper mapper, IComputerDrivesQuestionsService questionsService)
        {
            _context = context;
            _mapper = mapper;
            _questionsService = questionsService;
        }
        public async Task<GoodsInformation<string>> SearchComputerDrives(ComputerDrivesSelector computerDrivesSelector)
        {
            var computerDrives = _context.ComputerDrives.AsQueryable();
            return new GoodsInformation<string>()
            {
                GoodCells = await GetGoodCells(computerDrivesSelector),

                Questions = !computerDrivesSelector.ComputerPartsSelector.ComputerTechnologiesSelector.GoodsSelector.GetQuestions
                ? null : await _questionsService.GetComputerDrivesQuestions(computerDrives, computerDrivesSelector)
            };
        }
        private async Task<List<GoodCellModel>> GetGoodCells(ComputerDrivesSelector computerDrivesSelector)
        {
            var goodsSelector = computerDrivesSelector.ComputerPartsSelector.ComputerTechnologiesSelector.GoodsSelector;
            return await _context.ComputerDrives
                .Where(g => (goodsSelector.PriceFrom == null || g.Price >= goodsSelector.PriceFrom)
                && (goodsSelector.PriceTo == null || g.Price <= goodsSelector.PriceTo))
                .Where(g => goodsSelector.Producers == null || goodsSelector.Producers.Contains(g.Producer.Name))
                .Where(g => goodsSelector.Countries == null || goodsSelector.Countries.Contains(g.Manufacturer.Country.Value))
                .Where(g => goodsSelector.Materials == null || goodsSelector.Materials.Contains(g.MaterialValue))
                .Where(g => goodsSelector.Colors == null || goodsSelector.Colors.Contains(g.ColorValue))

                .Where(g => computerDrivesSelector.Capacities == null || computerDrivesSelector.Capacities.Contains(g.Capacity))
                .Where(g => computerDrivesSelector.Types == null || computerDrivesSelector.Types.Contains(g.TypeValue))
                .Where(g => computerDrivesSelector.FormFactorTypes == null || computerDrivesSelector.FormFactorTypes.Contains(g.FormFactorTypeValue))
                .Skip(goodsSelector.From)
                .Take(goodsSelector.To)
                .ProjectTo<GoodCellModel>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }
    }
}
