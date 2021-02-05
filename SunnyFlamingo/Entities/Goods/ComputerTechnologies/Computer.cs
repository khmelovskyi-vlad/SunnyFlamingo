﻿using SunnyFlamingo.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

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
        [Column(TypeName = "nvarchar(500)")]
        public CPUSocketType CPUSocketType { get; set; }
        [Column(TypeName = "nvarchar(500)")]
        public ComputerDriveType ComputerDriveType { get; set; }
        public int NumberOfCores { get; set; }
        public int? FloppyDrivesCount { get; set; }
    }
}
