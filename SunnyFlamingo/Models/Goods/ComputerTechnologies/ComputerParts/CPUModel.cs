using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Models
{
    public class CPUModel: ComputerPartModel
    {
        public string CPUSocketType { get; set; }
        public int ThermalDesignPower { get; set; }
        public int NumberOfCores { get; set; }
        public int NumberOfThreads { get; set; }
    }
}
