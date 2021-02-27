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
        Task<int> AddGood(GoodModel goodModel, string email);
        Task<int> AddComputerTechnology(ComputerTechnologyModel computerTechnologyModel, string email);
        Task<int> AddComputerPart(ComputerPartModel computerPartModel, string email);
        Task<int> AddComputerAccessory(ComputerAccessoryModel computerAccessoryModel, string email);
        Task<int> AddComputer(ComputerModel computerModel, string email);
        Task<int> AddLaptop(LaptopModel laptopModel, string email);
        Task<int> AddFlashDrive(FlashDriveModel flashDriveModel, string email);
        Task<int> AddVideoCard(VideoCardModel videoCardModel, string email);
        Task<int> AddCPU(CPUModel cpuModel, string email);
        Task<int> AddCooler(CoolerModel coolerModel, string email);
        Task<int> AddComputerDrive(ComputerDriveModel computerDriveModel, string email);
        Task<int> AddMause(MauseModel mauseModel, string email);
        Task<int> AddKeyboard(KeyboardModel keyboardModel, string email);
        Task<int> AddHeadphones(HeadphonesModel headphonesModel, string email);
    }
}
