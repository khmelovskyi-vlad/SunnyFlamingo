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
    public class VideoCardsSearcher : IVideoCardsSearcher
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly IVideoCardsQuestionsService _questionsService;
        public VideoCardsSearcher(ApplicationDbContext context, IMapper mapper, IVideoCardsQuestionsService questionsService)
        {
            _context = context;
            _mapper = mapper;
            _questionsService = questionsService;
        }
        public async Task<GoodsInformation<string>> SearchVideoCards(VideoCardsSelector videoCardsSelector)
        {
            var videoCards = _context.VideoCards.AsQueryable();
            return new GoodsInformation<string>()
            {
                GoodCells = await GetGoodCells(videoCardsSelector),

                Questions = !videoCardsSelector.ComputerPartsSelector.ComputerTechnologiesSelector.GoodsSelector.GetQuestions
                ? null : await _questionsService.GetVideoCardsQuestions(videoCards, videoCardsSelector)
            };
        }
        private async Task<List<GoodCellModel>> GetGoodCells(VideoCardsSelector videoCardsSelector)
        {
            var goodsSelector = videoCardsSelector.ComputerPartsSelector.ComputerTechnologiesSelector.GoodsSelector;
            return await _context.VideoCards
                .Where(g => (goodsSelector.PriceFrom == null || g.Price >= goodsSelector.PriceFrom)
                && (goodsSelector.PriceTo == null || g.Price <= goodsSelector.PriceTo))
                .Where(g => goodsSelector.Producers == null || goodsSelector.Producers.Contains(g.Producer.Name))
                .Where(g => goodsSelector.Countries == null || goodsSelector.Countries.Contains(g.Manufacturer.Country.Value))
                .Where(g => goodsSelector.Materials == null || goodsSelector.Materials.Contains(g.MaterialValue))
                .Where(g => goodsSelector.Colors == null || goodsSelector.Colors.Contains(g.ColorValue))

                .Where(g => videoCardsSelector.DriveInterfaces == null || videoCardsSelector.DriveInterfaces.Contains(g.DriveInterfaceValue))
                .Where(g => videoCardsSelector.VideoSizes == null || videoCardsSelector.VideoSizes.Contains(g.VideoSize))
                .Where(g => videoCardsSelector.VideoMemoryCapacities == null || videoCardsSelector.VideoMemoryCapacities.Contains(g.VideoMemoryCapacity))
                .Skip(goodsSelector.From)
                .Take(goodsSelector.To)
                .ProjectTo<GoodCellModel>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }
    }
}
