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
    public class FlashDrivesQuestionsService : IFlashDrivesQuestionsService
    {
        private readonly IComputerTechnologiesQuestionsService _computerTechnologiesQuestionsService;
        public FlashDrivesQuestionsService(IComputerTechnologiesQuestionsService computerTechnologiesQuestionsService)
        {
            _computerTechnologiesQuestionsService = computerTechnologiesQuestionsService;
        }
        public async Task<List<QuestionsBase<string>>> GetFlashDrivesQuestions(
            IQueryable<FlashDrive> flashDrives,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            int[] capacities,
            string[] USBSpecificationTypes,
            decimal? priceFrom,
            decimal? priceTo)
        {
            return new List<QuestionsBase<string>>()
                {
                    await GetProducerQuestion(GetProducerFlashDrives(flashDrives, producers, countries, materials, colors,
                    capacities, USBSpecificationTypes, priceFrom, priceTo), producers),
                    await GetCountryQuestion(GetCountryFlashDrives(flashDrives, producers, countries, materials, colors,
                    capacities, USBSpecificationTypes, priceFrom, priceTo), countries),
                    await GetMaterialQuestion(GetMaterialFlashDrives(flashDrives, producers, countries, materials, colors,
                    capacities, USBSpecificationTypes, priceFrom, priceTo), materials),
                    await GetColorQuestion(GetColorFlashDrives(flashDrives, producers, countries, materials, colors,
                    capacities, USBSpecificationTypes, priceFrom, priceTo), colors),
                    await GetPriceQuestion(GetPriceFlashDrives(flashDrives, producers, countries, materials, colors,
                    capacities, USBSpecificationTypes, priceFrom, priceTo), priceFrom, priceTo),

                    await GetCapacityQuestion(GetCapacityFlashDrives(flashDrives, producers, countries, materials, colors,
                    capacities, USBSpecificationTypes, priceFrom, priceTo), capacities),
                    await GetUSBSpecificationTypeQuestion(GetUSBSpecificationTypeFlashDrives(flashDrives, producers, countries, materials, colors,
                    capacities, USBSpecificationTypes, priceFrom, priceTo), USBSpecificationTypes),
                };
        }

        public IQueryable<T> GetProducerFlashDrives<T>(
            IQueryable<T> flashDrives,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            int[] capacities,
            string[] USBSpecificationTypes,
            decimal? priceFrom,
            decimal? priceTo) where T : FlashDrive
        {
            return _computerTechnologiesQuestionsService.GetProducerComputerTechnologies(
                flashDrives, producers, countries, materials, colors, priceFrom, priceTo)
                .Where(l => (producers != null && producers.Contains(l.Producer.Name)) ||
                ((capacities == null || capacities.Contains(l.Capacity))
                && (USBSpecificationTypes == null || USBSpecificationTypes.Contains(l.USBSpecificationTypeValue))
                && (countries == null || countries.Contains(l.Manufacturer.Country.Value))
                && (materials == null || materials.Contains(l.MaterialValue))
                && (colors == null || colors.Contains(l.ColorValue))));
        }
        public IQueryable<T> GetCountryFlashDrives<T>(
            IQueryable<T> flashDrives,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            int[] capacities,
            string[] USBSpecificationTypes,
            decimal? priceFrom,
            decimal? priceTo) where T : FlashDrive
        {
            return _computerTechnologiesQuestionsService.GetCountryComputerTechnologies(
                flashDrives, producers, countries, materials, colors, priceFrom, priceTo)
                .Where(l => (countries != null && countries.Contains(l.Manufacturer.Country.Value)) ||
                ((capacities == null || capacities.Contains(l.Capacity))
                && (USBSpecificationTypes == null || USBSpecificationTypes.Contains(l.USBSpecificationTypeValue))
                && (producers == null || producers.Contains(l.Producer.Name))
                && (materials == null || materials.Contains(l.MaterialValue))
                && (colors == null || colors.Contains(l.ColorValue))));
        }
        public IQueryable<T> GetMaterialFlashDrives<T>(
            IQueryable<T> flashDrives,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            int[] capacities,
            string[] USBSpecificationTypes,
            decimal? priceFrom,
            decimal? priceTo) where T : FlashDrive
        {
            return _computerTechnologiesQuestionsService.GetMaterialComputerTechnologies(
                flashDrives, producers, countries, materials, colors, priceFrom, priceTo)
                .Where(l => (materials != null && materials.Contains(l.MaterialValue)) ||
                ((capacities == null || capacities.Contains(l.Capacity))
                && (USBSpecificationTypes == null || USBSpecificationTypes.Contains(l.USBSpecificationTypeValue))
                && (producers == null || producers.Contains(l.Producer.Name))
                && (countries == null || countries.Contains(l.Manufacturer.Country.Value))
                && (colors == null || colors.Contains(l.ColorValue))));
        }
        public IQueryable<T> GetColorFlashDrives<T>(
            IQueryable<T> flashDrives,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            int[] capacities,
            string[] USBSpecificationTypes,
            decimal? priceFrom,
            decimal? priceTo) where T : FlashDrive
        {
            return _computerTechnologiesQuestionsService.GetColorComputerTechnologies(
                flashDrives, producers, countries, materials, colors, priceFrom, priceTo)
                .Where(l => (colors != null && colors.Contains(l.ColorValue)) ||
                ((capacities == null || capacities.Contains(l.Capacity))
                && (USBSpecificationTypes == null || USBSpecificationTypes.Contains(l.USBSpecificationTypeValue))
                && (producers == null || producers.Contains(l.Producer.Name))
                && (countries == null || countries.Contains(l.Manufacturer.Country.Value))
                && (materials == null || materials.Contains(l.MaterialValue))));
        }
        public IQueryable<T> GetPriceFlashDrives<T>(
            IQueryable<T> flashDrives,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            int[] capacities,
            string[] USBSpecificationTypes,
            decimal? priceFrom,
            decimal? priceTo) where T : FlashDrive
        {
            return _computerTechnologiesQuestionsService.GetPriceComputerTechnologies(
                flashDrives, producers, countries, materials, colors, priceFrom, priceTo)
                .Where(l => (capacities == null || capacities.Contains(l.Capacity))
                && (USBSpecificationTypes == null || USBSpecificationTypes.Contains(l.USBSpecificationTypeValue))
                && (producers == null || producers.Contains(l.Producer.Name))
                && (countries == null || countries.Contains(l.Manufacturer.Country.Value))
                && (materials == null || materials.Contains(l.MaterialValue))
                && (colors == null || colors.Contains(l.ColorValue)));
        }
        public IQueryable<T> GetCapacityFlashDrives<T>(
            IQueryable<T> flashDrives,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            int[] capacities,
            string[] USBSpecificationTypes,
            decimal? priceFrom,
            decimal? priceTo) where T : FlashDrive
        {
            if (producers == null && countries == null && materials == null && colors == null && capacities == null
                && USBSpecificationTypes == null && priceFrom == null && priceTo == null)
            {
                return flashDrives;
            }
            return flashDrives
                .Where(g => (capacities != null && capacities.Contains(g.Capacity)) ||
                ((priceFrom == null || g.Price >= priceFrom) && (priceTo == null || g.Price <= priceTo)
                && (USBSpecificationTypes == null || USBSpecificationTypes.Contains(g.USBSpecificationTypeValue))
                && (producers == null || producers.Contains(g.Producer.Name))
                && (countries == null || countries.Contains(g.Manufacturer.Country.Value))
                && (materials == null || materials.Contains(g.MaterialValue))
                && (colors == null || colors.Contains(g.ColorValue))));
        }
        public IQueryable<T> GetUSBSpecificationTypeFlashDrives<T>(
            IQueryable<T> flashDrives,
            string[] producers,
            string[] countries,
            string[] materials,
            string[] colors,
            int[] capacities,
            string[] USBSpecificationTypes,
            decimal? priceFrom,
            decimal? priceTo) where T : FlashDrive
        {
            if (producers == null && countries == null && materials == null && colors == null && capacities == null
                && USBSpecificationTypes == null && priceFrom == null && priceTo == null)
            {
                return flashDrives;
            }
            return flashDrives
                .Where(g => (USBSpecificationTypes != null && USBSpecificationTypes.Contains(g.USBSpecificationTypeValue)) ||
                ((priceFrom == null || g.Price >= priceFrom) && (priceTo == null || g.Price <= priceTo)
                && (capacities == null || capacities.Contains(g.Capacity))
                && (producers == null || producers.Contains(g.Producer.Name))
                && (countries == null || countries.Contains(g.Manufacturer.Country.Value))
                && (materials == null || materials.Contains(g.MaterialValue))
                && (colors == null || colors.Contains(g.ColorValue))));
        }






        public async Task<QuestionsBase<string>> GetProducerQuestion(IQueryable<FlashDrive> flashDrives, string[] producers)
        {
            return await _computerTechnologiesQuestionsService.GetProducerQuestion(flashDrives, producers);
        }
        public async Task<QuestionsBase<string>> GetCountryQuestion(IQueryable<FlashDrive> flashDrives, string[] countries)
        {
            return await _computerTechnologiesQuestionsService.GetCountryQuestion(flashDrives, countries);
        }
        public async Task<QuestionsBase<string>> GetMaterialQuestion(IQueryable<FlashDrive> flashDrives, string[] materials)
        {
            return await _computerTechnologiesQuestionsService.GetMaterialQuestion(flashDrives, materials);
        }
        public async Task<QuestionsBase<string>> GetColorQuestion(IQueryable<FlashDrive> flashDrives, string[] colors)
        {
            return await _computerTechnologiesQuestionsService.GetColorQuestion(flashDrives, colors);
        }
        public async Task<QuestionsBase<string>> GetPriceQuestion(IQueryable<FlashDrive> flashDrives, decimal? selectedFrom, decimal? selectedTo)
        {
            return await _computerTechnologiesQuestionsService.GetPriceQuestion(flashDrives, selectedFrom, selectedTo);
        }

        public async Task<QuestionsBase<string>> GetCapacityQuestion(IQueryable<FlashDrive> flashDrives, int[] capacities)
        {
            return new QuestionsBase<string>()
            {
                Key = "capacity",
                Value = "Select capacity",
                Order = 5,
                QuestionBaseList = await flashDrives
                        .Select(g => g.Capacity)
                        .GroupBy(p => p)
                        .Select(p => new { Count = p.Count(), Value = p.Key })
                        .Select(capacity => new QuestionBase<string>()
                        {
                            AfterBox = $"({capacity.Count})",
                            Checked = capacities != null && capacities.Contains(capacity.Value),
                            ControlType = ControlType.Checkbox,
                            Key = capacity.Value.ToString(),
                            Label = capacity.Value.ToString(),
                            Required = false,
                            Type = InputType.Checkbox,
                        }).ToListAsync()
            };
        }
        public async Task<QuestionsBase<string>> GetUSBSpecificationTypeQuestion(IQueryable<FlashDrive> flashDrives, string[] USBSpecificationTypes)
        {
            return new QuestionsBase<string>()
            {
                Key = "USBSpecificationType",
                Value = "Select USB specification type",
                Order = 6,
                QuestionBaseList = await flashDrives
                        .Select(g => g.USBSpecificationTypeValue)
                        .GroupBy(p => p)
                        .Select(p => new { Count = p.Count(), Value = p.Key })
                        .Select(USBSpecificationType => new QuestionBase<string>()
                        {
                            AfterBox = $"({USBSpecificationType.Count})",
                            Checked = USBSpecificationTypes != null && USBSpecificationTypes.Contains(USBSpecificationType.Value),
                            ControlType = ControlType.Checkbox,
                            Key = USBSpecificationType.Value,
                            Label = USBSpecificationType.Value,
                            Required = false,
                            Type = InputType.Checkbox,
                        }).ToListAsync()
            };
        }
    }
}
