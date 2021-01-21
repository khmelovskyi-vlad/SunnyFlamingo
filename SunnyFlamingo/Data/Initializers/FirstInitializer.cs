using Microsoft.EntityFrameworkCore;
using SunnyFlamingo.Entities;
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

            modelBuilder.Entity<Country>().HasData(GetCountries());
            modelBuilder.Entity<Color>().HasData(GetColors());
            modelBuilder.Entity<Material>().HasData(GetMaterials());
            modelBuilder.Entity<ConnectorType>().HasData(GetConnectorTypes());
            modelBuilder.Entity<CoolerType>().HasData(GetCoolerTypes());
            modelBuilder.Entity<DriveInterface>().HasData(GetDriveInterfaces());
            modelBuilder.Entity<FormFactorType>().HasData(GetFormFactorTypes());
            modelBuilder.Entity<USBSpecificationType>().HasData(GetUSBSpecificationTypes());
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
    }
}
