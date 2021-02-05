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
        public async Task<GoodsInformation<string>> SearchComputerTechnologies(
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            decimal? priceFrom,
            decimal? priceTo,
            int from,
            int to,
            bool getQuestions
            )
        {
            var computerTechnologies = _context.ComputerTechnology.AsQueryable();
            return new GoodsInformation<string>()
            {
                GoodCells = await GetGoodCells(
                    producers,
                    countries,
                    materials,
                    colors,
                    priceFrom,
                    priceTo,
                    from,
                    to),

                Questions = !getQuestions ? null : await _questionsService.GetComputerTechnologiesQuestions(
                    computerTechnologies,
                    producers,
                    countries,
                    materials,
                    colors,
                    priceFrom,
                    priceTo
                    )
            };
        }
        private async Task<List<GoodCellModel>> GetGoodCells(
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            decimal? priceFrom,
            decimal? priceTo,
            int from,
            int to)
        {
            if (producers == null && countries == null && materials == null && colors == null && priceFrom == null && priceTo == null)
            {
                return await _context.ComputerTechnology
                .Skip(from)
                .Take(to)
                .ProjectTo<GoodCellModel>(_mapper.ConfigurationProvider)
                .ToListAsync();
            }
            else
            {
                return await _context.ComputerTechnology
                .Where(g =>
                (priceFrom == null || g.Price >= priceFrom) && (priceTo == null || g.Price <= priceTo)
                && (producers == null || producers.Contains(g.Producer.Name))
                && (countries == null || countries.Contains(g.Manufacturer.Country.Value))
                && (materials == null || materials.Contains(g.MaterialValue))
                && (colors == null || colors.Contains(g.ColorValue)))
                .Skip(from)
                .Take(to)
                .ProjectTo<GoodCellModel>(_mapper.ConfigurationProvider)
                .ToListAsync();
            }
        }
    }
}
