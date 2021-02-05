using SunnyFlamingo.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Entities.Goods.ComputerTechnologies.ComputerAccessories
{
    public class Headphones : ComputerAccessory
    {
        [Column(TypeName = "nvarchar(500)")]
        public HeadphonesType Type { get; set; }
        [Column(TypeName = "nvarchar(500)")]
        public WirelessType WirelessType { get; set; }
        [Column(TypeName = "nvarchar(500)")]
        public string ConnectorTypeValue { get; set; }
        public ConnectorType ConnectorType { get; set; }
    }
}
