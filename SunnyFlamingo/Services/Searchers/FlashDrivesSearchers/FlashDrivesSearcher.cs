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
    public class FlashDrivesSearcher : IFlashDrivesSearcher
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly IFlashDrivesQuestionsService _questionsService;
        public FlashDrivesSearcher(ApplicationDbContext context, IMapper mapper, IFlashDrivesQuestionsService questionsService)
        {
            _context = context;
            _mapper = mapper;
            _questionsService = questionsService;
        }
        public async Task<GoodsInformation<string>> SearchFlashDrives(FlashDrivesSelector flashDrivesSelector)
        {
            var flashDrives = _context.FlashDrives.AsQueryable();
            return new GoodsInformation<string>()
            {
                GoodCells = await GetGoodCells(flashDrivesSelector),

                Questions = !flashDrivesSelector.ComputerTechnologiesSelector.GoodsSelector.GetQuestions
                ? null : await _questionsService.GetFlashDrivesQuestions(flashDrives, flashDrivesSelector)
            };
        }
        private async Task<List<GoodCellModel>> GetGoodCells(FlashDrivesSelector flashDrivesSelector)
        {
            var goodsSelector = flashDrivesSelector.ComputerTechnologiesSelector.GoodsSelector;
            return await _context.FlashDrives
                .Where(g => (goodsSelector.PriceFrom == null || g.Price >= goodsSelector.PriceFrom)
                && (goodsSelector.PriceTo == null || g.Price <= goodsSelector.PriceTo))
                .Where(g => goodsSelector.Producers == null || goodsSelector.Producers.Contains(g.Producer.Name))
                .Where(g => goodsSelector.Countries == null || goodsSelector.Countries.Contains(g.Manufacturer.Country.Value))
                .Where(g => goodsSelector.Materials == null || goodsSelector.Materials.Contains(g.MaterialValue))
                .Where(g => goodsSelector.Colors == null || goodsSelector.Colors.Contains(g.ColorValue))

                .Where(g => flashDrivesSelector.Capacities == null || flashDrivesSelector.Capacities.Contains(g.Capacity))
                .Where(g => flashDrivesSelector.USBSpecificationTypes == null || flashDrivesSelector.USBSpecificationTypes.Contains(g.USBSpecificationTypeValue))
                .Skip(goodsSelector.From)
                .Take(goodsSelector.To)
                .ProjectTo<GoodCellModel>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }
    }
}
