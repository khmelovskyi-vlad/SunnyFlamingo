using SunnyFlamingo.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SunnyFlamingo.ValueObjects
{
    public class Material
    {
        [Key]
        [Column(TypeName = "nvarchar(500)")]
        public string Value { get; set; }

        public List<Good> Goods { get; set; }
    }
}
