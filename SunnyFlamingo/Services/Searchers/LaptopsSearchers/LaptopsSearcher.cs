﻿using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using SunnyFlamingo.Data;
using SunnyFlamingo.Models;
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
        public async Task<GoodsInformation<string>> SearchLaptops(
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            int[] amountOfRAM,
            int[] CPUFrequency,
            float[] length,
            float[] height,
            float[] width,
            bool[] haveFloppyDrives,
            int?[] SSDMemory,
            int?[] hardDiskMemory,
            CPUSocketType[] CPUSocketType,
            ComputerDriveType[] computerDriveType,
            int[] numberOfCores,
            int?[] floppyDrivesCount,
            int[] display,
            decimal? priceFrom,
            decimal? priceTo,
            int from,
            int to,
            bool getQuestions
            )
        {
            var laptops = _context.Laptops.AsQueryable();
            return new GoodsInformation<string>()
            {
                GoodCells = await _context.Laptops
                .Where(g => producers != null ? producers.Contains(g.Producer.Name) : true)
                .Where(g => countries != null ? countries.Contains(g.Manufacturer.Country.Value) : true)
                .Where(g => materials != null ? materials.Contains(g.MaterialValue) : true)
                .Where(g => colors != null ? colors.Contains(g.ColorValue) : true)

                .Where(g => amountOfRAM != null ? amountOfRAM.Contains(g.AmountOfRAM) : true)
                .Where(g => CPUFrequency != null ? CPUFrequency.Contains(g.CPUFrequency) : true)
                .Where(g => length != null ? length.Contains(g.Length) : true)
                .Where(g => height != null ? height.Contains(g.Height) : true)
                .Where(g => width != null ? width.Contains(g.Width) : true)
                .Where(g => haveFloppyDrives != null ? haveFloppyDrives.Contains(g.HaveFloppyDrives) : true)
                .Where(g => SSDMemory != null ? SSDMemory.Contains(g.SSDMemory) : true)
                .Where(g => hardDiskMemory != null ? hardDiskMemory.Contains(g.HardDiskMemory) : true)
                .Where(g => CPUSocketType != null ? CPUSocketType.Contains(g.CPUSocketType) : true)
                .Where(g => computerDriveType != null ? computerDriveType.Contains(g.ComputerDriveType) : true)
                .Where(g => numberOfCores != null ? numberOfCores.Contains(g.NumberOfCores) : true)
                .Where(g => floppyDrivesCount != null ? floppyDrivesCount.Contains(g.FloppyDrivesCount) : true)
                .Where(g => display != null ? display.Contains(g.Display) : true)
                .Skip(from)
                .Take(to)
                .ProjectTo<GoodCellModel>(_mapper.ConfigurationProvider)
                .ToListAsync(),

                Questions = !getQuestions ? null : await _questionsService.GetLaptopsQuestions(laptops,
                    producers,
                    countries,
                    materials,
                    colors,
                    amountOfRAM,
                    CPUFrequency,
                    length,
                    height,
                    width,
                    haveFloppyDrives,
                    SSDMemory,
                    hardDiskMemory,
                    CPUSocketType,
                    computerDriveType,
                    numberOfCores,
                    floppyDrivesCount,
                    display,
                    priceFrom,
                    priceTo)
            };
        }
    }
}
