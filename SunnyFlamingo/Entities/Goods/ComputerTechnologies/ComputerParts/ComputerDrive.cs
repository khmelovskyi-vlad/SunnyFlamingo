using SunnyFlamingo.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Entities.Goods.ComputerTechnologies.ComputerParts
{
    public class ComputerDrive : ComputerPart
    {
        public int Capacity { get; set; }
        public ComputerDriveType Type { get; set; }
        public string FormFactorTypeValue { get; set; }
        public FormFactorType FormFactorType { get; set; }
    }
}
