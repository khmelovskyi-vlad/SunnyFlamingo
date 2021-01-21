using SunnyFlamingo.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.ValueObjects
{
    public class Color
    {
        [Key]
        public string Value { get; set; }
        public List<Good> Goods { get; set; }
    }
}
