using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Models
{
    public class FlashDriveModel: ComputerTechnologyModel
    {
        public int Capacity { get; set; }
        public string USBSpecificationType { get; set; }
    }
}
