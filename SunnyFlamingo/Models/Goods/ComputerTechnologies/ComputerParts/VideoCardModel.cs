using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Models
{
    public class VideoCardModel: ComputerPartModel
    {
        public int VideoSize { get; set; }
        public string DriveInterface { get; set; }
        public int VideoMemoryCapacity { get; set; }
    }
}
