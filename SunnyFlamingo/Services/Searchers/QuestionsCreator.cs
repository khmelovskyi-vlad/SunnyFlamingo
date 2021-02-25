using SunnyFlamingo.Models;
using SunnyFlamingo.Models.Selectors;
using SunnyFlamingo.ValueObjects;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Searchers
{
    public class QuestionsCreator : IQuestionsCreator
    {
        public QuestionsBase<string> GroupProducers(List<DBQuestionBase> dBQuestions)
        {
            var questions = dBQuestions.Where(el => el.QuestionsKey == "producer")
                .Select(question => new QuestionBase<string>(question)
                {
                    ControlType = ControlType.Checkbox,
                    Type = InputType.Checkbox
                }).ToList();
            return new QuestionsBase<string>()
            {
                Key = "producer",
                Value = "Select producer",
                Order = 1,
                QuestionBaseList = questions
            };
        }
        public QuestionsBase<string> GroupCountries(List<DBQuestionBase> dBQuestions)
        {
            var questions = dBQuestions.Where(el => el.QuestionsKey == "country")
                .Select(question => new QuestionBase<string>(question)
                {
                    ControlType = ControlType.Checkbox,
                    Type = InputType.Checkbox
                }).ToList();
            return new QuestionsBase<string>()
            {
                Key = "country",
                Value = "Select country",
                Order = 2,
                QuestionBaseList = questions.ToList()
            };
        }
        public QuestionsBase<string> GroupMaterials(List<DBQuestionBase> dBQuestions)
        {
            var questions = dBQuestions.Where(el => el.QuestionsKey == "material")
                .Select(question => new QuestionBase<string>(question)
                {
                    ControlType = ControlType.Checkbox,
                    Type = InputType.Checkbox
                }).ToList();
            return new QuestionsBase<string>()
            {
                Key = "material",
                Value = "Select material",
                Order = 3,
                QuestionBaseList = questions.ToList()
            };
        }
        public QuestionsBase<string> GroupColors(List<DBQuestionBase> dBQuestions)
        {
            var questions = dBQuestions.Where(el => el.QuestionsKey == "color")
                .Select(question => new QuestionBase<string>(question)
                {
                    ControlType = ControlType.Checkbox,
                    Type = InputType.Checkbox
                }).ToList();
            return new QuestionsBase<string>()
            {
                Key = "color",
                Value = "Select color",
                Order = 4,
                QuestionBaseList = questions.ToList()
            };
        }
        public QuestionsBase<string> GroupPrices(List<DBQuestionBase> dBQuestions, decimal? priceFrom, decimal? priceTo)
        {
            var questions = dBQuestions.Where(el => el.QuestionsKey == "price")
                .Select(question => new QuestionBase<string>(question)
                {
                    ControlType = ControlType.RangeSlider,
                    Key = "price",
                    SelectedFrom = priceFrom == null ? Convert.ToDecimal(question.From, new CultureInfo("en-US")) : priceFrom,
                    SelectedTo = priceTo == null ? Convert.ToDecimal(question.To, new CultureInfo("en-US")) : priceTo,
                }).ToList();
            return new QuestionsBase<string>()
            {
                Key = "price",
                Value = "Select price",
                Order = 5,
                QuestionBaseList = questions
            };
        }
        public QuestionsBase<string> GroupAmountOfRAMs(List<DBQuestionBase> dBQuestions)
        {
            var questions = dBQuestions.Where(el => el.QuestionsKey == "amountOfRAM")
                .Select(question => new QuestionBase<string>(question)
                {
                    ControlType = ControlType.Checkbox,
                    Type = InputType.Checkbox
                }).ToList();
            return new QuestionsBase<string>()
            {
                Key = "amountOfRAM",
                Value = "Select amount of RAM",
                Order = 10,
                QuestionBaseList = questions.ToList()
            };
        }
        public QuestionsBase<string> GroupCPUFrequencies(List<DBQuestionBase> dBQuestions)
        {
            var questions = dBQuestions.Where(el => el.QuestionsKey == "CPUFrequency")
                .Select(question => new QuestionBase<string>(question)
                {
                    ControlType = ControlType.Checkbox,
                    Type = InputType.Checkbox
                }).ToList();
            return new QuestionsBase<string>()
            {
                Key = "CPUFrequency",
                Value = "Select CPU frequency",
                Order = 11,
                QuestionBaseList = questions.ToList()
            };
        }
        public QuestionsBase<string> GroupHeight(List<DBQuestionBase> dBQuestions)
        {
            var questions = dBQuestions.Where(el => el.QuestionsKey == "height")
                .Select(question => new QuestionBase<string>(question)
                {
                    ControlType = ControlType.Checkbox,
                    Type = InputType.Checkbox
                }).ToList();
            return new QuestionsBase<string>()
            {
                Key = "height",
                Value = "Select height",
                Order = 12,
                QuestionBaseList = questions.ToList()
            };
        }
        public QuestionsBase<string> GroupWidth(List<DBQuestionBase> dBQuestions)
        {
            var questions = dBQuestions.Where(el => el.QuestionsKey == "width")
                .Select(question => new QuestionBase<string>(question)
                {
                    ControlType = ControlType.Checkbox,
                    Type = InputType.Checkbox
                }).ToList();
            return new QuestionsBase<string>()
            {
                Key = "width",
                Value = "Select width",
                Order = 13,
                QuestionBaseList = questions.ToList()
            };
        }
        public QuestionsBase<string> GroupLength(List<DBQuestionBase> dBQuestions)
        {
            var questions = dBQuestions.Where(el => el.QuestionsKey == "length")
                .Select(question => new QuestionBase<string>(question)
                {
                    ControlType = ControlType.Checkbox,
                    Type = InputType.Checkbox
                }).ToList();
            return new QuestionsBase<string>()
            {
                Key = "length",
                Value = "Select length",
                Order = 14,
                QuestionBaseList = questions.ToList()
            };
        }
        public QuestionsBase<string> GroupHaveFloppyDrives(List<DBQuestionBase> dBQuestions)
        {
            var questions = dBQuestions.Where(el => el.QuestionsKey == "haveFloppyDrives")
                .Select(question => new QuestionBase<string>(question)
                {
                    Key = question.Key == "1" ? "true" : "false",
                    Label = question.Key == "1" ? "true" : "false",
                    ControlType = ControlType.Checkbox,
                    Type = InputType.Checkbox
                }).ToList();
            return new QuestionsBase<string>()
            {
                Key = "haveFloppyDrives",
                Value = "Have floppy drive",
                Order = 15,
                QuestionBaseList = questions.ToList()
            };
        }
        public QuestionsBase<string> GroupSSDMemory(List<DBQuestionBase> dBQuestions)
        {
            var questions = dBQuestions.Where(el => el.QuestionsKey == "SSDMemory")
                .Select(question => new QuestionBase<string>(question)
                {
                    ControlType = ControlType.Checkbox,
                    Type = InputType.Checkbox
                }).ToList();
            return new QuestionsBase<string>()
            {
                Key = "SSDMemory",
                Value = "Select SSD memory",
                Order = 16,
                QuestionBaseList = questions.ToList()
            };
        }
        public QuestionsBase<string> GroupHardDiskMemory(List<DBQuestionBase> dBQuestions)
        {
            var questions = dBQuestions.Where(el => el.QuestionsKey == "hardDiskMemory")
                .Select(question => new QuestionBase<string>(question)
                {
                    ControlType = ControlType.Checkbox,
                    Type = InputType.Checkbox
                }).ToList();
            return new QuestionsBase<string>()
            {
                Key = "hardDiskMemory",
                Value = "Select hard disk memory",
                Order = 17,
                QuestionBaseList = questions.ToList()
            };
        }
        public QuestionsBase<string> GroupCPUSocketTypes(List<DBQuestionBase> dBQuestions)
        {
            var questions = dBQuestions.Where(el => el.QuestionsKey == "CPUSocketType")
                .Select(question => new QuestionBase<string>(question)
                {
                    ControlType = ControlType.Checkbox,
                    Type = InputType.Checkbox
                }).ToList();
            return new QuestionsBase<string>()
            {
                Key = "CPUSocketType",
                Value = "Select CPU socket type",
                Order = 18,
                QuestionBaseList = questions.ToList()
            };
        }
        public QuestionsBase<string> GroupComputerDriveTypes(List<DBQuestionBase> dBQuestions)
        {
            var questions = dBQuestions.Where(el => el.QuestionsKey == "computerDriveType")
                .Select(question => new QuestionBase<string>(question)
                {
                    ControlType = ControlType.Checkbox,
                    Type = InputType.Checkbox
                }).ToList();
            return new QuestionsBase<string>()
            {
                Key = "computerDriveType",
                Value = "Select computer drive type",
                Order = 19,
                QuestionBaseList = questions.ToList()
            };
        }
        public QuestionsBase<string> GroupNumberOfCores(List<DBQuestionBase> dBQuestions)
        {
            var questions = dBQuestions.Where(el => el.QuestionsKey == "numberOfCores")
                .Select(question => new QuestionBase<string>(question)
                {
                    ControlType = ControlType.Checkbox,
                    Type = InputType.Checkbox
                }).ToList();
            return new QuestionsBase<string>()
            {
                Key = "numberOfCores",
                Value = "Select number of cores",
                Order = 20,
                QuestionBaseList = questions.ToList()
            };
        }
        public QuestionsBase<string> GroupFloppyDrivesCount(List<DBQuestionBase> dBQuestions)
        {
            var questions = dBQuestions.Where(el => el.QuestionsKey == "floppyDrivesCount")
                .Select(question => new QuestionBase<string>(question)
                {
                    ControlType = ControlType.Checkbox,
                    Type = InputType.Checkbox
                }).ToList();
            return new QuestionsBase<string>()
            {
                Key = "floppyDrivesCount",
                Value = "Select floppy drives count",
                Order = 21,
                QuestionBaseList = questions.ToList()
            };
        }
        public QuestionsBase<string> GroupDisplays(List<DBQuestionBase> dBQuestions)
        {
            var questions = dBQuestions.Where(el => el.QuestionsKey == "display")
                .Select(question => new QuestionBase<string>(question)
                {
                    ControlType = ControlType.Checkbox,
                    Type = InputType.Checkbox
                }).ToList();
            return new QuestionsBase<string>()
            {
                Key = "display",
                Value = "Select display",
                Order = 22,
                QuestionBaseList = questions.ToList()
            };
        }

        public QuestionsBase<string> GroupCapacity(List<DBQuestionBase> dBQuestions)
        {
            var questions = dBQuestions.Where(el => el.QuestionsKey == "capacity")
                .Select(question => new QuestionBase<string>(question)
                {
                    ControlType = ControlType.Checkbox,
                    Type = InputType.Checkbox
                }).ToList();
            return new QuestionsBase<string>()
            {
                Key = "capacity",
                Value = "Select capacity",
                Order = 10,
                QuestionBaseList = questions.ToList()
            };
        }

        public QuestionsBase<string> GroupUSBSpecificationTypes(List<DBQuestionBase> dBQuestions)
        {
            var questions = dBQuestions.Where(el => el.QuestionsKey == "USBSpecificationType")
                .Select(question => new QuestionBase<string>(question)
                {
                    ControlType = ControlType.Checkbox,
                    Type = InputType.Checkbox
                }).ToList();
            return new QuestionsBase<string>()
            {
                Key = "USBSpecificationType",
                Value = "Select USB specification type",
                Order = 11,
                QuestionBaseList = questions.ToList()
            };
        }

        public QuestionsBase<string> GroupDriveInterfaces(List<DBQuestionBase> dBQuestions)
        {
            var questions = dBQuestions.Where(el => el.QuestionsKey == "driveInterface")
                .Select(question => new QuestionBase<string>(question)
                {
                    ControlType = ControlType.Checkbox,
                    Type = InputType.Checkbox
                }).ToList();
            return new QuestionsBase<string>()
            {
                Key = "driveInterface",
                Value = "Select drive interface",
                Order = 30,
                QuestionBaseList = questions.ToList()
            };
        }
        public QuestionsBase<string> GroupVideoSizes(List<DBQuestionBase> dBQuestions)
        {
            var questions = dBQuestions.Where(el => el.QuestionsKey == "videoSize")
                .Select(question => new QuestionBase<string>(question)
                {
                    ControlType = ControlType.Checkbox,
                    Type = InputType.Checkbox
                }).ToList();
            return new QuestionsBase<string>()
            {
                Key = "videoSize",
                Value = "Select video size",
                Order = 31,
                QuestionBaseList = questions.ToList()
            };
        }
        public QuestionsBase<string> GroupVideoMemoryCapacities(List<DBQuestionBase> dBQuestions)
        {
            var questions = dBQuestions.Where(el => el.QuestionsKey == "videoMemoryCapacity")
                .Select(question => new QuestionBase<string>(question)
                {
                    ControlType = ControlType.Checkbox,
                    Type = InputType.Checkbox
                }).ToList();
            return new QuestionsBase<string>()
            {
                Key = "videoMemoryCapacity",
                Value = "Select video memory capacity",
                Order = 31,
                QuestionBaseList = questions.ToList()
            };
        }
        public QuestionsBase<string> GroupThermalDesignPowers(List<DBQuestionBase> dBQuestions)
        {
            var questions = dBQuestions.Where(el => el.QuestionsKey == "thermalDesignPower")
                .Select(question => new QuestionBase<string>(question)
                {
                    ControlType = ControlType.Checkbox,
                    Type = InputType.Checkbox
                }).ToList();
            return new QuestionsBase<string>()
            {
                Key = "thermalDesignPower",
                Value = "Select thermal design power",
                Order = 30,
                QuestionBaseList = questions.ToList()
            };
        }
        public QuestionsBase<string> GroupNumberOfThreads(List<DBQuestionBase> dBQuestions)
        {
            var questions = dBQuestions.Where(el => el.QuestionsKey == "numberOfThreads")
                .Select(question => new QuestionBase<string>(question)
                {
                    ControlType = ControlType.Checkbox,
                    Type = InputType.Checkbox
                }).ToList();
            return new QuestionsBase<string>()
            {
                Key = "numberOfThreads",
                Value = "Select number of threads",
                Order = 31,
                QuestionBaseList = questions.ToList()
            };
        }
        public QuestionsBase<string> GroupCoolerTypes(List<DBQuestionBase> dBQuestions)
        {
            var questions = dBQuestions.Where(el => el.QuestionsKey == "coolerType")
                .Select(question => new QuestionBase<string>(question)
                {
                    ControlType = ControlType.Checkbox,
                    Type = InputType.Checkbox
                }).ToList();
            return new QuestionsBase<string>()
            {
                Key = "coolerType",
                Value = "Select cooler type",
                Order = 30,
                QuestionBaseList = questions.ToList()
            };
        }
        public QuestionsBase<string> GroupFanSizes(List<DBQuestionBase> dBQuestions)
        {
            var questions = dBQuestions.Where(el => el.QuestionsKey == "fanSize")
                .Select(question => new QuestionBase<string>(question)
                {
                    ControlType = ControlType.Checkbox,
                    Type = InputType.Checkbox
                }).ToList();
            return new QuestionsBase<string>()
            {
                Key = "fanSize",
                Value = "Select fan size",
                Order = 31,
                QuestionBaseList = questions.ToList()
            };
        }
        public QuestionsBase<string> GroupFormFactorTypes(List<DBQuestionBase> dBQuestions)
        {
            var questions = dBQuestions.Where(el => el.QuestionsKey == "formFactorType")
                .Select(question => new QuestionBase<string>(question)
                {
                    ControlType = ControlType.Checkbox,
                    Type = InputType.Checkbox
                }).ToList();
            return new QuestionsBase<string>()
            {
                Key = "formFactorType",
                Value = "Select form factor type",
                Order = 30,
                QuestionBaseList = questions.ToList()
            };
        }
        public QuestionsBase<string> GroupMauseTypes(List<DBQuestionBase> dBQuestions)
        {
            var questions = dBQuestions.Where(el => el.QuestionsKey == "mauseType")
                .Select(question => new QuestionBase<string>(question)
                {
                    ControlType = ControlType.Checkbox,
                    Type = InputType.Checkbox
                }).ToList();
            return new QuestionsBase<string>()
            {
                Key = "mauseType",
                Value = "Select mause type",
                Order = 30,
                QuestionBaseList = questions.ToList()
            };
        }
        public QuestionsBase<string> GroupButtonsCount(List<DBQuestionBase> dBQuestions)
        {
            var questions = dBQuestions.Where(el => el.QuestionsKey == "buttonsCount")
                .Select(question => new QuestionBase<string>(question)
                {
                    ControlType = ControlType.Checkbox,
                    Type = InputType.Checkbox
                }).ToList();
            return new QuestionsBase<string>()
            {
                Key = "buttonsCount",
                Value = "Select buttons count",
                Order = 31,
                QuestionBaseList = questions.ToList()
            };
        }
        public QuestionsBase<string> GroupKeyboardTypes(List<DBQuestionBase> dBQuestions)
        {
            var questions = dBQuestions.Where(el => el.QuestionsKey == "keyboardType")
                .Select(question => new QuestionBase<string>(question)
                {
                    ControlType = ControlType.Checkbox,
                    Type = InputType.Checkbox
                }).ToList();
            return new QuestionsBase<string>()
            {
                Key = "keyboardType",
                Value = "Select keyboard type",
                Order = 30,
                QuestionBaseList = questions.ToList()
            };
        }
        public QuestionsBase<string> GroupHeadphonesTypes(List<DBQuestionBase> dBQuestions)
        {
            var questions = dBQuestions.Where(el => el.QuestionsKey == "headphonesType")
                .Select(question => new QuestionBase<string>(question)
                {
                    ControlType = ControlType.Checkbox,
                    Type = InputType.Checkbox
                }).ToList();
            return new QuestionsBase<string>()
            {
                Key = "headphonesType",
                Value = "Select headphones type",
                Order = 30,
                QuestionBaseList = questions.ToList()
            };
        }
        public QuestionsBase<string> GroupWirelessTypes(List<DBQuestionBase> dBQuestions)
        {
            var questions = dBQuestions.Where(el => el.QuestionsKey == "wirelessType")
                .Select(question => new QuestionBase<string>(question)
                {
                    ControlType = ControlType.Checkbox,
                    Type = InputType.Checkbox
                }).ToList();
            return new QuestionsBase<string>()
            {
                Key = "wirelessType",
                Value = "Select wireless type",
                Order = 31,
                QuestionBaseList = questions.ToList()
            };
        }
        public QuestionsBase<string> GroupConnectorTypes(List<DBQuestionBase> dBQuestions)
        {
            var questions = dBQuestions.Where(el => el.QuestionsKey == "connectorType")
                .Select(question => new QuestionBase<string>(question)
                {
                    ControlType = ControlType.Checkbox,
                    Type = InputType.Checkbox
                }).ToList();
            return new QuestionsBase<string>()
            {
                Key = "connectorType",
                Value = "Select connector type",
                Order = 32,
                QuestionBaseList = questions.ToList()
            };
        }
    }
}
