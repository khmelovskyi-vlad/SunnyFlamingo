using SunnyFlamingo.ValueObjects;
using System.ComponentModel.DataAnnotations;

namespace SunnyFlamingo.Entities.Goods.ComputerTechnologies.ComputerAccessories
{
    public class Headphones : ComputerAccessory
    {
        [MaxLength(500)]
        public string TypeValue { get; set; }
        public HeadphonesType Type { get; set; }


        [MaxLength(500)]
        public string WirelessTypeValue { get; set; }
        public WirelessType WirelessType { get; set; }


        [MaxLength(500)]
        public string ConnectorTypeValue { get; set; }
        public ConnectorType ConnectorType { get; set; }
    }
}
