using SunnyFlamingo.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Entities.Goods.ComputerTechnologies
{
    public class FlashDrive : ComputerTechnology
    {
        public int Capacity { get; set; }
        public string USBSpecificationTypeValue { get; set; }
        public USBSpecificationType USBSpecificationType { get; set; }
    }
}
