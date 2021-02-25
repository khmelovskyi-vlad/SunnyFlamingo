using SunnyFlamingo.Models;
using SunnyFlamingo.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Creators
{
    public class QuestionCreator : IQuestionCreator
    {
        public QuestionBase<string> CreateImages()
        {
            return new QuestionBase<string>()
            {
                Key = "images",
                ControlType = ControlType.Image,
                Type = InputType.File,
                Label = "Images",
            };
        }
        public QuestionBase<string> CreateName()
        {
            return new QuestionBase<string>()
            {
                Key = "name",
                ControlType = ControlType.Textbox,
                Type = InputType.Search,
                Label = "Name",
                Validator = new QuestionValidator() { MaxLength = 500, MinLength = 1, Required = true }
            };
        }
        public QuestionBase<string> CreatePrice()
        {
            return new QuestionBase<string>()
            {
                Key = "price",
                ControlType = ControlType.Textbox,
                Type = InputType.Number,
                Label = "Price",
                Validator = new QuestionValidator() { Min = 1, Required = true }
            };
        }
        public QuestionBase<string> CreateIsAvailable()
        {
            return new QuestionBase<string>()
            {
                Key = "isAvailable",
                Value = "false",
                ControlType = ControlType.Switcher,
                Type = InputType.Checkbox,
                Label = "Is available",
                Validator = new QuestionValidator() { Required = true }
            };
        }
        public QuestionBase<string> CreateDescription()
        {
            return new QuestionBase<string>()
            {
                Key = "description",
                ControlType = ControlType.Textbox,
                Type = InputType.Search,
                Label = "Description",
                Validator = new QuestionValidator() { Required = true }
            };
        }
        public QuestionBase<string> CreateProducerId()
        {
            return new QuestionBase<string>()
            {
                Key = "producerId",
                ControlType = ControlType.Searcher,
                Type = InputType.Search,
                Label = "Producer id",
                MethodName = "producerId",
                Validator = new QuestionValidator() { Required = true }
            };
        }
        public QuestionBase<string> CreateManufacturerId()
        {
            return new QuestionBase<string>()
            {
                Key = "manufacturerId",
                ControlType = ControlType.Searcher,
                Type = InputType.Search,
                Label = "Manufacturer id",
                MethodName = "manufacturerId",
                Validator = new QuestionValidator() { Required = true }
            };
        }
        public QuestionBase<string> CreateMaterial()
        {
            return new QuestionBase<string>()
            {
                Key = "material",
                ControlType = ControlType.Searcher,
                Type = InputType.Search,
                Label = "Material",
                MethodName = "material",
                Validator = new QuestionValidator() { Required = true }
            };
        }
        public QuestionBase<string> CreateColor()
        {
            return new QuestionBase<string>()
            {
                Key = "color",
                ControlType = ControlType.Searcher,
                Type = InputType.Search,
                Label = "Color",
                MethodName = "color",
                Validator = new QuestionValidator() { Required = true }
            };
        }

        public QuestionBase<string> CreateAmountOfRAMs()
        {
            return new QuestionBase<string>()
            {
                Key = "amountOfRAM",
                ControlType = ControlType.Textbox,
                Type = InputType.Number,
                Label = "Amount of RAM",
                Validator = new QuestionValidator() { Min = 1, Required = true }
            };
        }
        public QuestionBase<string> CreateCPUFrequencies()
        {
            return new QuestionBase<string>()
            {
                Key = "cpuFrequency",
                ControlType = ControlType.Textbox,
                Type = InputType.Number,
                Label = "CPU frequency",
                Validator = new QuestionValidator() { Min = 1, Required = true }
            };
        }
        public QuestionBase<string> CreateHeight()
        {
            return new QuestionBase<string>()
            {
                Key = "height",
                ControlType = ControlType.Textbox,
                Type = InputType.Number,
                Label = "Height",
                Validator = new QuestionValidator() { Min = 1, Required = true }
            };
        }
        public QuestionBase<string> CreateWidth()
        {
            return new QuestionBase<string>()
            {
                Key = "width",
                ControlType = ControlType.Textbox,
                Type = InputType.Number,
                Label = "Width",
                Validator = new QuestionValidator() { Min = 1, Required = true }
            };
        }
        public QuestionBase<string> CreateLength()
        {
            return new QuestionBase<string>()
            {
                Key = "length",
                ControlType = ControlType.Textbox,
                Type = InputType.Number,
                Label = "Length",
                Validator = new QuestionValidator() { Min = 1, Required = true }
            };
        }
        public QuestionBase<string> CreateHaveFloppyDrives()
        {
            return new QuestionBase<string>()
            {
                Value = "false",
                Key = "haveFloppyDrives",
                ControlType = ControlType.Switcher,
                Type = InputType.Checkbox,
                Label = "Have floppy drives",
                Validator = new QuestionValidator() { Required = true }
            };
        }
        public QuestionBase<string> CreateSSDMemory()
        {
            return new QuestionBase<string>()
            {
                Key = "ssdMemory",
                ControlType = ControlType.Textbox,
                Type = InputType.Number,
                Label = "SSD memory",
                Validator = new QuestionValidator() { Min = 1 }
            };
        }
        public QuestionBase<string> CreateHardDiskMemory()
        {
            return new QuestionBase<string>()
            {
                Key = "hardDiskMemory",
                ControlType = ControlType.Textbox,
                Type = InputType.Number,
                Label = "Hard disk memory",
                Validator = new QuestionValidator() { Min = 1 }
            };
        }
        public QuestionBase<string> CreateCPUSocketTypes()
        {
            return new QuestionBase<string>()
            {
                Key = "cpuSocketType",
                ControlType = ControlType.Searcher,
                Type = InputType.Search,
                Label = "CPU socket type",
                MethodName = "cpuSocketType",
                Validator = new QuestionValidator() { Required = true }
            };
        }
        public QuestionBase<string> CreateComputerDriveTypes()
        {
            return new QuestionBase<string>()
            {
                Key = "computerDriveTypes",
                ControlType = ControlType.SearcherArray,
                Type = InputType.Search,
                Label = "Computer drive type",
                MethodName = "computerDriveTypes",
            };
        }
        public QuestionBase<string> CreateNumberOfCores()
        {
            return new QuestionBase<string>()
            {
                Key = "numberOfCores",
                ControlType = ControlType.Textbox,
                Type = InputType.Number,
                Label = "Number of cores",
                Validator = new QuestionValidator() { Required = true }
            };
        }
        public QuestionBase<string> CreateFloppyDrivesCount()
        {
            return new QuestionBase<string>()
            {
                Key = "floppyDrivesCount",
                ControlType = ControlType.Textbox,
                Type = InputType.Number,
                Label = "Floppy drives count",
            };
        }
        public QuestionBase<string> CreateDisplays()
        {
            return new QuestionBase<string>()
            {
                Key = "display",
                ControlType = ControlType.Textbox,
                Type = InputType.Number,
                Label = "Display",
                Validator = new QuestionValidator() { Required = true }
            };
        }

        public QuestionBase<string> CreateCapacity()
        {
            return new QuestionBase<string>()
            {
                Key = "capacity",
                ControlType = ControlType.Textbox,
                Type = InputType.Number,
                Label = "Capacity",
                Validator = new QuestionValidator() { Required = true }
            };
        }
        public QuestionBase<string> CreateUSBSpecificationTypes()
        {
            return new QuestionBase<string>()
            {
                Key = "usbSpecificationType",
                ControlType = ControlType.Searcher,
                Type = InputType.Search,
                Label = "USB specification type",
                MethodName = "usbSpecificationType",
                Validator = new QuestionValidator() { Required = true }
            };
        }
        public QuestionBase<string> CreateDriveInterfaces()
        {
            return new QuestionBase<string>()
            {
                Key = "driveInterface",
                ControlType = ControlType.Searcher,
                Type = InputType.Search,
                Label = "Drive interface",
                MethodName = "driveInterface",
                Validator = new QuestionValidator() { Required = true }
            };
        }

        public QuestionBase<string> CreateVideoSizes()
        {
            return new QuestionBase<string>()
            {
                Key = "videoSize",
                ControlType = ControlType.Textbox,
                Type = InputType.Number,
                Label = "Video size",
                Validator = new QuestionValidator() { Required = true }
            };
        }
        public QuestionBase<string> CreateVideoMemoryCapacities()
        {
            return new QuestionBase<string>()
            {
                Key = "videoMemoryCapacity",
                ControlType = ControlType.Textbox,
                Type = InputType.Number,
                Label = "Video memory capacity",
                Validator = new QuestionValidator() { Required = true }
            };
        }
        public QuestionBase<string> CreateThermalDesignPowers()
        {
            return new QuestionBase<string>()
            {
                Key = "thermalDesignPower",
                ControlType = ControlType.Textbox,
                Type = InputType.Number,
                Label = "Thermal design power",
                Validator = new QuestionValidator() { Required = true }
            };
        }
        public QuestionBase<string> CreateNumberOfThreads()
        {
            return new QuestionBase<string>()
            {
                Key = "numberOfThreads",
                ControlType = ControlType.Textbox,
                Type = InputType.Number,
                Label = "Number of threads",
                Validator = new QuestionValidator() { Required = true }
            };
        }
        public QuestionBase<string> CreateCPUSocketType()
        {
            return new QuestionBase<string>()
            {
                Key = "cpuSocketType",
                ControlType = ControlType.Searcher,
                Type = InputType.Search,
                Label = "CPU socket type",
                MethodName = "cpuSocketType",
                Validator = new QuestionValidator() { Required = true }
            };
        }
        public QuestionBase<string> CreateCoolerTypes()
        {
            return new QuestionBase<string>()
            {
                Key = "type",
                ControlType = ControlType.Searcher,
                Type = InputType.Search,
                Label = "Type",
                MethodName = "coolerType",
                Validator = new QuestionValidator() { Required = true }
            };
        }
        public QuestionBase<string> CreateFanSizes()
        {
            return new QuestionBase<string>()
            {
                Key = "fanSize",
                ControlType = ControlType.Textbox,
                Type = InputType.Number,
                Label = "Fan size",
                Validator = new QuestionValidator() { Required = true }
            };
        }
        public QuestionBase<string> CreateFormFactorTypes()
        {
            return new QuestionBase<string>()
            {
                Key = "type",
                ControlType = ControlType.Searcher,
                Type = InputType.Search,
                Label = "Type",
                MethodName = "formFactorType",
                Validator = new QuestionValidator() { Required = true }
            };
        }
        public QuestionBase<string> CreateMauseTypes()
        {
            return new QuestionBase<string>()
            {
                Key = "type",
                ControlType = ControlType.Searcher,
                Type = InputType.Search,
                Label = "Type",
                MethodName = "mauseType",
                Validator = new QuestionValidator() { Required = true }
            };
        }
        public QuestionBase<string> CreateButtonsCount()
        {
            return new QuestionBase<string>()
            {
                Key = "buttonsCount",
                ControlType = ControlType.Textbox,
                Type = InputType.Number,
                Label = "Buttons count",
                Validator = new QuestionValidator() { Required = true }
            };
        }
        public QuestionBase<string> CreateKeyboardTypes()
        {
            return new QuestionBase<string>()
            {
                Key = "type",
                ControlType = ControlType.Searcher,
                Type = InputType.Search,
                Label = "Type",
                MethodName = "keyboardType",
                Validator = new QuestionValidator() { Required = true }
            };
        }
        public QuestionBase<string> CreateHeadphonesTypes()
        {
            return new QuestionBase<string>()
            {
                Key = "type",
                ControlType = ControlType.Searcher,
                Type = InputType.Search,
                Label = "Type",
                MethodName = "headphonesType",
                Validator = new QuestionValidator() { Required = true }
            };
        }
        public QuestionBase<string> CreateWirelessTypes()
        {
            return new QuestionBase<string>()
            {
                Key = "wirelessType",
                ControlType = ControlType.Searcher,
                Type = InputType.Search,
                Label = "Wireless type",
                MethodName = "wirelessType",
                Validator = new QuestionValidator() { Required = true }
            };
        }
        public QuestionBase<string> CreateConnectorTypes()
        {
            return new QuestionBase<string>()
            {
                Key = "connectorType",
                ControlType = ControlType.Searcher,
                Type = InputType.Search,
                Label = "Connector type",
                MethodName = "connectorType",
                Validator = new QuestionValidator() { Required = true }
            };
        }
    }
}
