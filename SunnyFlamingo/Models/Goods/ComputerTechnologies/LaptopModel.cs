using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Models
{
    public class LaptopModel : ComputerTechnologyModel
    {
        public int AmountOfRAM { get; set; }
        public int CPUFrequency { get; set; }
        public float Length { get; set; }
        public float Height { get; set; }
        public float Width { get; set; }
        public bool HaveFloppyDrives { get; set; }
        public int? SSDMemory { get; set; }
        public int? HardDiskMemory { get; set; }
        public string CPUSocketType { get; set; }
        public List<string> ComputerDriveTypes { get; set; }
        public int NumberOfCores { get; set; }
        public int? FloppyDrivesCount { get; set; }
        public int Display { get; set; }
    }
}
