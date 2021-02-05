using SunnyFlamingo.Models;
using SunnyFlamingo.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Searchers
{
    public interface IComputersSearcher
    {
        Task<GoodsInformation<string>> SearchComputers(
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
               decimal? priceTo,
               int from,
               int to,
               bool getQuestions
               );
    }
}
