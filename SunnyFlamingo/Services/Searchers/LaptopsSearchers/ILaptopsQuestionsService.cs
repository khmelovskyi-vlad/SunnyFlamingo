using SunnyFlamingo.Entities.Goods.ComputerTechnologies;
using SunnyFlamingo.Models;
using SunnyFlamingo.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Searchers
{
    public interface ILaptopsQuestionsService
    {
        Task<List<QuestionsBase<string>>> GetLaptopsQuestions(
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
               decimal? priceTo);
    }
}
