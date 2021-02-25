using SunnyFlamingo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Creators
{
    public interface IQuestionCreator
    {
        QuestionBase<string> CreateImages();
        QuestionBase<string> CreateName();
        QuestionBase<string> CreatePrice();
        QuestionBase<string> CreateIsAvailable();
        QuestionBase<string> CreateDescription();
        QuestionBase<string> CreateProducerId();
        QuestionBase<string> CreateManufacturerId();
        QuestionBase<string> CreateMaterial();
        QuestionBase<string> CreateColor();
        QuestionBase<string> CreateAmountOfRAMs();
        QuestionBase<string> CreateCPUFrequencies();
        QuestionBase<string> CreateHeight();
        QuestionBase<string> CreateWidth();
        QuestionBase<string> CreateLength();
        QuestionBase<string> CreateHaveFloppyDrives();
        QuestionBase<string> CreateSSDMemory();
        QuestionBase<string> CreateHardDiskMemory();
        QuestionBase<string> CreateCPUSocketTypes();
        QuestionBase<string> CreateComputerDriveTypes();
        QuestionBase<string> CreateNumberOfCores();
        QuestionBase<string> CreateFloppyDrivesCount();
        QuestionBase<string> CreateDisplays();

        QuestionBase<string> CreateCapacity();
        QuestionBase<string> CreateUSBSpecificationTypes();
        QuestionBase<string> CreateDriveInterfaces();
        QuestionBase<string> CreateVideoSizes();
        QuestionBase<string> CreateVideoMemoryCapacities();
        QuestionBase<string> CreateThermalDesignPowers();
        QuestionBase<string> CreateNumberOfThreads();
        QuestionBase<string> CreateCPUSocketType();
        QuestionBase<string> CreateCoolerTypes();
        QuestionBase<string> CreateFanSizes();
        QuestionBase<string> CreateFormFactorTypes();
        QuestionBase<string> CreateMauseTypes();
        QuestionBase<string> CreateButtonsCount();
        QuestionBase<string> CreateKeyboardTypes();
        QuestionBase<string> CreateHeadphonesTypes();
        QuestionBase<string> CreateWirelessTypes();
        QuestionBase<string> CreateConnectorTypes();
    }
}
