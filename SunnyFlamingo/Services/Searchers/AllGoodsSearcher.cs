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
        private readonly IComputersSearcher _computersSearcher;
        private readonly IFlashDrivesSearcher _flashDrivesSearcher;
        private readonly IComputerPartsSearcher _computerPartsSearcher;
        private readonly IComputerAccessoriesSearcher _computerAccessoriesSearcher;
        public AllGoodsSearcher(
            IGoodsSearcher goodsSearcher,
            IComputerTechnologiesSearchers computerTechnologiesSearcher,
            ILaptopsSearcher laptopsSearcher,
            IComputersSearcher computersSearcher,
            IFlashDrivesSearcher flashDrivesSearcher,
            IComputerPartsSearcher computerPartsSearcher,
            IComputerAccessoriesSearcher computerAccessoriesSearcher)
        {
            _goodsSearcher = goodsSearcher;
            _computerTechnologiesSearcher = computerTechnologiesSearcher;
            _laptopsSearcher = laptopsSearcher;
            _computersSearcher = computersSearcher;
            _flashDrivesSearcher = flashDrivesSearcher;
            _computerPartsSearcher = computerPartsSearcher;
            _computerAccessoriesSearcher = computerAccessoriesSearcher;
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
            string haveFloppyDrives,
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
                CreateBoolArray(haveFloppyDrives),
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
        public async Task<GoodsInformation<string>> SearchComputers(
            string producer,
            string country,
            string material,
            string color,
            string amountOfRAM,
            string CPUFrequency,
            string length,
            string height,
            string width,
            string haveFloppyDrives,
            string SSDMemory,
            string hardDiskMemory,
            string CPUSocketType,
            string computerDriveType,
            string numberOfCores,
            string floppyDrivesCount,
            decimal? priceFrom,
            decimal? priceTo,
            int from,
            int to,
            bool getQuestions)
        {
            return await _computersSearcher.SearchComputers(
                CreateStringArray(producer),
                CreateStringArray(country),
                CreateStringArray(material),
                CreateStringArray(color),
                CreateIntArray(amountOfRAM),
                CreateIntArray(CPUFrequency),
                CreateFloatArray(length),
                CreateFloatArray(height),
                CreateFloatArray(width),
                CreateBoolArray(haveFloppyDrives),
                CreateNullableIntArray(SSDMemory),
                CreateNullableIntArray(hardDiskMemory),
                CreateCPUSocketTypeArray(CPUSocketType),
                CreateComputerDriveTypeArray(computerDriveType),
                CreateIntArray(numberOfCores),
                CreateNullableIntArray(floppyDrivesCount),

                priceFrom, priceTo,
                from, to, getQuestions);
        }
        public async Task<GoodsInformation<string>> SearchFlashDrives(
            string producer,
            string country,
            string material,
            string color,
            string capacity,
            string USBSpecificationTypeValue,
            decimal? priceFrom,
            decimal? priceTo,
            int from,
            int to,
            bool getQuestions)
        {
            return await _flashDrivesSearcher.SearchFlashDrives(
                CreateStringArray(producer),
                CreateStringArray(country),
                CreateStringArray(material),
                CreateStringArray(color),
                CreateIntArray(capacity),
                CreateStringArray(USBSpecificationTypeValue),
                priceFrom, priceTo,
                from, to, getQuestions);
        }
        public async Task<GoodsInformation<string>> SearchComputerParts(
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
            return await _computerPartsSearcher.SearchComputerParts(
                CreateStringArray(producer),
                CreateStringArray(country),
                CreateStringArray(material),
                CreateStringArray(color), priceFrom, priceTo, from, to, getQuestions);
        }
        public async Task<GoodsInformation<string>> SearchComputerAccessories(
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
            return await _computerAccessoriesSearcher.SearchComputerAccessories(
                CreateStringArray(producer),
                CreateStringArray(country),
                CreateStringArray(material),
                CreateStringArray(color), priceFrom, priceTo, from, to, getQuestions);
        }




        private bool[] CreateBoolArray(string value)
        {
            try
            {
                return value == null ? null : value.Split(',', StringSplitOptions.None)
                    .Select(el => el == "True" ? true : el == "False" ? false : throw new FormatException())
                    .ToArray();
            }
            catch (FormatException)
            {
                return null;
            }
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
