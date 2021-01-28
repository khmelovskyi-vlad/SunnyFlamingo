using AutoMapper;
using SunnyFlamingo.Data;
using SunnyFlamingo.Models;
using SunnyFlamingo.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Searchers
{
    public class AllGoodsSearcher : IAllGoodsSearcher
    {
        private readonly IGoodsSearcher _goodsSearcher;
        private readonly IComputerTechnologiesSearchers _computerTechnologiesSearcher;
        private readonly ILaptopsSearcher _laptopsSearcher;
        public AllGoodsSearcher(
            IGoodsSearcher goodsSearcher, 
            IComputerTechnologiesSearchers computerTechnologiesSearcher, 
            ILaptopsSearcher laptopsSearcher)
        {
            _goodsSearcher = goodsSearcher;
            _computerTechnologiesSearcher = computerTechnologiesSearcher;
            _laptopsSearcher = laptopsSearcher;
        }
        public async Task<GoodsInformation<string>> SearchGoods(
            string producer,
            string country,
            string material,
            string color,
            decimal? priceFrom,
            decimal? priceTo,
            int from,
            int to,
            bool getQuestions)
        {
            return await _goodsSearcher.SearchGoods(
                CreateStringArray(producer),
                CreateStringArray(country),
                CreateStringArray(material),
                CreateStringArray(color), priceFrom, priceTo, from, to, getQuestions);
        }
        public async Task<GoodsInformation<string>> SearchComputerTechnologies(
            string producer,
            string country,
            string material,
            string color,
            decimal? priceFrom,
            decimal? priceTo,
            int from,
            int to,
            bool getQuestions)
        {
            return await _computerTechnologiesSearcher.SearchComputerTechnologies(
                CreateStringArray(producer),
                CreateStringArray(country),
                CreateStringArray(material),
                CreateStringArray(color), priceFrom, priceTo, from, to, getQuestions);
        }
        public async Task<GoodsInformation<string>> SearchLaptops(
            string producer,
            string country,
            string material,
            string color,
            string amountOfRAM,
            string CPUFrequency,
            string length,
            string height,
            string width,
            bool? haveFloppyDrives,
            string SSDMemory,
            string hardDiskMemory,
            string CPUSocketType,
            string computerDriveType,
            string numberOfCores,
            string floppyDrivesCount,
            string display,
            decimal? priceFrom,
            decimal? priceTo,
            int from,
            int to,
            bool getQuestions)
        {
            return await _laptopsSearcher.SearchLaptops(
                CreateStringArray(producer),
                CreateStringArray(country),
                CreateStringArray(material),
                CreateStringArray(color),
                CreateIntArray(amountOfRAM),
                CreateIntArray(CPUFrequency),
                CreateFloatArray(length),
                CreateFloatArray(height),
                CreateFloatArray(width),
                haveFloppyDrives,
                CreateNullableIntArray(SSDMemory),
                CreateNullableIntArray(hardDiskMemory),
                CreateCPUSocketTypeArray(CPUSocketType),
                CreateComputerDriveTypeArray(computerDriveType),
                CreateIntArray(numberOfCores),
                CreateNullableIntArray(floppyDrivesCount),
                CreateIntArray(display),

                priceFrom, priceTo,
                from, to, getQuestions);
        }




        private ComputerDriveType[] CreateComputerDriveTypeArray(string value)
        {
            try
            {
                return value == null ? null : value.Split(',', StringSplitOptions.None)
                    .Select(el => (ComputerDriveType)Enum.Parse(typeof(ComputerDriveType), el, true))
                    .ToArray();
            }
            catch (FormatException)
            {
                return null;
            }
        }
        private CPUSocketType[] CreateCPUSocketTypeArray(string value)
        {
            try
            {
                return value == null ? null : value.Split(',', StringSplitOptions.None)
                    .Select(el => (CPUSocketType)Enum.Parse(typeof(CPUSocketType), el, true))
                    .ToArray();
            }
            catch (FormatException)
            {
                return null;
            }
        }
        private string[] CreateStringArray(string value)
        {
            return value == null ? null : value.Split(',', StringSplitOptions.None);
        }
        private int[] CreateIntArray(string value)
        {
            try
            {
                return value == null ? null : value.Split(',', StringSplitOptions.None).Select(el => Convert.ToInt32(el)).ToArray();
            }
            catch (FormatException)
            {
                return null;
            }
        }
        private float[] CreateFloatArray(string value)
        {
            try
            {
                return value == null ? null : value.Split(',', StringSplitOptions.None).Select(el => (float)Convert.ToDouble(el)).ToArray();
            }
            catch (FormatException)
            {
                return null;
            }
        }
        private int?[] CreateNullableIntArray(string value)
        {
            return value == null ? null : value.Split(',', StringSplitOptions.None).Select(el => ParseToNullableInt(el)).ToArray();
        }
        private int? ParseToNullableInt(string value)
        {
            int result;
            if (int.TryParse(value, out result))
            {
                return result;
            }
            return null;
        }
    }
}
