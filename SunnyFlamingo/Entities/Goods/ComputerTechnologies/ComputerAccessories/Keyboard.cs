using SunnyFlamingo.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Entities.Goods.ComputerTechnologies.ComputerAccessories
{
    public class Keyboard : ComputerAccessory
    {
        [Column(TypeName = "nvarchar(500)")]
        public KeySwitchType Type { get; set; }
    }
}
