using SunnyFlamingo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Creators
{
    public class QuestionGrouper : IQuestionGrouper
    {
        private readonly IQuestionCreator _questionCreator;
        public QuestionGrouper(IQuestionCreator questionCreator)
        {
            _questionCreator = questionCreator;
        }
        public List<QuestionBase<string>> GroupGoods()
        {
            return new List<QuestionBase<string>>() {
                    _questionCreator.CreateImages(),
                    _questionCreator.CreateName(),
                    _questionCreator.CreatePrice(),
                    _questionCreator.CreateIsAvailable(),
                    _questionCreator.CreateDescription(),
                    _questionCreator.CreateProducerId(),
                    _questionCreator.CreateManufacturerId(),
                    _questionCreator.CreateMaterial(),
                    _questionCreator.CreateColor(),
            };
        }
        public List<QuestionBase<string>> GroupComputerTechnologies()
        {
            return GroupGoods();
        }
        public List<QuestionBase<string>> GroupComputerParts()
        {
            return GroupComputerTechnologies();
        }
        public List<QuestionBase<string>> GroupComputerAccessories()
        {
            return GroupComputerTechnologies();
        }
        public List<QuestionBase<string>> GroupComputers()
        {
            var result = GroupComputerTechnologies();
            result.AddRange(new List<QuestionBase<string>>() {
                    _questionCreator.CreateAmountOfRAMs(),
                    _questionCreator.CreateCPUFrequencies(),
                    _questionCreator.CreateHeight(),
                    _questionCreator.CreateWidth(),
                    _questionCreator.CreateLength(),
                    _questionCreator.CreateHaveFloppyDrives(),
                    _questionCreator.CreateSSDMemory(),
                    _questionCreator.CreateHardDiskMemory(),
                    _questionCreator.CreateCPUSocketTypes(),
                    _questionCreator.CreateComputerDriveTypes(),
                    _questionCreator.CreateNumberOfCores(),
                    _questionCreator.CreateFloppyDrivesCount(),
            });
            return result;
        }
        public List<QuestionBase<string>> GroupLaptops()
        {
            var result = GroupComputerTechnologies();
            result.AddRange(new List<QuestionBase<string>>() {
                    _questionCreator.CreateAmountOfRAMs(),
                    _questionCreator.CreateCPUFrequencies(),
                    _questionCreator.CreateHeight(),
                    _questionCreator.CreateWidth(),
                    _questionCreator.CreateLength(),
                    _questionCreator.CreateHaveFloppyDrives(),
                    _questionCreator.CreateSSDMemory(),
                    _questionCreator.CreateHardDiskMemory(),
                    _questionCreator.CreateCPUSocketTypes(),
                    _questionCreator.CreateComputerDriveTypes(),
                    _questionCreator.CreateNumberOfCores(),
                    _questionCreator.CreateFloppyDrivesCount(),
                    _questionCreator.CreateDisplays(),
            });
            return result;
        }
        public List<QuestionBase<string>> GroupFlashDrives()
        {
            var result = GroupComputerTechnologies();
            result.AddRange(new List<QuestionBase<string>>() {
                    _questionCreator.CreateCapacity(),
                    _questionCreator.CreateUSBSpecificationTypes(),
            });
            return result;
        }
        public List<QuestionBase<string>> GroupVideoCards()
        {
            var result = GroupComputerParts();
            result.AddRange(new List<QuestionBase<string>>() {
                    _questionCreator.CreateVideoSizes(),
                    _questionCreator.CreateDriveInterfaces(),
                    _questionCreator.CreateVideoMemoryCapacities(),
            });
            return result;
        }
        public List<QuestionBase<string>> GroupCPUs()
        {
            var result = GroupComputerParts();
            result.AddRange(new List<QuestionBase<string>>() {
                    _questionCreator.CreateCPUSocketType(),
                    _questionCreator.CreateThermalDesignPowers(),
                    _questionCreator.CreateNumberOfCores(),
                    _questionCreator.CreateNumberOfThreads(),
            });
            return result;
        }
        public List<QuestionBase<string>> GroupCoolers()
        {
            var result = GroupComputerParts();
            result.AddRange(new List<QuestionBase<string>>() {
                    _questionCreator.CreateCoolerTypes(),
                    _questionCreator.CreateFanSizes(),
            });
            return result;
        }
        public List<QuestionBase<string>> GroupComputerDrives()
        {
            var result = GroupComputerParts();
            result.AddRange(new List<QuestionBase<string>>() {
                    _questionCreator.CreateCapacity(),
                    _questionCreator.CreateComputerDriveTypes(),
                    _questionCreator.CreateFormFactorTypes(),
            });
            return result;
        }
        public List<QuestionBase<string>> GroupMice()
        {
            var result = GroupComputerAccessories();
            result.AddRange(new List<QuestionBase<string>>() {
                    _questionCreator.CreateMauseTypes(),
                    _questionCreator.CreateButtonsCount(),
            });
            return result;
        }
        public List<QuestionBase<string>> GroupKeyboards()
        {
            var result = GroupComputerAccessories();
            result.AddRange(new List<QuestionBase<string>>() {
                    _questionCreator.CreateKeyboardTypes(),
            });
            return result;
        }
        public List<QuestionBase<string>> GroupHeadphones()
        {
            var result = GroupComputerAccessories();
            result.AddRange(new List<QuestionBase<string>>() {
                    _questionCreator.CreateHeadphonesTypes(),
                    _questionCreator.CreateWirelessTypes(),
                    _questionCreator.CreateConnectorTypes(),
            });
            return result;
        }
    }
}
