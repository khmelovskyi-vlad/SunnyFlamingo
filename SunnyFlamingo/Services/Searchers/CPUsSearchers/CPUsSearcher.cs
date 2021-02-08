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
    public class CPUsSearcher : ICPUsSearcher
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly ICPUsQuestionsService _questionsService;
        public CPUsSearcher(ApplicationDbContext context, IMapper mapper, ICPUsQuestionsService questionsService)
        {
            _context = context;
            _mapper = mapper;
            _questionsService = questionsService;
        }
        public async Task<GoodsInformation<string>> SearchCPUs(CPUsSelector CPUsSelector)
        {
            var CPUs = _context.CPUs.AsQueryable();
            return new GoodsInformation<string>()
            {
                GoodCells = await GetGoodCells(CPUsSelector),

                Questions = !CPUsSelector.ComputerPartsSelector.ComputerTechnologiesSelector.GoodsSelector.GetQuestions
                ? null : await _questionsService.GetCPUsQuestions(CPUs, CPUsSelector)
            };
        }
        private async Task<List<GoodCellModel>> GetGoodCells(CPUsSelector CPUsSelector)
        {
            var goodsSelector = CPUsSelector.ComputerPartsSelector.ComputerTechnologiesSelector.GoodsSelector;
            return await _context.CPUs
                .Where(g => (goodsSelector.PriceFrom == null || g.Price >= goodsSelector.PriceFrom)
                && (goodsSelector.PriceTo == null || g.Price <= goodsSelector.PriceTo))
                .Where(g => goodsSelector.Producers == null || goodsSelector.Producers.Contains(g.Producer.Name))
                .Where(g => goodsSelector.Countries == null || goodsSelector.Countries.Contains(g.Manufacturer.Country.Value))
                .Where(g => goodsSelector.Materials == null || goodsSelector.Materials.Contains(g.MaterialValue))
                .Where(g => goodsSelector.Colors == null || goodsSelector.Colors.Contains(g.ColorValue))

                .Where(g => CPUsSelector.CPUSocketTypes == null || CPUsSelector.CPUSocketTypes.Contains(g.CPUSocketTypeValue))
                .Where(g => CPUsSelector.ThermalDesignPowers == null || CPUsSelector.ThermalDesignPowers.Contains(g.ThermalDesignPower))
                .Where(g => CPUsSelector.NumberOfCores == null || CPUsSelector.NumberOfCores.Contains(g.NumberOfCores))
                .Where(g => CPUsSelector.NumberOfThreads == null || CPUsSelector.NumberOfThreads.Contains(g.NumberOfThreads))
                .Skip(goodsSelector.From)
                .Take(goodsSelector.To)
                .ProjectTo<GoodCellModel>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }
    }
}
