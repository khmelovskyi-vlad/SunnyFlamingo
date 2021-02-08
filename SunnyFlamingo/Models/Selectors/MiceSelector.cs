using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Models.Selectors
{
    public class MiceSelector
    {
        public ComputerAccessoriesSelector ComputerAccessoriesSelector { get; set; }
        public string[] Types { get; set; }
        public int[] ButtonsCount { get; set; }
    }
}
