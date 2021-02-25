using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Models
{
    public class ComputerDriveModel: ComputerPartModel
    {
        public int Capacity { get; set; }
        public string Type { get; set; }
        public string FormFactorType { get; set; }
    }
}
