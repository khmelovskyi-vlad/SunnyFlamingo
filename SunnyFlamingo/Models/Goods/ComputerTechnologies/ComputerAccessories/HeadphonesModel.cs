using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Models
{
    public class HeadphonesModel: ComputerAccessoryModel
    {
        public string Type { get; set; }
        public string WirelessType { get; set; }
        public string ConnectorType { get; set; }
    }
}
