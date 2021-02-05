using Microsoft.EntityFrameworkCore;
using SunnyFlamingo.Entities.Goods.ComputerTechnologies;
using SunnyFlamingo.Models;
using SunnyFlamingo.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Searchers
{
    public class LaptopsQuestionsService : ILaptopsQuestionsService
    {
        private readonly IComputerTechnologiesQuestionsService _computerTechnologiesQuestionsService;
        public LaptopsQuestionsService(IComputerTechnologiesQuestionsService computerTechnologiesQuestionsService)
        {
            _computerTechnologiesQuestionsService = computerTechnologiesQuestionsService;
        }
        public async Task<List<QuestionsBase<string>>> GetLaptopsQuestions(
            IQueryable<Laptop> laptops,
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
            decimal? priceTo)
        {
            var result = new List<QuestionsBase<string>>()
                {
                    await GetProducerQuestion(GetProducerLaptops(laptops, producers, countries, materials, colors, amountOfRAM, CPUFrequency,
                    length, height, width, haveFloppyDrives, SSDMemory, hardDiskMemory, CPUSocketType, computerDriveType,
                    numberOfCores, floppyDrivesCount, display, priceFrom, priceTo), producers),
                    await GetCountryQuestion(GetCountryLaptops(laptops, producers, countries, materials, colors, amountOfRAM, CPUFrequency,
                    length, height, width, haveFloppyDrives, SSDMemory, hardDiskMemory, CPUSocketType, computerDriveType,
                    numberOfCores, floppyDrivesCount, display, priceFrom, priceTo), countries),
                    await GetMaterialQuestion(GetMaterialLaptops(laptops, producers, countries, materials, colors, amountOfRAM, CPUFrequency,
                    length, height, width, haveFloppyDrives, SSDMemory, hardDiskMemory, CPUSocketType, computerDriveType,
                    numberOfCores, floppyDrivesCount, display, priceFrom, priceTo), materials),
                    await GetColorQuestion(GetColorLaptops(laptops, producers, countries, materials, colors, amountOfRAM, CPUFrequency,
                    length, height, width, haveFloppyDrives, SSDMemory, hardDiskMemory, CPUSocketType, computerDriveType,
                    numberOfCores, floppyDrivesCount, display, priceFrom, priceTo), colors),
                    await GetPriceQuestion(GetPriceLaptops(laptops, producers, countries, materials, colors, amountOfRAM, CPUFrequency,
                    length, height, width, haveFloppyDrives, SSDMemory, hardDiskMemory, CPUSocketType, computerDriveType,
                    numberOfCores, floppyDrivesCount, display, priceFrom, priceTo), priceFrom, priceTo),

                    await GetAmountOfRAMQuestion(GetAmountOfRAMLaptops(laptops, producers, countries, materials, colors, amountOfRAM, CPUFrequency,
                    length, height, width, haveFloppyDrives, SSDMemory, hardDiskMemory, CPUSocketType, computerDriveType,
                    numberOfCores, floppyDrivesCount, display, priceFrom, priceTo), amountOfRAM),
                    await GetCPUFrequencyQuestion(GetCPUFrequencyLaptops(laptops, producers, countries, materials, colors, amountOfRAM, CPUFrequency,
                    length, height, width, haveFloppyDrives, SSDMemory, hardDiskMemory, CPUSocketType, computerDriveType,
                    numberOfCores, floppyDrivesCount, display, priceFrom, priceTo), CPUFrequency),
                    await GetLengthQuestion(GetLengthLaptops(laptops, producers, countries, materials, colors, amountOfRAM, CPUFrequency,
                    length, height, width, haveFloppyDrives, SSDMemory, hardDiskMemory, CPUSocketType, computerDriveType,
                    numberOfCores, floppyDrivesCount, display, priceFrom, priceTo), length),
                    await GetHeightQuestion(GetHeightLaptops(laptops, producers, countries, materials, colors, amountOfRAM, CPUFrequency,
                    length, height, width, haveFloppyDrives, SSDMemory, hardDiskMemory, CPUSocketType, computerDriveType,
                    numberOfCores, floppyDrivesCount, display, priceFrom, priceTo), height),
                    await GetWidthQuestion(GetWidthLaptops(laptops, producers, countries, materials, colors, amountOfRAM, CPUFrequency,
                    length, height, width, haveFloppyDrives, SSDMemory, hardDiskMemory, CPUSocketType, computerDriveType,
                    numberOfCores, floppyDrivesCount, display, priceFrom, priceTo), width),
                    await GetHaveFloppyDrivesQuestion(GetHaveFloppyDrivesLaptops(laptops, producers, countries, materials, colors, amountOfRAM, CPUFrequency,
                    length, height, width, haveFloppyDrives, SSDMemory, hardDiskMemory, CPUSocketType, computerDriveType,
                    numberOfCores, floppyDrivesCount, display, priceFrom, priceTo), haveFloppyDrives),
                    await GetSSDMemoryQuestion(GetSSDMemoryLaptops(laptops, producers, countries, materials, colors, amountOfRAM, CPUFrequency,
                    length, height, width, haveFloppyDrives, SSDMemory, hardDiskMemory, CPUSocketType, computerDriveType,
                    numberOfCores, floppyDrivesCount, display, priceFrom, priceTo), SSDMemory),
                    await GetHardDiskMemoryQuestion(GetHardDiskMemoryLaptops(laptops, producers, countries, materials, colors, amountOfRAM, CPUFrequency,
                    length, height, width, haveFloppyDrives, SSDMemory, hardDiskMemory, CPUSocketType, computerDriveType,
                    numberOfCores, floppyDrivesCount, display, priceFrom, priceTo), hardDiskMemory),
                    await GetCPUSocketTypeQuestion(GetCPUSocketTypeLaptops(laptops, producers, countries, materials, colors, amountOfRAM, CPUFrequency,
                    length, height, width, haveFloppyDrives, SSDMemory, hardDiskMemory, CPUSocketType, computerDriveType,
                    numberOfCores, floppyDrivesCount, display, priceFrom, priceTo), CPUSocketType),
                    await GetComputerDriveTypeQuestion(GetComputerDriveTypeLaptops(laptops, producers, countries, materials, colors, amountOfRAM, CPUFrequency,
                    length, height, width, haveFloppyDrives, SSDMemory, hardDiskMemory, CPUSocketType, computerDriveType,
                    numberOfCores, floppyDrivesCount, display, priceFrom, priceTo), computerDriveType),
                    await GetNumberOfCoreQuestion(GetNumberOfCoresLaptops(laptops, producers, countries, materials, colors, amountOfRAM, CPUFrequency,
                    length, height, width, haveFloppyDrives, SSDMemory, hardDiskMemory, CPUSocketType, computerDriveType,
                    numberOfCores, floppyDrivesCount, display, priceFrom, priceTo), numberOfCores),
                    await GetDisplayQuestion(GetDisplayLaptops(laptops, producers, countries, materials, colors, amountOfRAM, CPUFrequency,
                    length, height, width, haveFloppyDrives, SSDMemory, hardDiskMemory, CPUSocketType, computerDriveType,
                    numberOfCores, floppyDrivesCount, display, priceFrom, priceTo), display)
                };
            if (haveFloppyDrives != null && !haveFloppyDrives.Contains(true) && haveFloppyDrives.Contains(false))
            {
                result.Add(await GetFloppyDrivesCountQuestion(GetFloppyDrivesCountLaptops(laptops, producers, countries, materials, colors, amountOfRAM, CPUFrequency,
                    length, height, width, haveFloppyDrives, SSDMemory, hardDiskMemory, CPUSocketType, computerDriveType,
                    numberOfCores, floppyDrivesCount, display, priceFrom, priceTo), floppyDrivesCount));
            }
            return result;
        }

        public IQueryable<T> GetProducerLaptops<T>(
            IQueryable<T> laptops,
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
            decimal? priceTo) where T : Laptop
        {
            return _computerTechnologiesQuestionsService.GetProducerComputerTechnologies(
                laptops, producers, countries, materials, colors, priceFrom, priceTo)
                .Where(l => (producers != null && producers.Contains(l.Producer.Name)) ||
                ((haveFloppyDrives == null || haveFloppyDrives.Contains(l.HaveFloppyDrives))
                && (amountOfRAM == null || amountOfRAM.Contains(l.AmountOfRAM))
                && (display == null || display.Contains(l.Display))
                && (floppyDrivesCount == null || floppyDrivesCount.Contains(l.FloppyDrivesCount))
                && (numberOfCores == null || numberOfCores.Contains(l.NumberOfCores))
                && (computerDriveType == null || computerDriveType.Contains(l.ComputerDriveType))
                && (CPUSocketType == null || CPUSocketType.Contains(l.CPUSocketType))
                && (hardDiskMemory == null || hardDiskMemory.Contains(l.HardDiskMemory))
                && (SSDMemory == null || SSDMemory.Contains(l.SSDMemory))
                && (width == null || width.Contains(l.Width))
                && (height == null || height.Contains(l.Height))
                && (length == null || length.Contains(l.Length))
                && (CPUFrequency == null || CPUFrequency.Contains(l.CPUFrequency))
                && (countries == null || countries.Contains(l.Manufacturer.Country.Value))
                && (materials == null || materials.Contains(l.MaterialValue))
                && (colors == null || colors.Contains(l.ColorValue))));
        }
        public IQueryable<T> GetCountryLaptops<T>(
            IQueryable<T> laptops,
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
            decimal? priceTo) where T : Laptop
        {
            return _computerTechnologiesQuestionsService.GetCountryComputerTechnologies(
                laptops, producers, countries, materials, colors, priceFrom, priceTo)
                .Where(l => (countries != null && countries.Contains(l.Manufacturer.Country.Value)) ||
                ((haveFloppyDrives == null || haveFloppyDrives.Contains(l.HaveFloppyDrives))
                && (amountOfRAM == null || amountOfRAM.Contains(l.AmountOfRAM))
                && (display == null || display.Contains(l.Display))
                && (floppyDrivesCount == null || floppyDrivesCount.Contains(l.FloppyDrivesCount))
                && (numberOfCores == null || numberOfCores.Contains(l.NumberOfCores))
                && (computerDriveType == null || computerDriveType.Contains(l.ComputerDriveType))
                && (CPUSocketType == null || CPUSocketType.Contains(l.CPUSocketType))
                && (hardDiskMemory == null || hardDiskMemory.Contains(l.HardDiskMemory))
                && (SSDMemory == null || SSDMemory.Contains(l.SSDMemory))
                && (width == null || width.Contains(l.Width))
                && (height == null || height.Contains(l.Height))
                && (length == null || length.Contains(l.Length))
                && (CPUFrequency == null || CPUFrequency.Contains(l.CPUFrequency))
                && (producers == null || producers.Contains(l.Producer.Name))
                && (materials == null || materials.Contains(l.MaterialValue))
                && (colors == null || colors.Contains(l.ColorValue))));
        }
        public IQueryable<T> GetMaterialLaptops<T>(
            IQueryable<T> laptops,
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
            decimal? priceTo) where T : Laptop
        {
            return _computerTechnologiesQuestionsService.GetMaterialComputerTechnologies(
                laptops, producers, countries, materials, colors, priceFrom, priceTo)
                .Where(l => (materials != null && materials.Contains(l.MaterialValue)) ||
                ((haveFloppyDrives == null || haveFloppyDrives.Contains(l.HaveFloppyDrives))
                && (amountOfRAM == null || amountOfRAM.Contains(l.AmountOfRAM))
                && (display == null || display.Contains(l.Display))
                && (floppyDrivesCount == null || floppyDrivesCount.Contains(l.FloppyDrivesCount))
                && (numberOfCores == null || numberOfCores.Contains(l.NumberOfCores))
                && (computerDriveType == null || computerDriveType.Contains(l.ComputerDriveType))
                && (CPUSocketType == null || CPUSocketType.Contains(l.CPUSocketType))
                && (hardDiskMemory == null || hardDiskMemory.Contains(l.HardDiskMemory))
                && (SSDMemory == null || SSDMemory.Contains(l.SSDMemory))
                && (width == null || width.Contains(l.Width))
                && (height == null || height.Contains(l.Height))
                && (length == null || length.Contains(l.Length))
                && (CPUFrequency == null || CPUFrequency.Contains(l.CPUFrequency))
                && (producers == null || producers.Contains(l.Producer.Name))
                && (countries == null || countries.Contains(l.Manufacturer.Country.Value))
                && (colors == null || colors.Contains(l.ColorValue))));
        }
        public IQueryable<T> GetColorLaptops<T>(
            IQueryable<T> laptops,
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
            decimal? priceTo) where T : Laptop
        {
            return _computerTechnologiesQuestionsService.GetColorComputerTechnologies(
                laptops, producers, countries, materials, colors, priceFrom, priceTo)
                .Where(l => (colors != null && colors.Contains(l.ColorValue)) ||
                ((haveFloppyDrives == null || haveFloppyDrives.Contains(l.HaveFloppyDrives))
                && (amountOfRAM == null || amountOfRAM.Contains(l.AmountOfRAM))
                && (display == null || display.Contains(l.Display))
                && (floppyDrivesCount == null || floppyDrivesCount.Contains(l.FloppyDrivesCount))
                && (numberOfCores == null || numberOfCores.Contains(l.NumberOfCores))
                && (computerDriveType == null || computerDriveType.Contains(l.ComputerDriveType))
                && (CPUSocketType == null || CPUSocketType.Contains(l.CPUSocketType))
                && (hardDiskMemory == null || hardDiskMemory.Contains(l.HardDiskMemory))
                && (SSDMemory == null || SSDMemory.Contains(l.SSDMemory))
                && (width == null || width.Contains(l.Width))
                && (height == null || height.Contains(l.Height))
                && (length == null || length.Contains(l.Length))
                && (CPUFrequency == null || CPUFrequency.Contains(l.CPUFrequency))
                && (producers == null || producers.Contains(l.Producer.Name))
                && (countries == null || countries.Contains(l.Manufacturer.Country.Value))
                && (materials == null || materials.Contains(l.MaterialValue))));
        }
        public IQueryable<T> GetPriceLaptops<T>(
            IQueryable<T> laptops,
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
            decimal? priceTo) where T : Laptop
        {
            return _computerTechnologiesQuestionsService.GetPriceComputerTechnologies(
                laptops, producers, countries, materials, colors, priceFrom, priceTo)
                .Where(l =>
                (haveFloppyDrives == null || haveFloppyDrives.Contains(l.HaveFloppyDrives))
                && (amountOfRAM == null || amountOfRAM.Contains(l.AmountOfRAM))
                && (display == null || display.Contains(l.Display))
                && (floppyDrivesCount == null || floppyDrivesCount.Contains(l.FloppyDrivesCount))
                && (numberOfCores == null || numberOfCores.Contains(l.NumberOfCores))
                && (computerDriveType == null || computerDriveType.Contains(l.ComputerDriveType))
                && (CPUSocketType == null || CPUSocketType.Contains(l.CPUSocketType))
                && (hardDiskMemory == null || hardDiskMemory.Contains(l.HardDiskMemory))
                && (SSDMemory == null || SSDMemory.Contains(l.SSDMemory))
                && (width == null || width.Contains(l.Width))
                && (height == null || height.Contains(l.Height))
                && (length == null || length.Contains(l.Length))
                && (CPUFrequency == null || CPUFrequency.Contains(l.CPUFrequency))
                && (producers == null || producers.Contains(l.Producer.Name))
                && (countries == null || countries.Contains(l.Manufacturer.Country.Value))
                && (materials == null || materials.Contains(l.MaterialValue))
                && (colors == null || colors.Contains(l.ColorValue)));
        }
        public IQueryable<T> GetAmountOfRAMLaptops<T>(
            IQueryable<T> laptops,
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
            decimal? priceTo) where T : Laptop
        {
            if (producers == null && countries == null && materials == null && colors == null && CPUFrequency == null && length == null
                && height == null && width == null && haveFloppyDrives == null && SSDMemory == null && hardDiskMemory == null
                && CPUSocketType == null && computerDriveType == null && numberOfCores == null && floppyDrivesCount == null && display == null
                && priceFrom == null && priceTo == null)
            {
                return laptops;
            }
            return laptops
                .Where(g => (amountOfRAM != null && amountOfRAM.Contains(g.AmountOfRAM)) ||
                ((priceFrom == null || g.Price >= priceFrom) && (priceTo == null || g.Price <= priceTo)
                && (haveFloppyDrives == null || haveFloppyDrives.Contains(g.HaveFloppyDrives))
                && (display == null || display.Contains(g.Display))
                && (floppyDrivesCount == null || floppyDrivesCount.Contains(g.FloppyDrivesCount))
                && (numberOfCores == null || numberOfCores.Contains(g.NumberOfCores))
                && (computerDriveType == null || computerDriveType.Contains(g.ComputerDriveType))
                && (CPUSocketType == null || CPUSocketType.Contains(g.CPUSocketType))
                && (hardDiskMemory == null || hardDiskMemory.Contains(g.HardDiskMemory))
                && (SSDMemory == null || SSDMemory.Contains(g.SSDMemory))
                && (width == null || width.Contains(g.Width))
                && (height == null || height.Contains(g.Height))
                && (length == null || length.Contains(g.Length))
                && (CPUFrequency == null || CPUFrequency.Contains(g.CPUFrequency))
                && (producers == null || producers.Contains(g.Producer.Name))
                && (countries == null || countries.Contains(g.Manufacturer.Country.Value))
                && (materials == null || materials.Contains(g.MaterialValue))
                && (colors == null || colors.Contains(g.ColorValue))));
        }
        public IQueryable<T> GetCPUFrequencyLaptops<T>(
            IQueryable<T> laptops,
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
            decimal? priceTo) where T : Laptop
        {
            if (producers == null && countries == null && materials == null && colors == null && amountOfRAM == null && length == null
                && height == null && width == null && haveFloppyDrives == null && SSDMemory == null && hardDiskMemory == null
                && CPUSocketType == null && computerDriveType == null && numberOfCores == null && floppyDrivesCount == null && display == null
                && priceFrom == null && priceTo == null)
            {
                return laptops;
            }
            return laptops
                .Where(g => (CPUFrequency != null && CPUFrequency.Contains(g.CPUFrequency)) ||
                ((priceFrom == null || g.Price >= priceFrom) && (priceTo == null || g.Price <= priceTo)
                && (haveFloppyDrives == null || haveFloppyDrives.Contains(g.HaveFloppyDrives))
                && (display == null || display.Contains(g.Display))
                && (floppyDrivesCount == null || floppyDrivesCount.Contains(g.FloppyDrivesCount))
                && (numberOfCores == null || numberOfCores.Contains(g.NumberOfCores))
                && (computerDriveType == null || computerDriveType.Contains(g.ComputerDriveType))
                && (CPUSocketType == null || CPUSocketType.Contains(g.CPUSocketType))
                && (hardDiskMemory == null || hardDiskMemory.Contains(g.HardDiskMemory))
                && (SSDMemory == null || SSDMemory.Contains(g.SSDMemory))
                && (width == null || width.Contains(g.Width))
                && (height == null || height.Contains(g.Height))
                && (length == null || length.Contains(g.Length))
                && (amountOfRAM == null || amountOfRAM.Contains(g.AmountOfRAM))
                && (producers == null || producers.Contains(g.Producer.Name))
                && (countries == null || countries.Contains(g.Manufacturer.Country.Value))
                && (materials == null || materials.Contains(g.MaterialValue))
                && (colors == null || colors.Contains(g.ColorValue))));
        }
        public IQueryable<T> GetLengthLaptops<T>(
            IQueryable<T> laptops,
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
            decimal? priceTo) where T : Laptop
        {
            if (producers == null && countries == null && materials == null && colors == null && amountOfRAM == null && CPUFrequency == null
                && height == null && width == null && haveFloppyDrives == null && SSDMemory == null && hardDiskMemory == null
                && CPUSocketType == null && computerDriveType == null && numberOfCores == null && floppyDrivesCount == null && display == null
                && priceFrom == null && priceTo == null)
            {
                return laptops;
            }
            return laptops
                .Where(g => (length != null && length.Contains(g.Length)) ||
                ((priceFrom == null || g.Price >= priceFrom) && (priceTo == null || g.Price <= priceTo)
                && (haveFloppyDrives == null || haveFloppyDrives.Contains(g.HaveFloppyDrives))
                && (display == null || display.Contains(g.Display))
                && (floppyDrivesCount == null || floppyDrivesCount.Contains(g.FloppyDrivesCount))
                && (numberOfCores == null || numberOfCores.Contains(g.NumberOfCores))
                && (computerDriveType == null || computerDriveType.Contains(g.ComputerDriveType))
                && (CPUSocketType == null || CPUSocketType.Contains(g.CPUSocketType))
                && (hardDiskMemory == null || hardDiskMemory.Contains(g.HardDiskMemory))
                && (SSDMemory == null || SSDMemory.Contains(g.SSDMemory))
                && (width == null || width.Contains(g.Width))
                && (height == null || height.Contains(g.Height))
                && (CPUFrequency == null || CPUFrequency.Contains(g.CPUFrequency))
                && (amountOfRAM == null || amountOfRAM.Contains(g.AmountOfRAM))
                && (producers == null || producers.Contains(g.Producer.Name))
                && (countries == null || countries.Contains(g.Manufacturer.Country.Value))
                && (materials == null || materials.Contains(g.MaterialValue))
                && (colors == null || colors.Contains(g.ColorValue))));
        }
        public IQueryable<T> GetHeightLaptops<T>(
            IQueryable<T> laptops,
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
            decimal? priceTo) where T : Laptop
        {
            if (producers == null && countries == null && materials == null && colors == null && amountOfRAM == null && CPUFrequency == null
                && length == null && width == null && haveFloppyDrives == null && SSDMemory == null && hardDiskMemory == null
                && CPUSocketType == null && computerDriveType == null && numberOfCores == null && floppyDrivesCount == null && display == null
                && priceFrom == null && priceTo == null)
            {
                return laptops;
            }
            return laptops
                .Where(g => (height != null && height.Contains(g.Height)) ||
                ((priceFrom == null || g.Price >= priceFrom) && (priceTo == null || g.Price <= priceTo)
                && (haveFloppyDrives == null || haveFloppyDrives.Contains(g.HaveFloppyDrives))
                && (display == null || display.Contains(g.Display))
                && (floppyDrivesCount == null || floppyDrivesCount.Contains(g.FloppyDrivesCount))
                && (numberOfCores == null || numberOfCores.Contains(g.NumberOfCores))
                && (computerDriveType == null || computerDriveType.Contains(g.ComputerDriveType))
                && (CPUSocketType == null || CPUSocketType.Contains(g.CPUSocketType))
                && (hardDiskMemory == null || hardDiskMemory.Contains(g.HardDiskMemory))
                && (SSDMemory == null || SSDMemory.Contains(g.SSDMemory))
                && (width == null || width.Contains(g.Width))
                && (length == null || length.Contains(g.Length))
                && (CPUFrequency == null || CPUFrequency.Contains(g.CPUFrequency))
                && (amountOfRAM == null || amountOfRAM.Contains(g.AmountOfRAM))
                && (producers == null || producers.Contains(g.Producer.Name))
                && (countries == null || countries.Contains(g.Manufacturer.Country.Value))
                && (materials == null || materials.Contains(g.MaterialValue))
                && (colors == null || colors.Contains(g.ColorValue))));
        }
        public IQueryable<T> GetWidthLaptops<T>(
            IQueryable<T> laptops,
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
            decimal? priceTo) where T : Laptop
        {
            if (producers == null && countries == null && materials == null && colors == null && amountOfRAM == null && CPUFrequency == null
                && height == null && length == null && haveFloppyDrives == null && SSDMemory == null && hardDiskMemory == null
                && CPUSocketType == null && computerDriveType == null && numberOfCores == null && floppyDrivesCount == null && display == null
                && priceFrom == null && priceTo == null)
            {
                return laptops;
            }
            return laptops
                .Where(g => (width != null && width.Contains(g.Width)) ||
                ((priceFrom == null || g.Price >= priceFrom) && (priceTo == null || g.Price <= priceTo)
                && (haveFloppyDrives == null || haveFloppyDrives.Contains(g.HaveFloppyDrives))
                && (display == null || display.Contains(g.Display))
                && (floppyDrivesCount == null || floppyDrivesCount.Contains(g.FloppyDrivesCount))
                && (numberOfCores == null || numberOfCores.Contains(g.NumberOfCores))
                && (computerDriveType == null || computerDriveType.Contains(g.ComputerDriveType))
                && (CPUSocketType == null || CPUSocketType.Contains(g.CPUSocketType))
                && (hardDiskMemory == null || hardDiskMemory.Contains(g.HardDiskMemory))
                && (SSDMemory == null || SSDMemory.Contains(g.SSDMemory))
                && (length == null || length.Contains(g.Length))
                && (height == null || height.Contains(g.Height))
                && (CPUFrequency == null || CPUFrequency.Contains(g.CPUFrequency))
                && (amountOfRAM == null || amountOfRAM.Contains(g.AmountOfRAM))
                && (producers == null || producers.Contains(g.Producer.Name))
                && (countries == null || countries.Contains(g.Manufacturer.Country.Value))
                && (materials == null || materials.Contains(g.MaterialValue))
                && (colors == null || colors.Contains(g.ColorValue))));
        }
        public IQueryable<T> GetSSDMemoryLaptops<T>(
            IQueryable<T> laptops,
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
            decimal? priceTo) where T : Laptop
        {
            if (producers == null && countries == null && materials == null && colors == null && amountOfRAM == null && CPUFrequency == null
                && height == null && length == null && haveFloppyDrives == null && width == null && hardDiskMemory == null
                && CPUSocketType == null && computerDriveType == null && numberOfCores == null && floppyDrivesCount == null && display == null
                && priceFrom == null && priceTo == null)
            {
                return laptops;
            }
            return laptops
                .Where(g => (SSDMemory != null && SSDMemory.Contains(g.SSDMemory)) ||
                ((priceFrom == null || g.Price >= priceFrom) && (priceTo == null || g.Price <= priceTo)
                && (haveFloppyDrives == null || haveFloppyDrives.Contains(g.HaveFloppyDrives))
                && (display == null || display.Contains(g.Display))
                && (floppyDrivesCount == null || floppyDrivesCount.Contains(g.FloppyDrivesCount))
                && (numberOfCores == null || numberOfCores.Contains(g.NumberOfCores))
                && (computerDriveType == null || computerDriveType.Contains(g.ComputerDriveType))
                && (CPUSocketType == null || CPUSocketType.Contains(g.CPUSocketType))
                && (hardDiskMemory == null || hardDiskMemory.Contains(g.HardDiskMemory))
                && (width == null || width.Contains(g.Width))
                && (length == null || length.Contains(g.Length))
                && (height == null || height.Contains(g.Height))
                && (CPUFrequency == null || CPUFrequency.Contains(g.CPUFrequency))
                && (amountOfRAM == null || amountOfRAM.Contains(g.AmountOfRAM))
                && (producers == null || producers.Contains(g.Producer.Name))
                && (countries == null || countries.Contains(g.Manufacturer.Country.Value))
                && (materials == null || materials.Contains(g.MaterialValue))
                && (colors == null || colors.Contains(g.ColorValue))));
        }
        public IQueryable<T> GetHardDiskMemoryLaptops<T>(
            IQueryable<T> laptops,
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
            decimal? priceTo) where T : Laptop
        {
            if (producers == null && countries == null && materials == null && colors == null && amountOfRAM == null && CPUFrequency == null
                && height == null && length == null && haveFloppyDrives == null && width == null && SSDMemory == null
                && CPUSocketType == null && computerDriveType == null && numberOfCores == null && floppyDrivesCount == null && display == null
                && priceFrom == null && priceTo == null)
            {
                return laptops;
            }
            return laptops
                .Where(g => (hardDiskMemory != null && hardDiskMemory.Contains(g.HardDiskMemory)) ||
                ((priceFrom == null || g.Price >= priceFrom) && (priceTo == null || g.Price <= priceTo)
                && (haveFloppyDrives == null || haveFloppyDrives.Contains(g.HaveFloppyDrives))
                && (display == null || display.Contains(g.Display))
                && (floppyDrivesCount == null || floppyDrivesCount.Contains(g.FloppyDrivesCount))
                && (numberOfCores == null || numberOfCores.Contains(g.NumberOfCores))
                && (computerDriveType == null || computerDriveType.Contains(g.ComputerDriveType))
                && (CPUSocketType == null || CPUSocketType.Contains(g.CPUSocketType))
                && (SSDMemory == null || SSDMemory.Contains(g.SSDMemory))
                && (width == null || width.Contains(g.Width))
                && (length == null || length.Contains(g.Length))
                && (height == null || height.Contains(g.Height))
                && (CPUFrequency == null || CPUFrequency.Contains(g.CPUFrequency))
                && (amountOfRAM == null || amountOfRAM.Contains(g.AmountOfRAM))
                && (producers == null || producers.Contains(g.Producer.Name))
                && (countries == null || countries.Contains(g.Manufacturer.Country.Value))
                && (materials == null || materials.Contains(g.MaterialValue))
                && (colors == null || colors.Contains(g.ColorValue))));
        }
        public IQueryable<T> GetCPUSocketTypeLaptops<T>(
            IQueryable<T> laptops,
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
            decimal? priceTo) where T : Laptop
        {
            if (producers == null && countries == null && materials == null && colors == null && amountOfRAM == null && CPUFrequency == null
                && height == null && length == null && haveFloppyDrives == null && width == null && SSDMemory == null
                && hardDiskMemory == null && computerDriveType == null && numberOfCores == null && floppyDrivesCount == null && display == null
                && priceFrom == null && priceTo == null)
            {
                return laptops;
            }
            return laptops
                .Where(g => (CPUSocketType != null && CPUSocketType.Contains(g.CPUSocketType)) ||
                ((priceFrom == null || g.Price >= priceFrom) && (priceTo == null || g.Price <= priceTo)
                && (haveFloppyDrives == null || haveFloppyDrives.Contains(g.HaveFloppyDrives))
                && (display == null || display.Contains(g.Display))
                && (floppyDrivesCount == null || floppyDrivesCount.Contains(g.FloppyDrivesCount))
                && (numberOfCores == null || numberOfCores.Contains(g.NumberOfCores))
                && (computerDriveType == null || computerDriveType.Contains(g.ComputerDriveType))
                && (hardDiskMemory == null || hardDiskMemory.Contains(g.HardDiskMemory))
                && (SSDMemory == null || SSDMemory.Contains(g.SSDMemory))
                && (width == null || width.Contains(g.Width))
                && (length == null || length.Contains(g.Length))
                && (height == null || height.Contains(g.Height))
                && (CPUFrequency == null || CPUFrequency.Contains(g.CPUFrequency))
                && (amountOfRAM == null || amountOfRAM.Contains(g.AmountOfRAM))
                && (producers == null || producers.Contains(g.Producer.Name))
                && (countries == null || countries.Contains(g.Manufacturer.Country.Value))
                && (materials == null || materials.Contains(g.MaterialValue))
                && (colors == null || colors.Contains(g.ColorValue))));
        }
        public IQueryable<T> GetComputerDriveTypeLaptops<T>(
            IQueryable<T> laptops,
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
            decimal? priceTo) where T : Laptop
        {
            if (producers == null && countries == null && materials == null && colors == null && amountOfRAM == null && CPUFrequency == null
                && height == null && length == null && haveFloppyDrives == null && width == null && SSDMemory == null
                && hardDiskMemory == null && CPUSocketType == null && numberOfCores == null && floppyDrivesCount == null && display == null
                && priceFrom == null && priceTo == null)
            {
                return laptops;
            }
            return laptops
                .Where(g => (computerDriveType != null && computerDriveType.Contains(g.ComputerDriveType)) ||
                ((priceFrom == null || g.Price >= priceFrom) && (priceTo == null || g.Price <= priceTo)
                && (haveFloppyDrives == null || haveFloppyDrives.Contains(g.HaveFloppyDrives))
                && (display == null || display.Contains(g.Display))
                && (floppyDrivesCount == null || floppyDrivesCount.Contains(g.FloppyDrivesCount))
                && (numberOfCores == null || numberOfCores.Contains(g.NumberOfCores))
                && (CPUSocketType == null || CPUSocketType.Contains(g.CPUSocketType))
                && (hardDiskMemory == null || hardDiskMemory.Contains(g.HardDiskMemory))
                && (SSDMemory == null || SSDMemory.Contains(g.SSDMemory))
                && (width == null || width.Contains(g.Width))
                && (length == null || length.Contains(g.Length))
                && (height == null || height.Contains(g.Height))
                && (CPUFrequency == null || CPUFrequency.Contains(g.CPUFrequency))
                && (amountOfRAM == null || amountOfRAM.Contains(g.AmountOfRAM))
                && (producers == null || producers.Contains(g.Producer.Name))
                && (countries == null || countries.Contains(g.Manufacturer.Country.Value))
                && (materials == null || materials.Contains(g.MaterialValue))
                && (colors == null || colors.Contains(g.ColorValue))));
        }
        public IQueryable<T> GetNumberOfCoresLaptops<T>(
            IQueryable<T> laptops,
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
            decimal? priceTo) where T : Laptop
        {
            if (producers == null && countries == null && materials == null && colors == null && amountOfRAM == null && CPUFrequency == null
                && height == null && length == null && haveFloppyDrives == null && width == null && SSDMemory == null
                && hardDiskMemory == null && CPUSocketType == null && computerDriveType == null && floppyDrivesCount == null && display == null
                && priceFrom == null && priceTo == null)
            {
                return laptops;
            }
            return laptops
                .Where(g => (numberOfCores != null && numberOfCores.Contains(g.NumberOfCores)) ||
                ((priceFrom == null || g.Price >= priceFrom) && (priceTo == null || g.Price <= priceTo)
                && (haveFloppyDrives == null || haveFloppyDrives.Contains(g.HaveFloppyDrives))
                && (computerDriveType == null || computerDriveType.Contains(g.ComputerDriveType))
                && (display == null || display.Contains(g.Display))
                && (floppyDrivesCount == null || floppyDrivesCount.Contains(g.FloppyDrivesCount))
                && (CPUSocketType == null || CPUSocketType.Contains(g.CPUSocketType))
                && (hardDiskMemory == null || hardDiskMemory.Contains(g.HardDiskMemory))
                && (SSDMemory == null || SSDMemory.Contains(g.SSDMemory))
                && (width == null || width.Contains(g.Width))
                && (length == null || length.Contains(g.Length))
                && (height == null || height.Contains(g.Height))
                && (CPUFrequency == null || CPUFrequency.Contains(g.CPUFrequency))
                && (amountOfRAM == null || amountOfRAM.Contains(g.AmountOfRAM))
                && (producers == null || producers.Contains(g.Producer.Name))
                && (countries == null || countries.Contains(g.Manufacturer.Country.Value))
                && (materials == null || materials.Contains(g.MaterialValue))
                && (colors == null || colors.Contains(g.ColorValue))));
        }
        public IQueryable<T> GetFloppyDrivesCountLaptops<T>(
            IQueryable<T> laptops,
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
            decimal? priceTo) where T : Laptop
        {
            if (producers == null && countries == null && materials == null && colors == null && amountOfRAM == null && CPUFrequency == null
                && height == null && length == null && haveFloppyDrives == null && width == null && SSDMemory == null
                && hardDiskMemory == null && CPUSocketType == null && computerDriveType == null && numberOfCores == null && display == null
                && priceFrom == null && priceTo == null)
            {
                return laptops;
            }
            return laptops
                .Where(g => (floppyDrivesCount != null && floppyDrivesCount.Contains(g.FloppyDrivesCount)) ||
                ((priceFrom == null || g.Price >= priceFrom) && (priceTo == null || g.Price <= priceTo)
                && (haveFloppyDrives == null || haveFloppyDrives.Contains(g.HaveFloppyDrives))
                && (computerDriveType == null || computerDriveType.Contains(g.ComputerDriveType))
                && (display == null || display.Contains(g.Display))
                && (numberOfCores == null || numberOfCores.Contains(g.NumberOfCores))
                && (CPUSocketType == null || CPUSocketType.Contains(g.CPUSocketType))
                && (hardDiskMemory == null || hardDiskMemory.Contains(g.HardDiskMemory))
                && (SSDMemory == null || SSDMemory.Contains(g.SSDMemory))
                && (width == null || width.Contains(g.Width))
                && (length == null || length.Contains(g.Length))
                && (height == null || height.Contains(g.Height))
                && (CPUFrequency == null || CPUFrequency.Contains(g.CPUFrequency))
                && (amountOfRAM == null || amountOfRAM.Contains(g.AmountOfRAM))
                && (producers == null || producers.Contains(g.Producer.Name))
                && (countries == null || countries.Contains(g.Manufacturer.Country.Value))
                && (materials == null || materials.Contains(g.MaterialValue))
                && (colors == null || colors.Contains(g.ColorValue))));
        }
        public IQueryable<T> GetDisplayLaptops<T>(
            IQueryable<T> laptops,
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
            decimal? priceTo) where T : Laptop
        {
            if (producers == null && countries == null && materials == null && colors == null && amountOfRAM == null && CPUFrequency == null
                && height == null && length == null && haveFloppyDrives == null && width == null && SSDMemory == null
                && hardDiskMemory == null && CPUSocketType == null && computerDriveType == null && numberOfCores == null && floppyDrivesCount == null
                && priceFrom == null && priceTo == null)
            {
                return laptops;
            }
            return laptops
                .Where(g => (display != null && display.Contains(g.Display)) ||
                ((priceFrom == null || g.Price >= priceFrom) && (priceTo == null || g.Price <= priceTo)
                && (haveFloppyDrives == null || haveFloppyDrives.Contains(g.HaveFloppyDrives))
                && (computerDriveType == null || computerDriveType.Contains(g.ComputerDriveType))
                && (floppyDrivesCount == null || floppyDrivesCount.Contains(g.Display))
                && (numberOfCores == null || numberOfCores.Contains(g.NumberOfCores))
                && (CPUSocketType == null || CPUSocketType.Contains(g.CPUSocketType))
                && (hardDiskMemory == null || hardDiskMemory.Contains(g.HardDiskMemory))
                && (SSDMemory == null || SSDMemory.Contains(g.SSDMemory))
                && (width == null || width.Contains(g.Width))
                && (length == null || length.Contains(g.Length))
                && (height == null || height.Contains(g.Height))
                && (CPUFrequency == null || CPUFrequency.Contains(g.CPUFrequency))
                && (amountOfRAM == null || amountOfRAM.Contains(g.AmountOfRAM))
                && (producers == null || producers.Contains(g.Producer.Name))
                && (countries == null || countries.Contains(g.Manufacturer.Country.Value))
                && (materials == null || materials.Contains(g.MaterialValue))
                && (colors == null || colors.Contains(g.ColorValue))));
        }
        public IQueryable<T> GetHaveFloppyDrivesLaptops<T>(
            IQueryable<T> laptops,
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
            decimal? priceTo) where T : Laptop
        {
            if (producers == null && countries == null && materials == null && colors == null && amountOfRAM == null && CPUFrequency == null
                && height == null && length == null && display == null && width == null && SSDMemory == null
                && hardDiskMemory == null && CPUSocketType == null && computerDriveType == null && numberOfCores == null && floppyDrivesCount == null
                && priceFrom == null && priceTo == null)
            {
                return laptops;
            }
            return laptops
                .Where(g =>
                ((priceFrom == null || g.Price >= priceFrom) && (priceTo == null || g.Price <= priceTo)
                && (haveFloppyDrives == null || haveFloppyDrives.Contains(g.HaveFloppyDrives))
                && (display == null || display.Contains(g.Display))
                && (computerDriveType == null || computerDriveType.Contains(g.ComputerDriveType))
                && (floppyDrivesCount == null || floppyDrivesCount.Contains(g.FloppyDrivesCount))
                && (numberOfCores == null || numberOfCores.Contains(g.NumberOfCores))
                && (CPUSocketType == null || CPUSocketType.Contains(g.CPUSocketType))
                && (hardDiskMemory == null || hardDiskMemory.Contains(g.HardDiskMemory))
                && (SSDMemory == null || SSDMemory.Contains(g.SSDMemory))
                && (width == null || width.Contains(g.Width))
                && (length == null || length.Contains(g.Length))
                && (height == null || height.Contains(g.Height))
                && (CPUFrequency == null || CPUFrequency.Contains(g.CPUFrequency))
                && (amountOfRAM == null || amountOfRAM.Contains(g.AmountOfRAM))
                && (producers == null || producers.Contains(g.Producer.Name))
                && (countries == null || countries.Contains(g.Manufacturer.Country.Value))
                && (materials == null || materials.Contains(g.MaterialValue))
                && (colors == null || colors.Contains(g.ColorValue))));
        }






        public async Task<QuestionsBase<string>> GetProducerQuestion(IQueryable<Laptop> laptops, string[] producers)
        {
            return await _computerTechnologiesQuestionsService.GetProducerQuestion(laptops, producers);
        }
        public async Task<QuestionsBase<string>> GetCountryQuestion(IQueryable<Laptop> laptops, string[] countries)
        {
            return await _computerTechnologiesQuestionsService.GetCountryQuestion(laptops, countries);
        }
        public async Task<QuestionsBase<string>> GetMaterialQuestion(IQueryable<Laptop> laptops, string[] materials)
        {
            return await _computerTechnologiesQuestionsService.GetMaterialQuestion(laptops, materials);
        }
        public async Task<QuestionsBase<string>> GetColorQuestion(IQueryable<Laptop> laptops, string[] colors)
        {
            return await _computerTechnologiesQuestionsService.GetColorQuestion(laptops, colors);
        }
        public async Task<QuestionsBase<string>> GetPriceQuestion(IQueryable<Laptop> laptops, decimal? selectedFrom, decimal? selectedTo)
        {
            return await _computerTechnologiesQuestionsService.GetPriceQuestion(laptops, selectedFrom, selectedTo);
        }

        public async Task<QuestionsBase<string>> GetAmountOfRAMQuestion(IQueryable<Laptop> laptops, int[] amountOfRAMs)
        {
            return new QuestionsBase<string>()
            {
                Key = "amountOfRAM",
                Value = "Select amount of RAM",
                Order = 5,
                QuestionBaseList = await laptops
                        .Select(g => g.AmountOfRAM)
                        .GroupBy(p => p)
                        .Select(p => new { Count = p.Count(), Value = p.Key })
                        .Select(amountOfRAM => new QuestionBase<string>()
                        {
                            AfterBox = $"({amountOfRAM.Count})",
                            Checked = amountOfRAMs != null && amountOfRAMs.Contains(amountOfRAM.Value),
                            ControlType = ControlType.Checkbox,
                            Key = amountOfRAM.Value.ToString(),
                            Label = amountOfRAM.Value.ToString(),
                            Required = false,
                            Type = InputType.Checkbox,
                        }).ToListAsync()
            };
        }
        public async Task<QuestionsBase<string>> GetCPUFrequencyQuestion(IQueryable<Laptop> laptops, int[] CPUFrequencies)
        {
            return new QuestionsBase<string>()
            {
                Key = "CPUFrequency",
                Value = "Select CPU frequency",
                Order = 6,
                QuestionBaseList = await laptops
                        .Select(g => g.CPUFrequency)
                        .GroupBy(p => p)
                        .Select(p => new { Count = p.Count(), Value = p.Key })
                        .Select(CPUFrequency => new QuestionBase<string>()
                        {
                            AfterBox = $"({CPUFrequency.Count})",
                            Checked = CPUFrequencies != null && CPUFrequencies.Contains(CPUFrequency.Value),
                            ControlType = ControlType.Checkbox,
                            Key = CPUFrequency.Value.ToString(),
                            Label = CPUFrequency.Value.ToString(),
                            Required = false,
                            Type = InputType.Checkbox,
                        }).ToListAsync()
            };
        }
        public async Task<QuestionsBase<string>> GetHeightQuestion(IQueryable<Laptop> laptops, float[] heights)
        {
            return new QuestionsBase<string>()
            {
                Key = "height",
                Value = "Select height",
                Order = 7,
                QuestionBaseList = await laptops
                        .Select(g => g.Height)
                        .GroupBy(p => p)
                        .Select(p => new { Count = p.Count(), Value = p.Key })
                        .Select(height => new QuestionBase<string>()
                        {
                            AfterBox = $"({height.Count})",
                            Checked = heights != null && heights.Contains(height.Value),
                            ControlType = ControlType.Checkbox,
                            Key = height.Value.ToString(),
                            Label = height.Value.ToString(),
                            Required = false,
                            Type = InputType.Checkbox,
                        }).ToListAsync()
            };
        }
        public async Task<QuestionsBase<string>> GetWidthQuestion(IQueryable<Laptop> laptops, float[] widths)
        {
            return new QuestionsBase<string>()
            {
                Key = "width",
                Value = "Select width",
                Order = 8,
                QuestionBaseList = await laptops
                        .Select(g => g.Width)
                        .GroupBy(p => p)
                        .Select(p => new { Count = p.Count(), Value = p.Key })
                        .Select(width => new QuestionBase<string>()
                        {
                            AfterBox = $"({width.Count})",
                            Checked = widths != null && widths.Contains(width.Value),
                            ControlType = ControlType.Checkbox,
                            Key = width.Value.ToString(),
                            Label = width.Value.ToString(),
                            Required = false,
                            Type = InputType.Checkbox,
                        }).ToListAsync()
            };
        }
        public async Task<QuestionsBase<string>> GetLengthQuestion(IQueryable<Laptop> laptops, float[] lengthes)
        {
            return new QuestionsBase<string>()
            {
                Key = "length",
                Value = "Select length",
                Order = 9,
                QuestionBaseList = await laptops
                        .Select(g => g.Length)
                        .GroupBy(p => p)
                        .Select(p => new { Count = p.Count(), Value = p.Key })
                        .Select(length => new QuestionBase<string>()
                        {
                            AfterBox = $"({length.Count})",
                            Checked = lengthes != null && lengthes.Contains(length.Value),
                            ControlType = ControlType.Checkbox,
                            Key = length.Value.ToString(),
                            Label = length.Value.ToString(),
                            Required = false,
                            Type = InputType.Checkbox,
                        }).ToListAsync()
            };
        }
        public async Task<QuestionsBase<string>> GetHaveFloppyDrivesQuestion(IQueryable<Laptop> laptops, bool[] haveFloppyDrives)
        {
            return new QuestionsBase<string>()
            {
                Key = "haveFloppyDrives",
                Value = "Have floppy drive",
                Order = 10,
                QuestionBaseList = await laptops
                        .Select(g => g.HaveFloppyDrives)
                        .GroupBy(p => p)
                        .Select(p => new { Count = p.Count(), Value = p.Key })
                        .Select(haveFloppyDrive => new QuestionBase<string>()
                        {
                            AfterBox = $"({haveFloppyDrive.Count})",
                            Checked = haveFloppyDrives != null && haveFloppyDrives.Contains(haveFloppyDrive.Value),
                            ControlType = ControlType.Checkbox,
                            Key = haveFloppyDrive.Value.ToString(),
                            Label = haveFloppyDrive.Value.ToString(),
                            Required = false,
                            Type = InputType.Checkbox,
                        }).ToListAsync()
            };
        }
        public async Task<QuestionsBase<string>> GetSSDMemoryQuestion(IQueryable<Laptop> laptops, int?[] SSDMemories)
        {
            return new QuestionsBase<string>()
            {
                Key = "SSDMemory",
                Value = "Select SSD memory",
                Order = 11,
                QuestionBaseList = await laptops
                        .Select(g => g.SSDMemory)
                        .GroupBy(p => p)
                        .Select(p => new { Count = p.Count(), Value = p.Key })
                        .Select(SSDMemory => new QuestionBase<string>()
                        {
                            AfterBox = $"({SSDMemory.Count})",
                            Checked = SSDMemories != null && SSDMemories.Contains(SSDMemory.Value),
                            ControlType = ControlType.Checkbox,
                            Key = SSDMemory.Value.ToString(),
                            Label = SSDMemory.Value.ToString(),
                            Required = false,
                            Type = InputType.Checkbox,
                        }).ToListAsync()
            };
        }
        public async Task<QuestionsBase<string>> GetHardDiskMemoryQuestion(IQueryable<Laptop> laptops, int?[] hardDiskMemories)
        {
            return new QuestionsBase<string>()
            {
                Key = "hardDiskMemory",
                Value = "Select hard disk memory",
                Order = 12,
                QuestionBaseList = await laptops
                        .Select(g => g.HardDiskMemory)
                        .GroupBy(p => p)
                        .Select(p => new { Count = p.Count(), Value = p.Key })
                        .Select(hardDiskMemory => new QuestionBase<string>()
                        {
                            AfterBox = $"({hardDiskMemory.Count})",
                            Checked = hardDiskMemories != null && hardDiskMemories.Contains(hardDiskMemory.Value),
                            ControlType = ControlType.Checkbox,
                            Key = hardDiskMemory.Value.ToString(),
                            Label = hardDiskMemory.Value.ToString(),
                            Required = false,
                            Type = InputType.Checkbox,
                        }).ToListAsync()
            };
        }
        public async Task<QuestionsBase<string>> GetCPUSocketTypeQuestion(IQueryable<Laptop> laptops, CPUSocketType[] CPUSocketTypes)
        {
            return new QuestionsBase<string>()
            {
                Key = "CPUSocketType",
                Value = "Select CPU socket type",
                Order = 13,
                QuestionBaseList = await laptops
                        .Select(g => g.CPUSocketType)
                        .GroupBy(p => p)
                        .Select(p => new { Count = p.Count(), Value = p.Key })
                        .Select(CPUSocketType => new QuestionBase<string>()
                        {
                            AfterBox = $"({CPUSocketType.Count})",
                            Checked = CPUSocketTypes != null && CPUSocketTypes.Contains(CPUSocketType.Value),
                            ControlType = ControlType.Checkbox,
                            Key = CPUSocketType.Value.ToString(),
                            Label = CPUSocketType.Value.ToString(),
                            Required = false,
                            Type = InputType.Checkbox,
                        }).ToListAsync()
            };
        }
        public async Task<QuestionsBase<string>> GetComputerDriveTypeQuestion(IQueryable<Laptop> laptops, ComputerDriveType[] computerDriveTypes)
        {
            return new QuestionsBase<string>()
            {
                Key = "computerDriveType",
                Value = "Select computer drive type",
                Order = 14,
                QuestionBaseList = await laptops
                        .Select(g => g.ComputerDriveType)
                        .GroupBy(p => p)
                        .Select(p => new { Count = p.Count(), Value = p.Key })
                        .Select(computerDriveType => new QuestionBase<string>()
                        {
                            AfterBox = $"({computerDriveType.Count})",
                            Checked = computerDriveTypes != null && computerDriveTypes.Contains(computerDriveType.Value),
                            ControlType = ControlType.Checkbox,
                            Key = computerDriveType.Value.ToString(),
                            Label = computerDriveType.Value.ToString(),
                            Required = false,
                            Type = InputType.Checkbox,
                        }).ToListAsync()
            };
        }
        public async Task<QuestionsBase<string>> GetNumberOfCoreQuestion(IQueryable<Laptop> laptops, int[] numberOfCores)
        {
            return new QuestionsBase<string>()
            {
                Key = "numberOfCores",
                Value = "Select number of cores",
                Order = 15,
                QuestionBaseList = await laptops
                        .Select(g => g.NumberOfCores)
                        .GroupBy(p => p)
                        .Select(p => new { Count = p.Count(), Value = p.Key })
                        .Select(numberOfCore => new QuestionBase<string>()
                        {
                            AfterBox = $"({numberOfCore.Count})",
                            Checked = numberOfCores != null && numberOfCores.Contains(numberOfCore.Value),
                            ControlType = ControlType.Checkbox,
                            Key = numberOfCore.Value.ToString(),
                            Label = numberOfCore.Value.ToString(),
                            Required = false,
                            Type = InputType.Checkbox,
                        }).ToListAsync()
            };
        }
        public async Task<QuestionsBase<string>> GetFloppyDrivesCountQuestion(IQueryable<Laptop> laptops, int?[] floppyDrivesCountArray)
        {
            return new QuestionsBase<string>()
            {
                Key = "floppyDrivesCount",
                Value = "Select floppy drives count",
                Order = 16,
                QuestionBaseList = await laptops
                        .Select(g => g.FloppyDrivesCount)
                        .GroupBy(p => p)
                        .Select(p => new { Count = p.Count(), Value = p.Key })
                        .Select(floppyDrivesCount => new QuestionBase<string>()
                        {
                            AfterBox = $"({floppyDrivesCount.Count})",
                            Checked = floppyDrivesCountArray != null && floppyDrivesCountArray.Contains(floppyDrivesCount.Value),
                            ControlType = ControlType.Checkbox,
                            Key = floppyDrivesCount.Value.ToString(),
                            Label = floppyDrivesCount.Value.ToString(),
                            Required = false,
                            Type = InputType.Checkbox,
                        }).ToListAsync()
            };
        }
        public async Task<QuestionsBase<string>> GetDisplayQuestion(IQueryable<Laptop> laptops, int[] displays)
        {
            return new QuestionsBase<string>()
            {
                Key = "display",
                Value = "Select display",
                Order = 17,
                QuestionBaseList = await laptops
                        .Select(g => g.Display)
                        .GroupBy(p => p)
                        .Select(p => new { Count = p.Count(), Value = p.Key })
                        .Select(display => new QuestionBase<string>()
                        {
                            AfterBox = $"({display.Count})",
                            Checked = displays != null && displays.Contains(display.Value),
                            ControlType = ControlType.Checkbox,
                            Key = display.Value.ToString(),
                            Label = display.Value.ToString(),
                            Required = false,
                            Type = InputType.Checkbox,
                        }).ToListAsync()
            };
        }
    }
}
