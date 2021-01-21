using SunnyFlamingo.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Entities.Goods.ComputerTechnologies.ComputerParts
{
    public class VideoCard : ComputerPart
    {
        public int VideoSize { get; set; }
        public string DriveInterfaceValue { get; set; }
        public DriveInterface DriveInterface { get; set; }
        public int VideoMemoryCapacity { get; set; }
    }
}
