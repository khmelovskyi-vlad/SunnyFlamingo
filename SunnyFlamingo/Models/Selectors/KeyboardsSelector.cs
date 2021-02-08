using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Models.Selectors
{
    public class KeyboardsSelector
    {
        public ComputerAccessoriesSelector ComputerAccessoriesSelector { get; set; }
        public string[] Types { get; set; }
    }
}
