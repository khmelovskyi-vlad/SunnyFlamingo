using SunnyFlamingo.Models;
using SunnyFlamingo.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SunnyFlamingo.Entities.Goods.ComputerTechnologies
{
    public class Laptop : ComputerTechnology
    {
        public Laptop()
        {

        }
        public Laptop(LaptopModel laptopModel)
        {
            Name = laptopModel.Name;
            Price = laptopModel.Price;
            IsAvailable = laptopModel.IsAvailable;
            Description = laptopModel.Description;
            ProducerId = laptopModel.ProducerId;
            ManufacturerId = laptopModel.ManufacturerId;
            MaterialValue = laptopModel.Material;
            ColorValue = laptopModel.Color;
            AmountOfRAM = laptopModel.AmountOfRAM;
            CPUFrequency = laptopModel.CPUFrequency;
            Length = laptopModel.Length;
            Height = laptopModel.Height;
            Width = laptopModel.Width;
            HaveFloppyDrives = laptopModel.HaveFloppyDrives;
            SSDMemory = laptopModel.SSDMemory;
            HardDiskMemory = laptopModel.HardDiskMemory;
            CPUSocketTypeValue = laptopModel.CPUSocketType;
            NumberOfCores = laptopModel.NumberOfCores;
            if (HaveFloppyDrives)
            {
                FloppyDrivesCount = laptopModel.FloppyDrivesCount;
            }
            Display = laptopModel.Display;
            if (laptopModel.UserId != null && laptopModel.UserId != new Guid())
            {
                UserId = laptopModel.UserId;
            }
        }
        public int AmountOfRAM { get; set; }
        public int CPUFrequency { get; set; }
        public float Length { get; set; }
        public float Height { get; set; }
        public float Width { get; set; }
        public bool HaveFloppyDrives { get; set; }
        public int? SSDMemory { get; set; }
        public int? HardDiskMemory { get; set; }
        [MaxLength(500)]
        public string CPUSocketTypeValue { get; set; }
        public CPUSocketType CPUSocketType { get; set; }
        public List<LaptopComputerDriveType> LaptopComputerDriveTypes { get; set; }
        public int NumberOfCores { get; set; }
        public int? FloppyDrivesCount { get; set; }
        public int Display { get; set; }
    }
}
