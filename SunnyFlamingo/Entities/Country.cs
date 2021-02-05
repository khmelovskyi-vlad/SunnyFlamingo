using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Entities
{
    public class Country
    {
        public Guid Id { get; set; }
        [Column(TypeName = "nvarchar(500)")]
        public string Value { get; set; }
        public List<Producer> Producers { get; set; }
        public List<Manufacturer> Manufacturers { get; set; }
    }
}
