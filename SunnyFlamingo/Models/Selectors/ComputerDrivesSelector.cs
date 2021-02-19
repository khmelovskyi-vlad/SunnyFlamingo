using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Models.Selectors
{
    public class ComputerDrivesSelector : ComputerPartsSelector
    {
        public int[] Capacities { get; set; }
        public string[] Types { get; set; }
        public string[] FormFactorTypes { get; set; }
    }
}
