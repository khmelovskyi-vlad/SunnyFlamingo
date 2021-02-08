﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Models.Selectors
{
    public class CPUsSelector
    {
        public ComputerPartsSelector ComputerPartsSelector { get; set; }
        public string[] CPUSocketTypes { get; set; }
        public int[] ThermalDesignPowers { get; set; }
        public int[] NumberOfCores { get; set; }
        public int[] NumberOfThreads { get; set; }
    }
}
