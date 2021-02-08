using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Models.Selectors
{
    public class VideoCardsSelector
    {
        public ComputerPartsSelector ComputerPartsSelector { get; set; }
        public string[] DriveInterfaces { get; set; }
        public int[] VideoSizes { get; set; }
        public int[] VideoMemoryCapacities { get; set; }
    }
}
