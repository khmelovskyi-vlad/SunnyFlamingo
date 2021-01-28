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
        private readonly IGoodsQuestionsService _goodsQuestionsService;
        public LaptopsQuestionsService(IGoodsQuestionsService goodsQuestionsService)
        {
            _goodsQuestionsService = goodsQuestionsService;
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
            bool? haveFloppyDrives,
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
                    await GetAmountOfRAMQuestion(laptops, amountOfRAM),
                    await GetCPUFrequencyQuestion(laptops, CPUFrequency),
                    await GetLengthQuestion(laptops, length),
                    await GetHeightQuestion(laptops, height),
                    await GetWidthQuestion(laptops, width),
                    await GetHaveFloppyDrivesQuestion(laptops, haveFloppyDrives),
                    await GetSSDMemoryQuestion(laptops, SSDMemory),
                    await GetHardDiskMemoryQuestion(laptops, hardDiskMemory),
                    await GetCPUSocketTypeQuestion(laptops, CPUSocketType),
                    await GetComputerDriveTypeQuestion(laptops, computerDriveType),
                    await GetNumberOfCoreQuestion(laptops, numberOfCores),
                    await GetFloppyDrivesCountQuestion(laptops, floppyDrivesCount),
                    await GetDisplayQuestion(laptops, display)
                };
            result.AddRange(await _goodsQuestionsService.GetGoodsQuestions(laptops, producers, countries, materials, colors, priceFrom, priceTo));
            return result;
        }
        private async Task<QuestionsBase<string>> GetAmountOfRAMQuestion(IQueryable<Laptop> laptops, int[] amountOfRAMs)
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
        private async Task<QuestionsBase<string>> GetCPUFrequencyQuestion(IQueryable<Laptop> laptops, int[] CPUFrequencies)
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
        private async Task<QuestionsBase<string>> GetHeightQuestion(IQueryable<Laptop> laptops, float[] heights)
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
        private async Task<QuestionsBase<string>> GetWidthQuestion(IQueryable<Laptop> laptops, float[] widths)
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
        private async Task<QuestionsBase<string>> GetLengthQuestion(IQueryable<Laptop> laptops, float[] lengthes)
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
        private async Task<QuestionsBase<string>> GetHaveFloppyDrivesQuestion(IQueryable<Laptop> laptops, bool? haveFloppyDrives)
        {
            return new QuestionsBase<string>()
            {
                Key = "haveFloppyDrive",
                Value = "Have floppy drive",
                Order = 10,
                QuestionBaseList = await laptops
                        .Select(g => g.HaveFloppyDrives)
                        .GroupBy(p => p)
                        .Select(p => new { Count = p.Count(), Value = p.Key })
                        .Select(haveFloppyDrive => new QuestionBase<string>()
                        {
                            AfterBox = $"({haveFloppyDrive.Count})",
                            Checked = haveFloppyDrives != null && haveFloppyDrives == true,
                            ControlType = ControlType.Checkbox,
                            Key = haveFloppyDrive.Value.ToString(),
                            Label = haveFloppyDrive.Value.ToString(),
                            Required = false,
                            Type = InputType.Checkbox,
                        }).ToListAsync()
            };
        }
        private async Task<QuestionsBase<string>> GetSSDMemoryQuestion(IQueryable<Laptop> laptops, int?[] SSDMemories)
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
        private async Task<QuestionsBase<string>> GetHardDiskMemoryQuestion(IQueryable<Laptop> laptops, int?[] hardDiskMemories)
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
        private async Task<QuestionsBase<string>> GetCPUSocketTypeQuestion(IQueryable<Laptop> laptops, CPUSocketType[] CPUSocketTypes)
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
        private async Task<QuestionsBase<string>> GetComputerDriveTypeQuestion(IQueryable<Laptop> laptops, ComputerDriveType[] computerDriveTypes)
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
        private async Task<QuestionsBase<string>> GetNumberOfCoreQuestion(IQueryable<Laptop> laptops, int[] numberOfCores)
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
        private async Task<QuestionsBase<string>> GetFloppyDrivesCountQuestion(IQueryable<Laptop> laptops, int?[] floppyDrivesCountArray)
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
        private async Task<QuestionsBase<string>> GetDisplayQuestion(IQueryable<Laptop> laptops, int[] displays)
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
