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
    public class LaptopsQuestionsService : ILaptopsQuestionsService
    {
        private readonly IComputerTechnologiesQuestionsService _computerTechnologiesQuestionsService;
        private readonly IQuestionsGrouper _questionsGrouper;
        public LaptopsQuestionsService(
            IComputerTechnologiesQuestionsService computerTechnologiesQuestionsService,
            IQuestionsGrouper questionsGrouper)
        {
            _computerTechnologiesQuestionsService = computerTechnologiesQuestionsService;
            _questionsGrouper = questionsGrouper;
        }
        public async Task<List<QuestionsBase<string>>> GetLaptopsQuestions(IQueryable<Laptop> laptops, LaptopsSelector laptopsSelector)
        {
            var goodsSelector = laptopsSelector.ComputerTechnologiesSelector.GoodsSelector;
            var result = await GetQuestionList(laptops, laptopsSelector);
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
                _questionsGrouper.GroupDisplays(result),
            };
            if (laptopsSelector.HaveFloppyDrives == null || laptopsSelector.HaveFloppyDrives.Contains(true))
            {
                questions.Add(_questionsGrouper.GroupFloppyDrivesCount(result));
            }
            return questions;
        }
        private async Task<List<QuestionBase<string>>> GetQuestionList(IQueryable<Laptop> laptops, LaptopsSelector laptopsSelector)
        {
            var goodsSelector = laptopsSelector.ComputerTechnologiesSelector.GoodsSelector;
            var producerQuestions = GetProducerQuestion(GetProducerLaptops(laptops, laptopsSelector), goodsSelector.Producers);
            var countryQuestions = GetCountryQuestion(GetCountryLaptops(laptops, laptopsSelector), goodsSelector.Countries);
            var materialQuestions = GetMaterialQuestion(GetMaterialLaptops(laptops, laptopsSelector), goodsSelector.Materials);
            var colorQuestions = GetColorQuestion(GetColorLaptops(laptops, laptopsSelector), goodsSelector.Colors);
            var priceQuestions = GetPriceQuestion(GetPriceLaptops(laptops, laptopsSelector));


            var amountOfRAMQuestions = GetAmountOfRAMQuestion(GetAmountOfRAMLaptops(laptops, laptopsSelector), laptopsSelector.AmountOfRAMs);
            var CPUFrequencyQuestions = GetCPUFrequencyQuestion(GetCPUFrequencyLaptops(laptops, laptopsSelector), laptopsSelector.CPUFrequencies);
            var lengthQuestions = GetLengthQuestion(GetLengthLaptops(laptops, laptopsSelector), laptopsSelector.Length);
            var heightQuestions = GetHeightQuestion(GetHeightLaptops(laptops, laptopsSelector), laptopsSelector.Height);
            var widthQuestions = GetWidthQuestion(GetWidthLaptops(laptops, laptopsSelector), laptopsSelector.Width);
            var haveFloppyDrivesQuestions = GetHaveFloppyDrivesQuestion(GetHaveFloppyDrivesLaptops(laptops, laptopsSelector), laptopsSelector.HaveFloppyDrives);
            var SSDMemoryQuestions = GetSSDMemoryQuestion(GetSSDMemoryLaptops(laptops, laptopsSelector), laptopsSelector.SSDMemory);
            var hardDiskMemoryQuestions = GetHardDiskMemoryQuestion(GetHardDiskMemoryLaptops(laptops, laptopsSelector), laptopsSelector.HardDiskMemory);
            var CPUSocketTypeQuestions = GetCPUSocketTypeQuestion(GetCPUSocketTypeLaptops(laptops, laptopsSelector), laptopsSelector.CPUSocketTypes);
            var computerDriveTypeQuestions = GetComputerDriveTypeQuestion(GetComputerDriveTypeLaptops(laptops, laptopsSelector), laptopsSelector.ComputerDriveTypes);
            var numberOfCoreQuestions = GetNumberOfCoreQuestion(GetNumberOfCoresLaptops(laptops, laptopsSelector), laptopsSelector.NumberOfCores);
            var displayQuestions = GetDisplayQuestion(GetDisplayLaptops(laptops, laptopsSelector), laptopsSelector.Displays);
            var floppyDrivesCountQuestions = GetFloppyDrivesCountQuestion(GetFloppyDrivesCountLaptops(laptops, laptopsSelector), laptopsSelector.FloppyDrivesCount);


            var group = producerQuestions.Union(countryQuestions).Union(materialQuestions).Union(colorQuestions).Union(priceQuestions)
                .Union(amountOfRAMQuestions).Union(CPUFrequencyQuestions).Union(lengthQuestions).Union(heightQuestions)
                .Union(widthQuestions).Union(haveFloppyDrivesQuestions).Union(SSDMemoryQuestions).Union(hardDiskMemoryQuestions)
                .Union(CPUSocketTypeQuestions).Union(computerDriveTypeQuestions).Union(numberOfCoreQuestions)
                .Union(displayQuestions);

            if (laptopsSelector.HaveFloppyDrives == null || laptopsSelector.HaveFloppyDrives.Contains(true))
            {
                group = group.Union(floppyDrivesCountQuestions);
            }
            return await group.ToListAsync();
        }

        public IQueryable<T> GetProducerLaptops<T>(
            IQueryable<T> laptops,
            LaptopsSelector laptopsSelector) where T : Laptop
        {
            var goodsSelector = laptopsSelector.ComputerTechnologiesSelector.GoodsSelector;
            var computerTechnologiesSelector = laptopsSelector.ComputerTechnologiesSelector;
            return _computerTechnologiesQuestionsService.GetProducerComputerTechnologies(
                laptops, computerTechnologiesSelector)
                .Where(l => (goodsSelector.Producers != null && goodsSelector.Producers.Contains(l.Producer.Name)) ||
                ((laptopsSelector.HaveFloppyDrives == null || laptopsSelector.HaveFloppyDrives.Contains(l.HaveFloppyDrives))
                && (laptopsSelector.AmountOfRAMs == null || laptopsSelector.AmountOfRAMs.Contains(l.AmountOfRAM))
                && (laptopsSelector.Displays == null || laptopsSelector.Displays.Contains(l.Display))
                && (laptopsSelector.FloppyDrivesCount == null || laptopsSelector.FloppyDrivesCount.Contains(l.FloppyDrivesCount))
                && (laptopsSelector.NumberOfCores == null || laptopsSelector.NumberOfCores.Contains(l.NumberOfCores))
                && (laptopsSelector.ComputerDriveTypes == null || 
                laptopsSelector.ComputerDriveTypes.Any(c => l.LaptopComputerDriveTypes.Select(el => el.ComputerDriveTypeValue).Contains(c)))
                && (laptopsSelector.CPUSocketTypes == null || laptopsSelector.CPUSocketTypes.Contains(l.CPUSocketTypeValue))
                && (laptopsSelector.HardDiskMemory == null || laptopsSelector.HardDiskMemory.Contains(l.HardDiskMemory))
                && (laptopsSelector.SSDMemory == null || laptopsSelector.SSDMemory.Contains(l.SSDMemory))
                && (laptopsSelector.Width == null || laptopsSelector.Width.Contains(l.Width))
                && (laptopsSelector.Height == null || laptopsSelector.Height.Contains(l.Height))
                && (laptopsSelector.Length == null || laptopsSelector.Length.Contains(l.Length))
                && (laptopsSelector.CPUFrequencies == null || laptopsSelector.CPUFrequencies.Contains(l.CPUFrequency))));
        }
        public IQueryable<T> GetCountryLaptops<T>(
            IQueryable<T> laptops,
            LaptopsSelector laptopsSelector) where T : Laptop
        {
            var goodsSelector = laptopsSelector.ComputerTechnologiesSelector.GoodsSelector;
            var computerTechnologiesSelector = laptopsSelector.ComputerTechnologiesSelector;
            return _computerTechnologiesQuestionsService.GetCountryComputerTechnologies(
                laptops, computerTechnologiesSelector)
                .Where(l => (goodsSelector.Countries != null && goodsSelector.Countries.Contains(l.Manufacturer.Country.Value)) ||
                ((laptopsSelector.HaveFloppyDrives == null || laptopsSelector.HaveFloppyDrives.Contains(l.HaveFloppyDrives))
                && (laptopsSelector.AmountOfRAMs == null || laptopsSelector.AmountOfRAMs.Contains(l.AmountOfRAM))
                && (laptopsSelector.Displays == null || laptopsSelector.Displays.Contains(l.Display))
                && (laptopsSelector.FloppyDrivesCount == null || laptopsSelector.FloppyDrivesCount.Contains(l.FloppyDrivesCount))
                && (laptopsSelector.NumberOfCores == null || laptopsSelector.NumberOfCores.Contains(l.NumberOfCores))
                && (laptopsSelector.ComputerDriveTypes == null || 
                laptopsSelector.ComputerDriveTypes.Any(c => l.LaptopComputerDriveTypes.Select(el => el.ComputerDriveTypeValue).Contains(c)))
                && (laptopsSelector.CPUSocketTypes == null || laptopsSelector.CPUSocketTypes.Contains(l.CPUSocketTypeValue))
                && (laptopsSelector.HardDiskMemory == null || laptopsSelector.HardDiskMemory.Contains(l.HardDiskMemory))
                && (laptopsSelector.SSDMemory == null || laptopsSelector.SSDMemory.Contains(l.SSDMemory))
                && (laptopsSelector.Width == null || laptopsSelector.Width.Contains(l.Width))
                && (laptopsSelector.Height == null || laptopsSelector.Height.Contains(l.Height))
                && (laptopsSelector.Length == null || laptopsSelector.Length.Contains(l.Length))
                && (laptopsSelector.CPUFrequencies == null || laptopsSelector.CPUFrequencies.Contains(l.CPUFrequency))));
        }
        public IQueryable<T> GetMaterialLaptops<T>(
            IQueryable<T> laptops,
            LaptopsSelector laptopsSelector) where T : Laptop
        {
            var goodsSelector = laptopsSelector.ComputerTechnologiesSelector.GoodsSelector;
            var computerTechnologiesSelector = laptopsSelector.ComputerTechnologiesSelector;
            return _computerTechnologiesQuestionsService.GetMaterialComputerTechnologies(
                laptops, computerTechnologiesSelector)
                .Where(l => (goodsSelector.Materials != null && goodsSelector.Materials.Contains(l.MaterialValue)) ||
                ((laptopsSelector.HaveFloppyDrives == null || laptopsSelector.HaveFloppyDrives.Contains(l.HaveFloppyDrives))
                && (laptopsSelector.AmountOfRAMs == null || laptopsSelector.AmountOfRAMs.Contains(l.AmountOfRAM))
                && (laptopsSelector.Displays == null || laptopsSelector.Displays.Contains(l.Display))
                && (laptopsSelector.FloppyDrivesCount == null || laptopsSelector.FloppyDrivesCount.Contains(l.FloppyDrivesCount))
                && (laptopsSelector.NumberOfCores == null || laptopsSelector.NumberOfCores.Contains(l.NumberOfCores))
                && (laptopsSelector.ComputerDriveTypes == null ||
                laptopsSelector.ComputerDriveTypes.Any(c => l.LaptopComputerDriveTypes.Select(el => el.ComputerDriveTypeValue).Contains(c)))
                && (laptopsSelector.CPUSocketTypes == null || laptopsSelector.CPUSocketTypes.Contains(l.CPUSocketTypeValue))
                && (laptopsSelector.HardDiskMemory == null || laptopsSelector.HardDiskMemory.Contains(l.HardDiskMemory))
                && (laptopsSelector.SSDMemory == null || laptopsSelector.SSDMemory.Contains(l.SSDMemory))
                && (laptopsSelector.Width == null || laptopsSelector.Width.Contains(l.Width))
                && (laptopsSelector.Height == null || laptopsSelector.Height.Contains(l.Height))
                && (laptopsSelector.Length == null || laptopsSelector.Length.Contains(l.Length))
                && (laptopsSelector.CPUFrequencies == null || laptopsSelector.CPUFrequencies.Contains(l.CPUFrequency))));
        }
        public IQueryable<T> GetColorLaptops<T>(
            IQueryable<T> laptops,
            LaptopsSelector laptopsSelector) where T : Laptop
        {
            var goodsSelector = laptopsSelector.ComputerTechnologiesSelector.GoodsSelector;
            var computerTechnologiesSelector = laptopsSelector.ComputerTechnologiesSelector;
            return _computerTechnologiesQuestionsService.GetColorComputerTechnologies(
                laptops, computerTechnologiesSelector)
                .Where(l => (goodsSelector.Colors != null && goodsSelector.Colors.Contains(l.ColorValue)) ||
                ((laptopsSelector.HaveFloppyDrives == null || laptopsSelector.HaveFloppyDrives.Contains(l.HaveFloppyDrives))
                && (laptopsSelector.AmountOfRAMs == null || laptopsSelector.AmountOfRAMs.Contains(l.AmountOfRAM))
                && (laptopsSelector.Displays == null || laptopsSelector.Displays.Contains(l.Display))
                && (laptopsSelector.FloppyDrivesCount == null || laptopsSelector.FloppyDrivesCount.Contains(l.FloppyDrivesCount))
                && (laptopsSelector.NumberOfCores == null || laptopsSelector.NumberOfCores.Contains(l.NumberOfCores))
                && (laptopsSelector.ComputerDriveTypes == null ||
                laptopsSelector.ComputerDriveTypes.Any(c => l.LaptopComputerDriveTypes.Select(el => el.ComputerDriveTypeValue).Contains(c)))
                && (laptopsSelector.CPUSocketTypes == null || laptopsSelector.CPUSocketTypes.Contains(l.CPUSocketTypeValue))
                && (laptopsSelector.HardDiskMemory == null || laptopsSelector.HardDiskMemory.Contains(l.HardDiskMemory))
                && (laptopsSelector.SSDMemory == null || laptopsSelector.SSDMemory.Contains(l.SSDMemory))
                && (laptopsSelector.Width == null || laptopsSelector.Width.Contains(l.Width))
                && (laptopsSelector.Height == null || laptopsSelector.Height.Contains(l.Height))
                && (laptopsSelector.Length == null || laptopsSelector.Length.Contains(l.Length))
                && (laptopsSelector.CPUFrequencies == null || laptopsSelector.CPUFrequencies.Contains(l.CPUFrequency))));
        }
        public IQueryable<T> GetPriceLaptops<T>(
            IQueryable<T> laptops,
            LaptopsSelector laptopsSelector) where T : Laptop
        {
            var goodsSelector = laptopsSelector.ComputerTechnologiesSelector.GoodsSelector;
            var computerTechnologiesSelector = laptopsSelector.ComputerTechnologiesSelector;
            return _computerTechnologiesQuestionsService.GetPriceComputerTechnologies(
                laptops, computerTechnologiesSelector)
                .Where(l =>
                (laptopsSelector.HaveFloppyDrives == null || laptopsSelector.HaveFloppyDrives.Contains(l.HaveFloppyDrives))
                && (laptopsSelector.AmountOfRAMs == null || laptopsSelector.AmountOfRAMs.Contains(l.AmountOfRAM))
                && (laptopsSelector.Displays == null || laptopsSelector.Displays.Contains(l.Display))
                && (laptopsSelector.FloppyDrivesCount == null || laptopsSelector.FloppyDrivesCount.Contains(l.FloppyDrivesCount))
                && (laptopsSelector.NumberOfCores == null || laptopsSelector.NumberOfCores.Contains(l.NumberOfCores))
                && (laptopsSelector.ComputerDriveTypes == null ||
                laptopsSelector.ComputerDriveTypes.Any(c => l.LaptopComputerDriveTypes.Select(el => el.ComputerDriveTypeValue).Contains(c)))
                && (laptopsSelector.CPUSocketTypes == null || laptopsSelector.CPUSocketTypes.Contains(l.CPUSocketTypeValue))
                && (laptopsSelector.HardDiskMemory == null || laptopsSelector.HardDiskMemory.Contains(l.HardDiskMemory))
                && (laptopsSelector.SSDMemory == null || laptopsSelector.SSDMemory.Contains(l.SSDMemory))
                && (laptopsSelector.Width == null || laptopsSelector.Width.Contains(l.Width))
                && (laptopsSelector.Height == null || laptopsSelector.Height.Contains(l.Height))
                && (laptopsSelector.Length == null || laptopsSelector.Length.Contains(l.Length))
                && (laptopsSelector.CPUFrequencies == null || laptopsSelector.CPUFrequencies.Contains(l.CPUFrequency)));
        }
        public IQueryable<T> GetAmountOfRAMLaptops<T>(
            IQueryable<T> laptops,
            LaptopsSelector laptopsSelector) where T : Laptop
        {
            var goodsSelector = laptopsSelector.ComputerTechnologiesSelector.GoodsSelector;
            return laptops
                .Where(l => (laptopsSelector.AmountOfRAMs != null && laptopsSelector.AmountOfRAMs.Contains(l.AmountOfRAM)) ||
                ((goodsSelector.PriceFrom == null || l.Price >= goodsSelector.PriceFrom) 
                && (goodsSelector.PriceTo == null || l.Price <= goodsSelector.PriceTo)
                && (laptopsSelector.HaveFloppyDrives == null || laptopsSelector.HaveFloppyDrives.Contains(l.HaveFloppyDrives))
                && (laptopsSelector.Displays == null || laptopsSelector.Displays.Contains(l.Display))
                && (laptopsSelector.FloppyDrivesCount == null || laptopsSelector.FloppyDrivesCount.Contains(l.FloppyDrivesCount))
                && (laptopsSelector.NumberOfCores == null || laptopsSelector.NumberOfCores.Contains(l.NumberOfCores))
                && (laptopsSelector.ComputerDriveTypes == null ||
                laptopsSelector.ComputerDriveTypes.Any(c => l.LaptopComputerDriveTypes.Select(el => el.ComputerDriveTypeValue).Contains(c)))
                && (laptopsSelector.CPUSocketTypes == null || laptopsSelector.CPUSocketTypes.Contains(l.CPUSocketTypeValue))
                && (laptopsSelector.HardDiskMemory == null || laptopsSelector.HardDiskMemory.Contains(l.HardDiskMemory))
                && (laptopsSelector.SSDMemory == null || laptopsSelector.SSDMemory.Contains(l.SSDMemory))
                && (laptopsSelector.Width == null || laptopsSelector.Width.Contains(l.Width))
                && (laptopsSelector.Height == null || laptopsSelector.Height.Contains(l.Height))
                && (laptopsSelector.Length == null || laptopsSelector.Length.Contains(l.Length))
                && (laptopsSelector.CPUFrequencies == null || laptopsSelector.CPUFrequencies.Contains(l.CPUFrequency))
                && (goodsSelector.Producers == null || goodsSelector.Producers.Contains(l.Producer.Name))
                && (goodsSelector.Countries == null || goodsSelector.Countries.Contains(l.Manufacturer.Country.Value))
                && (goodsSelector.Materials == null || goodsSelector.Materials.Contains(l.MaterialValue))
                && (goodsSelector.Colors == null || goodsSelector.Colors.Contains(l.ColorValue))));
        }
        public IQueryable<T> GetCPUFrequencyLaptops<T>(
            IQueryable<T> laptops,
            LaptopsSelector laptopsSelector) where T : Laptop
        {
            var goodsSelector = laptopsSelector.ComputerTechnologiesSelector.GoodsSelector;
            return laptops
                .Where(l => (laptopsSelector.CPUFrequencies != null && laptopsSelector.CPUFrequencies.Contains(l.CPUFrequency)) ||
                ((goodsSelector.PriceFrom == null || l.Price >= goodsSelector.PriceFrom)
                && (goodsSelector.PriceTo == null || l.Price <= goodsSelector.PriceTo)
                && (laptopsSelector.HaveFloppyDrives == null || laptopsSelector.HaveFloppyDrives.Contains(l.HaveFloppyDrives))
                && (laptopsSelector.Displays == null || laptopsSelector.Displays.Contains(l.Display))
                && (laptopsSelector.FloppyDrivesCount == null || laptopsSelector.FloppyDrivesCount.Contains(l.FloppyDrivesCount))
                && (laptopsSelector.NumberOfCores == null || laptopsSelector.NumberOfCores.Contains(l.NumberOfCores))
                && (laptopsSelector.ComputerDriveTypes == null ||
                laptopsSelector.ComputerDriveTypes.Any(c => l.LaptopComputerDriveTypes.Select(el => el.ComputerDriveTypeValue).Contains(c)))
                && (laptopsSelector.CPUSocketTypes == null || laptopsSelector.CPUSocketTypes.Contains(l.CPUSocketTypeValue))
                && (laptopsSelector.HardDiskMemory == null || laptopsSelector.HardDiskMemory.Contains(l.HardDiskMemory))
                && (laptopsSelector.SSDMemory == null || laptopsSelector.SSDMemory.Contains(l.SSDMemory))
                && (laptopsSelector.Width == null || laptopsSelector.Width.Contains(l.Width))
                && (laptopsSelector.Height == null || laptopsSelector.Height.Contains(l.Height))
                && (laptopsSelector.Length == null || laptopsSelector.Length.Contains(l.Length))
                && (laptopsSelector.AmountOfRAMs == null || laptopsSelector.AmountOfRAMs.Contains(l.AmountOfRAM))
                && (goodsSelector.Producers == null || goodsSelector.Producers.Contains(l.Producer.Name))
                && (goodsSelector.Countries == null || goodsSelector.Countries.Contains(l.Manufacturer.Country.Value))
                && (goodsSelector.Materials == null || goodsSelector.Materials.Contains(l.MaterialValue))
                && (goodsSelector.Colors == null || goodsSelector.Colors.Contains(l.ColorValue))));
        }
        public IQueryable<T> GetLengthLaptops<T>(
            IQueryable<T> laptops,
            LaptopsSelector laptopsSelector) where T : Laptop
        {
            var goodsSelector = laptopsSelector.ComputerTechnologiesSelector.GoodsSelector;
            return laptops
                .Where(l => (laptopsSelector.Length != null && laptopsSelector.Length.Contains(l.Length)) ||
                ((goodsSelector.PriceFrom == null || l.Price >= goodsSelector.PriceFrom)
                && (goodsSelector.PriceTo == null || l.Price <= goodsSelector.PriceTo)
                && (laptopsSelector.HaveFloppyDrives == null || laptopsSelector.HaveFloppyDrives.Contains(l.HaveFloppyDrives))
                && (laptopsSelector.Displays == null || laptopsSelector.Displays.Contains(l.Display))
                && (laptopsSelector.FloppyDrivesCount == null || laptopsSelector.FloppyDrivesCount.Contains(l.FloppyDrivesCount))
                && (laptopsSelector.NumberOfCores == null || laptopsSelector.NumberOfCores.Contains(l.NumberOfCores))
                && (laptopsSelector.ComputerDriveTypes == null ||
                laptopsSelector.ComputerDriveTypes.Any(c => l.LaptopComputerDriveTypes.Select(el => el.ComputerDriveTypeValue).Contains(c)))
                && (laptopsSelector.CPUSocketTypes == null || laptopsSelector.CPUSocketTypes.Contains(l.CPUSocketTypeValue))
                && (laptopsSelector.HardDiskMemory == null || laptopsSelector.HardDiskMemory.Contains(l.HardDiskMemory))
                && (laptopsSelector.SSDMemory == null || laptopsSelector.SSDMemory.Contains(l.SSDMemory))
                && (laptopsSelector.Width == null || laptopsSelector.Width.Contains(l.Width))
                && (laptopsSelector.Height == null || laptopsSelector.Height.Contains(l.Height))
                && (laptopsSelector.CPUFrequencies == null || laptopsSelector.CPUFrequencies.Contains(l.CPUFrequency))
                && (laptopsSelector.AmountOfRAMs == null || laptopsSelector.AmountOfRAMs.Contains(l.AmountOfRAM))
                && (goodsSelector.Producers == null || goodsSelector.Producers.Contains(l.Producer.Name))
                && (goodsSelector.Countries == null || goodsSelector.Countries.Contains(l.Manufacturer.Country.Value))
                && (goodsSelector.Materials == null || goodsSelector.Materials.Contains(l.MaterialValue))
                && (goodsSelector.Colors == null || goodsSelector.Colors.Contains(l.ColorValue))));
        }
        public IQueryable<T> GetHeightLaptops<T>(
            IQueryable<T> laptops,
            LaptopsSelector laptopsSelector) where T : Laptop
        {
            var goodsSelector = laptopsSelector.ComputerTechnologiesSelector.GoodsSelector;
            return laptops
                .Where(l => (laptopsSelector.Height != null && laptopsSelector.Height.Contains(l.Height)) ||
                ((goodsSelector.PriceFrom == null || l.Price >= goodsSelector.PriceFrom)
                && (goodsSelector.PriceTo == null || l.Price <= goodsSelector.PriceTo)
                && (laptopsSelector.HaveFloppyDrives == null || laptopsSelector.HaveFloppyDrives.Contains(l.HaveFloppyDrives))
                && (laptopsSelector.Displays == null || laptopsSelector.Displays.Contains(l.Display))
                && (laptopsSelector.FloppyDrivesCount == null || laptopsSelector.FloppyDrivesCount.Contains(l.FloppyDrivesCount))
                && (laptopsSelector.NumberOfCores == null || laptopsSelector.NumberOfCores.Contains(l.NumberOfCores))
                && (laptopsSelector.ComputerDriveTypes == null ||
                laptopsSelector.ComputerDriveTypes.Any(c => l.LaptopComputerDriveTypes.Select(el => el.ComputerDriveTypeValue).Contains(c)))
                && (laptopsSelector.CPUSocketTypes == null || laptopsSelector.CPUSocketTypes.Contains(l.CPUSocketTypeValue))
                && (laptopsSelector.HardDiskMemory == null || laptopsSelector.HardDiskMemory.Contains(l.HardDiskMemory))
                && (laptopsSelector.SSDMemory == null || laptopsSelector.SSDMemory.Contains(l.SSDMemory))
                && (laptopsSelector.Width == null || laptopsSelector.Width.Contains(l.Width))
                && (laptopsSelector.Length == null || laptopsSelector.Length.Contains(l.Length))
                && (laptopsSelector.CPUFrequencies == null || laptopsSelector.CPUFrequencies.Contains(l.CPUFrequency))
                && (laptopsSelector.AmountOfRAMs == null || laptopsSelector.AmountOfRAMs.Contains(l.AmountOfRAM))
                && (goodsSelector.Producers == null || goodsSelector.Producers.Contains(l.Producer.Name))
                && (goodsSelector.Countries == null || goodsSelector.Countries.Contains(l.Manufacturer.Country.Value))
                && (goodsSelector.Materials == null || goodsSelector.Materials.Contains(l.MaterialValue))
                && (goodsSelector.Colors == null || goodsSelector.Colors.Contains(l.ColorValue))));
        }
        public IQueryable<T> GetWidthLaptops<T>(
            IQueryable<T> laptops,
            LaptopsSelector laptopsSelector) where T : Laptop
        {
            var goodsSelector = laptopsSelector.ComputerTechnologiesSelector.GoodsSelector;
            return laptops
                .Where(l => (laptopsSelector.Width != null && laptopsSelector.Width.Contains(l.Width)) ||
                ((goodsSelector.PriceFrom == null || l.Price >= goodsSelector.PriceFrom)
                && (goodsSelector.PriceTo == null || l.Price <= goodsSelector.PriceTo)
                && (laptopsSelector.HaveFloppyDrives == null || laptopsSelector.HaveFloppyDrives.Contains(l.HaveFloppyDrives))
                && (laptopsSelector.Displays == null || laptopsSelector.Displays.Contains(l.Display))
                && (laptopsSelector.FloppyDrivesCount == null || laptopsSelector.FloppyDrivesCount.Contains(l.FloppyDrivesCount))
                && (laptopsSelector.NumberOfCores == null || laptopsSelector.NumberOfCores.Contains(l.NumberOfCores))
                && (laptopsSelector.ComputerDriveTypes == null ||
                laptopsSelector.ComputerDriveTypes.Any(c => l.LaptopComputerDriveTypes.Select(el => el.ComputerDriveTypeValue).Contains(c)))
                && (laptopsSelector.CPUSocketTypes == null || laptopsSelector.CPUSocketTypes.Contains(l.CPUSocketTypeValue))
                && (laptopsSelector.HardDiskMemory == null || laptopsSelector.HardDiskMemory.Contains(l.HardDiskMemory))
                && (laptopsSelector.SSDMemory == null || laptopsSelector.SSDMemory.Contains(l.SSDMemory))
                && (laptopsSelector.Height == null || laptopsSelector.Height.Contains(l.Height))
                && (laptopsSelector.Length == null || laptopsSelector.Length.Contains(l.Length))
                && (laptopsSelector.CPUFrequencies == null || laptopsSelector.CPUFrequencies.Contains(l.CPUFrequency))
                && (laptopsSelector.AmountOfRAMs == null || laptopsSelector.AmountOfRAMs.Contains(l.AmountOfRAM))
                && (goodsSelector.Producers == null || goodsSelector.Producers.Contains(l.Producer.Name))
                && (goodsSelector.Countries == null || goodsSelector.Countries.Contains(l.Manufacturer.Country.Value))
                && (goodsSelector.Materials == null || goodsSelector.Materials.Contains(l.MaterialValue))
                && (goodsSelector.Colors == null || goodsSelector.Colors.Contains(l.ColorValue))));
        }
        public IQueryable<T> GetSSDMemoryLaptops<T>(
            IQueryable<T> laptops,
            LaptopsSelector laptopsSelector) where T : Laptop
        {
            var goodsSelector = laptopsSelector.ComputerTechnologiesSelector.GoodsSelector;
            return laptops
                .Where(l => (laptopsSelector.SSDMemory != null && laptopsSelector.SSDMemory.Contains(l.SSDMemory)) ||
                ((goodsSelector.PriceFrom == null || l.Price >= goodsSelector.PriceFrom)
                && (goodsSelector.PriceTo == null || l.Price <= goodsSelector.PriceTo)
                && (laptopsSelector.HaveFloppyDrives == null || laptopsSelector.HaveFloppyDrives.Contains(l.HaveFloppyDrives))
                && (laptopsSelector.Displays == null || laptopsSelector.Displays.Contains(l.Display))
                && (laptopsSelector.FloppyDrivesCount == null || laptopsSelector.FloppyDrivesCount.Contains(l.FloppyDrivesCount))
                && (laptopsSelector.NumberOfCores == null || laptopsSelector.NumberOfCores.Contains(l.NumberOfCores))
                && (laptopsSelector.ComputerDriveTypes == null ||
                laptopsSelector.ComputerDriveTypes.Any(c => l.LaptopComputerDriveTypes.Select(el => el.ComputerDriveTypeValue).Contains(c)))
                && (laptopsSelector.CPUSocketTypes == null || laptopsSelector.CPUSocketTypes.Contains(l.CPUSocketTypeValue))
                && (laptopsSelector.HardDiskMemory == null || laptopsSelector.HardDiskMemory.Contains(l.HardDiskMemory))
                && (laptopsSelector.Width == null || laptopsSelector.Width.Contains(l.Width))
                && (laptopsSelector.Height == null || laptopsSelector.Height.Contains(l.Height))
                && (laptopsSelector.Length == null || laptopsSelector.Length.Contains(l.Length))
                && (laptopsSelector.CPUFrequencies == null || laptopsSelector.CPUFrequencies.Contains(l.CPUFrequency))
                && (laptopsSelector.AmountOfRAMs == null || laptopsSelector.AmountOfRAMs.Contains(l.AmountOfRAM))
                && (goodsSelector.Producers == null || goodsSelector.Producers.Contains(l.Producer.Name))
                && (goodsSelector.Countries == null || goodsSelector.Countries.Contains(l.Manufacturer.Country.Value))
                && (goodsSelector.Materials == null || goodsSelector.Materials.Contains(l.MaterialValue))
                && (goodsSelector.Colors == null || goodsSelector.Colors.Contains(l.ColorValue))));
        }
        public IQueryable<T> GetHardDiskMemoryLaptops<T>(
            IQueryable<T> laptops,
            LaptopsSelector laptopsSelector) where T : Laptop
        {
            var goodsSelector = laptopsSelector.ComputerTechnologiesSelector.GoodsSelector;
            return laptops
                .Where(l => (laptopsSelector.HardDiskMemory != null && laptopsSelector.HardDiskMemory.Contains(l.HardDiskMemory)) ||
                ((goodsSelector.PriceFrom == null || l.Price >= goodsSelector.PriceFrom)
                && (goodsSelector.PriceTo == null || l.Price <= goodsSelector.PriceTo)
                && (laptopsSelector.HaveFloppyDrives == null || laptopsSelector.HaveFloppyDrives.Contains(l.HaveFloppyDrives))
                && (laptopsSelector.Displays == null || laptopsSelector.Displays.Contains(l.Display))
                && (laptopsSelector.FloppyDrivesCount == null || laptopsSelector.FloppyDrivesCount.Contains(l.FloppyDrivesCount))
                && (laptopsSelector.NumberOfCores == null || laptopsSelector.NumberOfCores.Contains(l.NumberOfCores))
                && (laptopsSelector.ComputerDriveTypes == null ||
                laptopsSelector.ComputerDriveTypes.Any(c => l.LaptopComputerDriveTypes.Select(el => el.ComputerDriveTypeValue).Contains(c)))
                && (laptopsSelector.CPUSocketTypes == null || laptopsSelector.CPUSocketTypes.Contains(l.CPUSocketTypeValue))
                && (laptopsSelector.SSDMemory == null || laptopsSelector.SSDMemory.Contains(l.SSDMemory))
                && (laptopsSelector.Width == null || laptopsSelector.Width.Contains(l.Width))
                && (laptopsSelector.Height == null || laptopsSelector.Height.Contains(l.Height))
                && (laptopsSelector.Length == null || laptopsSelector.Length.Contains(l.Length))
                && (laptopsSelector.CPUFrequencies == null || laptopsSelector.CPUFrequencies.Contains(l.CPUFrequency))
                && (laptopsSelector.AmountOfRAMs == null || laptopsSelector.AmountOfRAMs.Contains(l.AmountOfRAM))
                && (goodsSelector.Producers == null || goodsSelector.Producers.Contains(l.Producer.Name))
                && (goodsSelector.Countries == null || goodsSelector.Countries.Contains(l.Manufacturer.Country.Value))
                && (goodsSelector.Materials == null || goodsSelector.Materials.Contains(l.MaterialValue))
                && (goodsSelector.Colors == null || goodsSelector.Colors.Contains(l.ColorValue))));
        }
        public IQueryable<T> GetCPUSocketTypeLaptops<T>(
            IQueryable<T> laptops,
            LaptopsSelector laptopsSelector) where T : Laptop
        {
            var goodsSelector = laptopsSelector.ComputerTechnologiesSelector.GoodsSelector;
            return laptops
                .Where(l => (laptopsSelector.CPUSocketTypes != null && laptopsSelector.CPUSocketTypes.Contains(l.CPUSocketTypeValue)) ||
                ((goodsSelector.PriceFrom == null || l.Price >= goodsSelector.PriceFrom)
                && (goodsSelector.PriceTo == null || l.Price <= goodsSelector.PriceTo)
                && (laptopsSelector.HaveFloppyDrives == null || laptopsSelector.HaveFloppyDrives.Contains(l.HaveFloppyDrives))
                && (laptopsSelector.Displays == null || laptopsSelector.Displays.Contains(l.Display))
                && (laptopsSelector.FloppyDrivesCount == null || laptopsSelector.FloppyDrivesCount.Contains(l.FloppyDrivesCount))
                && (laptopsSelector.NumberOfCores == null || laptopsSelector.NumberOfCores.Contains(l.NumberOfCores))
                && (laptopsSelector.ComputerDriveTypes == null ||
                laptopsSelector.ComputerDriveTypes.Any(c => l.LaptopComputerDriveTypes.Select(el => el.ComputerDriveTypeValue).Contains(c)))
                && (laptopsSelector.HardDiskMemory == null || laptopsSelector.HardDiskMemory.Contains(l.HardDiskMemory))
                && (laptopsSelector.SSDMemory == null || laptopsSelector.SSDMemory.Contains(l.SSDMemory))
                && (laptopsSelector.Width == null || laptopsSelector.Width.Contains(l.Width))
                && (laptopsSelector.Height == null || laptopsSelector.Height.Contains(l.Height))
                && (laptopsSelector.Length == null || laptopsSelector.Length.Contains(l.Length))
                && (laptopsSelector.CPUFrequencies == null || laptopsSelector.CPUFrequencies.Contains(l.CPUFrequency))
                && (laptopsSelector.AmountOfRAMs == null || laptopsSelector.AmountOfRAMs.Contains(l.AmountOfRAM))
                && (goodsSelector.Producers == null || goodsSelector.Producers.Contains(l.Producer.Name))
                && (goodsSelector.Countries == null || goodsSelector.Countries.Contains(l.Manufacturer.Country.Value))
                && (goodsSelector.Materials == null || goodsSelector.Materials.Contains(l.MaterialValue))
                && (goodsSelector.Colors == null || goodsSelector.Colors.Contains(l.ColorValue))));
        }
        public IQueryable<T> GetComputerDriveTypeLaptops<T>(
            IQueryable<T> laptops,
            LaptopsSelector laptopsSelector) where T : Laptop
        {
            var goodsSelector = laptopsSelector.ComputerTechnologiesSelector.GoodsSelector;
            return laptops
                .Where(l => (laptopsSelector.ComputerDriveTypes != null 
                && laptopsSelector.ComputerDriveTypes.Any(c => l.LaptopComputerDriveTypes.Select(el => el.ComputerDriveTypeValue).Contains(c))) 
                ||
                ((goodsSelector.PriceFrom == null || l.Price >= goodsSelector.PriceFrom)
                && (goodsSelector.PriceTo == null || l.Price <= goodsSelector.PriceTo)
                && (laptopsSelector.HaveFloppyDrives == null || laptopsSelector.HaveFloppyDrives.Contains(l.HaveFloppyDrives))
                && (laptopsSelector.Displays == null || laptopsSelector.Displays.Contains(l.Display))
                && (laptopsSelector.FloppyDrivesCount == null || laptopsSelector.FloppyDrivesCount.Contains(l.FloppyDrivesCount))
                && (laptopsSelector.NumberOfCores == null || laptopsSelector.NumberOfCores.Contains(l.NumberOfCores))
                && (laptopsSelector.CPUSocketTypes == null || laptopsSelector.CPUSocketTypes.Contains(l.CPUSocketTypeValue))
                && (laptopsSelector.HardDiskMemory == null || laptopsSelector.HardDiskMemory.Contains(l.HardDiskMemory))
                && (laptopsSelector.SSDMemory == null || laptopsSelector.SSDMemory.Contains(l.SSDMemory))
                && (laptopsSelector.Width == null || laptopsSelector.Width.Contains(l.Width))
                && (laptopsSelector.Height == null || laptopsSelector.Height.Contains(l.Height))
                && (laptopsSelector.Length == null || laptopsSelector.Length.Contains(l.Length))
                && (laptopsSelector.CPUFrequencies == null || laptopsSelector.CPUFrequencies.Contains(l.CPUFrequency))
                && (laptopsSelector.AmountOfRAMs == null || laptopsSelector.AmountOfRAMs.Contains(l.AmountOfRAM))
                && (goodsSelector.Producers == null || goodsSelector.Producers.Contains(l.Producer.Name))
                && (goodsSelector.Countries == null || goodsSelector.Countries.Contains(l.Manufacturer.Country.Value))
                && (goodsSelector.Materials == null || goodsSelector.Materials.Contains(l.MaterialValue))
                && (goodsSelector.Colors == null || goodsSelector.Colors.Contains(l.ColorValue))));
        }
        public IQueryable<T> GetNumberOfCoresLaptops<T>(
            IQueryable<T> laptops,
            LaptopsSelector laptopsSelector) where T : Laptop
        {
            var goodsSelector = laptopsSelector.ComputerTechnologiesSelector.GoodsSelector;
            return laptops
                .Where(l => (laptopsSelector.NumberOfCores != null && laptopsSelector.NumberOfCores.Contains(l.NumberOfCores)) ||
                ((goodsSelector.PriceFrom == null || l.Price >= goodsSelector.PriceFrom)
                && (goodsSelector.PriceTo == null || l.Price <= goodsSelector.PriceTo)
                && (laptopsSelector.HaveFloppyDrives == null || laptopsSelector.HaveFloppyDrives.Contains(l.HaveFloppyDrives))
                && (laptopsSelector.Displays == null || laptopsSelector.Displays.Contains(l.Display))
                && (laptopsSelector.FloppyDrivesCount == null || laptopsSelector.FloppyDrivesCount.Contains(l.FloppyDrivesCount))
                && (laptopsSelector.HardDiskMemory == null || laptopsSelector.HardDiskMemory.Contains(l.HardDiskMemory))
                && (laptopsSelector.ComputerDriveTypes == null ||
                laptopsSelector.ComputerDriveTypes.Any(c => l.LaptopComputerDriveTypes.Select(el => el.ComputerDriveTypeValue).Contains(c)))
                && (laptopsSelector.CPUSocketTypes == null || laptopsSelector.CPUSocketTypes.Contains(l.CPUSocketTypeValue))
                && (laptopsSelector.SSDMemory == null || laptopsSelector.SSDMemory.Contains(l.SSDMemory))
                && (laptopsSelector.Width == null || laptopsSelector.Width.Contains(l.Width))
                && (laptopsSelector.Height == null || laptopsSelector.Height.Contains(l.Height))
                && (laptopsSelector.Length == null || laptopsSelector.Length.Contains(l.Length))
                && (laptopsSelector.CPUFrequencies == null || laptopsSelector.CPUFrequencies.Contains(l.CPUFrequency))
                && (laptopsSelector.AmountOfRAMs == null || laptopsSelector.AmountOfRAMs.Contains(l.AmountOfRAM))
                && (goodsSelector.Producers == null || goodsSelector.Producers.Contains(l.Producer.Name))
                && (goodsSelector.Countries == null || goodsSelector.Countries.Contains(l.Manufacturer.Country.Value))
                && (goodsSelector.Materials == null || goodsSelector.Materials.Contains(l.MaterialValue))
                && (goodsSelector.Colors == null || goodsSelector.Colors.Contains(l.ColorValue))));
        }
        public IQueryable<T> GetFloppyDrivesCountLaptops<T>(
            IQueryable<T> laptops,
            LaptopsSelector laptopsSelector) where T : Laptop
        {
            var goodsSelector = laptopsSelector.ComputerTechnologiesSelector.GoodsSelector;
            return laptops
                .Where(l => (laptopsSelector.FloppyDrivesCount != null && laptopsSelector.FloppyDrivesCount.Contains(l.FloppyDrivesCount)) ||
                ((goodsSelector.PriceFrom == null || l.Price >= goodsSelector.PriceFrom)
                && (goodsSelector.PriceTo == null || l.Price <= goodsSelector.PriceTo)
                && (laptopsSelector.HaveFloppyDrives == null || laptopsSelector.HaveFloppyDrives.Contains(l.HaveFloppyDrives))
                && (laptopsSelector.Displays == null || laptopsSelector.Displays.Contains(l.Display))
                && (laptopsSelector.NumberOfCores == null || laptopsSelector.NumberOfCores.Contains(l.NumberOfCores))
                && (laptopsSelector.HardDiskMemory == null || laptopsSelector.HardDiskMemory.Contains(l.HardDiskMemory))
                && (laptopsSelector.ComputerDriveTypes == null ||
                laptopsSelector.ComputerDriveTypes.Any(c => l.LaptopComputerDriveTypes.Select(el => el.ComputerDriveTypeValue).Contains(c)))
                && (laptopsSelector.CPUSocketTypes == null || laptopsSelector.CPUSocketTypes.Contains(l.CPUSocketTypeValue))
                && (laptopsSelector.SSDMemory == null || laptopsSelector.SSDMemory.Contains(l.SSDMemory))
                && (laptopsSelector.Width == null || laptopsSelector.Width.Contains(l.Width))
                && (laptopsSelector.Height == null || laptopsSelector.Height.Contains(l.Height))
                && (laptopsSelector.Length == null || laptopsSelector.Length.Contains(l.Length))
                && (laptopsSelector.CPUFrequencies == null || laptopsSelector.CPUFrequencies.Contains(l.CPUFrequency))
                && (laptopsSelector.AmountOfRAMs == null || laptopsSelector.AmountOfRAMs.Contains(l.AmountOfRAM))
                && (goodsSelector.Producers == null || goodsSelector.Producers.Contains(l.Producer.Name))
                && (goodsSelector.Countries == null || goodsSelector.Countries.Contains(l.Manufacturer.Country.Value))
                && (goodsSelector.Materials == null || goodsSelector.Materials.Contains(l.MaterialValue))
                && (goodsSelector.Colors == null || goodsSelector.Colors.Contains(l.ColorValue))));
        }
        public IQueryable<T> GetDisplayLaptops<T>(
            IQueryable<T> laptops,
            LaptopsSelector laptopsSelector) where T : Laptop
        {
            var goodsSelector = laptopsSelector.ComputerTechnologiesSelector.GoodsSelector;
            return laptops
                .Where(l => (laptopsSelector.Displays != null && laptopsSelector.Displays.Contains(l.Display)) ||
                ((goodsSelector.PriceFrom == null || l.Price >= goodsSelector.PriceFrom)
                && (goodsSelector.PriceTo == null || l.Price <= goodsSelector.PriceTo)
                && (laptopsSelector.HaveFloppyDrives == null || laptopsSelector.HaveFloppyDrives.Contains(l.HaveFloppyDrives))
                && (laptopsSelector.FloppyDrivesCount == null || laptopsSelector.FloppyDrivesCount.Contains(l.FloppyDrivesCount))
                && (laptopsSelector.NumberOfCores == null || laptopsSelector.NumberOfCores.Contains(l.NumberOfCores))
                && (laptopsSelector.HardDiskMemory == null || laptopsSelector.HardDiskMemory.Contains(l.HardDiskMemory))
                && (laptopsSelector.ComputerDriveTypes == null ||
                laptopsSelector.ComputerDriveTypes.Any(c => l.LaptopComputerDriveTypes.Select(el => el.ComputerDriveTypeValue).Contains(c)))
                && (laptopsSelector.CPUSocketTypes == null || laptopsSelector.CPUSocketTypes.Contains(l.CPUSocketTypeValue))
                && (laptopsSelector.SSDMemory == null || laptopsSelector.SSDMemory.Contains(l.SSDMemory))
                && (laptopsSelector.Width == null || laptopsSelector.Width.Contains(l.Width))
                && (laptopsSelector.Height == null || laptopsSelector.Height.Contains(l.Height))
                && (laptopsSelector.Length == null || laptopsSelector.Length.Contains(l.Length))
                && (laptopsSelector.CPUFrequencies == null || laptopsSelector.CPUFrequencies.Contains(l.CPUFrequency))
                && (laptopsSelector.AmountOfRAMs == null || laptopsSelector.AmountOfRAMs.Contains(l.AmountOfRAM))
                && (goodsSelector.Producers == null || goodsSelector.Producers.Contains(l.Producer.Name))
                && (goodsSelector.Countries == null || goodsSelector.Countries.Contains(l.Manufacturer.Country.Value))
                && (goodsSelector.Materials == null || goodsSelector.Materials.Contains(l.MaterialValue))
                && (goodsSelector.Colors == null || goodsSelector.Colors.Contains(l.ColorValue))));
        }
        public IQueryable<T> GetHaveFloppyDrivesLaptops<T>(
            IQueryable<T> laptops,
            LaptopsSelector laptopsSelector) where T : Laptop
        {
            var goodsSelector = laptopsSelector.ComputerTechnologiesSelector.GoodsSelector;
            return laptops
                .Where(l => (laptopsSelector.HaveFloppyDrives != null && laptopsSelector.HaveFloppyDrives.Contains(l.HaveFloppyDrives)) ||
                ((goodsSelector.PriceFrom == null || l.Price >= goodsSelector.PriceFrom)
                && (goodsSelector.PriceTo == null || l.Price <= goodsSelector.PriceTo)
                && (laptopsSelector.FloppyDrivesCount == null || laptopsSelector.FloppyDrivesCount.Contains(l.FloppyDrivesCount))
                && (laptopsSelector.Displays == null || laptopsSelector.Displays.Contains(l.Display))
                && (laptopsSelector.NumberOfCores == null || laptopsSelector.NumberOfCores.Contains(l.NumberOfCores))
                && (laptopsSelector.HardDiskMemory == null || laptopsSelector.HardDiskMemory.Contains(l.HardDiskMemory))
                && (laptopsSelector.ComputerDriveTypes == null ||
                laptopsSelector.ComputerDriveTypes.Any(c => l.LaptopComputerDriveTypes.Select(el => el.ComputerDriveTypeValue).Contains(c)))
                && (laptopsSelector.CPUSocketTypes == null || laptopsSelector.CPUSocketTypes.Contains(l.CPUSocketTypeValue))
                && (laptopsSelector.SSDMemory == null || laptopsSelector.SSDMemory.Contains(l.SSDMemory))
                && (laptopsSelector.Width == null || laptopsSelector.Width.Contains(l.Width))
                && (laptopsSelector.Height == null || laptopsSelector.Height.Contains(l.Height))
                && (laptopsSelector.Length == null || laptopsSelector.Length.Contains(l.Length))
                && (laptopsSelector.CPUFrequencies == null || laptopsSelector.CPUFrequencies.Contains(l.CPUFrequency))
                && (laptopsSelector.AmountOfRAMs == null || laptopsSelector.AmountOfRAMs.Contains(l.AmountOfRAM))
                && (goodsSelector.Producers == null || goodsSelector.Producers.Contains(l.Producer.Name))
                && (goodsSelector.Countries == null || goodsSelector.Countries.Contains(l.Manufacturer.Country.Value))
                && (goodsSelector.Materials == null || goodsSelector.Materials.Contains(l.MaterialValue))
                && (goodsSelector.Colors == null || goodsSelector.Colors.Contains(l.ColorValue))));
        }






        public IQueryable<QuestionBase<string>> GetProducerQuestion(IQueryable<Laptop> laptops, string[] producers)
        {
            return _computerTechnologiesQuestionsService.GetProducerQuestion(laptops, producers);
        }
        public IQueryable<QuestionBase<string>> GetCountryQuestion(IQueryable<Laptop> laptops, string[] countries)
        {
            return _computerTechnologiesQuestionsService.GetCountryQuestion(laptops, countries);
        }
        public IQueryable<QuestionBase<string>> GetMaterialQuestion(IQueryable<Laptop> laptops, string[] materials)
        {
            return _computerTechnologiesQuestionsService.GetMaterialQuestion(laptops, materials);
        }
        public IQueryable<QuestionBase<string>> GetColorQuestion(IQueryable<Laptop> laptops, string[] colors)
        {
            return _computerTechnologiesQuestionsService.GetColorQuestion(laptops, colors);
        }
        public IQueryable<QuestionBase<string>> GetPriceQuestion(IQueryable<Laptop> laptops)
        {
            return _computerTechnologiesQuestionsService.GetPriceQuestion(laptops);
        }

        public IQueryable<QuestionBase<string>> GetAmountOfRAMQuestion(IQueryable<Laptop> laptops, int[] amountOfRAMs)
        {
            var stringList = amountOfRAMs?.Select(item => item.ToString()).ToList();
            return laptops
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
        public IQueryable<QuestionBase<string>> GetCPUFrequencyQuestion(IQueryable<Laptop> laptops, int[] CPUFrequencies)
        {
            var stringList = CPUFrequencies?.Select(item => item.ToString()).ToList();
            return laptops
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
        public IQueryable<QuestionBase<string>> GetHeightQuestion(IQueryable<Laptop> laptops, float[] height)
        {
            var stringList = height?.Select(item => item.ToString()).ToList();
            return laptops
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
        public IQueryable<QuestionBase<string>> GetWidthQuestion(IQueryable<Laptop> laptops, float[] width)
        {
            var stringList = width?.Select(item => item.ToString()).ToList();
            return laptops
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
        public IQueryable<QuestionBase<string>> GetLengthQuestion(IQueryable<Laptop> laptops, float[] length)
        {
            var stringList = length?.Select(item => item.ToString()).ToList();
            return laptops
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
        public IQueryable<QuestionBase<string>> GetHaveFloppyDrivesQuestion(IQueryable<Laptop> laptops, bool[] haveFloppyDrives)
        {
            var stringList = haveFloppyDrives?.Select(item => item.ToString()).ToList();
            return laptops
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
        public IQueryable<QuestionBase<string>> GetSSDMemoryQuestion(IQueryable<Laptop> laptops, int?[] SSDMemories)
        {
            var stringList = SSDMemories?.Select(item => item.Value.ToString()).ToList();
            return laptops
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
        public IQueryable<QuestionBase<string>> GetHardDiskMemoryQuestion(IQueryable<Laptop> laptops, int?[] hardDiskMemories)
        {
            var stringList = hardDiskMemories?.Select(item => item.ToString()).ToList();
            return laptops
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
        public IQueryable<QuestionBase<string>> GetCPUSocketTypeQuestion(IQueryable<Laptop> laptops, string[] CPUSocketTypes)
        {
            return laptops
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
        public IQueryable<QuestionBase<string>> GetComputerDriveTypeQuestion(IQueryable<Laptop> laptops, string[] computerDriveTypes)
        {
            return laptops
                        .SelectMany(g => g.LaptopComputerDriveTypes.Select(l => l.ComputerDriveTypeValue))
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
        public IQueryable<QuestionBase<string>> GetNumberOfCoreQuestion(IQueryable<Laptop> laptops, int[] numberOfCores)
        {
            var stringList = numberOfCores?.Select(item => item.ToString()).ToList();
            return laptops
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
        public IQueryable<QuestionBase<string>> GetFloppyDrivesCountQuestion(IQueryable<Laptop> laptops, int?[] floppyDrivesCountArray)
        {
            var stringList = floppyDrivesCountArray?.Select(item => item.ToString()).ToList();
            return laptops
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
        public IQueryable<QuestionBase<string>> GetDisplayQuestion(IQueryable<Laptop> laptops, int[] displays)
        {
            var stringList = displays?.Select(item => item.ToString()).ToList();
            return laptops
                        .Select(g => g.Display)
                        .GroupBy(p => p)
                        .Select(p => new { Count = p.Count(), Value = Convert.ToString(p.Key) })
                        .Select(display => new QuestionBase<string>()
                        {
                            QuestionsKey = "display",
                            AfterBox = (stringList != null && stringList.Contains(display.Value)) ? (int?)null : display.Count,
                            Checked = stringList != null && stringList.Contains(display.Value),
                            ControlType = ControlType.Checkbox,
                            Key = display.Value,
                            Label = display.Value,
                            Required = false,
                            Type = InputType.Checkbox,
                        });
        }
    }
}
