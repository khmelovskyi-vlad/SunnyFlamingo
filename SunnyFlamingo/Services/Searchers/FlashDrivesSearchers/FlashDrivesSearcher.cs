using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using SunnyFlamingo.Data;
using SunnyFlamingo.Models;
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
        public async Task<GoodsInformation<string>> SearchFlashDrives(
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            int[] capacities,
            string[] USBSpecificationTypes,
            decimal? priceFrom,
            decimal? priceTo,
            int from,
            int to,
            bool getQuestions
            )
        {
            var flashDrives = _context.FlashDrives.AsQueryable();
            return new GoodsInformation<string>()
            {
                GoodCells = await _context.FlashDrives
                .Where(g => producers != null ? producers.Contains(g.Producer.Name) : true)
                .Where(g => countries != null ? countries.Contains(g.Manufacturer.Country.Value) : true)
                .Where(g => materials != null ? materials.Contains(g.MaterialValue) : true)
                .Where(g => colors != null ? colors.Contains(g.ColorValue) : true)

                .Where(g => capacities != null ? capacities.Contains(g.Capacity) : true)
                .Where(g => USBSpecificationTypes != null ? USBSpecificationTypes.Contains(g.USBSpecificationTypeValue) : true)
                .Skip(from)
                .Take(to)
                .ProjectTo<GoodCellModel>(_mapper.ConfigurationProvider)
                .ToListAsync(),

                Questions = !getQuestions ? null : await _questionsService.GetFlashDrivesQuestions(flashDrives,
                    producers,
                    countries,
                    materials,
                    colors,
                    capacities,
                    USBSpecificationTypes,
                    priceFrom,
                    priceTo)
            };
        }
    }
}
