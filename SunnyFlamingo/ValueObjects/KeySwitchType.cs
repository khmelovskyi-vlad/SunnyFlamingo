using SunnyFlamingo.Entities.Goods.ComputerTechnologies.ComputerAccessories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.ValueObjects
{
    //public enum KeySwitchType
    //{
    //    Cherry,
    //    Logitech,
    //    Gateron,
    //    Razer,
    //    TTC,
    //    OUTEMU
    //}
    public class KeySwitchType
    {
        [Key]
        [MaxLength(500)]
        public string Value { get; set; }
        public List<Keyboard> Keyboards { get; set; }
    }
}
