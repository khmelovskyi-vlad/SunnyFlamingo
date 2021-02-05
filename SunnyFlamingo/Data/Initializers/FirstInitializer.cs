using Microsoft.EntityFrameworkCore;
using SunnyFlamingo.Entities;
using SunnyFlamingo.Entities.Goods;
using SunnyFlamingo.Entities.Goods.ComputerTechnologies;
using SunnyFlamingo.Entities.Goods.ComputerTechnologies.ComputerAccessories;
using SunnyFlamingo.Entities.Goods.ComputerTechnologies.ComputerParts;
using SunnyFlamingo.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunnyFlamingo.Data.Initializers
{
    public class FirstInitializer : IInitializer
    {
        public void Run(ModelBuilder modelBuilder)
        {
            var random = new Random();

            var countries = GetCountries();
            var materials = GetMaterials();
            var colors = GetColors();
            var USBSpecificationTypes = GetUSBSpecificationTypes();
            var driveInterfaces = GetDriveInterfaces();
            var coolerTypes = GetCoolerTypes();
            var formFactorTypes = GetFormFactorTypes();
            var connectorTypes = GetConnectorTypes();
            var manufacturers = GetManufacturers(random, countries);
            var producers = GetProducers(random, countries);

            modelBuilder.Entity<Country>().HasData(countries);
            modelBuilder.Entity<Color>().HasData(colors);
            modelBuilder.Entity<Material>().HasData(materials);
            modelBuilder.Entity<ConnectorType>().HasData(connectorTypes);
            modelBuilder.Entity<CoolerType>().HasData(coolerTypes);
            modelBuilder.Entity<DriveInterface>().HasData(driveInterfaces);
            modelBuilder.Entity<FormFactorType>().HasData(formFactorTypes);
            modelBuilder.Entity<USBSpecificationType>().HasData(USBSpecificationTypes);
            modelBuilder.Entity<Manufacturer>().HasData(manufacturers);
            modelBuilder.Entity<Producer>().HasData(producers);

            modelBuilder.Entity<Good>().HasData(GetGoods(random, colors, materials, manufacturers, producers));
            modelBuilder.Entity<ComputerTechnology>().HasData(GetComputerTechnologies(random, colors, materials, manufacturers, producers));
            modelBuilder.Entity<Laptop>().HasData(GetLaptops(random, colors, materials, manufacturers, producers));
            modelBuilder.Entity<FlashDrive>().HasData(GetFlashDrives(random, colors, materials, manufacturers, producers, USBSpecificationTypes));
            modelBuilder.Entity<ComputerPart>().HasData(GetComputerParts(random, colors, materials, manufacturers, producers));
            modelBuilder.Entity<ComputerAccessory>().HasData(GetComputerAccessories(random, colors, materials, manufacturers, producers));
            modelBuilder.Entity<Computer>().HasData(GetComputers(random, colors, materials, manufacturers, producers));
            modelBuilder.Entity<VideoCard>().HasData(GetVideoCards(random, colors, materials, manufacturers, producers, driveInterfaces));
            modelBuilder.Entity<CPU>().HasData(GetCPUs(random, colors, materials, manufacturers, producers));
            modelBuilder.Entity<Cooler>().HasData(GetCoolers(random, colors, materials, manufacturers, producers, coolerTypes));
            modelBuilder.Entity<ComputerDrive>().HasData(GetComputerDrives(random, colors, materials, manufacturers, producers, formFactorTypes));
            modelBuilder.Entity<Mause>().HasData(GetMice(random, colors, materials, manufacturers, producers));
            modelBuilder.Entity<Keyboard>().HasData(GetKeyboards(random, colors, materials, manufacturers, producers));
            modelBuilder.Entity<Headphones>().HasData(GetHeadphones(random, colors, materials, manufacturers, producers, connectorTypes));
        }
        private List<Headphones> GetHeadphones(
            Random random,
            List<Color> colors,
            List<Material> materials,
            List<Manufacturer> manufacturers,
            List<Producer> producers,
            List<ConnectorType> connectorTypes
            )
        {
            List<Headphones> headphonesList = new List<Headphones>();
            for (int i = 0; i < 50; i++)
            {
                var headphones = new Headphones()
                {
                    Id = Guid.NewGuid(),
                    AddTime = DateTime.Now,
                    ColorValue = colors[random.Next(0, colors.Count())].Value,
                    Description = CreateRandomString(10, 1000, "abcdefghijklmnopqrstuvwxyz        ", random),
                    IsAvailable = true,
                    MaterialValue = materials[random.Next(0, materials.Count())].Value,
                    Name = CreateRandomString(10, 100, "abcdefghijklmnopqrstuvwxyz        ", random),
                    Price = CreateRandomDecimal(random),
                    ManufacturerId = manufacturers[random.Next(0, manufacturers.Count())].Id,
                    ProducerId = producers[random.Next(0, producers.Count())].Id,
                    Type = (HeadphonesType)random.Next(0, Enum.GetNames(typeof(HeadphonesType)).Length),
                    WirelessType = (WirelessType)random.Next(0, Enum.GetNames(typeof(WirelessType)).Length),
                    ConnectorTypeValue = connectorTypes[random.Next(0, connectorTypes.Count())].Value,
                };
                headphonesList.Add(headphones);
            }
            return headphonesList;
        }
        private List<Keyboard> GetKeyboards(
            Random random,
            List<Color> colors,
            List<Material> materials,
            List<Manufacturer> manufacturers,
            List<Producer> producers
            )
        {
            List<Keyboard> keyboards = new List<Keyboard>();
            for (int i = 0; i < 50; i++)
            {
                var keyboard = new Keyboard()
                {
                    Id = Guid.NewGuid(),
                    AddTime = DateTime.Now,
                    ColorValue = colors[random.Next(0, colors.Count())].Value,
                    Description = CreateRandomString(10, 1000, "abcdefghijklmnopqrstuvwxyz        ", random),
                    IsAvailable = true,
                    MaterialValue = materials[random.Next(0, materials.Count())].Value,
                    Name = CreateRandomString(10, 100, "abcdefghijklmnopqrstuvwxyz        ", random),
                    Price = CreateRandomDecimal(random),
                    ManufacturerId = manufacturers[random.Next(0, manufacturers.Count())].Id,
                    ProducerId = producers[random.Next(0, producers.Count())].Id,
                    Type = (KeySwitchType)random.Next(0, Enum.GetNames(typeof(KeySwitchType)).Length),
                };
                keyboards.Add(keyboard);
            }
            return keyboards;
        }
        private List<Mause> GetMice(
            Random random,
            List<Color> colors,
            List<Material> materials,
            List<Manufacturer> manufacturers,
            List<Producer> producers
            )
        {
            List<Mause> mice = new List<Mause>();
            for (int i = 0; i < 50; i++)
            {
                var mause = new Mause()
                {
                    Id = Guid.NewGuid(),
                    AddTime = DateTime.Now,
                    ColorValue = colors[random.Next(0, colors.Count())].Value,
                    Description = CreateRandomString(10, 1000, "abcdefghijklmnopqrstuvwxyz        ", random),
                    IsAvailable = true,
                    MaterialValue = materials[random.Next(0, materials.Count())].Value,
                    Name = CreateRandomString(10, 100, "abcdefghijklmnopqrstuvwxyz        ", random),
                    Price = CreateRandomDecimal(random),
                    ManufacturerId = manufacturers[random.Next(0, manufacturers.Count())].Id,
                    ProducerId = producers[random.Next(0, producers.Count())].Id,
                    ButtonsCount = random.Next(1000, 40000),
                    Type = (MauseType)random.Next(0, Enum.GetNames(typeof(MauseType)).Length),
                };
                mice.Add(mause);
            }
            return mice;
        }
        private List<ComputerDrive> GetComputerDrives(
            Random random,
            List<Color> colors,
            List<Material> materials,
            List<Manufacturer> manufacturers,
            List<Producer> producers,
            List<FormFactorType> formFactorTypes
            )
        {
            List<ComputerDrive> computerDrives = new List<ComputerDrive>();
            for (int i = 0; i < 50; i++)
            {
                var computerDrive = new ComputerDrive()
                {
                    Id = Guid.NewGuid(),
                    AddTime = DateTime.Now,
                    ColorValue = colors[random.Next(0, colors.Count())].Value,
                    Description = CreateRandomString(10, 1000, "abcdefghijklmnopqrstuvwxyz        ", random),
                    IsAvailable = true,
                    MaterialValue = materials[random.Next(0, materials.Count())].Value,
                    Name = CreateRandomString(10, 100, "abcdefghijklmnopqrstuvwxyz        ", random),
                    Price = CreateRandomDecimal(random),
                    ManufacturerId = manufacturers[random.Next(0, manufacturers.Count())].Id,
                    ProducerId = producers[random.Next(0, producers.Count())].Id,
                    Capacity = random.Next(1000, 40000),
                    Type = (ComputerDriveType)random.Next(0, Enum.GetNames(typeof(ComputerDriveType)).Length),
                    FormFactorTypeValue = formFactorTypes[random.Next(0, formFactorTypes.Count())].Value,
                };
                computerDrives.Add(computerDrive);
            }
            return computerDrives;
        }
        private List<Cooler> GetCoolers(
            Random random,
            List<Color> colors,
            List<Material> materials,
            List<Manufacturer> manufacturers,
            List<Producer> producers,
            List<CoolerType> coolerTypes
            )
        {
            List<Cooler> coolers = new List<Cooler>();
            for (int i = 0; i < 50; i++)
            {
                var cooler = new Cooler()
                {
                    Id = Guid.NewGuid(),
                    AddTime = DateTime.Now,
                    ColorValue = colors[random.Next(0, colors.Count())].Value,
                    Description = CreateRandomString(10, 1000, "abcdefghijklmnopqrstuvwxyz        ", random),
                    IsAvailable = true,
                    MaterialValue = materials[random.Next(0, materials.Count())].Value,
                    Name = CreateRandomString(10, 100, "abcdefghijklmnopqrstuvwxyz        ", random),
                    Price = CreateRandomDecimal(random),
                    ManufacturerId = manufacturers[random.Next(0, manufacturers.Count())].Id,
                    ProducerId = producers[random.Next(0, producers.Count())].Id,
                    TypeValue = coolerTypes[random.Next(0, coolerTypes.Count())].Value,
                    FanSize = random.Next(1000, 40000),
                };
                coolers.Add(cooler);
            }
            return coolers;
        }
        private List<CPU> GetCPUs(
            Random random,
            List<Color> colors,
            List<Material> materials,
            List<Manufacturer> manufacturers,
            List<Producer> producers
            )
        {
            List<CPU> CPUs = new List<CPU>();
            for (int i = 0; i < 50; i++)
            {
                var CPU = new CPU()
                {
                    Id = Guid.NewGuid(),
                    AddTime = DateTime.Now,
                    ColorValue = colors[random.Next(0, colors.Count())].Value,
                    Description = CreateRandomString(10, 1000, "abcdefghijklmnopqrstuvwxyz        ", random),
                    IsAvailable = true,
                    MaterialValue = materials[random.Next(0, materials.Count())].Value,
                    Name = CreateRandomString(10, 100, "abcdefghijklmnopqrstuvwxyz        ", random),
                    Price = CreateRandomDecimal(random),
                    ManufacturerId = manufacturers[random.Next(0, manufacturers.Count())].Id,
                    ProducerId = producers[random.Next(0, producers.Count())].Id,
                    CPUSocketType = (CPUSocketType)random.Next(0, Enum.GetNames(typeof(CPUSocketType)).Length),
                    ThermalDesignPower = random.Next(1000, 40000),
                    NumberOfCores = random.Next(1000, 40000),
                    NumberOfThreads = random.Next(1000, 40000),
                };
                CPUs.Add(CPU);
            }
            return CPUs;
        }
        private List<VideoCard> GetVideoCards(
            Random random,
            List<Color> colors,
            List<Material> materials,
            List<Manufacturer> manufacturers,
            List<Producer> producers,
            List<DriveInterface> driveInterfaces
            )
        {
            List<VideoCard> videoCards = new List<VideoCard>();
            for (int i = 0; i < 50; i++)
            {
                var videoCard = new VideoCard()
                {
                    Id = Guid.NewGuid(),
                    AddTime = DateTime.Now,
                    ColorValue = colors[random.Next(0, colors.Count())].Value,
                    Description = CreateRandomString(10, 1000, "abcdefghijklmnopqrstuvwxyz        ", random),
                    IsAvailable = true,
                    MaterialValue = materials[random.Next(0, materials.Count())].Value,
                    Name = CreateRandomString(10, 100, "abcdefghijklmnopqrstuvwxyz        ", random),
                    Price = CreateRandomDecimal(random),
                    ManufacturerId = manufacturers[random.Next(0, manufacturers.Count())].Id,
                    ProducerId = producers[random.Next(0, producers.Count())].Id,
                    VideoSize = random.Next(1000, 40000),
                    DriveInterfaceValue = driveInterfaces[random.Next(0, driveInterfaces.Count())].Value,
                    VideoMemoryCapacity = random.Next(1000, 40000),
                };
                videoCards.Add(videoCard);
            }
            return videoCards;
        }
        private List<ComputerAccessory> GetComputerAccessories(
            Random random,
            List<Color> colors,
            List<Material> materials,
            List<Manufacturer> manufacturers,
            List<Producer> producers
            )
        {
            List<ComputerAccessory> computerAccessories = new List<ComputerAccessory>();
            for (int i = 0; i < 50; i++)
            {
                var computerAccessory = new ComputerAccessory()
                {
                    Id = Guid.NewGuid(),
                    AddTime = DateTime.Now,
                    ColorValue = colors[random.Next(0, colors.Count())].Value,
                    Description = CreateRandomString(10, 1000, "abcdefghijklmnopqrstuvwxyz        ", random),
                    IsAvailable = true,
                    MaterialValue = materials[random.Next(0, materials.Count())].Value,
                    Name = CreateRandomString(10, 100, "abcdefghijklmnopqrstuvwxyz        ", random),
                    Price = CreateRandomDecimal(random),
                    ManufacturerId = manufacturers[random.Next(0, manufacturers.Count())].Id,
                    ProducerId = producers[random.Next(0, producers.Count())].Id,
                };
                computerAccessories.Add(computerAccessory);
            }
            return computerAccessories;
        }
        private List<ComputerPart> GetComputerParts(
            Random random,
            List<Color> colors,
            List<Material> materials,
            List<Manufacturer> manufacturers,
            List<Producer> producers
            )
        {
            List<ComputerPart> computerParts = new List<ComputerPart>();
            for (int i = 0; i < 50; i++)
            {
                var computerPart = new ComputerPart()
                {
                    Id = Guid.NewGuid(),
                    AddTime = DateTime.Now,
                    ColorValue = colors[random.Next(0, colors.Count())].Value,
                    Description = CreateRandomString(10, 1000, "abcdefghijklmnopqrstuvwxyz        ", random),
                    IsAvailable = true,
                    MaterialValue = materials[random.Next(0, materials.Count())].Value,
                    Name = CreateRandomString(10, 100, "abcdefghijklmnopqrstuvwxyz        ", random),
                    Price = CreateRandomDecimal(random),
                    ManufacturerId = manufacturers[random.Next(0, manufacturers.Count())].Id,
                    ProducerId = producers[random.Next(0, producers.Count())].Id,
                };
                computerParts.Add(computerPart);
            }
            return computerParts;
        }
        private List<FlashDrive> GetFlashDrives(
            Random random,
            List<Color> colors,
            List<Material> materials,
            List<Manufacturer> manufacturers,
            List<Producer> producers,
            List<USBSpecificationType> USBSpecificationTypes
            )
        {
            List<FlashDrive> flashDrives = new List<FlashDrive>();
            for (int i = 0; i < 50; i++)
            {
                var flashDrive = new FlashDrive()
                {
                    Id = Guid.NewGuid(),
                    AddTime = DateTime.Now,
                    ColorValue = colors[random.Next(0, colors.Count())].Value,
                    Description = CreateRandomString(10, 1000, "abcdefghijklmnopqrstuvwxyz        ", random),
                    IsAvailable = true,
                    MaterialValue = materials[random.Next(0, materials.Count())].Value,
                    Name = CreateRandomString(10, 100, "abcdefghijklmnopqrstuvwxyz        ", random),
                    Price = CreateRandomDecimal(random),
                    ManufacturerId = manufacturers[random.Next(0, manufacturers.Count())].Id,
                    ProducerId = producers[random.Next(0, producers.Count())].Id,
                    Capacity = random.Next(1, 32),
                    USBSpecificationTypeValue = USBSpecificationTypes[random.Next(0, USBSpecificationTypes.Count())].Value,
                };
                flashDrives.Add(flashDrive);
            }
            return flashDrives;
        }
        private List<Computer> GetComputers(
            Random random,
            List<Color> colors,
            List<Material> materials,
            List<Manufacturer> manufacturers,
            List<Producer> producers
            )
        {
            List<Computer> computers = new List<Computer>();
            for (int i = 0; i < 50; i++)
            {
                var haveFloppyDrives = CreateRandomBool(random);
                var computer = new Computer()
                {
                    Id = Guid.NewGuid(),
                    AddTime = DateTime.Now,
                    ColorValue = colors[random.Next(0, colors.Count())].Value,
                    Description = CreateRandomString(10, 1000, "abcdefghijklmnopqrstuvwxyz        ", random),
                    IsAvailable = true,
                    MaterialValue = materials[random.Next(0, materials.Count())].Value,
                    Name = CreateRandomString(10, 100, "abcdefghijklmnopqrstuvwxyz        ", random),
                    Price = CreateRandomDecimal(random),
                    ManufacturerId = manufacturers[random.Next(0, manufacturers.Count())].Id,
                    ProducerId = producers[random.Next(0, producers.Count())].Id,
                    AmountOfRAM = random.Next(1, 32),
                    CPUFrequency = random.Next(1, 32),
                    Length = random.Next(1, 32),
                    Height = random.Next(1, 32),
                    Width = random.Next(1, 32),
                    HaveFloppyDrives = haveFloppyDrives,
                    SSDMemory = random.Next(1000, 3200),
                    HardDiskMemory = random.Next(1, 32),
                    CPUSocketType = (CPUSocketType)random.Next(0, Enum.GetNames(typeof(CPUSocketType)).Length),
                    ComputerDriveType = (ComputerDriveType)random.Next(0, Enum.GetNames(typeof(ComputerDriveType)).Length),
                    NumberOfCores = random.Next(1, 32),
                    FloppyDrivesCount = CreateRandomNullInt(1, 32, haveFloppyDrives, random),
                };
                computers.Add(computer);
            }
            return computers;
        }
        private List<Laptop> GetLaptops(
            Random random,
            List<Color> colors,
            List<Material> materials,
            List<Manufacturer> manufacturers,
            List<Producer> producers
            )
        {
            List<Laptop> laptops = new List<Laptop>();
            for (int i = 0; i < 50; i++)
            {
                var haveFloppyDrives = CreateRandomBool(random);
                var laptop = new Laptop()
                {
                    Id = Guid.NewGuid(),
                    AddTime = DateTime.Now,
                    ColorValue = colors[random.Next(0, colors.Count())].Value,
                    Description = CreateRandomString(10, 1000, "abcdefghijklmnopqrstuvwxyz        ", random),
                    IsAvailable = true,
                    MaterialValue = materials[random.Next(0, materials.Count())].Value,
                    Name = CreateRandomString(10, 100, "abcdefghijklmnopqrstuvwxyz        ", random),
                    Price = CreateRandomDecimal(random),
                    ManufacturerId = manufacturers[random.Next(0, manufacturers.Count())].Id,
                    ProducerId = producers[random.Next(0, producers.Count())].Id,
                    AmountOfRAM = random.Next(1, 32),
                    CPUFrequency = random.Next(1, 32),
                    Length = random.Next(1, 32),
                    Height = random.Next(1, 32),
                    Width = random.Next(1, 32),
                    HaveFloppyDrives = haveFloppyDrives,
                    SSDMemory = random.Next(1000, 3200),
                    HardDiskMemory = random.Next(1, 32),
                    CPUSocketType = (CPUSocketType)random.Next(0, Enum.GetNames(typeof(CPUSocketType)).Length),
                    ComputerDriveType = (ComputerDriveType)random.Next(0, Enum.GetNames(typeof(ComputerDriveType)).Length),
                    NumberOfCores = random.Next(1, 32),
                    FloppyDrivesCount = CreateRandomNullInt(1, 32, haveFloppyDrives, random),
                    Display = random.Next(1, 32),
                };
                laptops.Add(laptop);
            }
            return laptops;
        }
        private List<ComputerTechnology> GetComputerTechnologies(
            Random random,
            List<Color> colors,
            List<Material> materials,
            List<Manufacturer> manufacturers,
            List<Producer> producers
            )
        {
            List<ComputerTechnology> computerTechnologies = new List<ComputerTechnology>();
            for (int i = 0; i < 50; i++)
            {
                var computerTechnology = new ComputerTechnology()
                {
                    Id = Guid.NewGuid(),
                    AddTime = DateTime.Now,
                    ColorValue = colors[random.Next(0, colors.Count())].Value,
                    Description = CreateRandomString(10, 1000, "abcdefghijklmnopqrstuvwxyz        ", random),
                    IsAvailable = true,
                    MaterialValue = materials[random.Next(0, materials.Count())].Value,
                    Name = CreateRandomString(10, 100, "abcdefghijklmnopqrstuvwxyz        ", random),
                    Price = CreateRandomDecimal(random),
                    ManufacturerId = manufacturers[random.Next(0, manufacturers.Count())].Id,
                    ProducerId = producers[random.Next(0, producers.Count())].Id,
                };
                computerTechnologies.Add(computerTechnology);
            }
            return computerTechnologies;
        }
        private List<Good> GetGoods(
            Random random, 
            List<Color> colors, 
            List<Material> materials, 
            List<Manufacturer> manufacturers,
            List<Producer> producers
            )
        {
            List<Good> goods = new List<Good>();
            for (int i = 0; i < 100; i++)
            {
                var good = new Good() 
                { 
                    Id = Guid.NewGuid(),
                    Name = CreateRandomString(10, 100, "abcdefghijklmnopqrstuvwxyz        ", random),
                    Price = CreateRandomDecimal(random),
                    IsAvailable = true,
                    Description = CreateRandomString(10, 1000, "abcdefghijklmnopqrstuvwxyz        ", random),
                    AddTime = DateTime.Now,
                    ProducerId = producers[random.Next(0, producers.Count())].Id,
                    ManufacturerId = manufacturers[random.Next(0, manufacturers.Count())].Id,
                    MaterialValue = materials[random.Next(0, materials.Count())].Value,
                    ColorValue = colors[random.Next(0, colors.Count())].Value,
                };
                goods.Add(good);
            }
            return goods;
        }
        private List<Manufacturer> GetManufacturers(Random random, List<Country> countries)
        {
            List<Manufacturer> manufacturers = new List<Manufacturer>();
            for (int i = 0; i < 100; i++)
            {
                manufacturers.Add(new Manufacturer()
                {
                    Id = Guid.NewGuid(),
                    Address = CreateRandomString(10, 100, "abcdefghijklmnopqrstuvwxyz        ", random),
                    Name = CreateRandomString(10, 1000, "abcdefghijklmnopqrstuvwxyz        ", random),
                    CountryId = countries[random.Next(0, countries.Count())].Id
                });
            }
            return manufacturers;
        }
        private List<Producer> GetProducers(Random random, List<Country> countries)
        {
            List<Producer> producers = new List<Producer>();
            for (int i = 0; i < 100; i++)
            {
                producers.Add(new Producer()
                {
                    Id = Guid.NewGuid(),
                    Address = CreateRandomString(10, 100, "abcdefghijklmnopqrstuvwxyz        ", random),
                    Name = CreateRandomString(10, 1000, "abcdefghijklmnopqrstuvwxyz        ", random),
                    CountryId = countries[random.Next(0, countries.Count())].Id
                });
            }
            return producers;
        }
        private List<Country> GetCountries()
        {
            List<Country> countries = new List<Country>()
            {
                new Country() { Id = Guid.NewGuid(), Value = "Ukraine" },
                new Country() { Id = Guid.NewGuid(), Value = "Germany" },
                new Country() { Id = Guid.NewGuid(), Value = "Great Britain" },
                new Country() { Id = Guid.NewGuid(), Value = "Poland" },
                new Country() { Id = Guid.NewGuid(), Value = "France" },
                new Country() { Id = Guid.NewGuid(), Value = "Czech Republic" },
                new Country() { Id = Guid.NewGuid(), Value = "Australia" },
                new Country() { Id = Guid.NewGuid(), Value = "USA" },
                new Country() { Id = Guid.NewGuid(), Value = "Canada" },
                new Country() { Id = Guid.NewGuid(), Value = "Brazil" },
                new Country() { Id = Guid.NewGuid(), Value = "India" },
                new Country() { Id = Guid.NewGuid(), Value = "China" },
                new Country() { Id = Guid.NewGuid(), Value = "Japonia" },
            };
            return countries;
        }
        private List<Color> GetColors()
        {
            List<Color> colors = new List<Color>()
            {
                new Color() { Value = "Gradient" },
                new Color() { Value = "Violet" },
                new Color() { Value = "Black" },
                new Color() { Value = "White" },
                new Color() { Value = "Gray" },
                new Color() { Value = "Green" },
                new Color() { Value = "Blue" },
                new Color() { Value = "Yellow" },
                new Color() { Value = "Red" },
                new Color() { Value = "Pink" },
                new Color() { Value = "Orange" },
                new Color() { Value = "Brown" },
            };
            return colors;
        }
        private List<Material> GetMaterials()
        {
            List<Material> materials = new List<Material>()
            { 
                new Material() { Value = "Plastic" },
                new Material() { Value = "Wood" },
                new Material() { Value = "Iron" },
                new Material() { Value = "Aluminum" },
                new Material() { Value = "Glass" },
                new Material() { Value = "Rubber" },
                new Material() { Value = "Cloth" },
                new Material() { Value = "Jeans" },
                new Material() { Value = "Leather" },
            };
            return materials;
        }
        private List<ConnectorType> GetConnectorTypes()
        {
            List<ConnectorType> connectorTypes = new List<ConnectorType>()
            {
                new ConnectorType(){ Value="2.5mm" },
                new ConnectorType(){ Value="3.5mm" },
                new ConnectorType(){ Value="Easy Disconnect" },
                new ConnectorType(){ Value="USB" },
                new ConnectorType(){ Value="RCA" },
                new ConnectorType(){ Value="Quick Disconnect Connector" },
            };
            return connectorTypes;
        }
        private List<CoolerType> GetCoolerTypes()
        {
            List<CoolerType> coolerTypes = new List<CoolerType>()
            { 
                new CoolerType() { Value = "Water/Liquid Cooling" },
                new CoolerType() { Value = "Case Fans" },
                new CoolerType() { Value = "CPUFans & Heatsinks" },
            };
            return coolerTypes;
        }
        private List<DriveInterface> GetDriveInterfaces()
        {
            List<DriveInterface> driveInterfaces = new List<DriveInterface>() 
            {
                new DriveInterface() { Value = "USB 3.0" },
                new DriveInterface() { Value = "SATA" },
                new DriveInterface() { Value = "USB 3.1 Gen2" },
                new DriveInterface() { Value = "USB Type C" },
                new DriveInterface() { Value = "Other" },
                new DriveInterface() { Value = "USB 2.0" },
                new DriveInterface() { Value = "PCI Express 3.0 x4" },
                new DriveInterface() { Value = "Ethernet" },
                new DriveInterface() { Value = "USB 3.1 Gen1" },
                new DriveInterface() { Value = "USB 3.2 Gen 1" },
                new DriveInterface() { Value = "USB" },
                new DriveInterface() { Value = "PCI Express 4.0 x4" },
                new DriveInterface() { Value = "EIDE" },
                new DriveInterface() { Value = "eSata" },
                new DriveInterface() { Value = "3.5mm audio" },
                new DriveInterface() { Value = "DisplayPort" },
                new DriveInterface() { Value = "Thunderbolt" },
                new DriveInterface() { Value = "USB 3.2 Gen 2" },
                new DriveInterface() { Value = "USB Type A" },
                new DriveInterface() { Value = "Wi-Fi" },
            };
            return driveInterfaces;
        }
        private List<FormFactorType> GetFormFactorTypes()
        {
            List<FormFactorType> formFactorTypes = new List<FormFactorType>() 
            { 
                new FormFactorType() { Value = "1.8" },
                new FormFactorType() { Value = "2.5" },
                new FormFactorType() { Value = "Add In Card" },
                new FormFactorType() { Value = "USB" },
            };
            return formFactorTypes;
        }
        private List<USBSpecificationType> GetUSBSpecificationTypes()
        {
            List<USBSpecificationType> USBSpecificationTypes = new List<USBSpecificationType>()
            {
                new USBSpecificationType() { Value = "USB 3.1" },
                new USBSpecificationType() { Value = "USB 2.0" },
            };
            return USBSpecificationTypes;
        }















        private string CreateRandomString(int minLength, int maxLenght, string chars, Random random)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < random.Next(minLength, maxLenght); i++)
            {
                stringBuilder.Append(chars[random.Next(0, chars.Length)]);
            }
            return stringBuilder.ToString();
        }
        private int? CreateRandomNullInt(int minLength, int maxLenght, bool getInt, Random random)
        {
            if (getInt)
            {
                return random.Next(minLength, maxLenght);
            }
            else
            {
                return null;
            }
        }
        private decimal CreateRandomDecimal(Random random)
        {
            return (decimal)random.NextDouble() * 100000;
            //return new decimal(NextInt32(random),
            //                   NextInt32(random),
            //                   NextInt32(random),
            //                   false,
            //                   (byte)random.Next(5));
        }
        public static int NextInt32(Random random)
        {
            var a = (int)(1000 * random.NextDouble());
            //int firstBits = random.Next(0, 1 << 4) << 28;
            //int lastBits = random.Next(0, 1 << 28);
            return a;
        }
        private bool CreateRandomBool(Random random)
        {
            return random.Next(2) == 0;
        }
    }
}
