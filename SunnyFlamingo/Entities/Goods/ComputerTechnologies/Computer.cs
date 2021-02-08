using SunnyFlamingo.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SunnyFlamingo.Entities.Goods.ComputerTechnologies
{
    public class Computer : ComputerTechnology
    {
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
