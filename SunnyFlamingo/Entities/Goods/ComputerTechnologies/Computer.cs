using SunnyFlamingo.Models;
using SunnyFlamingo.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SunnyFlamingo.Entities.Goods.ComputerTechnologies
{
    public class Computer : ComputerTechnology
    {
        public Computer()
        {

        }
        public Computer(ComputerModel computerModel)
        {
            Name = computerModel.Name;
            Price = computerModel.Price;
            IsAvailable = computerModel.IsAvailable;
            Description = computerModel.Description;
            ProducerId = computerModel.ProducerId;
            ManufacturerId = computerModel.ManufacturerId;
            MaterialValue = computerModel.Material;
            ColorValue = computerModel.Color;
            AmountOfRAM = computerModel.AmountOfRAM;
            CPUFrequency = computerModel.CPUFrequency;
            Length = computerModel.Length;
            Height = computerModel.Height;
            Width = computerModel.Width;
            HaveFloppyDrives = computerModel.HaveFloppyDrives;
            SSDMemory = computerModel.SSDMemory;
            HardDiskMemory = computerModel.HardDiskMemory;
            CPUSocketTypeValue = computerModel.CPUSocketType;
            NumberOfCores = computerModel.NumberOfCores;
            if (HaveFloppyDrives)
            {
                FloppyDrivesCount = computerModel.FloppyDrivesCount;
            }
            if (computerModel.UserId != null && computerModel.UserId != new Guid())
            {
                UserId = computerModel.UserId;
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
        public List<ComputerComputerDriveType> ComputerComputerDriveTypes { get; set; }
        public int NumberOfCores { get; set; }
        public int? FloppyDrivesCount { get; set; }
    }
}
