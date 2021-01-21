using SunnyFlamingo.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Entities.Goods.ComputerTechnologies.ComputerAccessories
{
    public class Keyboard : ComputerAccessory
    {
        public KeySwitchType Type { get; set; }
    }
}
