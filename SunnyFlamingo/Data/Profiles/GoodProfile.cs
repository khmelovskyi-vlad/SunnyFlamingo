using AutoMapper;
using SunnyFlamingo.Entities;
using SunnyFlamingo.Entities.Goods;
using SunnyFlamingo.Entities.Goods.ComputerTechnologies;
using SunnyFlamingo.Entities.Goods.ComputerTechnologies.ComputerAccessories;
using SunnyFlamingo.Entities.Goods.ComputerTechnologies.ComputerParts;
using SunnyFlamingo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Data.Profiles
{
    public class GoodProfile : Profile
    {
        public GoodProfile()
        {
            CreateMap<Good, GoodInformation>()
                .ForMember(p => p.ImgIds,
                opt => opt.MapFrom(good => good.ImageInfo.Select(i => i.Id).ToList()))
                .ForMember(p => p.Type,
                opt => opt.MapFrom(good => good.GetType().Name))
                .ForMember(p => p.Producer,
                opt => opt.MapFrom(good => good.Producer.Name))
                .ForMember(p => p.Country,
                opt => opt.MapFrom(good => good.Manufacturer.Country.Value))
                .ForMember(p => p.Material,
                opt => opt.MapFrom(good => good.MaterialValue))
                .ForMember(p => p.Color,
                opt => opt.MapFrom(good => good.ColorValue));
            CreateMap<ComputerTechnology, GoodInformation>()
                .ForMember(p => p.ImgIds,
                opt => opt.MapFrom(computerTechnology => computerTechnology.ImageInfo.Select(i => i.Id).ToList()))
                .ForMember(p => p.Type,
                opt => opt.MapFrom(computerTechnology => computerTechnology.GetType().Name))
                .ForMember(p => p.Producer,
                opt => opt.MapFrom(computerTechnology => computerTechnology.Producer.Name))
                .ForMember(p => p.Country,
                opt => opt.MapFrom(computerTechnology => computerTechnology.Manufacturer.Country.Value))
                .ForMember(p => p.Material,
                opt => opt.MapFrom(computerTechnology => computerTechnology.MaterialValue))
                .ForMember(p => p.Color,
                opt => opt.MapFrom(computerTechnology => computerTechnology.ColorValue));
            CreateMap<ComputerPart, GoodInformation>()
                .ForMember(p => p.ImgIds,
                opt => opt.MapFrom(computerPart => computerPart.ImageInfo.Select(i => i.Id).ToList()))
                .ForMember(p => p.Type,
                opt => opt.MapFrom(computerPart => computerPart.GetType().Name))
                .ForMember(p => p.Producer,
                opt => opt.MapFrom(computerPart => computerPart.Producer.Name))
                .ForMember(p => p.Country,
                opt => opt.MapFrom(computerPart => computerPart.Manufacturer.Country.Value))
                .ForMember(p => p.Material,
                opt => opt.MapFrom(computerPart => computerPart.MaterialValue))
                .ForMember(p => p.Color,
                opt => opt.MapFrom(computerPart => computerPart.ColorValue));
            CreateMap<ComputerAccessory, GoodInformation>()
                .ForMember(p => p.ImgIds,
                opt => opt.MapFrom(computerAccessory => computerAccessory.ImageInfo.Select(i => i.Id).ToList()))
                .ForMember(p => p.Type,
                opt => opt.MapFrom(computerAccessory => computerAccessory.GetType().Name))
                .ForMember(p => p.Producer,
                opt => opt.MapFrom(computerAccessory => computerAccessory.Producer.Name))
                .ForMember(p => p.Country,
                opt => opt.MapFrom(computerAccessory => computerAccessory.Manufacturer.Country.Value))
                .ForMember(p => p.Material,
                opt => opt.MapFrom(computerAccessory => computerAccessory.MaterialValue))
                .ForMember(p => p.Color,
                opt => opt.MapFrom(computerAccessory => computerAccessory.ColorValue));
            CreateMap<FlashDrive, GoodInformation>()
                .ForMember(p => p.ImgIds,
                opt => opt.MapFrom(flashDrive => flashDrive.ImageInfo.Select(i => i.Id).ToList()))
                .ForMember(p => p.Type,
                opt => opt.MapFrom(flashDrive => flashDrive.GetType().Name))
                .ForMember(p => p.Producer,
                opt => opt.MapFrom(flashDrive => flashDrive.Producer.Name))
                .ForMember(p => p.Country,
                opt => opt.MapFrom(flashDrive => flashDrive.Manufacturer.Country.Value))
                .ForMember(p => p.Material,
                opt => opt.MapFrom(flashDrive => flashDrive.MaterialValue))
                .ForMember(p => p.Color,
                opt => opt.MapFrom(flashDrive => flashDrive.ColorValue))
                .ForMember(p => p.Properties,
                opt => opt.MapFrom(flashDrive => new PropertyModel[] { 
                    new PropertyModel("Capacity", flashDrive.Capacity.ToString()),
                    new PropertyModel("USB specification type", flashDrive.USBSpecificationTypeValue)
                }));
            CreateMap<Laptop, GoodInformation>()
                .ForMember(p => p.ImgIds,
                opt => opt.MapFrom(laptop => laptop.ImageInfo.Select(i => i.Id).ToList()))
                .ForMember(p => p.Type,
                opt => opt.MapFrom(laptop => laptop.GetType().Name))
                .ForMember(p => p.Producer,
                opt => opt.MapFrom(laptop => laptop.Producer.Name))
                .ForMember(p => p.Country,
                opt => opt.MapFrom(laptop => laptop.Manufacturer.Country.Value))
                .ForMember(p => p.Material,
                opt => opt.MapFrom(laptop => laptop.MaterialValue))
                .ForMember(p => p.Color,
                opt => opt.MapFrom(laptop => laptop.ColorValue))
                .ForMember(p => p.Properties,
                opt => opt.MapFrom(laptop => new PropertyModel[] {
                    new PropertyModel("Amount of RAM", laptop.AmountOfRAM.ToString()),
                    new PropertyModel("CPU frequency", laptop.CPUFrequency.ToString()),
                    new PropertyModel("Length", laptop.Length.ToString()),
                    new PropertyModel("Height", laptop.Height.ToString()),
                    new PropertyModel("Width", laptop.Width.ToString()),
                    new PropertyModel("Have floppy drives", laptop.HaveFloppyDrives.ToString()),
                    new PropertyModel("SSD memory", laptop.SSDMemory.ToString()),
                    new PropertyModel("Hard disk memory", laptop.HardDiskMemory.ToString()),
                    new PropertyModel("CPU socket type", laptop.CPUSocketTypeValue),
                    new PropertyModel("Number of cores", laptop.NumberOfCores.ToString()),
                    new PropertyModel("Floppy drives count", laptop.FloppyDrivesCount.ToString()),
                    new PropertyModel("Display", laptop.Display.ToString()),
                }))
                .ForMember(p => p.PropertyLists,
                opt => opt.MapFrom(laptop => new PropertyListModel[]
                {
                    new PropertyListModel("Laptop computer drive types", laptop.LaptopComputerDriveTypes.Select(lcdt => lcdt.ComputerDriveTypeValue).ToList())
                }));
            CreateMap<Computer, GoodInformation>()
                .ForMember(p => p.ImgIds,
                opt => opt.MapFrom(computer => computer.ImageInfo.Select(i => i.Id).ToList()))
                .ForMember(p => p.Type,
                opt => opt.MapFrom(computer => computer.GetType().Name))
                .ForMember(p => p.Producer,
                opt => opt.MapFrom(computer => computer.Producer.Name))
                .ForMember(p => p.Country,
                opt => opt.MapFrom(computer => computer.Manufacturer.Country.Value))
                .ForMember(p => p.Material,
                opt => opt.MapFrom(computer => computer.MaterialValue))
                .ForMember(p => p.Color,
                opt => opt.MapFrom(computer => computer.ColorValue))
                .ForMember(p => p.Properties,
                opt => opt.MapFrom(computer => new PropertyModel[] {
                    new PropertyModel("Amount of RAM", computer.AmountOfRAM.ToString()),
                    new PropertyModel("CPU frequency", computer.CPUFrequency.ToString()),
                    new PropertyModel("Length", computer.Length.ToString()),
                    new PropertyModel("Height", computer.Height.ToString()),
                    new PropertyModel("Width", computer.Width.ToString()),
                    new PropertyModel("Have floppy drives", computer.HaveFloppyDrives.ToString()),
                    new PropertyModel("SSD memory", computer.SSDMemory.ToString()),
                    new PropertyModel("Hard disk memory", computer.HardDiskMemory.ToString()),
                    new PropertyModel("CPU socket type", computer.CPUSocketTypeValue),
                    new PropertyModel("Number of cores", computer.NumberOfCores.ToString()),
                    new PropertyModel("Floppy drives count", computer.FloppyDrivesCount.ToString()),
                }))
                .ForMember(p => p.PropertyLists,
                opt => opt.MapFrom(computer => new PropertyListModel[]
                {
                    new PropertyListModel("Computer computer drive types", computer.ComputerComputerDriveTypes.Select(lcdt => lcdt.ComputerDriveTypeValue).ToList())
                }));
            CreateMap<VideoCard, GoodInformation>()
                .ForMember(p => p.ImgIds,
                opt => opt.MapFrom(videoCard => videoCard.ImageInfo.Select(i => i.Id).ToList()))
                .ForMember(p => p.Type,
                opt => opt.MapFrom(videoCard => videoCard.GetType().Name))
                .ForMember(p => p.Producer,
                opt => opt.MapFrom(videoCard => videoCard.Producer.Name))
                .ForMember(p => p.Country,
                opt => opt.MapFrom(videoCard => videoCard.Manufacturer.Country.Value))
                .ForMember(p => p.Material,
                opt => opt.MapFrom(videoCard => videoCard.MaterialValue))
                .ForMember(p => p.Color,
                opt => opt.MapFrom(videoCard => videoCard.ColorValue))
                .ForMember(p => p.Properties,
                opt => opt.MapFrom(videoCard => new PropertyModel[] {
                    new PropertyModel("Video size", videoCard.VideoSize.ToString()),
                    new PropertyModel("Drive interface", videoCard.DriveInterfaceValue),
                    new PropertyModel("Video memory capacity", videoCard.VideoMemoryCapacity.ToString()),
                }));
            CreateMap<CPU, GoodInformation>()
                .ForMember(p => p.ImgIds,
                opt => opt.MapFrom(cpu => cpu.ImageInfo.Select(i => i.Id).ToList()))
                .ForMember(p => p.Type,
                opt => opt.MapFrom(cpu => cpu.GetType().Name))
                .ForMember(p => p.Producer,
                opt => opt.MapFrom(cpu => cpu.Producer.Name))
                .ForMember(p => p.Country,
                opt => opt.MapFrom(cpu => cpu.Manufacturer.Country.Value))
                .ForMember(p => p.Material,
                opt => opt.MapFrom(cpu => cpu.MaterialValue))
                .ForMember(p => p.Color,
                opt => opt.MapFrom(cpu => cpu.ColorValue))
                .ForMember(p => p.Properties,
                opt => opt.MapFrom(cpu => new PropertyModel[] {
                    new PropertyModel("CPU socket type", cpu.CPUSocketTypeValue),
                    new PropertyModel("Thermal design power", cpu.ThermalDesignPower.ToString()),
                    new PropertyModel("Number of cores", cpu.NumberOfCores.ToString()),
                    new PropertyModel("Number of threads", cpu.NumberOfThreads.ToString()),
                }));
            CreateMap<Cooler, GoodInformation>()
                .ForMember(p => p.ImgIds,
                opt => opt.MapFrom(cooler => cooler.ImageInfo.Select(i => i.Id).ToList()))
                .ForMember(p => p.Type,
                opt => opt.MapFrom(cooler => cooler.GetType().Name))
                .ForMember(p => p.Producer,
                opt => opt.MapFrom(cooler => cooler.Producer.Name))
                .ForMember(p => p.Country,
                opt => opt.MapFrom(cooler => cooler.Manufacturer.Country.Value))
                .ForMember(p => p.Material,
                opt => opt.MapFrom(cooler => cooler.MaterialValue))
                .ForMember(p => p.Color,
                opt => opt.MapFrom(cooler => cooler.ColorValue))
                .ForMember(p => p.Properties,
                opt => opt.MapFrom(cooler => new PropertyModel[] {
                    new PropertyModel("Type", cooler.TypeValue),
                    new PropertyModel("Fan size", cooler.FanSize.ToString()),
                }));
            CreateMap<ComputerDrive, GoodInformation>()
                .ForMember(p => p.ImgIds,
                opt => opt.MapFrom(computerDrive => computerDrive.ImageInfo.Select(i => i.Id).ToList()))
                .ForMember(p => p.Type,
                opt => opt.MapFrom(computerDrive => computerDrive.GetType().Name))
                .ForMember(p => p.Producer,
                opt => opt.MapFrom(computerDrive => computerDrive.Producer.Name))
                .ForMember(p => p.Country,
                opt => opt.MapFrom(computerDrive => computerDrive.Manufacturer.Country.Value))
                .ForMember(p => p.Material,
                opt => opt.MapFrom(computerDrive => computerDrive.MaterialValue))
                .ForMember(p => p.Color,
                opt => opt.MapFrom(computerDrive => computerDrive.ColorValue))
                .ForMember(p => p.Properties,
                opt => opt.MapFrom(computerDrive => new PropertyModel[] {
                    new PropertyModel("Capacity", computerDrive.Capacity.ToString()),
                    new PropertyModel("Type", computerDrive.TypeValue),
                    new PropertyModel("Form factor type", computerDrive.FormFactorTypeValue),
                }));
            CreateMap<Mause, GoodInformation>()
                .ForMember(p => p.ImgIds,
                opt => opt.MapFrom(mause => mause.ImageInfo.Select(i => i.Id).ToList()))
                .ForMember(p => p.Type,
                opt => opt.MapFrom(mause => mause.GetType().Name))
                .ForMember(p => p.Producer,
                opt => opt.MapFrom(mause => mause.Producer.Name))
                .ForMember(p => p.Country,
                opt => opt.MapFrom(mause => mause.Manufacturer.Country.Value))
                .ForMember(p => p.Material,
                opt => opt.MapFrom(mause => mause.MaterialValue))
                .ForMember(p => p.Color,
                opt => opt.MapFrom(mause => mause.ColorValue))
                .ForMember(p => p.Properties,
                opt => opt.MapFrom(mause => new PropertyModel[] {
                    new PropertyModel("Type", mause.TypeValue),
                    new PropertyModel("Buttons count", mause.ButtonsCount.ToString()),
                }));
            CreateMap<Keyboard, GoodInformation>()
                .ForMember(p => p.ImgIds,
                opt => opt.MapFrom(keyboard => keyboard.ImageInfo.Select(i => i.Id).ToList()))
                .ForMember(p => p.Type,
                opt => opt.MapFrom(keyboard => keyboard.GetType().Name))
                .ForMember(p => p.Producer,
                opt => opt.MapFrom(keyboard => keyboard.Producer.Name))
                .ForMember(p => p.Country,
                opt => opt.MapFrom(keyboard => keyboard.Manufacturer.Country.Value))
                .ForMember(p => p.Material,
                opt => opt.MapFrom(keyboard => keyboard.MaterialValue))
                .ForMember(p => p.Color,
                opt => opt.MapFrom(keyboard => keyboard.ColorValue))
                .ForMember(p => p.Properties,
                opt => opt.MapFrom(keyboard => new PropertyModel[] {
                    new PropertyModel("Type", keyboard.TypeValue),
                }));
            CreateMap<Headphones, GoodInformation>()
                .ForMember(p => p.ImgIds,
                opt => opt.MapFrom(headphones => headphones.ImageInfo.Select(i => i.Id).ToList()))
                .ForMember(p => p.Type,
                opt => opt.MapFrom(headphones => headphones.GetType().Name))
                .ForMember(p => p.Producer,
                opt => opt.MapFrom(headphones => headphones.Producer.Name))
                .ForMember(p => p.Country,
                opt => opt.MapFrom(headphones => headphones.Manufacturer.Country.Value))
                .ForMember(p => p.Material,
                opt => opt.MapFrom(headphones => headphones.MaterialValue))
                .ForMember(p => p.Color,
                opt => opt.MapFrom(headphones => headphones.ColorValue))
                .ForMember(p => p.Properties,
                opt => opt.MapFrom(headphones => new PropertyModel[] {
                    new PropertyModel("Type", headphones.TypeValue),
                    new PropertyModel("Wireless type", headphones.WirelessTypeValue),
                    new PropertyModel("Connector type", headphones.ConnectorTypeValue),
                }));
        }
    }
}
