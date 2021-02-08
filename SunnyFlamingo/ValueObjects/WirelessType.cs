using SunnyFlamingo.Entities.Goods.ComputerTechnologies.ComputerAccessories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.ValueObjects
{
    //public enum WirelessType
    //{
    //    Bluetooth,
    //    IR,
    //    Kleer,
    //    RF,
    //    Infrared,
    //    No
    //}
    public class WirelessType
    {
        [Key]
        [MaxLength(500)]
        public string Value { get; set; }
        public List<Headphones> Headphones { get; set; }
    }
}
