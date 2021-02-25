using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SunnyFlamingo.Data;
using SunnyFlamingo.Entities;
using SunnyFlamingo.Entities.Goods;
using SunnyFlamingo.Models;
using SunnyFlamingo.Services.Creators;
using SunnyFlamingo.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Controllers
{
    [Route("api/adding-goods")]
    [ApiController]
    public class AddingGoodsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly IGoodsCreator _goodsCreator;
        public AddingGoodsController(ApplicationDbContext context, IMapper mapper, IGoodsCreator goodsCreator)
        {
            _context = context;
            _mapper = mapper;
            _goodsCreator = goodsCreator;
        }
        [HttpGet("getTypes")]
        public string[] GetGoodTypes(string part)
        {
            return AppDomain.CurrentDomain.GetAssemblies()
                       .SelectMany(assembly => assembly.GetTypes())
                       .Where(type => type.IsSubclassOf(typeof(Good)) || type.IsEquivalentTo(typeof(Good)))
                       .Select(type => type.Name)
                       .Where(type => part == null || type.ToLower().Contains(part.ToLower()))
                       .Take(10)
                       .ToArray();
        }
        [HttpGet("getQuestions")]
        public QuestionsBase<string> GetGoodQuestions(string type)
        {
            return _goodsCreator.GetGoodQuestions(type);
        }
        [HttpGet("producerId")]
        public async Task<QuestionOption[]> GetProducerOptions(string part)
        {
            return await _context.Producers
                //.Where(producer => part == null || producer.Name.ToLower() == part.ToLower())
                .Select(producer => new QuestionOption() { Key = producer.Id.ToString(), Value = producer.Name })
                .Take(10)
                .ToArrayAsync();
        }
        [HttpGet("manufacturerId")]
        public async Task<QuestionOption[]> GetManufacturersOptions(string part)
        {
            return await _context.Manufacturers
                //.Where(manufacturer => part == null || manufacturer.Name.ToLower() == part.ToLower())
                .Select(manufacturer => new QuestionOption() { Key = manufacturer.Id.ToString(), Value = manufacturer.Name })
                .Take(10)
                .ToArrayAsync();
        }
        [HttpGet("material")]
        public async Task<QuestionOption[]> GetMaterialsOptions(string part)
        {
            return await _context.Materials
                //.Where(material => part == null || material.Name.ToLower() == part.ToLower())
                .Select(material => new QuestionOption() { Key = material.Value, Value = material.Value })
                .Take(10)
                .ToArrayAsync();
        }
        [HttpGet("color")]
        public async Task<QuestionOption[]> GetColorsOptions(string part)
        {
            return await _context.Colors
                //.Where(color => part == null || color.Value.ToLower() == part.ToLower())
                .Select(color => new QuestionOption() { Key = color.Value, Value = color.Value })
                .Take(10)
                .ToArrayAsync();
        }
        [HttpGet("cpuSocketType")]
        public async Task<QuestionOption[]> GetCPUSocketTypes(string part)
        {
            return await _context.CPUSocketTypes
                //.Where(color => part == null || color.Value.ToLower() == part.ToLower())
                .Select(cpuSocketType => new QuestionOption() { Key = cpuSocketType.Value, Value = cpuSocketType.Value })
                .Take(10)
                .ToArrayAsync();
        }
        [HttpGet("computerDriveTypes")]
        public async Task<QuestionOption[]> GetComputerDriveTypeIds(string part)
        {
            return await _context.ComputerDriveTypes
                //.Where(color => part == null || color.Value.ToLower() == part.ToLower())
                .Select(computerDriveType => new QuestionOption() { Key = computerDriveType.Value, Value = computerDriveType.Value })
                .Take(10)
                .ToArrayAsync();
        }
        [HttpGet("usbSpecificationType")]
        public async Task<QuestionOption[]> GetUSBSpecificationTypes(string part)
        {
            return await _context.USBSpecificationTypes
                //.Where(color => part == null || color.Value.ToLower() == part.ToLower())
                .Select(usbSpecificationType => new QuestionOption() { Key = usbSpecificationType.Value, Value = usbSpecificationType.Value })
                .Take(10)
                .ToArrayAsync();
        }
        [HttpGet("driveInterface")]
        public async Task<QuestionOption[]> GetDriveInterfaces(string part)
        {
            return await _context.DriveInterfaces
                //.Where(color => part == null || color.Value.ToLower() == part.ToLower())
                .Select(driveInterface => new QuestionOption() { Key = driveInterface.Value, Value = driveInterface.Value })
                .Take(10)
                .ToArrayAsync();
        }
        [HttpGet("coolerType")]
        public async Task<QuestionOption[]> GetCoolerTypes(string part)
        {
            return await _context.CoolerTypes
                //.Where(color => part == null || color.Value.ToLower() == part.ToLower())
                .Select(coolerType => new QuestionOption() { Key = coolerType.Value, Value = coolerType.Value })
                .Take(10)
                .ToArrayAsync();
        }
        [HttpGet("formFactorType")]
        public async Task<QuestionOption[]> GetFormFactorTypes(string part)
        {
            return await _context.FormFactorTypes
                //.Where(color => part == null || color.Value.ToLower() == part.ToLower())
                .Select(formFactorType => new QuestionOption() { Key = formFactorType.Value, Value = formFactorType.Value })
                .Take(10)
                .ToArrayAsync();
        }
        [HttpGet("mauseType")]
        public async Task<QuestionOption[]> GetMauseTypes(string part)
        {
            return await _context.MauseTypes
                //.Where(color => part == null || color.Value.ToLower() == part.ToLower())
                .Select(mauseType => new QuestionOption() { Key = mauseType.Value, Value = mauseType.Value })
                .Take(10)
                .ToArrayAsync();
        }
        [HttpGet("keyboardType")]
        public async Task<QuestionOption[]> GetKeyboardTypes(string part)
        {
            return await _context.KeySwitchTypes
                //.Where(color => part == null || color.Value.ToLower() == part.ToLower())
                .Select(keyboardType => new QuestionOption() { Key = keyboardType.Value, Value = keyboardType.Value })
                .Take(10)
                .ToArrayAsync();
        }
        [HttpGet("headphonesType")]
        public async Task<QuestionOption[]> GetHeadphonesTypes(string part)
        {
            return await _context.HeadphonesTypes
                //.Where(color => part == null || color.Value.ToLower() == part.ToLower())
                .Select(headphonesType => new QuestionOption() { Key = headphonesType.Value, Value = headphonesType.Value })
                .Take(10)
                .ToArrayAsync();
        }
        [HttpGet("wirelessType")]
        public async Task<QuestionOption[]> GetWirelessTypes(string part)
        {
            return await _context.WirelessTypes
                //.Where(color => part == null || color.Value.ToLower() == part.ToLower())
                .Select(wirelessType => new QuestionOption() { Key = wirelessType.Value, Value = wirelessType.Value })
                .Take(10)
                .ToArrayAsync();
        }
        [HttpGet("connectorType")]
        public async Task<QuestionOption[]> GetConnectorTypes(string part)
        {
            return await _context.ConnectorTypes
                //.Where(color => part == null || color.Value.ToLower() == part.ToLower())
                .Select(connectorType => new QuestionOption() { Key = connectorType.Value, Value = connectorType.Value })
                .Take(10)
                .ToArrayAsync();
        }



        [HttpPost("add-good")]
        public async Task<int> AddGood([FromBody] GoodModel goodModel)
        {
            return await _goodsCreator.AddGood(goodModel);
            //return 1;
        }
        [HttpPost("add-computer-technology")]
        public async Task<int> AddComputerTechnology([FromBody] ComputerTechnologyModel computerTechnologyModel)
        {
            return await _goodsCreator.AddComputerTechnology(computerTechnologyModel);
            //return 1;
        }
        [HttpPost("add-computer-part")]
        public async Task<int> AddComputerPart([FromBody] ComputerPartModel computerPartModel)
        {
            return await _goodsCreator.AddComputerPart(computerPartModel);
            //return 1;
        }
        [HttpPost("add-computer-accessory")]
        public async Task<int> AddComputerAccessory([FromBody] ComputerAccessoryModel computerAccessoryModel)
        {
            return await _goodsCreator.AddComputerAccessory(computerAccessoryModel);
            //return 1;
        }
        [HttpPost("add-computer")]
        public async Task<int> AddComputer([FromBody] ComputerModel computerModel)
        {
            return await _goodsCreator.AddComputer(computerModel);
            //return 1;
        }
        [HttpPost("add-laptop")]
        public async Task<int> AddLaptop([FromBody] LaptopModel laptopModel)
        {
            return await _goodsCreator.AddLaptop(laptopModel);
            //return 1;
        }
        [HttpPost("add-flash-drive")]
        public async Task<int> AddFlashDrive([FromBody] FlashDriveModel flashDriveModel)
        {
            return await _goodsCreator.AddFlashDrive(flashDriveModel);
            //return 1;
        }
        [HttpPost("add-video-card")]
        public async Task<int> AddVideoCard([FromBody] VideoCardModel videoCardModel)
        {
            return await _goodsCreator.AddVideoCard(videoCardModel);
            //return 1;
        }
        [HttpPost("add-cpu")]
        public async Task<int> AddCPU([FromBody] CPUModel cpuModel)
        {
            return await _goodsCreator.AddCPU(cpuModel);
            //return 1;
        }
        [HttpPost("add-cooler")]
        public async Task<int> AddCooler([FromBody] CoolerModel coolerModel)
        {
            return await _goodsCreator.AddCooler(coolerModel);
            //return 1;
        }
        [HttpPost("add-computer-drives")]
        public async Task<int> AddComputerDrive([FromBody] ComputerDriveModel computerDriveModel)
        {
            return await _goodsCreator.AddComputerDrive(computerDriveModel);
            //return 1;
        }
        [HttpPost("add-mause")]
        public async Task<int> AddMause([FromBody] MauseModel mauseModel)
        {
            return await _goodsCreator.AddMause(mauseModel);
            //return 1;
        }
        [HttpPost("add-keyboard")]
        public async Task<int> AddKeyboard([FromBody] KeyboardModel keyboardModel)
        {
            return await _goodsCreator.AddKeyboard(keyboardModel);
            //return 1;
        }
        [HttpPost("add-headphones")]
        public async Task<int> AddHeadphones([FromBody] HeadphonesModel headphonesModel)
        {
            return await _goodsCreator.AddHeadphones(headphonesModel);
            //return 1;
        }
    }
}
