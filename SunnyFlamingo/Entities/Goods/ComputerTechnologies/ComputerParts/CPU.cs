using SunnyFlamingo.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Entities.Goods.ComputerTechnologies.ComputerParts
{
    public class CPU : ComputerPart
    {
        public CPUSocketType CPUSocketType { get; set; }
        public int ThermalDesignPower { get; set; }
        public int NumberOfCores { get; set; }
        public int NumberOfThreads { get; set; }
    }
}
