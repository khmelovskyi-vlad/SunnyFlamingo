using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using SunnyFlamingo.Data;
using SunnyFlamingo.Models;
using SunnyFlamingo.Models.Selectors;
using SunnyFlamingo.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Searchers
{
    public class LaptopsSearcher : ILaptopsSearcher
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly ILaptopsQuestionsService _questionsService;
        public LaptopsSearcher(ApplicationDbContext context, IMapper mapper, ILaptopsQuestionsService questionsService)
        {
            _context = context;
            _mapper = mapper;
            _questionsService = questionsService;
        }
        public async Task<GoodsInformation<string>> SearchLaptops(LaptopsSelector laptopsSelector)
        {
            var laptops = _context.Laptops.AsQueryable();
            return new GoodsInformation<string>()
            {
                GoodCells = await GetGoodCells(laptopsSelector),

                Questions = !laptopsSelector.ComputerTechnologiesSelector.GoodsSelector.GetQuestions
                ? null : await _questionsService.GetLaptopsQuestions(laptops, laptopsSelector)
            };
        }
        private async Task<List<GoodCellModel>> GetGoodCells(LaptopsSelector laptopsSelector)
        {
            var goodsSelector = laptopsSelector.ComputerTechnologiesSelector.GoodsSelector;
            return await _context.Laptops
                .Where(g => (goodsSelector.PriceFrom == null || g.Price >= goodsSelector.PriceFrom)
                && (goodsSelector.PriceTo == null || g.Price <= goodsSelector.PriceTo))
                .Where(g => goodsSelector.Producers == null || goodsSelector.Producers.Contains(g.Producer.Name))
                .Where(g => goodsSelector.Countries == null || goodsSelector.Countries.Contains(g.Manufacturer.Country.Value))
                .Where(g => goodsSelector.Materials == null || goodsSelector.Materials.Contains(g.MaterialValue))
                .Where(g => goodsSelector.Colors == null || goodsSelector.Colors.Contains(g.ColorValue))

                .Where(g => laptopsSelector.AmountOfRAMs == null || laptopsSelector.AmountOfRAMs.Contains(g.AmountOfRAM))
                .Where(g => laptopsSelector.CPUFrequencies == null || laptopsSelector.CPUFrequencies.Contains(g.CPUFrequency))
                .Where(g => laptopsSelector.Length == null || laptopsSelector.Length.Contains(g.Length))
                .Where(g => laptopsSelector.Height == null || laptopsSelector.Height.Contains(g.Height))
                .Where(g => laptopsSelector.Width == null || laptopsSelector.Width.Contains(g.Width))
                .Where(g => laptopsSelector.HaveFloppyDrives == null || laptopsSelector.HaveFloppyDrives.Contains(g.HaveFloppyDrives))
                .Where(g => laptopsSelector.SSDMemory == null || laptopsSelector.SSDMemory.Contains(g.SSDMemory))
                .Where(g => laptopsSelector.HardDiskMemory == null || laptopsSelector.HardDiskMemory.Contains(g.HardDiskMemory))
                .Where(g => laptopsSelector.CPUSocketTypes == null || laptopsSelector.CPUSocketTypes.Contains(g.CPUSocketTypeValue))
                .Where(g => laptopsSelector.ComputerDriveTypes == null || laptopsSelector.ComputerDriveTypes.Any(c => g.LaptopComputerDriveTypes.Select(el => el.ComputerDriveTypeValue).Contains(c)))
                .Where(g => laptopsSelector.NumberOfCores == null || laptopsSelector.NumberOfCores.Contains(g.NumberOfCores))
                .Where(g => laptopsSelector.FloppyDrivesCount == null || laptopsSelector.FloppyDrivesCount.Contains(g.FloppyDrivesCount))
                .Where(g => laptopsSelector.Displays == null || laptopsSelector.Displays.Contains(g.Display))
                .Skip(goodsSelector.From)
                .Take(goodsSelector.To)
                .ProjectTo<GoodCellModel>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }
    }
}
