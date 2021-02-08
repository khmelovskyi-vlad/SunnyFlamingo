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
    public class ComputersSearcher : IComputersSearcher
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly IComputersQuestionsService _questionsService;
        public ComputersSearcher(ApplicationDbContext context, IMapper mapper, IComputersQuestionsService questionsService)
        {
            _context = context;
            _mapper = mapper;
            _questionsService = questionsService;
        }
        public async Task<GoodsInformation<string>> SearchComputers(ComputersSelector computersSelector)
        {
            var computers = _context.Computers.AsQueryable();
            return new GoodsInformation<string>()
            {
                GoodCells = await GetGoodCells(computersSelector),


                Questions = !computersSelector.ComputerTechnologiesSelector.GoodsSelector.GetQuestions
                ? null : await _questionsService.GetComputersQuestions(computers, computersSelector)
            };
        }
        private async Task<List<GoodCellModel>> GetGoodCells(ComputersSelector computersSelector)
        {
            var goodsSelector = computersSelector.ComputerTechnologiesSelector.GoodsSelector;
            return await _context.Computers
                .Where(g => (goodsSelector.PriceFrom == null || g.Price >= goodsSelector.PriceFrom)
                && (goodsSelector.PriceTo == null || g.Price <= goodsSelector.PriceTo))
                .Where(g => goodsSelector.Producers == null || goodsSelector.Producers.Contains(g.Producer.Name))
                .Where(g => goodsSelector.Countries == null || goodsSelector.Countries.Contains(g.Manufacturer.Country.Value))
                .Where(g => goodsSelector.Materials == null || goodsSelector.Materials.Contains(g.MaterialValue))
                .Where(g => goodsSelector.Colors == null || goodsSelector.Colors.Contains(g.ColorValue))

                .Where(g => computersSelector.AmountOfRAMs == null || computersSelector.AmountOfRAMs.Contains(g.AmountOfRAM))
                .Where(g => computersSelector.CPUFrequencies == null || computersSelector.CPUFrequencies.Contains(g.CPUFrequency))
                .Where(g => computersSelector.Length == null || computersSelector.Length.Contains(g.Length))
                .Where(g => computersSelector.Height == null || computersSelector.Height.Contains(g.Height))
                .Where(g => computersSelector.Width == null || computersSelector.Width.Contains(g.Width))
                .Where(g => computersSelector.HaveFloppyDrives == null || computersSelector.HaveFloppyDrives.Contains(g.HaveFloppyDrives))
                .Where(g => computersSelector.SSDMemory == null || computersSelector.SSDMemory.Contains(g.SSDMemory))
                .Where(g => computersSelector.HardDiskMemory == null || computersSelector.HardDiskMemory.Contains(g.HardDiskMemory))
                .Where(g => computersSelector.CPUSocketTypes == null || computersSelector.CPUSocketTypes.Contains(g.CPUSocketTypeValue))
                .Where(g => computersSelector.ComputerDriveTypes == null || computersSelector.ComputerDriveTypes.Any(c => g.ComputerComputerDriveTypes.Select(el => el.ComputerDriveTypeValue).Contains(c)))
                .Where(g => computersSelector.NumberOfCores == null || computersSelector.NumberOfCores.Contains(g.NumberOfCores))
                .Where(g => computersSelector.FloppyDrivesCount == null || computersSelector.FloppyDrivesCount.Contains(g.FloppyDrivesCount))
                .Skip(goodsSelector.From)
                .Take(goodsSelector.To)
                .ProjectTo<GoodCellModel>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }
    }
}
