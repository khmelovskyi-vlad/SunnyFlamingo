using SunnyFlamingo.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Searchers
{
    public class QuestionsGrouper : IQuestionsGrouper
    {
        public QuestionsBase<string> GroupProducers(List<QuestionBase<string>> questions)
        {
            return new QuestionsBase<string>()
            {
                Key = "producer",
                Value = "Select producer",
                Order = 1,
                QuestionBaseList = questions.Where(el => el.QuestionsKey == "producer").ToList()
            };
        }
        public QuestionsBase<string> GroupCountries(List<QuestionBase<string>> questions)
        {
            return new QuestionsBase<string>()
            {
                Key = "country",
                Value = "Select country",
                Order = 2,
                QuestionBaseList = questions.Where(el => el.QuestionsKey == "country").ToList()
            };
        }
        public QuestionsBase<string> GroupMaterials(List<QuestionBase<string>> questions)
        {
            return new QuestionsBase<string>()
            {
                Key = "material",
                Value = "Select material",
                Order = 3,
                QuestionBaseList = questions.Where(el => el.QuestionsKey == "material").ToList()
            };
        }
        public QuestionsBase<string> GroupColors(List<QuestionBase<string>> questions)
        {
            return new QuestionsBase<string>()
            {
                Key = "color",
                Value = "Select color",
                Order = 4,
                QuestionBaseList = questions.Where(el => el.QuestionsKey == "color").ToList()
            };
        }
        public QuestionsBase<string> GroupPrices(List<QuestionBase<string>> questions, decimal? priceFrom, decimal? priceTo)
        {
            return new QuestionsBase<string>()
            {
                Key = "price",
                Value = "Select price",
                Order = 5,
                QuestionBaseList = questions.Where(el => el.QuestionsKey == "price")
                .GroupBy(q => q.QuestionsKey)
                .Select(q => new QuestionBase<string>()
                {
                    ControlType = q.First().ControlType,
                    From = Convert.ToDecimal(q.First(el => el.Key == "minPrice").Label, new CultureInfo("en-US")),
                    To = Convert.ToDecimal(q.First(el => el.Key == "maxPrice").Label, new CultureInfo("en-US")),
                    SelectedFrom = priceFrom == null ? Convert.ToDecimal(q.First(el => el.Key == "minPrice").Label, new CultureInfo("en-US")) : priceFrom,
                    SelectedTo = priceTo == null ? Convert.ToDecimal(q.First(el => el.Key == "maxPrice").Label, new CultureInfo("en-US")) : priceTo,
                    Required = false,
                }).ToList()
            };
        }
        public QuestionsBase<string> GroupAmountOfRAMs(List<QuestionBase<string>> questions)
        {
            return new QuestionsBase<string>()
            {
                Key = "amountOfRAM",
                Value = "Select amount of RAM",
                Order = 10,
                QuestionBaseList = questions.Where(el => el.QuestionsKey == "amountOfRAM").ToList()
            };
        }
        public QuestionsBase<string> GroupCPUFrequencies(List<QuestionBase<string>> questions)
        {
            return new QuestionsBase<string>()
            {
                Key = "CPUFrequency",
                Value = "Select CPU frequency",
                Order = 11,
                QuestionBaseList = questions.Where(el => el.QuestionsKey == "CPUFrequency").ToList()
            };
        }
        public QuestionsBase<string> GroupHeight(List<QuestionBase<string>> questions)
        {
            return new QuestionsBase<string>()
            {
                Key = "height",
                Value = "Select height",
                Order = 12,
                QuestionBaseList = questions.Where(el => el.QuestionsKey == "height").ToList()
            };
        }
        public QuestionsBase<string> GroupWidth(List<QuestionBase<string>> questions)
        {
            return new QuestionsBase<string>()
            {
                Key = "width",
                Value = "Select width",
                Order = 13,
                QuestionBaseList = questions.Where(el => el.QuestionsKey == "width").ToList()
            };
        }
        public QuestionsBase<string> GroupLength(List<QuestionBase<string>> questions)
        {
            return new QuestionsBase<string>()
            {
                Key = "length",
                Value = "Select length",
                Order = 14,
                QuestionBaseList = questions.Where(el => el.QuestionsKey == "length").ToList()
            };
        }
        public QuestionsBase<string> GroupHaveFloppyDrives(List<QuestionBase<string>> questions)
        {
            return new QuestionsBase<string>()
            {
                Key = "haveFloppyDrives",
                Value = "Have floppy drive",
                Order = 15,
                QuestionBaseList = questions.Where(el => el.QuestionsKey == "haveFloppyDrives").ToList()
            };
        }
        public QuestionsBase<string> GroupSSDMemory(List<QuestionBase<string>> questions)
        {
            return new QuestionsBase<string>()
            {
                Key = "SSDMemory",
                Value = "Select SSD memory",
                Order = 16,
                QuestionBaseList = questions.Where(el => el.QuestionsKey == "SSDMemory").ToList()
            };
        }
        public QuestionsBase<string> GroupHardDiskMemory(List<QuestionBase<string>> questions)
        {
            return new QuestionsBase<string>()
            {
                Key = "hardDiskMemory",
                Value = "Select hard disk memory",
                Order = 17,
                QuestionBaseList = questions.Where(el => el.QuestionsKey == "hardDiskMemory").ToList()
            };
        }
        public QuestionsBase<string> GroupCPUSocketTypes(List<QuestionBase<string>> questions)
        {
            return new QuestionsBase<string>()
            {
                Key = "CPUSocketType",
                Value = "Select CPU socket type",
                Order = 18,
                QuestionBaseList = questions.Where(el => el.QuestionsKey == "CPUSocketType").ToList()
            };
        }
        public QuestionsBase<string> GroupComputerDriveTypes(List<QuestionBase<string>> questions)
        {
            return new QuestionsBase<string>()
            {
                Key = "computerDriveType",
                Value = "Select computer drive type",
                Order = 19,
                QuestionBaseList = questions.Where(el => el.QuestionsKey == "computerDriveType").ToList()
            };
        }
        public QuestionsBase<string> GroupNumberOfCores(List<QuestionBase<string>> questions)
        {
            return new QuestionsBase<string>()
            {
                Key = "numberOfCores",
                Value = "Select number of cores",
                Order = 20,
                QuestionBaseList = questions.Where(el => el.QuestionsKey == "numberOfCores").ToList()
            };
        }
        public QuestionsBase<string> GroupFloppyDrivesCount(List<QuestionBase<string>> questions)
        {
            return new QuestionsBase<string>()
            {
                Key = "floppyDrivesCount",
                Value = "Select floppy drives count",
                Order = 21,
                QuestionBaseList = questions.Where(el => el.QuestionsKey == "floppyDrivesCount").ToList()
            };
        }
        public QuestionsBase<string> GroupDisplays(List<QuestionBase<string>> questions)
        {
            return new QuestionsBase<string>()
            {
                Key = "display",
                Value = "Select display",
                Order = 22,
                QuestionBaseList = questions.Where(el => el.QuestionsKey == "display").ToList()
            };
        }
        public QuestionsBase<string> GroupCapacities(List<QuestionBase<string>> questions)
        {
            return new QuestionsBase<string>()
            {
                Key = "capacity",
                Value = "Select capacity",
                Order = 10,
                QuestionBaseList = questions.Where(el => el.QuestionsKey == "capacity").ToList()
            };
        }
        public QuestionsBase<string> GroupUSBSpecificationTypes(List<QuestionBase<string>> questions)
        {
            return new QuestionsBase<string>()
            {
                Key = "USBSpecificationType",
                Value = "Select USB specification type",
                Order = 11,
                QuestionBaseList = questions.Where(el => el.QuestionsKey == "USBSpecificationType").ToList()
            };
        }
        public QuestionsBase<string> GroupFormFactorTypes(List<QuestionBase<string>> questions)
        {
            return new QuestionsBase<string>()
            {
                Key = "formFactorType",
                Value = "Select form factor type",
                Order = 30,
                QuestionBaseList = questions.Where(el => el.QuestionsKey == "formFactorType").ToList()
            };
        }
        public QuestionsBase<string> GroupCoolerTypes(List<QuestionBase<string>> questions)
        {
            return new QuestionsBase<string>()
            {
                Key = "coolerType",
                Value = "Select cooler type",
                Order = 30,
                QuestionBaseList = questions.Where(el => el.QuestionsKey == "coolerType").ToList()
            };
        }
        public QuestionsBase<string> GroupFanSizes(List<QuestionBase<string>> questions)
        {
            return new QuestionsBase<string>()
            {
                Key = "fanSize",
                Value = "Select fan size",
                Order = 31,
                QuestionBaseList = questions.Where(el => el.QuestionsKey == "fanSize").ToList()
            };
        }



        public QuestionsBase<string> GroupThermalDesignPowers(List<QuestionBase<string>> questions)
        {
            return new QuestionsBase<string>()
            {
                Key = "thermalDesignPower",
                Value = "Select thermal design power",
                Order = 30,
                QuestionBaseList = questions.Where(el => el.QuestionsKey == "thermalDesignPower").ToList()
            };
        }
        public QuestionsBase<string> GroupNumberOfThreads(List<QuestionBase<string>> questions)
        {
            return new QuestionsBase<string>()
            {
                Key = "numberOfThreads",
                Value = "Select number of threads",
                Order = 31,
                QuestionBaseList = questions.Where(el => el.QuestionsKey == "numberOfThreads").ToList()
            };
        }

        public QuestionsBase<string> GroupDriveInterfaces(List<QuestionBase<string>> questions)
        {
            return new QuestionsBase<string>()
            {
                Key = "driveInterface",
                Value = "Select drive interface",
                Order = 30,
                QuestionBaseList = questions.Where(el => el.QuestionsKey == "driveInterface").ToList()
            };
        }
        public QuestionsBase<string> GroupVideoSizes(List<QuestionBase<string>> questions)
        {
            return new QuestionsBase<string>()
            {
                Key = "videoSize",
                Value = "Select video size",
                Order = 31,
                QuestionBaseList = questions.Where(el => el.QuestionsKey == "videoSize").ToList()
            };
        }
        public QuestionsBase<string> GroupVideoMemoryCapacities(List<QuestionBase<string>> questions)
        {
            return new QuestionsBase<string>()
            {
                Key = "videoMemoryCapacity",
                Value = "Select video memory capacity",
                Order = 31,
                QuestionBaseList = questions.Where(el => el.QuestionsKey == "videoMemoryCapacity").ToList()
            };
        }





        public QuestionsBase<string> GroupHeadphonesTypes(List<QuestionBase<string>> questions)
        {
            return new QuestionsBase<string>()
            {
                Key = "headphonesType",
                Value = "Select headphones type",
                Order = 30,
                QuestionBaseList = questions.Where(el => el.QuestionsKey == "headphonesType").ToList()
            };
        }
        public QuestionsBase<string> GroupWirelessTypes(List<QuestionBase<string>> questions)
        {
            return new QuestionsBase<string>()
            {
                Key = "wirelessType",
                Value = "Select wireless type",
                Order = 31,
                QuestionBaseList = questions.Where(el => el.QuestionsKey == "wirelessType").ToList()
            };
        }
        public QuestionsBase<string> GroupConnectorTypes(List<QuestionBase<string>> questions)
        {
            return new QuestionsBase<string>()
            {
                Key = "connectorType",
                Value = "Select connector type",
                Order = 32,
                QuestionBaseList = questions.Where(el => el.QuestionsKey == "connectorType").ToList()
            };
        }
        public QuestionsBase<string> GroupKeyboardTypes(List<QuestionBase<string>> questions)
        {
            return new QuestionsBase<string>()
            {
                Key = "keyboardType",
                Value = "Select keyboard type",
                Order = 30,
                QuestionBaseList = questions.Where(el => el.QuestionsKey == "keyboardType").ToList()
            };
        }
        public QuestionsBase<string> GroupMauseTypes(List<QuestionBase<string>> questions)
        {
            return new QuestionsBase<string>()
            {
                Key = "mauseType",
                Value = "Select mause type",
                Order = 30,
                QuestionBaseList = questions.Where(el => el.QuestionsKey == "mauseType").ToList()
            };
        }
        public QuestionsBase<string> GroupButtonsCount(List<QuestionBase<string>> questions)
        {
            return new QuestionsBase<string>()
            {
                Key = "buttonsCount",
                Value = "Select buttons count",
                Order = 31,
                QuestionBaseList = questions.Where(el => el.QuestionsKey == "buttonsCount").ToList()
            };
        }
    }
}
