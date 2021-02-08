using Microsoft.EntityFrameworkCore;
using SunnyFlamingo.Entities.Goods.ComputerTechnologies;
using SunnyFlamingo.Models;
using SunnyFlamingo.Models.Selectors;
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
        private readonly IQuestionsGrouper _questionsGrouper;
        public ComputersQuestionsService(
            IComputerTechnologiesQuestionsService computerTechnologiesQuestionsService,
            IQuestionsGrouper questionsGrouper)
        {
            _computerTechnologiesQuestionsService = computerTechnologiesQuestionsService;
            _questionsGrouper = questionsGrouper;
        }
        public async Task<List<QuestionsBase<string>>> GetComputersQuestions(
            IQueryable<Computer> computers,
            ComputersSelector computersSelector)
        {
            var goodsSelector = computersSelector.ComputerTechnologiesSelector.GoodsSelector;
            var result = await GetQuestionList(computers, computersSelector);
            var questions = new List<QuestionsBase<string>>()
            {
                _questionsGrouper.GroupProducers(result),
                _questionsGrouper.GroupCountries(result),
                _questionsGrouper.GroupMaterials(result),
                _questionsGrouper.GroupColors(result),
                _questionsGrouper.GroupPrices(result, goodsSelector.PriceFrom, goodsSelector.PriceTo),
                _questionsGrouper.GroupAmountOfRAMs(result),
                _questionsGrouper.GroupCPUFrequencies(result),
                _questionsGrouper.GroupHeight(result),
                _questionsGrouper.GroupWidth(result),
                _questionsGrouper.GroupLength(result),
                _questionsGrouper.GroupHaveFloppyDrives(result),
                _questionsGrouper.GroupSSDMemory(result),
                _questionsGrouper.GroupHardDiskMemory(result),
                _questionsGrouper.GroupCPUSocketTypes(result),
                _questionsGrouper.GroupComputerDriveTypes(result),
                _questionsGrouper.GroupNumberOfCores(result),
            };
            if (computersSelector.HaveFloppyDrives == null || computersSelector.HaveFloppyDrives.Contains(true))
            {
                questions.Add(_questionsGrouper.GroupFloppyDrivesCount(result));
            }
            return questions;
        }
        private async Task<List<QuestionBase<string>>> GetQuestionList(IQueryable<Computer> computers, ComputersSelector computersSelector)
        {
            var goodsSelector = computersSelector.ComputerTechnologiesSelector.GoodsSelector;
            var producerQuestions = GetProducerQuestion(GetProducerComputers(computers, computersSelector), goodsSelector.Producers);
            var countryQuestions = GetCountryQuestion(GetCountryComputers(computers, computersSelector), goodsSelector.Countries);
            var materialQuestions = GetMaterialQuestion(GetMaterialComputers(computers, computersSelector), goodsSelector.Materials);
            var colorQuestions = GetColorQuestion(GetColorComputers(computers, computersSelector), goodsSelector.Colors);
            var priceQuestions = GetPriceQuestion(GetPriceComputers(computers, computersSelector));


            var amountOfRAMQuestions = GetAmountOfRAMQuestion(GetAmountOfRAMComputers(computers, computersSelector), computersSelector.AmountOfRAMs);
            var CPUFrequencyQuestions = GetCPUFrequencyQuestion(GetCPUFrequencyComputers(computers, computersSelector), computersSelector.CPUFrequencies);
            var lengthQuestions = GetLengthQuestion(GetLengthComputers(computers, computersSelector), computersSelector.Length);
            var heightQuestions = GetHeightQuestion(GetHeightComputers(computers, computersSelector), computersSelector.Height);
            var widthQuestions = GetWidthQuestion(GetWidthComputers(computers, computersSelector), computersSelector.Width);
            var haveFloppyDrivesQuestions = GetHaveFloppyDrivesQuestion(GetHaveFloppyDrivesComputers(computers, computersSelector), computersSelector.HaveFloppyDrives);
            var SSDMemoryQuestions = GetSSDMemoryQuestion(GetSSDMemoryComputers(computers, computersSelector), computersSelector.SSDMemory);
            var hardDiskMemoryQuestions = GetHardDiskMemoryQuestion(GetHardDiskMemoryComputers(computers, computersSelector), computersSelector.HardDiskMemory);
            var CPUSocketTypeQuestions = GetCPUSocketTypeQuestion(GetCPUSocketTypeComputers(computers, computersSelector), computersSelector.CPUSocketTypes);
            var computerDriveTypeQuestions = GetComputerDriveTypeQuestion(GetComputerDriveTypeComputers(computers, computersSelector), computersSelector.ComputerDriveTypes);
            var numberOfCoreQuestions = GetNumberOfCoreQuestion(GetNumberOfCoresComputers(computers, computersSelector), computersSelector.NumberOfCores);
            var floppyDrivesCountQuestions = GetFloppyDrivesCountQuestion(GetFloppyDrivesCountComputers(computers, computersSelector), computersSelector.FloppyDrivesCount);


            var group = producerQuestions.Union(countryQuestions).Union(materialQuestions).Union(colorQuestions).Union(priceQuestions)
                .Union(amountOfRAMQuestions).Union(CPUFrequencyQuestions).Union(lengthQuestions).Union(heightQuestions)
                .Union(widthQuestions).Union(haveFloppyDrivesQuestions).Union(SSDMemoryQuestions).Union(hardDiskMemoryQuestions)
                .Union(CPUSocketTypeQuestions).Union(computerDriveTypeQuestions).Union(numberOfCoreQuestions);

            if (computersSelector.HaveFloppyDrives == null || computersSelector.HaveFloppyDrives.Contains(true))
            {
                group = group.Union(floppyDrivesCountQuestions);
            }
            return await group.ToListAsync();
        }

        public IQueryable<T> GetProducerComputers<T>(
            IQueryable<T> computers,
            ComputersSelector computersSelector) where T : Computer
        {
            var goodsSelector = computersSelector.ComputerTechnologiesSelector.GoodsSelector;
            var computerTechnologiesSelector = computersSelector.ComputerTechnologiesSelector;
            return _computerTechnologiesQuestionsService.GetProducerComputerTechnologies(
                computers, computerTechnologiesSelector)
                .Where(comp => (goodsSelector.Producers != null && goodsSelector.Producers.Contains(comp.Producer.Name)) ||
                ((computersSelector.HaveFloppyDrives == null || computersSelector.HaveFloppyDrives.Contains(comp.HaveFloppyDrives))
                && (computersSelector.AmountOfRAMs == null || computersSelector.AmountOfRAMs.Contains(comp.AmountOfRAM))
                && (computersSelector.FloppyDrivesCount == null || computersSelector.FloppyDrivesCount.Contains(comp.FloppyDrivesCount))
                && (computersSelector.NumberOfCores == null || computersSelector.NumberOfCores.Contains(comp.NumberOfCores))
                && (computersSelector.ComputerDriveTypes == null ||
                computersSelector.ComputerDriveTypes.Any(c => comp.ComputerComputerDriveTypes.Select(el => el.ComputerDriveTypeValue).Contains(c)))
                && (computersSelector.CPUSocketTypes == null || computersSelector.CPUSocketTypes.Contains(comp.CPUSocketTypeValue))
                && (computersSelector.HardDiskMemory == null || computersSelector.HardDiskMemory.Contains(comp.HardDiskMemory))
                && (computersSelector.SSDMemory == null || computersSelector.SSDMemory.Contains(comp.SSDMemory))
                && (computersSelector.Width == null || computersSelector.Width.Contains(comp.Width))
                && (computersSelector.Height == null || computersSelector.Height.Contains(comp.Height))
                && (computersSelector.Length == null || computersSelector.Length.Contains(comp.Length))
                && (computersSelector.CPUFrequencies == null || computersSelector.CPUFrequencies.Contains(comp.CPUFrequency))));
        }
        public IQueryable<T> GetCountryComputers<T>(
            IQueryable<T> computers,
            ComputersSelector computersSelector) where T : Computer
        {
            var goodsSelector = computersSelector.ComputerTechnologiesSelector.GoodsSelector;
            var computerTechnologiesSelector = computersSelector.ComputerTechnologiesSelector;
            return _computerTechnologiesQuestionsService.GetCountryComputerTechnologies(
                computers, computerTechnologiesSelector)
                .Where(comp => (goodsSelector.Countries != null && goodsSelector.Countries.Contains(comp.Manufacturer.Country.Value)) ||
                ((computersSelector.HaveFloppyDrives == null || computersSelector.HaveFloppyDrives.Contains(comp.HaveFloppyDrives))
                && (computersSelector.AmountOfRAMs == null || computersSelector.AmountOfRAMs.Contains(comp.AmountOfRAM))
                && (computersSelector.FloppyDrivesCount == null || computersSelector.FloppyDrivesCount.Contains(comp.FloppyDrivesCount))
                && (computersSelector.NumberOfCores == null || computersSelector.NumberOfCores.Contains(comp.NumberOfCores))
                && (computersSelector.ComputerDriveTypes == null ||
                computersSelector.ComputerDriveTypes.Any(c => comp.ComputerComputerDriveTypes.Select(el => el.ComputerDriveTypeValue).Contains(c)))
                && (computersSelector.CPUSocketTypes == null || computersSelector.CPUSocketTypes.Contains(comp.CPUSocketTypeValue))
                && (computersSelector.HardDiskMemory == null || computersSelector.HardDiskMemory.Contains(comp.HardDiskMemory))
                && (computersSelector.SSDMemory == null || computersSelector.SSDMemory.Contains(comp.SSDMemory))
                && (computersSelector.Width == null || computersSelector.Width.Contains(comp.Width))
                && (computersSelector.Height == null || computersSelector.Height.Contains(comp.Height))
                && (computersSelector.Length == null || computersSelector.Length.Contains(comp.Length))
                && (computersSelector.CPUFrequencies == null || computersSelector.CPUFrequencies.Contains(comp.CPUFrequency))));
        }
        public IQueryable<T> GetMaterialComputers<T>(
            IQueryable<T> computers,
            ComputersSelector computersSelector) where T : Computer
        {
            var goodsSelector = computersSelector.ComputerTechnologiesSelector.GoodsSelector;
            var computerTechnologiesSelector = computersSelector.ComputerTechnologiesSelector;
            return _computerTechnologiesQuestionsService.GetMaterialComputerTechnologies(
                computers, computerTechnologiesSelector)
                .Where(comp => (goodsSelector.Materials != null && goodsSelector.Materials.Contains(comp.MaterialValue)) ||
                ((computersSelector.HaveFloppyDrives == null || computersSelector.HaveFloppyDrives.Contains(comp.HaveFloppyDrives))
                && (computersSelector.AmountOfRAMs == null || computersSelector.AmountOfRAMs.Contains(comp.AmountOfRAM))
                && (computersSelector.FloppyDrivesCount == null || computersSelector.FloppyDrivesCount.Contains(comp.FloppyDrivesCount))
                && (computersSelector.NumberOfCores == null || computersSelector.NumberOfCores.Contains(comp.NumberOfCores))
                && (computersSelector.ComputerDriveTypes == null ||
                computersSelector.ComputerDriveTypes.Any(c => comp.ComputerComputerDriveTypes.Select(el => el.ComputerDriveTypeValue).Contains(c)))
                && (computersSelector.CPUSocketTypes == null || computersSelector.CPUSocketTypes.Contains(comp.CPUSocketTypeValue))
                && (computersSelector.HardDiskMemory == null || computersSelector.HardDiskMemory.Contains(comp.HardDiskMemory))
                && (computersSelector.SSDMemory == null || computersSelector.SSDMemory.Contains(comp.SSDMemory))
                && (computersSelector.Width == null || computersSelector.Width.Contains(comp.Width))
                && (computersSelector.Height == null || computersSelector.Height.Contains(comp.Height))
                && (computersSelector.Length == null || computersSelector.Length.Contains(comp.Length))
                && (computersSelector.CPUFrequencies == null || computersSelector.CPUFrequencies.Contains(comp.CPUFrequency))));
        }
        public IQueryable<T> GetColorComputers<T>(
            IQueryable<T> computers,
            ComputersSelector computersSelector) where T : Computer
        {
            var goodsSelector = computersSelector.ComputerTechnologiesSelector.GoodsSelector;
            var computerTechnologiesSelector = computersSelector.ComputerTechnologiesSelector;
            return _computerTechnologiesQuestionsService.GetColorComputerTechnologies(
                computers, computerTechnologiesSelector)
                .Where(comp => (goodsSelector.Colors != null && goodsSelector.Colors.Contains(comp.ColorValue)) ||
                ((computersSelector.HaveFloppyDrives == null || computersSelector.HaveFloppyDrives.Contains(comp.HaveFloppyDrives))
                && (computersSelector.AmountOfRAMs == null || computersSelector.AmountOfRAMs.Contains(comp.AmountOfRAM))
                && (computersSelector.FloppyDrivesCount == null || computersSelector.FloppyDrivesCount.Contains(comp.FloppyDrivesCount))
                && (computersSelector.NumberOfCores == null || computersSelector.NumberOfCores.Contains(comp.NumberOfCores))
                && (computersSelector.ComputerDriveTypes == null ||
                computersSelector.ComputerDriveTypes.Any(c => comp.ComputerComputerDriveTypes.Select(el => el.ComputerDriveTypeValue).Contains(c)))
                && (computersSelector.CPUSocketTypes == null || computersSelector.CPUSocketTypes.Contains(comp.CPUSocketTypeValue))
                && (computersSelector.HardDiskMemory == null || computersSelector.HardDiskMemory.Contains(comp.HardDiskMemory))
                && (computersSelector.SSDMemory == null || computersSelector.SSDMemory.Contains(comp.SSDMemory))
                && (computersSelector.Width == null || computersSelector.Width.Contains(comp.Width))
                && (computersSelector.Height == null || computersSelector.Height.Contains(comp.Height))
                && (computersSelector.Length == null || computersSelector.Length.Contains(comp.Length))
                && (computersSelector.CPUFrequencies == null || computersSelector.CPUFrequencies.Contains(comp.CPUFrequency))));
        }
        public IQueryable<T> GetPriceComputers<T>(
            IQueryable<T> computers,
            ComputersSelector computersSelector) where T : Computer
        {
            var goodsSelector = computersSelector.ComputerTechnologiesSelector.GoodsSelector;
            var computerTechnologiesSelector = computersSelector.ComputerTechnologiesSelector;
            return _computerTechnologiesQuestionsService.GetPriceComputerTechnologies(
                computers, computerTechnologiesSelector)
                .Where(comp =>
                (computersSelector.HaveFloppyDrives == null || computersSelector.HaveFloppyDrives.Contains(comp.HaveFloppyDrives))
                && (computersSelector.AmountOfRAMs == null || computersSelector.AmountOfRAMs.Contains(comp.AmountOfRAM))
                && (computersSelector.FloppyDrivesCount == null || computersSelector.FloppyDrivesCount.Contains(comp.FloppyDrivesCount))
                && (computersSelector.NumberOfCores == null || computersSelector.NumberOfCores.Contains(comp.NumberOfCores))
                && (computersSelector.ComputerDriveTypes == null ||
                computersSelector.ComputerDriveTypes.Any(c => comp.ComputerComputerDriveTypes.Select(el => el.ComputerDriveTypeValue).Contains(c)))
                && (computersSelector.CPUSocketTypes == null || computersSelector.CPUSocketTypes.Contains(comp.CPUSocketTypeValue))
                && (computersSelector.HardDiskMemory == null || computersSelector.HardDiskMemory.Contains(comp.HardDiskMemory))
                && (computersSelector.SSDMemory == null || computersSelector.SSDMemory.Contains(comp.SSDMemory))
                && (computersSelector.Width == null || computersSelector.Width.Contains(comp.Width))
                && (computersSelector.Height == null || computersSelector.Height.Contains(comp.Height))
                && (computersSelector.Length == null || computersSelector.Length.Contains(comp.Length))
                && (computersSelector.CPUFrequencies == null || computersSelector.CPUFrequencies.Contains(comp.CPUFrequency)));
        }
        public IQueryable<T> GetAmountOfRAMComputers<T>(
            IQueryable<T> computers,
            ComputersSelector computersSelector) where T : Computer
        {
            var goodsSelector = computersSelector.ComputerTechnologiesSelector.GoodsSelector;
            return computers
                .Where(comp => (computersSelector.AmountOfRAMs != null && computersSelector.AmountOfRAMs.Contains(comp.AmountOfRAM)) ||
                ((goodsSelector.PriceFrom == null || comp.Price >= goodsSelector.PriceFrom)
                && (goodsSelector.PriceTo == null || comp.Price <= goodsSelector.PriceTo)
                && (computersSelector.HaveFloppyDrives == null || computersSelector.HaveFloppyDrives.Contains(comp.HaveFloppyDrives))
                && (computersSelector.FloppyDrivesCount == null || computersSelector.FloppyDrivesCount.Contains(comp.FloppyDrivesCount))
                && (computersSelector.NumberOfCores == null || computersSelector.NumberOfCores.Contains(comp.NumberOfCores))
                && (computersSelector.ComputerDriveTypes == null ||
                computersSelector.ComputerDriveTypes.Any(c => comp.ComputerComputerDriveTypes.Select(el => el.ComputerDriveTypeValue).Contains(c)))
                && (computersSelector.CPUSocketTypes == null || computersSelector.CPUSocketTypes.Contains(comp.CPUSocketTypeValue))
                && (computersSelector.HardDiskMemory == null || computersSelector.HardDiskMemory.Contains(comp.HardDiskMemory))
                && (computersSelector.SSDMemory == null || computersSelector.SSDMemory.Contains(comp.SSDMemory))
                && (computersSelector.Width == null || computersSelector.Width.Contains(comp.Width))
                && (computersSelector.Height == null || computersSelector.Height.Contains(comp.Height))
                && (computersSelector.Length == null || computersSelector.Length.Contains(comp.Length))
                && (computersSelector.CPUFrequencies == null || computersSelector.CPUFrequencies.Contains(comp.CPUFrequency))
                && (goodsSelector.Producers == null || goodsSelector.Producers.Contains(comp.Producer.Name))
                && (goodsSelector.Countries == null || goodsSelector.Countries.Contains(comp.Manufacturer.Country.Value))
                && (goodsSelector.Materials == null || goodsSelector.Materials.Contains(comp.MaterialValue))
                && (goodsSelector.Colors == null || goodsSelector.Colors.Contains(comp.ColorValue))));
        }
        public IQueryable<T> GetCPUFrequencyComputers<T>(
            IQueryable<T> computers,
            ComputersSelector computersSelector) where T : Computer
        {
            var goodsSelector = computersSelector.ComputerTechnologiesSelector.GoodsSelector;
            return computers
                .Where(comp => (computersSelector.CPUFrequencies != null && computersSelector.CPUFrequencies.Contains(comp.CPUFrequency)) ||
                ((goodsSelector.PriceFrom == null || comp.Price >= goodsSelector.PriceFrom)
                && (goodsSelector.PriceTo == null || comp.Price <= goodsSelector.PriceTo)
                && (computersSelector.HaveFloppyDrives == null || computersSelector.HaveFloppyDrives.Contains(comp.HaveFloppyDrives))
                && (computersSelector.FloppyDrivesCount == null || computersSelector.FloppyDrivesCount.Contains(comp.FloppyDrivesCount))
                && (computersSelector.NumberOfCores == null || computersSelector.NumberOfCores.Contains(comp.NumberOfCores))
                && (computersSelector.ComputerDriveTypes == null ||
                computersSelector.ComputerDriveTypes.Any(c => comp.ComputerComputerDriveTypes.Select(el => el.ComputerDriveTypeValue).Contains(c)))
                && (computersSelector.CPUSocketTypes == null || computersSelector.CPUSocketTypes.Contains(comp.CPUSocketTypeValue))
                && (computersSelector.HardDiskMemory == null || computersSelector.HardDiskMemory.Contains(comp.HardDiskMemory))
                && (computersSelector.SSDMemory == null || computersSelector.SSDMemory.Contains(comp.SSDMemory))
                && (computersSelector.Width == null || computersSelector.Width.Contains(comp.Width))
                && (computersSelector.Height == null || computersSelector.Height.Contains(comp.Height))
                && (computersSelector.Length == null || computersSelector.Length.Contains(comp.Length))
                && (computersSelector.AmountOfRAMs == null || computersSelector.AmountOfRAMs.Contains(comp.AmountOfRAM))
                && (goodsSelector.Producers == null || goodsSelector.Producers.Contains(comp.Producer.Name))
                && (goodsSelector.Countries == null || goodsSelector.Countries.Contains(comp.Manufacturer.Country.Value))
                && (goodsSelector.Materials == null || goodsSelector.Materials.Contains(comp.MaterialValue))
                && (goodsSelector.Colors == null || goodsSelector.Colors.Contains(comp.ColorValue))));
        }
        public IQueryable<T> GetLengthComputers<T>(
            IQueryable<T> computers,
            ComputersSelector computersSelector) where T : Computer
        {
            var goodsSelector = computersSelector.ComputerTechnologiesSelector.GoodsSelector;
            return computers
                .Where(comp => (computersSelector.Length != null && computersSelector.Length.Contains(comp.Length)) ||
                ((goodsSelector.PriceFrom == null || comp.Price >= goodsSelector.PriceFrom)
                && (goodsSelector.PriceTo == null || comp.Price <= goodsSelector.PriceTo)
                && (computersSelector.HaveFloppyDrives == null || computersSelector.HaveFloppyDrives.Contains(comp.HaveFloppyDrives))
                && (computersSelector.FloppyDrivesCount == null || computersSelector.FloppyDrivesCount.Contains(comp.FloppyDrivesCount))
                && (computersSelector.NumberOfCores == null || computersSelector.NumberOfCores.Contains(comp.NumberOfCores))
                && (computersSelector.ComputerDriveTypes == null ||
                computersSelector.ComputerDriveTypes.Any(c => comp.ComputerComputerDriveTypes.Select(el => el.ComputerDriveTypeValue).Contains(c)))
                && (computersSelector.CPUSocketTypes == null || computersSelector.CPUSocketTypes.Contains(comp.CPUSocketTypeValue))
                && (computersSelector.HardDiskMemory == null || computersSelector.HardDiskMemory.Contains(comp.HardDiskMemory))
                && (computersSelector.SSDMemory == null || computersSelector.SSDMemory.Contains(comp.SSDMemory))
                && (computersSelector.Width == null || computersSelector.Width.Contains(comp.Width))
                && (computersSelector.Height == null || computersSelector.Height.Contains(comp.Height))
                && (computersSelector.CPUFrequencies == null || computersSelector.CPUFrequencies.Contains(comp.CPUFrequency))
                && (computersSelector.AmountOfRAMs == null || computersSelector.AmountOfRAMs.Contains(comp.AmountOfRAM))
                && (goodsSelector.Producers == null || goodsSelector.Producers.Contains(comp.Producer.Name))
                && (goodsSelector.Countries == null || goodsSelector.Countries.Contains(comp.Manufacturer.Country.Value))
                && (goodsSelector.Materials == null || goodsSelector.Materials.Contains(comp.MaterialValue))
                && (goodsSelector.Colors == null || goodsSelector.Colors.Contains(comp.ColorValue))));
        }
        public IQueryable<T> GetHeightComputers<T>(
            IQueryable<T> computers,
            ComputersSelector computersSelector) where T : Computer
        {
            var goodsSelector = computersSelector.ComputerTechnologiesSelector.GoodsSelector;
            return computers
                .Where(comp => (computersSelector.Height != null && computersSelector.Height.Contains(comp.Height)) ||
                ((goodsSelector.PriceFrom == null || comp.Price >= goodsSelector.PriceFrom)
                && (goodsSelector.PriceTo == null || comp.Price <= goodsSelector.PriceTo)
                && (computersSelector.HaveFloppyDrives == null || computersSelector.HaveFloppyDrives.Contains(comp.HaveFloppyDrives))
                && (computersSelector.FloppyDrivesCount == null || computersSelector.FloppyDrivesCount.Contains(comp.FloppyDrivesCount))
                && (computersSelector.NumberOfCores == null || computersSelector.NumberOfCores.Contains(comp.NumberOfCores))
                && (computersSelector.ComputerDriveTypes == null ||
                computersSelector.ComputerDriveTypes.Any(c => comp.ComputerComputerDriveTypes.Select(el => el.ComputerDriveTypeValue).Contains(c)))
                && (computersSelector.CPUSocketTypes == null || computersSelector.CPUSocketTypes.Contains(comp.CPUSocketTypeValue))
                && (computersSelector.HardDiskMemory == null || computersSelector.HardDiskMemory.Contains(comp.HardDiskMemory))
                && (computersSelector.SSDMemory == null || computersSelector.SSDMemory.Contains(comp.SSDMemory))
                && (computersSelector.Width == null || computersSelector.Width.Contains(comp.Width))
                && (computersSelector.Length == null || computersSelector.Length.Contains(comp.Length))
                && (computersSelector.CPUFrequencies == null || computersSelector.CPUFrequencies.Contains(comp.CPUFrequency))
                && (computersSelector.AmountOfRAMs == null || computersSelector.AmountOfRAMs.Contains(comp.AmountOfRAM))
                && (goodsSelector.Producers == null || goodsSelector.Producers.Contains(comp.Producer.Name))
                && (goodsSelector.Countries == null || goodsSelector.Countries.Contains(comp.Manufacturer.Country.Value))
                && (goodsSelector.Materials == null || goodsSelector.Materials.Contains(comp.MaterialValue))
                && (goodsSelector.Colors == null || goodsSelector.Colors.Contains(comp.ColorValue))));
        }
        public IQueryable<T> GetWidthComputers<T>(
            IQueryable<T> computers,
            ComputersSelector computersSelector) where T : Computer
        {
            var goodsSelector = computersSelector.ComputerTechnologiesSelector.GoodsSelector;
            return computers
                .Where(comp => (computersSelector.Width != null && computersSelector.Width.Contains(comp.Width)) ||
                ((goodsSelector.PriceFrom == null || comp.Price >= goodsSelector.PriceFrom)
                && (goodsSelector.PriceTo == null || comp.Price <= goodsSelector.PriceTo)
                && (computersSelector.HaveFloppyDrives == null || computersSelector.HaveFloppyDrives.Contains(comp.HaveFloppyDrives))
                && (computersSelector.FloppyDrivesCount == null || computersSelector.FloppyDrivesCount.Contains(comp.FloppyDrivesCount))
                && (computersSelector.NumberOfCores == null || computersSelector.NumberOfCores.Contains(comp.NumberOfCores))
                && (computersSelector.ComputerDriveTypes == null ||
                computersSelector.ComputerDriveTypes.Any(c => comp.ComputerComputerDriveTypes.Select(el => el.ComputerDriveTypeValue).Contains(c)))
                && (computersSelector.CPUSocketTypes == null || computersSelector.CPUSocketTypes.Contains(comp.CPUSocketTypeValue))
                && (computersSelector.HardDiskMemory == null || computersSelector.HardDiskMemory.Contains(comp.HardDiskMemory))
                && (computersSelector.SSDMemory == null || computersSelector.SSDMemory.Contains(comp.SSDMemory))
                && (computersSelector.Height == null || computersSelector.Height.Contains(comp.Height))
                && (computersSelector.Length == null || computersSelector.Length.Contains(comp.Length))
                && (computersSelector.CPUFrequencies == null || computersSelector.CPUFrequencies.Contains(comp.CPUFrequency))
                && (computersSelector.AmountOfRAMs == null || computersSelector.AmountOfRAMs.Contains(comp.AmountOfRAM))
                && (goodsSelector.Producers == null || goodsSelector.Producers.Contains(comp.Producer.Name))
                && (goodsSelector.Countries == null || goodsSelector.Countries.Contains(comp.Manufacturer.Country.Value))
                && (goodsSelector.Materials == null || goodsSelector.Materials.Contains(comp.MaterialValue))
                && (goodsSelector.Colors == null || goodsSelector.Colors.Contains(comp.ColorValue))));
        }
        public IQueryable<T> GetSSDMemoryComputers<T>(
            IQueryable<T> computers,
            ComputersSelector computersSelector) where T : Computer
        {
            var goodsSelector = computersSelector.ComputerTechnologiesSelector.GoodsSelector;
            return computers
                .Where(comp => (computersSelector.SSDMemory != null && computersSelector.SSDMemory.Contains(comp.SSDMemory)) ||
                ((goodsSelector.PriceFrom == null || comp.Price >= goodsSelector.PriceFrom)
                && (goodsSelector.PriceTo == null || comp.Price <= goodsSelector.PriceTo)
                && (computersSelector.HaveFloppyDrives == null || computersSelector.HaveFloppyDrives.Contains(comp.HaveFloppyDrives))
                && (computersSelector.FloppyDrivesCount == null || computersSelector.FloppyDrivesCount.Contains(comp.FloppyDrivesCount))
                && (computersSelector.NumberOfCores == null || computersSelector.NumberOfCores.Contains(comp.NumberOfCores))
                && (computersSelector.ComputerDriveTypes == null ||
                computersSelector.ComputerDriveTypes.Any(c => comp.ComputerComputerDriveTypes.Select(el => el.ComputerDriveTypeValue).Contains(c)))
                && (computersSelector.CPUSocketTypes == null || computersSelector.CPUSocketTypes.Contains(comp.CPUSocketTypeValue))
                && (computersSelector.HardDiskMemory == null || computersSelector.HardDiskMemory.Contains(comp.HardDiskMemory))
                && (computersSelector.Width == null || computersSelector.Width.Contains(comp.Width))
                && (computersSelector.Height == null || computersSelector.Height.Contains(comp.Height))
                && (computersSelector.Length == null || computersSelector.Length.Contains(comp.Length))
                && (computersSelector.CPUFrequencies == null || computersSelector.CPUFrequencies.Contains(comp.CPUFrequency))
                && (computersSelector.AmountOfRAMs == null || computersSelector.AmountOfRAMs.Contains(comp.AmountOfRAM))
                && (goodsSelector.Producers == null || goodsSelector.Producers.Contains(comp.Producer.Name))
                && (goodsSelector.Countries == null || goodsSelector.Countries.Contains(comp.Manufacturer.Country.Value))
                && (goodsSelector.Materials == null || goodsSelector.Materials.Contains(comp.MaterialValue))
                && (goodsSelector.Colors == null || goodsSelector.Colors.Contains(comp.ColorValue))));
        }
        public IQueryable<T> GetHardDiskMemoryComputers<T>(
            IQueryable<T> computers,
            ComputersSelector computersSelector) where T : Computer
        {
            var goodsSelector = computersSelector.ComputerTechnologiesSelector.GoodsSelector;
            return computers
                .Where(comp => (computersSelector.HardDiskMemory != null && computersSelector.HardDiskMemory.Contains(comp.HardDiskMemory)) ||
                ((goodsSelector.PriceFrom == null || comp.Price >= goodsSelector.PriceFrom)
                && (goodsSelector.PriceTo == null || comp.Price <= goodsSelector.PriceTo)
                && (computersSelector.HaveFloppyDrives == null || computersSelector.HaveFloppyDrives.Contains(comp.HaveFloppyDrives))
                && (computersSelector.FloppyDrivesCount == null || computersSelector.FloppyDrivesCount.Contains(comp.FloppyDrivesCount))
                && (computersSelector.NumberOfCores == null || computersSelector.NumberOfCores.Contains(comp.NumberOfCores))
                && (computersSelector.ComputerDriveTypes == null ||
                computersSelector.ComputerDriveTypes.Any(c => comp.ComputerComputerDriveTypes.Select(el => el.ComputerDriveTypeValue).Contains(c)))
                && (computersSelector.CPUSocketTypes == null || computersSelector.CPUSocketTypes.Contains(comp.CPUSocketTypeValue))
                && (computersSelector.SSDMemory == null || computersSelector.SSDMemory.Contains(comp.SSDMemory))
                && (computersSelector.Width == null || computersSelector.Width.Contains(comp.Width))
                && (computersSelector.Height == null || computersSelector.Height.Contains(comp.Height))
                && (computersSelector.Length == null || computersSelector.Length.Contains(comp.Length))
                && (computersSelector.CPUFrequencies == null || computersSelector.CPUFrequencies.Contains(comp.CPUFrequency))
                && (computersSelector.AmountOfRAMs == null || computersSelector.AmountOfRAMs.Contains(comp.AmountOfRAM))
                && (goodsSelector.Producers == null || goodsSelector.Producers.Contains(comp.Producer.Name))
                && (goodsSelector.Countries == null || goodsSelector.Countries.Contains(comp.Manufacturer.Country.Value))
                && (goodsSelector.Materials == null || goodsSelector.Materials.Contains(comp.MaterialValue))
                && (goodsSelector.Colors == null || goodsSelector.Colors.Contains(comp.ColorValue))));
        }
        public IQueryable<T> GetCPUSocketTypeComputers<T>(
            IQueryable<T> computers,
            ComputersSelector computersSelector) where T : Computer
        {
            var goodsSelector = computersSelector.ComputerTechnologiesSelector.GoodsSelector;
            return computers
                .Where(comp => (computersSelector.CPUSocketTypes != null && computersSelector.CPUSocketTypes.Contains(comp.CPUSocketTypeValue)) ||
                ((goodsSelector.PriceFrom == null || comp.Price >= goodsSelector.PriceFrom)
                && (goodsSelector.PriceTo == null || comp.Price <= goodsSelector.PriceTo)
                && (computersSelector.HaveFloppyDrives == null || computersSelector.HaveFloppyDrives.Contains(comp.HaveFloppyDrives))
                && (computersSelector.FloppyDrivesCount == null || computersSelector.FloppyDrivesCount.Contains(comp.FloppyDrivesCount))
                && (computersSelector.NumberOfCores == null || computersSelector.NumberOfCores.Contains(comp.NumberOfCores))
                && (computersSelector.ComputerDriveTypes == null ||
                computersSelector.ComputerDriveTypes.Any(c => comp.ComputerComputerDriveTypes.Select(el => el.ComputerDriveTypeValue).Contains(c)))
                && (computersSelector.HardDiskMemory == null || computersSelector.HardDiskMemory.Contains(comp.HardDiskMemory))
                && (computersSelector.SSDMemory == null || computersSelector.SSDMemory.Contains(comp.SSDMemory))
                && (computersSelector.Width == null || computersSelector.Width.Contains(comp.Width))
                && (computersSelector.Height == null || computersSelector.Height.Contains(comp.Height))
                && (computersSelector.Length == null || computersSelector.Length.Contains(comp.Length))
                && (computersSelector.CPUFrequencies == null || computersSelector.CPUFrequencies.Contains(comp.CPUFrequency))
                && (computersSelector.AmountOfRAMs == null || computersSelector.AmountOfRAMs.Contains(comp.AmountOfRAM))
                && (goodsSelector.Producers == null || goodsSelector.Producers.Contains(comp.Producer.Name))
                && (goodsSelector.Countries == null || goodsSelector.Countries.Contains(comp.Manufacturer.Country.Value))
                && (goodsSelector.Materials == null || goodsSelector.Materials.Contains(comp.MaterialValue))
                && (goodsSelector.Colors == null || goodsSelector.Colors.Contains(comp.ColorValue))));
        }
        public IQueryable<T> GetComputerDriveTypeComputers<T>(
            IQueryable<T> computers,
            ComputersSelector computersSelector) where T : Computer
        {
            var goodsSelector = computersSelector.ComputerTechnologiesSelector.GoodsSelector;
            return computers
                .Where(comp => (computersSelector.ComputerDriveTypes != null
                && computersSelector.ComputerDriveTypes.Any(c => comp.ComputerComputerDriveTypes.Select(el => el.ComputerDriveTypeValue).Contains(c)))
                ||
                ((goodsSelector.PriceFrom == null || comp.Price >= goodsSelector.PriceFrom)
                && (goodsSelector.PriceTo == null || comp.Price <= goodsSelector.PriceTo)
                && (computersSelector.HaveFloppyDrives == null || computersSelector.HaveFloppyDrives.Contains(comp.HaveFloppyDrives))
                && (computersSelector.FloppyDrivesCount == null || computersSelector.FloppyDrivesCount.Contains(comp.FloppyDrivesCount))
                && (computersSelector.NumberOfCores == null || computersSelector.NumberOfCores.Contains(comp.NumberOfCores))
                && (computersSelector.CPUSocketTypes == null || computersSelector.CPUSocketTypes.Contains(comp.CPUSocketTypeValue))
                && (computersSelector.HardDiskMemory == null || computersSelector.HardDiskMemory.Contains(comp.HardDiskMemory))
                && (computersSelector.SSDMemory == null || computersSelector.SSDMemory.Contains(comp.SSDMemory))
                && (computersSelector.Width == null || computersSelector.Width.Contains(comp.Width))
                && (computersSelector.Height == null || computersSelector.Height.Contains(comp.Height))
                && (computersSelector.Length == null || computersSelector.Length.Contains(comp.Length))
                && (computersSelector.CPUFrequencies == null || computersSelector.CPUFrequencies.Contains(comp.CPUFrequency))
                && (computersSelector.AmountOfRAMs == null || computersSelector.AmountOfRAMs.Contains(comp.AmountOfRAM))
                && (goodsSelector.Producers == null || goodsSelector.Producers.Contains(comp.Producer.Name))
                && (goodsSelector.Countries == null || goodsSelector.Countries.Contains(comp.Manufacturer.Country.Value))
                && (goodsSelector.Materials == null || goodsSelector.Materials.Contains(comp.MaterialValue))
                && (goodsSelector.Colors == null || goodsSelector.Colors.Contains(comp.ColorValue))));
        }
        public IQueryable<T> GetNumberOfCoresComputers<T>(
            IQueryable<T> computers,
            ComputersSelector computersSelector) where T : Computer
        {
            var goodsSelector = computersSelector.ComputerTechnologiesSelector.GoodsSelector;
            return computers
                .Where(comp => (computersSelector.NumberOfCores != null && computersSelector.NumberOfCores.Contains(comp.NumberOfCores)) ||
                ((goodsSelector.PriceFrom == null || comp.Price >= goodsSelector.PriceFrom)
                && (goodsSelector.PriceTo == null || comp.Price <= goodsSelector.PriceTo)
                && (computersSelector.HaveFloppyDrives == null || computersSelector.HaveFloppyDrives.Contains(comp.HaveFloppyDrives))
                && (computersSelector.FloppyDrivesCount == null || computersSelector.FloppyDrivesCount.Contains(comp.FloppyDrivesCount))
                && (computersSelector.HardDiskMemory == null || computersSelector.HardDiskMemory.Contains(comp.HardDiskMemory))
                && (computersSelector.ComputerDriveTypes == null ||
                computersSelector.ComputerDriveTypes.Any(c => comp.ComputerComputerDriveTypes.Select(el => el.ComputerDriveTypeValue).Contains(c)))
                && (computersSelector.CPUSocketTypes == null || computersSelector.CPUSocketTypes.Contains(comp.CPUSocketTypeValue))
                && (computersSelector.SSDMemory == null || computersSelector.SSDMemory.Contains(comp.SSDMemory))
                && (computersSelector.Width == null || computersSelector.Width.Contains(comp.Width))
                && (computersSelector.Height == null || computersSelector.Height.Contains(comp.Height))
                && (computersSelector.Length == null || computersSelector.Length.Contains(comp.Length))
                && (computersSelector.CPUFrequencies == null || computersSelector.CPUFrequencies.Contains(comp.CPUFrequency))
                && (computersSelector.AmountOfRAMs == null || computersSelector.AmountOfRAMs.Contains(comp.AmountOfRAM))
                && (goodsSelector.Producers == null || goodsSelector.Producers.Contains(comp.Producer.Name))
                && (goodsSelector.Countries == null || goodsSelector.Countries.Contains(comp.Manufacturer.Country.Value))
                && (goodsSelector.Materials == null || goodsSelector.Materials.Contains(comp.MaterialValue))
                && (goodsSelector.Colors == null || goodsSelector.Colors.Contains(comp.ColorValue))));
        }
        public IQueryable<T> GetFloppyDrivesCountComputers<T>(
            IQueryable<T> computers,
            ComputersSelector computersSelector) where T : Computer
        {
            var goodsSelector = computersSelector.ComputerTechnologiesSelector.GoodsSelector;
            return computers
                .Where(comp => (computersSelector.FloppyDrivesCount != null && computersSelector.FloppyDrivesCount.Contains(comp.FloppyDrivesCount)) ||
                ((goodsSelector.PriceFrom == null || comp.Price >= goodsSelector.PriceFrom)
                && (goodsSelector.PriceTo == null || comp.Price <= goodsSelector.PriceTo)
                && (computersSelector.HaveFloppyDrives == null || computersSelector.HaveFloppyDrives.Contains(comp.HaveFloppyDrives))
                && (computersSelector.NumberOfCores == null || computersSelector.NumberOfCores.Contains(comp.NumberOfCores))
                && (computersSelector.HardDiskMemory == null || computersSelector.HardDiskMemory.Contains(comp.HardDiskMemory))
                && (computersSelector.ComputerDriveTypes == null ||
                computersSelector.ComputerDriveTypes.Any(c => comp.ComputerComputerDriveTypes.Select(el => el.ComputerDriveTypeValue).Contains(c)))
                && (computersSelector.CPUSocketTypes == null || computersSelector.CPUSocketTypes.Contains(comp.CPUSocketTypeValue))
                && (computersSelector.SSDMemory == null || computersSelector.SSDMemory.Contains(comp.SSDMemory))
                && (computersSelector.Width == null || computersSelector.Width.Contains(comp.Width))
                && (computersSelector.Height == null || computersSelector.Height.Contains(comp.Height))
                && (computersSelector.Length == null || computersSelector.Length.Contains(comp.Length))
                && (computersSelector.CPUFrequencies == null || computersSelector.CPUFrequencies.Contains(comp.CPUFrequency))
                && (computersSelector.AmountOfRAMs == null || computersSelector.AmountOfRAMs.Contains(comp.AmountOfRAM))
                && (goodsSelector.Producers == null || goodsSelector.Producers.Contains(comp.Producer.Name))
                && (goodsSelector.Countries == null || goodsSelector.Countries.Contains(comp.Manufacturer.Country.Value))
                && (goodsSelector.Materials == null || goodsSelector.Materials.Contains(comp.MaterialValue))
                && (goodsSelector.Colors == null || goodsSelector.Colors.Contains(comp.ColorValue))));
        }
        public IQueryable<T> GetHaveFloppyDrivesComputers<T>(
            IQueryable<T> computers,
            ComputersSelector computersSelector) where T : Computer
        {
            var goodsSelector = computersSelector.ComputerTechnologiesSelector.GoodsSelector;
            return computers
                .Where(comp => (computersSelector.HaveFloppyDrives != null && computersSelector.HaveFloppyDrives.Contains(comp.HaveFloppyDrives)) ||
                ((goodsSelector.PriceFrom == null || comp.Price >= goodsSelector.PriceFrom)
                && (goodsSelector.PriceTo == null || comp.Price <= goodsSelector.PriceTo)
                && (computersSelector.FloppyDrivesCount == null || computersSelector.FloppyDrivesCount.Contains(comp.FloppyDrivesCount))
                && (computersSelector.NumberOfCores == null || computersSelector.NumberOfCores.Contains(comp.NumberOfCores))
                && (computersSelector.HardDiskMemory == null || computersSelector.HardDiskMemory.Contains(comp.HardDiskMemory))
                && (computersSelector.ComputerDriveTypes == null ||
                computersSelector.ComputerDriveTypes.Any(c => comp.ComputerComputerDriveTypes.Select(el => el.ComputerDriveTypeValue).Contains(c)))
                && (computersSelector.CPUSocketTypes == null || computersSelector.CPUSocketTypes.Contains(comp.CPUSocketTypeValue))
                && (computersSelector.SSDMemory == null || computersSelector.SSDMemory.Contains(comp.SSDMemory))
                && (computersSelector.Width == null || computersSelector.Width.Contains(comp.Width))
                && (computersSelector.Height == null || computersSelector.Height.Contains(comp.Height))
                && (computersSelector.Length == null || computersSelector.Length.Contains(comp.Length))
                && (computersSelector.CPUFrequencies == null || computersSelector.CPUFrequencies.Contains(comp.CPUFrequency))
                && (computersSelector.AmountOfRAMs == null || computersSelector.AmountOfRAMs.Contains(comp.AmountOfRAM))
                && (goodsSelector.Producers == null || goodsSelector.Producers.Contains(comp.Producer.Name))
                && (goodsSelector.Countries == null || goodsSelector.Countries.Contains(comp.Manufacturer.Country.Value))
                && (goodsSelector.Materials == null || goodsSelector.Materials.Contains(comp.MaterialValue))
                && (goodsSelector.Colors == null || goodsSelector.Colors.Contains(comp.ColorValue))));
        }






        public IQueryable<QuestionBase<string>> GetProducerQuestion(IQueryable<Computer> computers, string[] producers)
        {
            return _computerTechnologiesQuestionsService.GetProducerQuestion(computers, producers);
        }
        public IQueryable<QuestionBase<string>> GetCountryQuestion(IQueryable<Computer> computers, string[] countries)
        {
            return _computerTechnologiesQuestionsService.GetCountryQuestion(computers, countries);
        }
        public IQueryable<QuestionBase<string>> GetMaterialQuestion(IQueryable<Computer> computers, string[] materials)
        {
            return _computerTechnologiesQuestionsService.GetMaterialQuestion(computers, materials);
        }
        public IQueryable<QuestionBase<string>> GetColorQuestion(IQueryable<Computer> computers, string[] colors)
        {
            return _computerTechnologiesQuestionsService.GetColorQuestion(computers, colors);
        }
        public IQueryable<QuestionBase<string>> GetPriceQuestion(IQueryable<Computer> computers)
        {
            return _computerTechnologiesQuestionsService.GetPriceQuestion(computers);
        }

        public IQueryable<QuestionBase<string>> GetAmountOfRAMQuestion(IQueryable<Computer> computers, int[] amountOfRAMs)
        {
            var stringList = amountOfRAMs?.Select(item => item.ToString()).ToList();
            return computers
                        .Select(g => g.AmountOfRAM)
                        .GroupBy(p => p)
                        .Select(p => new { Count = p.Count(), Value = Convert.ToString(p.Key) })
                        .Select(amountOfRAM => new QuestionBase<string>()
                        {
                            QuestionsKey = "amountOfRAM",
                            AfterBox = (stringList != null && stringList.Contains(amountOfRAM.Value)) ? (int?)null : amountOfRAM.Count,
                            Checked = stringList != null && stringList.Contains(amountOfRAM.Value),
                            ControlType = ControlType.Checkbox,
                            Key = amountOfRAM.Value,
                            Label = amountOfRAM.Value,
                            Required = false,
                            Type = InputType.Checkbox,
                        });
        }
        public IQueryable<QuestionBase<string>> GetCPUFrequencyQuestion(IQueryable<Computer> computers, int[] CPUFrequencies)
        {
            var stringList = CPUFrequencies?.Select(item => item.ToString()).ToList();
            return computers
                        .Select(g => g.CPUFrequency)
                        .GroupBy(p => p)
                        .Select(p => new { Count = p.Count(), Value = Convert.ToString(p.Key) })
                        .Select(CPUFrequency => new QuestionBase<string>()
                        {
                            QuestionsKey = "CPUFrequency",
                            AfterBox = (stringList != null && stringList.Contains(CPUFrequency.Value)) ? (int?)null : CPUFrequency.Count,
                            Checked = stringList != null && stringList.Contains(CPUFrequency.Value),
                            ControlType = ControlType.Checkbox,
                            Key = CPUFrequency.Value,
                            Label = CPUFrequency.Value,
                            Required = false,
                            Type = InputType.Checkbox,
                        });
        }
        public IQueryable<QuestionBase<string>> GetHeightQuestion(IQueryable<Computer> computers, float[] height)
        {
            var stringList = height?.Select(item => item.ToString()).ToList();
            return computers
                        .Select(g => g.Height)
                        .GroupBy(p => p)
                        .Select(p => new { Count = p.Count(), Value = Convert.ToString(p.Key) })
                        .Select(height => new QuestionBase<string>()
                        {
                            QuestionsKey = "height",
                            AfterBox = (stringList != null && stringList.Contains(height.Value)) ? (int?)null : height.Count,
                            Checked = stringList != null && stringList.Contains(height.Value),
                            ControlType = ControlType.Checkbox,
                            Key = height.Value,
                            Label = height.Value,
                            Required = false,
                            Type = InputType.Checkbox,
                        });
        }
        public IQueryable<QuestionBase<string>> GetWidthQuestion(IQueryable<Computer> computers, float[] width)
        {
            var stringList = width?.Select(item => item.ToString()).ToList();
            return computers
                        .Select(g => g.Width)
                        .GroupBy(p => p)
                        .Select(p => new { Count = p.Count(), Value = Convert.ToString(p.Key) })
                        .Select(width => new QuestionBase<string>()
                        {
                            QuestionsKey = "width",
                            AfterBox = (stringList != null && stringList.Contains(width.Value)) ? (int?)null : width.Count,
                            Checked = stringList != null && stringList.Contains(width.Value),
                            ControlType = ControlType.Checkbox,
                            Key = width.Value,
                            Label = width.Value,
                            Required = false,
                            Type = InputType.Checkbox,
                        });
        }
        public IQueryable<QuestionBase<string>> GetLengthQuestion(IQueryable<Computer> computers, float[] length)
        {
            var stringList = length?.Select(item => item.ToString()).ToList();
            return computers
                        .Select(g => g.Length)
                        .GroupBy(p => p)
                        .Select(p => new { Count = p.Count(), Value = Convert.ToString(p.Key) })
                        .Select(length => new QuestionBase<string>()
                        {
                            QuestionsKey = "length",
                            AfterBox = (stringList != null && stringList.Contains(length.Value)) ? (int?)null : length.Count,
                            Checked = stringList != null && stringList.Contains(length.Value),
                            ControlType = ControlType.Checkbox,
                            Key = length.Value,
                            Label = length.Value,
                            Required = false,
                            Type = InputType.Checkbox,
                        });
        }
        public IQueryable<QuestionBase<string>> GetHaveFloppyDrivesQuestion(IQueryable<Computer> computers, bool[] haveFloppyDrives)
        {
            var stringList = haveFloppyDrives?.Select(item => item.ToString()).ToList();
            return computers
                        .Select(g => g.HaveFloppyDrives)
                        .Select(p => p ? "true" : "false")
                        .GroupBy(p => p)
                        .Select(p => new { Count = p.Count(), Value = p.Key })
                        .Select(haveFloppyDrive => new QuestionBase<string>()
                        {
                            QuestionsKey = "haveFloppyDrives",
                            AfterBox = (stringList != null && stringList.Contains(haveFloppyDrive.Value)) ? (int?)null : haveFloppyDrive.Count,
                            Checked = stringList != null && stringList.Contains(haveFloppyDrive.Value),
                            ControlType = ControlType.Checkbox,
                            Key = haveFloppyDrive.Value,
                            Label = haveFloppyDrive.Value,
                            Required = false,
                            Type = InputType.Checkbox,
                        });
        }
        public IQueryable<QuestionBase<string>> GetSSDMemoryQuestion(IQueryable<Computer> computers, int?[] SSDMemories)
        {
            var stringList = SSDMemories?.Select(item => item.Value.ToString()).ToList();
            return computers
                        .Select(g => g.SSDMemory.Value)
                        .GroupBy(p => p)
                        .Select(p => new { Count = p.Count(), Value = Convert.ToString(p.Key) })
                        .Select(SSDMemory => new QuestionBase<string>()
                        {
                            QuestionsKey = "SSDMemory",
                            AfterBox = (stringList != null && stringList.Contains(SSDMemory.Value)) ? (int?)null : SSDMemory.Count,
                            Checked = stringList != null && stringList.Contains(SSDMemory.Value),
                            ControlType = ControlType.Checkbox,
                            Key = SSDMemory.Value,
                            Label = SSDMemory.Value,
                            Required = false,
                            Type = InputType.Checkbox,
                        });
        }
        public IQueryable<QuestionBase<string>> GetHardDiskMemoryQuestion(IQueryable<Computer> computers, int?[] hardDiskMemories)
        {
            var stringList = hardDiskMemories?.Select(item => item.ToString()).ToList();
            return computers
                        .Select(g => g.HardDiskMemory.Value)
                        .GroupBy(p => p)
                        .Select(p => new { Count = p.Count(), Value = Convert.ToString(p.Key) })
                        .Select(hardDiskMemory => new QuestionBase<string>()
                        {
                            QuestionsKey = "hardDiskMemory",
                            AfterBox = (stringList != null && stringList.Contains(hardDiskMemory.Value)) ? (int?)null : hardDiskMemory.Count,
                            Checked = stringList != null && stringList.Contains(hardDiskMemory.Value),
                            ControlType = ControlType.Checkbox,
                            Key = hardDiskMemory.Value,
                            Label = hardDiskMemory.Value,
                            Required = false,
                            Type = InputType.Checkbox,
                        });
        }
        public IQueryable<QuestionBase<string>> GetCPUSocketTypeQuestion(IQueryable<Computer> computers, string[] CPUSocketTypes)
        {
            return computers
                        .Select(g => g.CPUSocketTypeValue)
                        .GroupBy(p => p)
                        .Select(p => new { Count = p.Count(), Value = Convert.ToString(p.Key) })
                        .Select(CPUSocketType => new QuestionBase<string>()
                        {
                            QuestionsKey = "CPUSocketType",
                            AfterBox = (CPUSocketTypes != null && CPUSocketTypes.Contains(CPUSocketType.Value)) ? (int?)null : CPUSocketType.Count,
                            Checked = CPUSocketTypes != null && CPUSocketTypes.Contains(CPUSocketType.Value),
                            ControlType = ControlType.Checkbox,
                            Key = CPUSocketType.Value,
                            Label = CPUSocketType.Value,
                            Required = false,
                            Type = InputType.Checkbox,
                        });
        }
        public IQueryable<QuestionBase<string>> GetComputerDriveTypeQuestion(IQueryable<Computer> computers, string[] computerDriveTypes)
        {
            return computers
                        .SelectMany(g => g.ComputerComputerDriveTypes.Select(l => l.ComputerDriveTypeValue))
                        .GroupBy(p => p)
                        .Select(p => new { Count = p.Count(), Value = Convert.ToString(p.Key) })
                        .Select(computerDriveType => new QuestionBase<string>()
                        {
                            QuestionsKey = "computerDriveType",
                            AfterBox = (computerDriveTypes != null && computerDriveTypes.Contains(computerDriveType.Value)) ? (int?)null : computerDriveType.Count,
                            Checked = computerDriveTypes != null && computerDriveTypes.Contains(computerDriveType.Value),
                            ControlType = ControlType.Checkbox,
                            Key = computerDriveType.Value,
                            Label = computerDriveType.Value,
                            Required = false,
                            Type = InputType.Checkbox,
                        });
        }
        public IQueryable<QuestionBase<string>> GetNumberOfCoreQuestion(IQueryable<Computer> computers, int[] numberOfCores)
        {
            var stringList = numberOfCores?.Select(item => item.ToString()).ToList();
            return computers
                        .Select(g => g.NumberOfCores)
                        .GroupBy(p => p)
                        .Select(p => new { Count = p.Count(), Value = Convert.ToString(p.Key) })
                        .Select(numberOfCore => new QuestionBase<string>()
                        {
                            QuestionsKey = "numberOfCores",
                            AfterBox = (stringList != null && stringList.Contains(numberOfCore.Value)) ? (int?)null : numberOfCore.Count,
                            Checked = stringList != null && stringList.Contains(numberOfCore.Value),
                            ControlType = ControlType.Checkbox,
                            Key = numberOfCore.Value,
                            Label = numberOfCore.Value,
                            Required = false,
                            Type = InputType.Checkbox,
                        });
        }
        public IQueryable<QuestionBase<string>> GetFloppyDrivesCountQuestion(IQueryable<Computer> computers, int?[] floppyDrivesCountArray)
        {
            var stringList = floppyDrivesCountArray?.Select(item => item.ToString()).ToList();
            return computers
                        .Select(g => g.FloppyDrivesCount.Value)
                        .GroupBy(p => p)
                        .Select(p => new { Count = p.Count(), Value = Convert.ToString(p.Key) })
                        .Select(floppyDrivesCount => new QuestionBase<string>()
                        {
                            QuestionsKey = "floppyDrivesCount",
                            AfterBox = (stringList != null && stringList.Contains(floppyDrivesCount.Value)) ? (int?)null : floppyDrivesCount.Count,
                            Checked = stringList != null && stringList.Contains(floppyDrivesCount.Value),
                            ControlType = ControlType.Checkbox,
                            Key = floppyDrivesCount.Value,
                            Label = floppyDrivesCount.Value,
                            Required = false,
                            Type = InputType.Checkbox,
                        });
        }
    }
}
