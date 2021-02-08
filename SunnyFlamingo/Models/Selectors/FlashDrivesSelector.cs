using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Models.Selectors
{
    public class FlashDrivesSelector
    {
        public ComputerTechnologiesSelector ComputerTechnologiesSelector { get; set; }
        public int[] Capacities { get; set; }
        public string[] USBSpecificationTypes { get; set; }
    }
}
