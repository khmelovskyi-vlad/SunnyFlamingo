using SunnyFlamingo.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SunnyFlamingo.ValueObjects
{
    public class Color
    {
        [Key]
        [MaxLength(500)]
        public string Value { get; set; }

        public List<Good> Goods { get; set; }
    }
}
