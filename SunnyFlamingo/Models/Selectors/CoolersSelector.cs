using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Models.Selectors
{
    public class CoolersSelector : ComputerPartsSelector
    {
        public string[] Types { get; set; }
        public int[] FanSizes { get; set; }
    }
}
