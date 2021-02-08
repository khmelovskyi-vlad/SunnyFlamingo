using SunnyFlamingo.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SunnyFlamingo.Entities.Goods.ComputerTechnologies.ComputerParts
{
    public class VideoCard : ComputerPart
    {
        public int VideoSize { get; set; }
        [MaxLength(500)]
        public string DriveInterfaceValue { get; set; }
        public DriveInterface DriveInterface { get; set; }
        public int VideoMemoryCapacity { get; set; }
    }
}
