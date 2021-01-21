using SunnyFlamingo.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Entities.Goods.ComputerTechnologies.ComputerAccessories
{
    public class Headphones : ComputerAccessory
    {
        public HeadphonesType Type { get; set; }
        public WirelessType WirelessType { get; set; }
        public string ConnectorTypeValue { get; set; }
        public ConnectorType ConnectorType { get; set; }
    }
}
