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
    public class ComputersQuestionsService : IComputersQuestionsService
    {
        private readonly IComputerTechnologiesQuestionsService _computerTechnologiesQuestionsService;
        public ComputersQuestionsService(IComputerTechnologiesQuestionsService computerTechnologiesQuestionsService)
        {
            _computerTechnologiesQuestionsService = computerTechnologiesQuestionsService;
        }
        public async Task<List<QuestionsBase<string>>> GetComputersQuestions(
            IQueryable<Computer> computers,
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
            decimal? priceFrom,
            decimal? priceTo)
        {
            var result = new List<QuestionsBase<string>>()
                {
                    await GetProducerQuestion(GetProducerComputers(computers, producers, countries, materials, colors, amountOfRAM, CPUFrequency,
                    length, height, width, haveFloppyDrives, SSDMemory, hardDiskMemory, CPUSocketType, computerDriveType,
                    numberOfCores, floppyDrivesCount, priceFrom, priceTo), producers),
                    await GetCountryQuestion(GetCountryComputers(computers, producers, countries, materials, colors, amountOfRAM, CPUFrequency,
                    length, height, width, haveFloppyDrives, SSDMemory, hardDiskMemory, CPUSocketType, computerDriveType,
                    numberOfCores, floppyDrivesCount, priceFrom, priceTo), countries),
                    await GetMaterialQuestion(GetMaterialComputers(computers, producers, countries, materials, colors, amountOfRAM, CPUFrequency,
                    length, height, width, haveFloppyDrives, SSDMemory, hardDiskMemory, CPUSocketType, computerDriveType,
                    numberOfCores, floppyDrivesCount, priceFrom, priceTo), materials),
                    await GetColorQuestion(GetColorComputers(computers, producers, countries, materials, colors, amountOfRAM, CPUFrequency,
                    length, height, width, haveFloppyDrives, SSDMemory, hardDiskMemory, CPUSocketType, computerDriveType,
                    numberOfCores, floppyDrivesCount, priceFrom, priceTo), colors),
                    await GetPriceQuestion(GetPriceComputers(computers, producers, countries, materials, colors, amountOfRAM, CPUFrequency,
                    length, height, width, haveFloppyDrives, SSDMemory, hardDiskMemory, CPUSocketType, computerDriveType,
                    numberOfCores, floppyDrivesCount, priceFrom, priceTo), priceFrom, priceTo),

                    await GetAmountOfRAMQuestion(GetAmountOfRAMComputers(computers, producers, countries, materials, colors, amountOfRAM, CPUFrequency,
                    length, height, width, haveFloppyDrives, SSDMemory, hardDiskMemory, CPUSocketType, computerDriveType,
                    numberOfCores, floppyDrivesCount, priceFrom, priceTo), amountOfRAM),
                    await GetCPUFrequencyQuestion(GetCPUFrequencyComputers(computers, producers, countries, materials, colors, amountOfRAM, CPUFrequency,
                    length, height, width, haveFloppyDrives, SSDMemory, hardDiskMemory, CPUSocketType, computerDriveType,
                    numberOfCores, floppyDrivesCount, priceFrom, priceTo), CPUFrequency),
                    await GetLengthQuestion(GetLengthComputers(computers, producers, countries, materials, colors, amountOfRAM, CPUFrequency,
                    length, height, width, haveFloppyDrives, SSDMemory, hardDiskMemory, CPUSocketType, computerDriveType,
                    numberOfCores, floppyDrivesCount, priceFrom, priceTo), length),
                    await GetHeightQuestion(GetHeightComputers(computers, producers, countries, materials, colors, amountOfRAM, CPUFrequency,
                    length, height, width, haveFloppyDrives, SSDMemory, hardDiskMemory, CPUSocketType, computerDriveType,
                    numberOfCores, floppyDrivesCount, priceFrom, priceTo), height),
                    await GetWidthQuestion(GetWidthComputers(computers, producers, countries, materials, colors, amountOfRAM, CPUFrequency,
                    length, height, width, haveFloppyDrives, SSDMemory, hardDiskMemory, CPUSocketType, computerDriveType,
                    numberOfCores, floppyDrivesCount, priceFrom, priceTo), width),
                    await GetHaveFloppyDrivesQuestion(GetHaveFloppyDrivesComputers(computers, producers, countries, materials, colors, amountOfRAM, CPUFrequency,
                    length, height, width, haveFloppyDrives, SSDMemory, hardDiskMemory, CPUSocketType, computerDriveType,
                    numberOfCores, floppyDrivesCount, priceFrom, priceTo), haveFloppyDrives),
                    await GetSSDMemoryQuestion(GetSSDMemoryComputers(computers, producers, countries, materials, colors, amountOfRAM, CPUFrequency,
                    length, height, width, haveFloppyDrives, SSDMemory, hardDiskMemory, CPUSocketType, computerDriveType,
                    numberOfCores, floppyDrivesCount, priceFrom, priceTo), SSDMemory),
                    await GetHardDiskMemoryQuestion(GetHardDiskMemoryComputers(computers, producers, countries, materials, colors, amountOfRAM, CPUFrequency,
                    length, height, width, haveFloppyDrives, SSDMemory, hardDiskMemory, CPUSocketType, computerDriveType,
                    numberOfCores, floppyDrivesCount, priceFrom, priceTo), hardDiskMemory),
                    await GetCPUSocketTypeQuestion(GetCPUSocketTypeComputers(computers, producers, countries, materials, colors, amountOfRAM, CPUFrequency,
                    length, height, width, haveFloppyDrives, SSDMemory, hardDiskMemory, CPUSocketType, computerDriveType,
                    numberOfCores, floppyDrivesCount, priceFrom, priceTo), CPUSocketType),
                    await GetComputerDriveTypeQuestion(GetComputerDriveTypeComputers(computers, producers, countries, materials, colors, amountOfRAM, CPUFrequency,
                    length, height, width, haveFloppyDrives, SSDMemory, hardDiskMemory, CPUSocketType, computerDriveType,
                    numberOfCores, floppyDrivesCount, priceFrom, priceTo), computerDriveType),
                    await GetNumberOfCoreQuestion(GetNumberOfCoresComputers(computers, producers, countries, materials, colors, amountOfRAM, CPUFrequency,
                    length, height, width, haveFloppyDrives, SSDMemory, hardDiskMemory, CPUSocketType, computerDriveType,
                    numberOfCores, floppyDrivesCount, priceFrom, priceTo), numberOfCores)
                };
            if (haveFloppyDrives != null && !haveFloppyDrives.Contains(true) && haveFloppyDrives.Contains(false))
            {
                result.Add(await GetFloppyDrivesCountQuestion(GetFloppyDrivesCountComputers(computers, producers, countries, materials, colors, amountOfRAM, CPUFrequency,
                    length, height, width, haveFloppyDrives, SSDMemory, hardDiskMemory, CPUSocketType, computerDriveType,
                    numberOfCores, floppyDrivesCount, priceFrom, priceTo), floppyDrivesCount));
            }
            return result;
        }

        public IQueryable<T> GetProducerComputers<T>(
            IQueryable<T> computers,
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
            decimal? priceFrom,
            decimal? priceTo) where T : Computer
        {
            return _computerTechnologiesQuestionsService.GetProducerComputerTechnologies(
                computers, producers, countries, materials, colors, priceFrom, priceTo)
                .Where(l => (producers != null && producers.Contains(l.Producer.Name)) ||
                ((haveFloppyDrives == null || haveFloppyDrives.Contains(l.HaveFloppyDrives))
                && (amountOfRAM == null || amountOfRAM.Contains(l.AmountOfRAM))
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
        public IQueryable<T> GetCountryComputers<T>(
            IQueryable<T> computers,
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
            decimal? priceFrom,
            decimal? priceTo) where T : Computer
        {
            return _computerTechnologiesQuestionsService.GetCountryComputerTechnologies(
                computers, producers, countries, materials, colors, priceFrom, priceTo)
                .Where(l => (countries != null && countries.Contains(l.Manufacturer.Country.Value)) ||
                ((haveFloppyDrives == null || haveFloppyDrives.Contains(l.HaveFloppyDrives))
                && (amountOfRAM == null || amountOfRAM.Contains(l.AmountOfRAM))
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
        public IQueryable<T> GetMaterialComputers<T>(
            IQueryable<T> computers,
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
            decimal? priceFrom,
            decimal? priceTo) where T : Computer
        {
            return _computerTechnologiesQuestionsService.GetMaterialComputerTechnologies(
                computers, producers, countries, materials, colors, priceFrom, priceTo)
                .Where(l => (materials != null && materials.Contains(l.MaterialValue)) ||
                ((haveFloppyDrives == null || haveFloppyDrives.Contains(l.HaveFloppyDrives))
                && (amountOfRAM == null || amountOfRAM.Contains(l.AmountOfRAM))
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
        public IQueryable<T> GetColorComputers<T>(
            IQueryable<T> computers,
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
            decimal? priceFrom,
            decimal? priceTo) where T : Computer
        {
            return _computerTechnologiesQuestionsService.GetColorComputerTechnologies(
                computers, producers, countries, materials, colors, priceFrom, priceTo)
                .Where(l => (colors != null && colors.Contains(l.ColorValue)) ||
                ((haveFloppyDrives == null || haveFloppyDrives.Contains(l.HaveFloppyDrives))
                && (amountOfRAM == null || amountOfRAM.Contains(l.AmountOfRAM))
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
        public IQueryable<T> GetPriceComputers<T>(
            IQueryable<T> computers,
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
            decimal? priceFrom,
            decimal? priceTo) where T : Computer
        {
            return _computerTechnologiesQuestionsService.GetPriceComputerTechnologies(
                computers, producers, countries, materials, colors, priceFrom, priceTo)
                .Where(l =>
                (haveFloppyDrives == null || haveFloppyDrives.Contains(l.HaveFloppyDrives))
                && (amountOfRAM == null || amountOfRAM.Contains(l.AmountOfRAM))
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
        public IQueryable<T> GetAmountOfRAMComputers<T>(
            IQueryable<T> computers,
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
            decimal? priceFrom,
            decimal? priceTo) where T : Computer
        {
            if (producers == null && countries == null && materials == null && colors == null && CPUFrequency == null && length == null
                && height == null && width == null && haveFloppyDrives == null && SSDMemory == null && hardDiskMemory == null
                && CPUSocketType == null && computerDriveType == null && numberOfCores == null && floppyDrivesCount == null
                && priceFrom == null && priceTo == null)
            {
                return computers;
            }
            return computers
                .Where(g => (amountOfRAM != null && amountOfRAM.Contains(g.AmountOfRAM)) ||
                ((priceFrom == null || g.Price >= priceFrom) && (priceTo == null || g.Price <= priceTo)
                && (haveFloppyDrives == null || haveFloppyDrives.Contains(g.HaveFloppyDrives))
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
        public IQueryable<T> GetCPUFrequencyComputers<T>(
            IQueryable<T> computers,
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
            decimal? priceFrom,
            decimal? priceTo) where T : Computer
        {
            if (producers == null && countries == null && materials == null && colors == null && amountOfRAM == null && length == null
                && height == null && width == null && haveFloppyDrives == null && SSDMemory == null && hardDiskMemory == null
                && CPUSocketType == null && computerDriveType == null && numberOfCores == null && floppyDrivesCount == null
                && priceFrom == null && priceTo == null)
            {
                return computers;
            }
            return computers
                .Where(g => (CPUFrequency != null && CPUFrequency.Contains(g.CPUFrequency)) ||
                ((priceFrom == null || g.Price >= priceFrom) && (priceTo == null || g.Price <= priceTo)
                && (haveFloppyDrives == null || haveFloppyDrives.Contains(g.HaveFloppyDrives))
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
        public IQueryable<T> GetLengthComputers<T>(
            IQueryable<T> computers,
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
            decimal? priceFrom,
            decimal? priceTo) where T : Computer
        {
            if (producers == null && countries == null && materials == null && colors == null && amountOfRAM == null && CPUFrequency == null
                && height == null && width == null && haveFloppyDrives == null && SSDMemory == null && hardDiskMemory == null
                && CPUSocketType == null && computerDriveType == null && numberOfCores == null && floppyDrivesCount == null
                && priceFrom == null && priceTo == null)
            {
                return computers;
            }
            return computers
                .Where(g => (length != null && length.Contains(g.Length)) ||
                ((priceFrom == null || g.Price >= priceFrom) && (priceTo == null || g.Price <= priceTo)
                && (haveFloppyDrives == null || haveFloppyDrives.Contains(g.HaveFloppyDrives))
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
        public IQueryable<T> GetHeightComputers<T>(
            IQueryable<T> computers,
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
            decimal? priceFrom,
            decimal? priceTo) where T : Computer
        {
            if (producers == null && countries == null && materials == null && colors == null && amountOfRAM == null && CPUFrequency == null
                && length == null && width == null && haveFloppyDrives == null && SSDMemory == null && hardDiskMemory == null
                && CPUSocketType == null && computerDriveType == null && numberOfCores == null && floppyDrivesCount == null
                && priceFrom == null && priceTo == null)
            {
                return computers;
            }
            return computers
                .Where(g => (height != null && height.Contains(g.Height)) ||
                ((priceFrom == null || g.Price >= priceFrom) && (priceTo == null || g.Price <= priceTo)
                && (haveFloppyDrives == null || haveFloppyDrives.Contains(g.HaveFloppyDrives))
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
        public IQueryable<T> GetWidthComputers<T>(
            IQueryable<T> computers,
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
            decimal? priceFrom,
            decimal? priceTo) where T : Computer
        {
            if (producers == null && countries == null && materials == null && colors == null && amountOfRAM == null && CPUFrequency == null
                && height == null && length == null && haveFloppyDrives == null && SSDMemory == null && hardDiskMemory == null
                && CPUSocketType == null && computerDriveType == null && numberOfCores == null && floppyDrivesCount == null
                && priceFrom == null && priceTo == null)
            {
                return computers;
            }
            return computers
                .Where(g => (width != null && width.Contains(g.Width)) ||
                ((priceFrom == null || g.Price >= priceFrom) && (priceTo == null || g.Price <= priceTo)
                && (haveFloppyDrives == null || haveFloppyDrives.Contains(g.HaveFloppyDrives))
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
        public IQueryable<T> GetSSDMemoryComputers<T>(
            IQueryable<T> computers,
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
            decimal? priceFrom,
            decimal? priceTo) where T : Computer
        {
            if (producers == null && countries == null && materials == null && colors == null && amountOfRAM == null && CPUFrequency == null
                && height == null && length == null && haveFloppyDrives == null && width == null && hardDiskMemory == null
                && CPUSocketType == null && computerDriveType == null && numberOfCores == null && floppyDrivesCount == null
                && priceFrom == null && priceTo == null)
            {
                return computers;
            }
            return computers
                .Where(g => (SSDMemory != null && SSDMemory.Contains(g.SSDMemory)) ||
                ((priceFrom == null || g.Price >= priceFrom) && (priceTo == null || g.Price <= priceTo)
                && (haveFloppyDrives == null || haveFloppyDrives.Contains(g.HaveFloppyDrives))
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
        public IQueryable<T> GetHardDiskMemoryComputers<T>(
            IQueryable<T> computers,
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
            decimal? priceFrom,
            decimal? priceTo) where T : Computer
        {
            if (producers == null && countries == null && materials == null && colors == null && amountOfRAM == null && CPUFrequency == null
                && height == null && length == null && haveFloppyDrives == null && width == null && SSDMemory == null
                && CPUSocketType == null && computerDriveType == null && numberOfCores == null && floppyDrivesCount == null
                && priceFrom == null && priceTo == null)
            {
                return computers;
            }
            return computers
                .Where(g => (hardDiskMemory != null && hardDiskMemory.Contains(g.HardDiskMemory)) ||
                ((priceFrom == null || g.Price >= priceFrom) && (priceTo == null || g.Price <= priceTo)
                && (haveFloppyDrives == null || haveFloppyDrives.Contains(g.HaveFloppyDrives))
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
        public IQueryable<T> GetCPUSocketTypeComputers<T>(
            IQueryable<T> computers,
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
            decimal? priceFrom,
            decimal? priceTo) where T : Computer
        {
            if (producers == null && countries == null && materials == null && colors == null && amountOfRAM == null && CPUFrequency == null
                && height == null && length == null && haveFloppyDrives == null && width == null && SSDMemory == null
                && hardDiskMemory == null && computerDriveType == null && numberOfCores == null && floppyDrivesCount == null
                && priceFrom == null && priceTo == null)
            {
                return computers;
            }
            return computers
                .Where(g => (CPUSocketType != null && CPUSocketType.Contains(g.CPUSocketType)) ||
                ((priceFrom == null || g.Price >= priceFrom) && (priceTo == null || g.Price <= priceTo)
                && (haveFloppyDrives == null || haveFloppyDrives.Contains(g.HaveFloppyDrives))
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
        public IQueryable<T> GetComputerDriveTypeComputers<T>(
            IQueryable<T> computers,
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
            decimal? priceFrom,
            decimal? priceTo) where T : Computer
        {
            if (producers == null && countries == null && materials == null && colors == null && amountOfRAM == null && CPUFrequency == null
                && height == null && length == null && haveFloppyDrives == null && width == null && SSDMemory == null
                && hardDiskMemory == null && CPUSocketType == null && numberOfCores == null && floppyDrivesCount == null
                && priceFrom == null && priceTo == null)
            {
                return computers;
            }
            return computers
                .Where(g => (computerDriveType != null && computerDriveType.Contains(g.ComputerDriveType)) ||
                ((priceFrom == null || g.Price >= priceFrom) && (priceTo == null || g.Price <= priceTo)
                && (haveFloppyDrives == null || haveFloppyDrives.Contains(g.HaveFloppyDrives))
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
        public IQueryable<T> GetNumberOfCoresComputers<T>(
            IQueryable<T> computers,
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
            decimal? priceFrom,
            decimal? priceTo) where T : Computer
        {
            if (producers == null && countries == null && materials == null && colors == null && amountOfRAM == null && CPUFrequency == null
                && height == null && length == null && haveFloppyDrives == null && width == null && SSDMemory == null
                && hardDiskMemory == null && CPUSocketType == null && computerDriveType == null && floppyDrivesCount == null
                && priceFrom == null && priceTo == null)
            {
                return computers;
            }
            return computers
                .Where(g => (numberOfCores != null && numberOfCores.Contains(g.NumberOfCores)) ||
                ((priceFrom == null || g.Price >= priceFrom) && (priceTo == null || g.Price <= priceTo)
                && (haveFloppyDrives == null || haveFloppyDrives.Contains(g.HaveFloppyDrives))
                && (computerDriveType == null || computerDriveType.Contains(g.ComputerDriveType))
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
        public IQueryable<T> GetFloppyDrivesCountComputers<T>(
            IQueryable<T> computers,
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
            decimal? priceFrom,
            decimal? priceTo) where T : Computer
        {
            if (producers == null && countries == null && materials == null && colors == null && amountOfRAM == null && CPUFrequency == null
                && height == null && length == null && haveFloppyDrives == null && width == null && SSDMemory == null
                && hardDiskMemory == null && CPUSocketType == null && computerDriveType == null && numberOfCores == null
                && priceFrom == null && priceTo == null)
            {
                return computers;
            }
            return computers
                .Where(g => (floppyDrivesCount != null && floppyDrivesCount.Contains(g.FloppyDrivesCount)) ||
                ((priceFrom == null || g.Price >= priceFrom) && (priceTo == null || g.Price <= priceTo)
                && (haveFloppyDrives == null || haveFloppyDrives.Contains(g.HaveFloppyDrives))
                && (computerDriveType == null || computerDriveType.Contains(g.ComputerDriveType))
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
        public IQueryable<T> GetHaveFloppyDrivesComputers<T>(
            IQueryable<T> computers,
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
            decimal? priceFrom,
            decimal? priceTo) where T : Computer
        {
            if (producers == null && countries == null && materials == null && colors == null && amountOfRAM == null && CPUFrequency == null
                && height == null && length == null && width == null && SSDMemory == null
                && hardDiskMemory == null && CPUSocketType == null && computerDriveType == null && numberOfCores == null && floppyDrivesCount == null
                && priceFrom == null && priceTo == null)
            {
                return computers;
            }
            return computers
                .Where(g =>
                ((priceFrom == null || g.Price >= priceFrom) && (priceTo == null || g.Price <= priceTo)
                && (haveFloppyDrives == null || haveFloppyDrives.Contains(g.HaveFloppyDrives))
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






        public async Task<QuestionsBase<string>> GetProducerQuestion(IQueryable<Computer> computers, string[] producers)
        {
            return await _computerTechnologiesQuestionsService.GetProducerQuestion(computers, producers);
        }
        public async Task<QuestionsBase<string>> GetCountryQuestion(IQueryable<Computer> computers, string[] countries)
        {
            return await _computerTechnologiesQuestionsService.GetCountryQuestion(computers, countries);
        }
        public async Task<QuestionsBase<string>> GetMaterialQuestion(IQueryable<Computer> computers, string[] materials)
        {
            return await _computerTechnologiesQuestionsService.GetMaterialQuestion(computers, materials);
        }
        public async Task<QuestionsBase<string>> GetColorQuestion(IQueryable<Computer> computers, string[] colors)
        {
            return await _computerTechnologiesQuestionsService.GetColorQuestion(computers, colors);
        }
        public async Task<QuestionsBase<string>> GetPriceQuestion(IQueryable<Computer> computers, decimal? selectedFrom, decimal? selectedTo)
        {
            return await _computerTechnologiesQuestionsService.GetPriceQuestion(computers, selectedFrom, selectedTo);
        }

        public async Task<QuestionsBase<string>> GetAmountOfRAMQuestion(IQueryable<Computer> computers, int[] amountOfRAMs)
        {
            return new QuestionsBase<string>()
            {
                Key = "amountOfRAM",
                Value = "Select amount of RAM",
                Order = 5,
                QuestionBaseList = await computers
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
        public async Task<QuestionsBase<string>> GetCPUFrequencyQuestion(IQueryable<Computer> computers, int[] CPUFrequencies)
        {
            return new QuestionsBase<string>()
            {
                Key = "CPUFrequency",
                Value = "Select CPU frequency",
                Order = 6,
                QuestionBaseList = await computers
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
        public async Task<QuestionsBase<string>> GetHeightQuestion(IQueryable<Computer> computers, float[] heights)
        {
            return new QuestionsBase<string>()
            {
                Key = "height",
                Value = "Select height",
                Order = 7,
                QuestionBaseList = await computers
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
        public async Task<QuestionsBase<string>> GetWidthQuestion(IQueryable<Computer> computers, float[] widths)
        {
            return new QuestionsBase<string>()
            {
                Key = "width",
                Value = "Select width",
                Order = 8,
                QuestionBaseList = await computers
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
        public async Task<QuestionsBase<string>> GetLengthQuestion(IQueryable<Computer> computers, float[] lengthes)
        {
            return new QuestionsBase<string>()
            {
                Key = "length",
                Value = "Select length",
                Order = 9,
                QuestionBaseList = await computers
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
        public async Task<QuestionsBase<string>> GetHaveFloppyDrivesQuestion(IQueryable<Computer> computers, bool[] haveFloppyDrives)
        {
            return new QuestionsBase<string>()
            {
                Key = "haveFloppyDrives",
                Value = "Have floppy drive",
                Order = 10,
                QuestionBaseList = await computers
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
        public async Task<QuestionsBase<string>> GetSSDMemoryQuestion(IQueryable<Computer> computers, int?[] SSDMemories)
        {
            return new QuestionsBase<string>()
            {
                Key = "SSDMemory",
                Value = "Select SSD memory",
                Order = 11,
                QuestionBaseList = await computers
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
        public async Task<QuestionsBase<string>> GetHardDiskMemoryQuestion(IQueryable<Computer> computers, int?[] hardDiskMemories)
        {
            return new QuestionsBase<string>()
            {
                Key = "hardDiskMemory",
                Value = "Select hard disk memory",
                Order = 12,
                QuestionBaseList = await computers
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
        public async Task<QuestionsBase<string>> GetCPUSocketTypeQuestion(IQueryable<Computer> computers, CPUSocketType[] CPUSocketTypes)
        {
            return new QuestionsBase<string>()
            {
                Key = "CPUSocketType",
                Value = "Select CPU socket type",
                Order = 13,
                QuestionBaseList = await computers
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
        public async Task<QuestionsBase<string>> GetComputerDriveTypeQuestion(IQueryable<Computer> computers, ComputerDriveType[] computerDriveTypes)
        {
            return new QuestionsBase<string>()
            {
                Key = "computerDriveType",
                Value = "Select computer drive type",
                Order = 14,
                QuestionBaseList = await computers
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
        public async Task<QuestionsBase<string>> GetNumberOfCoreQuestion(IQueryable<Computer> computers, int[] numberOfCores)
        {
            return new QuestionsBase<string>()
            {
                Key = "numberOfCores",
                Value = "Select number of cores",
                Order = 15,
                QuestionBaseList = await computers
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
        public async Task<QuestionsBase<string>> GetFloppyDrivesCountQuestion(IQueryable<Computer> computers, int?[] floppyDrivesCountArray)
        {
            return new QuestionsBase<string>()
            {
                Key = "floppyDrivesCount",
                Value = "Select floppy drives count",
                Order = 16,
                QuestionBaseList = await computers
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
    }
}
