using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Models.Selectors
{
    public class LaptopsSelector
    {
        public ComputerTechnologiesSelector ComputerTechnologiesSelector { get; set; }
        public int[] AmountOfRAMs { get; set; }
        public int[] CPUFrequencies { get; set; }
        public float[] Length { get; set; }
        public float[] Height { get; set; }
        public float[] Width { get; set; }
        public bool[] HaveFloppyDrives { get; set; }
        public int?[] SSDMemory { get; set; }
        public int?[] HardDiskMemory { get; set; }
        public string[] CPUSocketTypes { get; set; }
        public string[] ComputerDriveTypes { get; set; }
        public int[] NumberOfCores { get; set; }
        public int?[] FloppyDrivesCount { get; set; }
        public int[] Displays { get; set; }
    }
}
