using SunnyFlamingo.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Entities.Goods.ComputerTechnologies.ComputerParts
{
    public class Cooler : ComputerPart
    {
        public string TypeValue { get; set; }
        public CoolerType Type { get; set; }
        public int FanSize { get; set; }
    }
}
