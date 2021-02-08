using AutoMapper;
using SunnyFlamingo.Data;
using SunnyFlamingo.Models;
using SunnyFlamingo.Models.Selectors;
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
        private readonly IComputerDrivesSearcher _computerDrivesSearcher;
        private readonly ICoolersSearcher _coolersSearcher;
        private readonly ICPUsSearcher _CPUsSearcher;
        private readonly IVideoCardsSearcher _videoCardsSearcher;
        private readonly IHeadphonesSearcher _headphonesSearcher;
        private readonly IKeyboardsSearcher _keyboardsSearcher;
        private readonly IMiceSearcher _miceSearcher;
        public AllGoodsSearcher(
            IGoodsSearcher goodsSearcher,
            IComputerTechnologiesSearchers computerTechnologiesSearcher,
            ILaptopsSearcher laptopsSearcher,
            IComputersSearcher computersSearcher,
            IFlashDrivesSearcher flashDrivesSearcher,
            IComputerPartsSearcher computerPartsSearcher,
            IComputerAccessoriesSearcher computerAccessoriesSearcher,
            IComputerDrivesSearcher computerDrivesSearcher,
            ICoolersSearcher coolersSearcher,
            ICPUsSearcher CPUsSearcher,
            IVideoCardsSearcher videoCardsSearcher,
            IHeadphonesSearcher headphonesSearcher,
            IKeyboardsSearcher keyboardsSearcher,
            IMiceSearcher miceSearcher)
        {
            _goodsSearcher = goodsSearcher;
            _computerTechnologiesSearcher = computerTechnologiesSearcher;
            _laptopsSearcher = laptopsSearcher;
            _computersSearcher = computersSearcher;
            _flashDrivesSearcher = flashDrivesSearcher;
            _computerPartsSearcher = computerPartsSearcher;
            _computerAccessoriesSearcher = computerAccessoriesSearcher;
            _computerDrivesSearcher = computerDrivesSearcher;
            _coolersSearcher = coolersSearcher;
            _CPUsSearcher = CPUsSearcher;
            _videoCardsSearcher = videoCardsSearcher;
            _headphonesSearcher = headphonesSearcher;
            _keyboardsSearcher = keyboardsSearcher;
            _miceSearcher = miceSearcher;
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
            return await _goodsSearcher.SearchGoods(CreateGoodsSelector(
            producer,
            country,
            material,
            color,
            priceFrom,
            priceTo,
            from,
            to,
            getQuestions));
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
            return await _computerTechnologiesSearcher.SearchComputerTechnologies(CreateComputerTechnologiesSelector(
            producer,
            country,
            material,
            color,
            priceFrom,
            priceTo,
            from,
            to,
            getQuestions));
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
                CreateLaptopsSelector(
            producer,
            country,
            material,
            color,
            amountOfRAM,
            CPUFrequency,
            length,
            height,
            width,
            haveFloppyDrives,
            SSDMemory,
            hardDiskMemory,
            CPUSocketType,
            computerDriveType,
            numberOfCores,
            floppyDrivesCount,
            display,
            priceFrom,
            priceTo,
            from,
            to,
            getQuestions));
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
                CreateComputersSelector(
            producer,
            country,
            material,
            color,
            amountOfRAM,
            CPUFrequency,
            length,
            height,
            width,
            haveFloppyDrives,
            SSDMemory,
            hardDiskMemory,
            CPUSocketType,
            computerDriveType,
            numberOfCores,
            floppyDrivesCount,
            priceFrom,
            priceTo,
            from,
            to,
            getQuestions));
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
                CreateFlashDrivesSelector(
            producer,
            country,
            material,
            color,
            capacity,
            USBSpecificationTypeValue,
            priceFrom,
            priceTo,
            from,
            to,
            getQuestions));
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
                CreateComputerPartsSelector(
            producer,
            country,
            material,
            color,
            priceFrom,
            priceTo,
            from,
            to,
            getQuestions));
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
                CreateComputerAccessoriesSelector(
            producer,
            country,
            material,
            color,
            priceFrom,
            priceTo,
            from,
            to,
            getQuestions));
        }
        public async Task<GoodsInformation<string>> SearchComputerDrives(
            string producer,
            string country,
            string material,
            string color,
            string capacity,
            string type,
            string formFactorType,
            decimal? priceFrom,
            decimal? priceTo,
            int from,
            int to,
            bool getQuestions)
        {
            return await _computerDrivesSearcher.SearchComputerDrives(
                CreateComputerDrivesSelector(
            producer,
            country,
            material,
            color,
            capacity,
            type,
            formFactorType,
            priceFrom,
            priceTo,
            from,
            to,
            getQuestions));
        }
        public async Task<GoodsInformation<string>> SearchCoolers(
            string producer,
            string country,
            string material,
            string color,
            string coolerType,
            string fanSizeType,
            decimal? priceFrom,
            decimal? priceTo,
            int from,
            int to,
            bool getQuestions)
        {
            return await _coolersSearcher.SearchCoolers(
                CreateCoolersSelector(
            producer,
            country,
            material,
            color,
            coolerType,
            fanSizeType,
            priceFrom,
            priceTo,
            from,
            to,
            getQuestions));
        }
        public async Task<GoodsInformation<string>> SearchCPUs(
            string producer,
            string country,
            string material,
            string color,
            string CPUSocketType,
            string thermalDesignPower,
            string numberOfCores,
            string numberOfThreads,
            decimal? priceFrom,
            decimal? priceTo,
            int from,
            int to,
            bool getQuestions)
        {
            return await _CPUsSearcher.SearchCPUs(
                CreateCPUsSelector(
            producer,
            country,
            material,
            color,
            CPUSocketType,
            thermalDesignPower,
            numberOfCores,
            numberOfThreads,
            priceFrom,
            priceTo,
            from,
            to,
            getQuestions));
        }
        public async Task<GoodsInformation<string>> SearchVideoCards(
            string producer,
            string country,
            string material,
            string color,
            string driveInterface,
            string videoSize,
            string videoMemoryCapacity,
            decimal? priceFrom,
            decimal? priceTo,
            int from,
            int to,
            bool getQuestions)
        {
            return await _videoCardsSearcher.SearchVideoCards(
                CreateVideoCardsSelector(
            producer,
            country,
            material,
            color,
            driveInterface,
            videoSize,
            videoMemoryCapacity,
            priceFrom,
            priceTo,
            from,
            to,
            getQuestions));
        }

        public async Task<GoodsInformation<string>> SearchMice(
            string producer,
            string country,
            string material,
            string color,
            string mauseType,
            string buttonsCount,
            decimal? priceFrom,
            decimal? priceTo,
            int from,
            int to,
            bool getQuestions)
        {
            return await _miceSearcher.SearchMice(
                CreateMiceSelector(
            producer,
            country,
            material,
            color,
            mauseType,
            buttonsCount,
            priceFrom,
            priceTo,
            from,
            to,
            getQuestions));
        }
        public async Task<GoodsInformation<string>> SearchKeyboards(
            string producer,
            string country,
            string material,
            string color,
            string keyboardType,
            decimal? priceFrom,
            decimal? priceTo,
            int from,
            int to,
            bool getQuestions)
        {
            return await _keyboardsSearcher.SearchKeyboards(
                CreateKeyboardsSelector(
            producer,
            country,
            material,
            color,
            keyboardType,
            priceFrom,
            priceTo,
            from,
            to,
            getQuestions));
        }
        public async Task<GoodsInformation<string>> SearchHeadphones(
            string producer,
            string country,
            string material,
            string color,
            string headphonesType,
            string wirelessType,
            string connectorType,
            decimal? priceFrom,
            decimal? priceTo,
            int from,
            int to,
            bool getQuestions)
        {
            return await _headphonesSearcher.SearchHeadphones(
                CreateHeadphonesSelector(
            producer,
            country,
            material,
            color,
            headphonesType,
            wirelessType,
            connectorType,
            priceFrom,
            priceTo,
            from,
            to,
            getQuestions));
        }







        private MiceSelector CreateMiceSelector(
            string producer,
            string country,
            string material,
            string color,
            string mauseType,
            string buttonsCount,
            decimal? priceFrom,
            decimal? priceTo,
            int from,
            int to,
            bool getQuestions)
        {
            return new MiceSelector()
            {
                ComputerAccessoriesSelector = new ComputerAccessoriesSelector()
                {
                    ComputerTechnologiesSelector = new ComputerTechnologiesSelector()
                    {
                        GoodsSelector = new GoodsSelector()
                        {
                            Producers = CreateStringArray(producer),
                            Countries = CreateStringArray(country),
                            Materials = CreateStringArray(material),
                            Colors = CreateStringArray(color),
                            PriceFrom = priceFrom,
                            PriceTo = priceTo,
                            From = from,
                            To = to,
                            GetQuestions = getQuestions
                        }
                    }
                },
                Types = CreateStringArray(mauseType),
                ButtonsCount = CreateIntArray(buttonsCount)
            };
        }
        private KeyboardsSelector CreateKeyboardsSelector(
            string producer,
            string country,
            string material,
            string color,
            string keyboardType,
            decimal? priceFrom,
            decimal? priceTo,
            int from,
            int to,
            bool getQuestions)
        {
            return new KeyboardsSelector()
            {
                ComputerAccessoriesSelector = new ComputerAccessoriesSelector()
                {
                    ComputerTechnologiesSelector = new ComputerTechnologiesSelector()
                    {
                        GoodsSelector = new GoodsSelector()
                        {
                            Producers = CreateStringArray(producer),
                            Countries = CreateStringArray(country),
                            Materials = CreateStringArray(material),
                            Colors = CreateStringArray(color),
                            PriceFrom = priceFrom,
                            PriceTo = priceTo,
                            From = from,
                            To = to,
                            GetQuestions = getQuestions
                        }
                    }
                },
                Types = CreateStringArray(keyboardType)
            };
        }
        private HeadphonesSelector CreateHeadphonesSelector(
            string producer,
            string country,
            string material,
            string color,
            string headphonesType,
            string wirelessType,
            string connectorType,
            decimal? priceFrom,
            decimal? priceTo,
            int from,
            int to,
            bool getQuestions)
        {
            return new HeadphonesSelector()
            {
                ComputerAccessoriesSelector = new ComputerAccessoriesSelector()
                {
                    ComputerTechnologiesSelector = new ComputerTechnologiesSelector()
                    {
                        GoodsSelector = new GoodsSelector()
                        {
                            Producers = CreateStringArray(producer),
                            Countries = CreateStringArray(country),
                            Materials = CreateStringArray(material),
                            Colors = CreateStringArray(color),
                            PriceFrom = priceFrom,
                            PriceTo = priceTo,
                            From = from,
                            To = to,
                            GetQuestions = getQuestions
                        }
                    }
                },
                Types = CreateStringArray(headphonesType),
                WirelessTypes = CreateStringArray(wirelessType),
                ConnectorTypes = CreateStringArray(connectorType)
            };
        }
        private CPUsSelector CreateCPUsSelector(
            string producer,
            string country,
            string material,
            string color,
            string CPUSocketType,
            string thermalDesignPower,
            string numberOfCores,
            string numberOfThreads,
            decimal? priceFrom,
            decimal? priceTo,
            int from,
            int to,
            bool getQuestions)
        {
            return new CPUsSelector()
            {
                ComputerPartsSelector = new ComputerPartsSelector()
                {
                    ComputerTechnologiesSelector = new ComputerTechnologiesSelector()
                    {
                        GoodsSelector = new GoodsSelector()
                        {
                            Producers = CreateStringArray(producer),
                            Countries = CreateStringArray(country),
                            Materials = CreateStringArray(material),
                            Colors = CreateStringArray(color),
                            PriceFrom = priceFrom,
                            PriceTo = priceTo,
                            From = from,
                            To = to,
                            GetQuestions = getQuestions
                        }
                    }
                },
                CPUSocketTypes = CreateStringArray(CPUSocketType),
                ThermalDesignPowers = CreateIntArray(thermalDesignPower),
                NumberOfCores = CreateIntArray(numberOfCores),
                NumberOfThreads = CreateIntArray(numberOfThreads)
            };
        }
        private VideoCardsSelector CreateVideoCardsSelector(
            string producer,
            string country,
            string material,
            string color,
            string driveInterface,
            string videoSize,
            string videoMemoryCapacity,
            decimal? priceFrom,
            decimal? priceTo,
            int from,
            int to,
            bool getQuestions)
        {
            return new VideoCardsSelector()
            {
                ComputerPartsSelector = new ComputerPartsSelector()
                {
                    ComputerTechnologiesSelector = new ComputerTechnologiesSelector()
                    {
                        GoodsSelector = new GoodsSelector()
                        {
                            Producers = CreateStringArray(producer),
                            Countries = CreateStringArray(country),
                            Materials = CreateStringArray(material),
                            Colors = CreateStringArray(color),
                            PriceFrom = priceFrom,
                            PriceTo = priceTo,
                            From = from,
                            To = to,
                            GetQuestions = getQuestions
                        }
                    }
                },
                DriveInterfaces = CreateStringArray(driveInterface),
                VideoSizes = CreateIntArray(videoSize),
                VideoMemoryCapacities = CreateIntArray(videoMemoryCapacity)
            };
        }
        private CoolersSelector CreateCoolersSelector(
            string producer,
            string country,
            string material,
            string color,
            string coolerType,
            string fanSizeType,
            decimal? priceFrom,
            decimal? priceTo,
            int from,
            int to,
            bool getQuestions)
        {
            return new CoolersSelector()
            {
                ComputerPartsSelector = new ComputerPartsSelector()
                {
                    ComputerTechnologiesSelector = new ComputerTechnologiesSelector()
                    {
                        GoodsSelector = new GoodsSelector()
                        {
                            Producers = CreateStringArray(producer),
                            Countries = CreateStringArray(country),
                            Materials = CreateStringArray(material),
                            Colors = CreateStringArray(color),
                            PriceFrom = priceFrom,
                            PriceTo = priceTo,
                            From = from,
                            To = to,
                            GetQuestions = getQuestions
                        }
                    }
                },
                Types = CreateStringArray(coolerType),
                FanSizes = CreateIntArray(fanSizeType)
            };
        }

        private ComputerDrivesSelector CreateComputerDrivesSelector(
            string producer,
            string country,
            string material,
            string color,
            string capacity,
            string type,
            string formFactorType,
            decimal? priceFrom,
            decimal? priceTo,
            int from,
            int to,
            bool getQuestions)
        {
            return new ComputerDrivesSelector()
            {
                ComputerPartsSelector = new ComputerPartsSelector()
                {
                    ComputerTechnologiesSelector = new ComputerTechnologiesSelector()
                    {
                        GoodsSelector = new GoodsSelector()
                        {
                            Producers = CreateStringArray(producer),
                            Countries = CreateStringArray(country),
                            Materials = CreateStringArray(material),
                            Colors = CreateStringArray(color),
                            PriceFrom = priceFrom,
                            PriceTo = priceTo,
                            From = from,
                            To = to,
                            GetQuestions = getQuestions
                        }
                    }
                },
                Capacities = CreateIntArray(capacity),
                Types = CreateStringArray(type),
                FormFactorTypes = CreateStringArray(formFactorType)
            };
        }
        private GoodsSelector CreateGoodsSelector(
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
            return new GoodsSelector() 
            {
                Producers = CreateStringArray(producer),
                Countries = CreateStringArray(country),
                Materials = CreateStringArray(material),
                Colors = CreateStringArray(color),
                PriceFrom = priceFrom,
                PriceTo = priceTo,
                From = from,
                To = to,
                GetQuestions = getQuestions
            };
        }
        private ComputerTechnologiesSelector CreateComputerTechnologiesSelector(
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
            return new ComputerTechnologiesSelector()
            {
                GoodsSelector = new GoodsSelector()
                {
                    Producers = CreateStringArray(producer),
                    Countries = CreateStringArray(country),
                    Materials = CreateStringArray(material),
                    Colors = CreateStringArray(color),
                    PriceFrom = priceFrom,
                    PriceTo = priceTo,
                    From = from,
                    To = to,
                    GetQuestions = getQuestions
                }
            };
        }
        private ComputerPartsSelector CreateComputerPartsSelector(
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
            return new ComputerPartsSelector()
            {
                ComputerTechnologiesSelector = new ComputerTechnologiesSelector()
                {
                    GoodsSelector = new GoodsSelector()
                    {
                        Producers = CreateStringArray(producer),
                        Countries = CreateStringArray(country),
                        Materials = CreateStringArray(material),
                        Colors = CreateStringArray(color),
                        PriceFrom = priceFrom,
                        PriceTo = priceTo,
                        From = from,
                        To = to,
                        GetQuestions = getQuestions
                    }
                }
            };
        }
        private ComputerAccessoriesSelector CreateComputerAccessoriesSelector(
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
            return new ComputerAccessoriesSelector()
            {
                ComputerTechnologiesSelector = new ComputerTechnologiesSelector()
                {
                    GoodsSelector = new GoodsSelector()
                    {
                        Producers = CreateStringArray(producer),
                        Countries = CreateStringArray(country),
                        Materials = CreateStringArray(material),
                        Colors = CreateStringArray(color),
                        PriceFrom = priceFrom,
                        PriceTo = priceTo,
                        From = from,
                        To = to,
                        GetQuestions = getQuestions
                    }
                }
            };
        }


        private FlashDrivesSelector CreateFlashDrivesSelector(
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
            return
                new FlashDrivesSelector()
                {
                    ComputerTechnologiesSelector = new ComputerTechnologiesSelector()
                    {
                        GoodsSelector = new GoodsSelector()
                        {
                            Producers = CreateStringArray(producer),
                            Countries = CreateStringArray(country),
                            Materials = CreateStringArray(material),
                            Colors = CreateStringArray(color),
                            PriceFrom = priceFrom,
                            PriceTo = priceTo,
                            From = from,
                            To = to,
                            GetQuestions = getQuestions
                        }
                    },
                    Capacities = CreateIntArray(capacity),
                    USBSpecificationTypes = CreateStringArray(USBSpecificationTypeValue),
                };
        }
        private ComputersSelector CreateComputersSelector(
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
            return
                new ComputersSelector()
                {
                    ComputerTechnologiesSelector = new ComputerTechnologiesSelector()
                    {
                        GoodsSelector = new GoodsSelector()
                        {
                            Producers = CreateStringArray(producer),
                            Countries = CreateStringArray(country),
                            Materials = CreateStringArray(material),
                            Colors = CreateStringArray(color),
                            PriceFrom = priceFrom,
                            PriceTo = priceTo,
                            From = from,
                            To = to,
                            GetQuestions = getQuestions
                        }
                    },
                    AmountOfRAMs = CreateIntArray(amountOfRAM),
                    CPUFrequencies = CreateIntArray(CPUFrequency),
                    Length = CreateFloatArray(length),
                    Height = CreateFloatArray(height),
                    Width = CreateFloatArray(width),
                    HaveFloppyDrives = CreateBoolArray(haveFloppyDrives),
                    SSDMemory = CreateNullableIntArray(SSDMemory),
                    HardDiskMemory = CreateNullableIntArray(hardDiskMemory),
                    CPUSocketTypes = CreateStringArray(CPUSocketType),
                    ComputerDriveTypes = CreateStringArray(computerDriveType),
                    NumberOfCores = CreateIntArray(numberOfCores),
                    FloppyDrivesCount = CreateNullableIntArray(floppyDrivesCount),
                };
        }
        private LaptopsSelector CreateLaptopsSelector(
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
            return
                new LaptopsSelector()
                {
                    ComputerTechnologiesSelector = new ComputerTechnologiesSelector()
                    {
                        GoodsSelector = new GoodsSelector()
                        {
                            Producers = CreateStringArray(producer),
                            Countries = CreateStringArray(country),
                            Materials = CreateStringArray(material),
                            Colors = CreateStringArray(color),
                            PriceFrom = priceFrom,
                            PriceTo = priceTo,
                            From = from,
                            To = to,
                            GetQuestions = getQuestions
                        }
                    },
                    AmountOfRAMs = CreateIntArray(amountOfRAM),
                    CPUFrequencies = CreateIntArray(CPUFrequency),
                    Length = CreateFloatArray(length),
                    Height = CreateFloatArray(height),
                    Width = CreateFloatArray(width),
                    HaveFloppyDrives = CreateBoolArray(haveFloppyDrives),
                    SSDMemory = CreateNullableIntArray(SSDMemory),
                    HardDiskMemory = CreateNullableIntArray(hardDiskMemory),
                    CPUSocketTypes = CreateStringArray(CPUSocketType),
                    ComputerDriveTypes = CreateStringArray(computerDriveType),
                    NumberOfCores = CreateIntArray(numberOfCores),
                    FloppyDrivesCount = CreateNullableIntArray(floppyDrivesCount),
                    Displays = CreateIntArray(display),
                };
        }

        private bool[] CreateBoolArray(string value)
        {
            try
            {
                return value == null ? null : value.Split(',', StringSplitOptions.None)
                    .Select(el => el == "true" ? true : el == "false" ? false : throw new FormatException())
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
