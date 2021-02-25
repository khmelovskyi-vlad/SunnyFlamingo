using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Models
{
    public class CoolerModel: ComputerPartModel
    {
        public string Type { get; set; }
        public int FanSize { get; set; }
    }
}
