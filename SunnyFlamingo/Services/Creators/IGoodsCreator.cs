using SunnyFlamingo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Creators
{
    public interface IGoodsCreator
    {
        QuestionsBase<string> GetGoodQuestions(string type);
        Task<int> AddGood(GoodModel goodModel);
        Task<int> AddComputerTechnology(ComputerTechnologyModel computerTechnologyModel);
        Task<int> AddComputerPart(ComputerPartModel computerPartModel);
        Task<int> AddComputerAccessory(ComputerAccessoryModel computerAccessoryModel);
        Task<int> AddComputer(ComputerModel computerModel);
        Task<int> AddLaptop(LaptopModel laptopModel);
        Task<int> AddFlashDrive(FlashDriveModel flashDriveModel);
        Task<int> AddVideoCard(VideoCardModel videoCardModel);
        Task<int> AddCPU(CPUModel cpuModel);
        Task<int> AddCooler(CoolerModel coolerModel);
        Task<int> AddComputerDrive(ComputerDriveModel computerDriveModel);
        Task<int> AddMause(MauseModel mauseModel);
        Task<int> AddKeyboard(KeyboardModel keyboardModel);
        Task<int> AddHeadphones(HeadphonesModel headphonesModel);
    }
}
