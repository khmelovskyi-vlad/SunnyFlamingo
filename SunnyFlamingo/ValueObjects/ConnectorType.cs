using SunnyFlamingo.Entities.Goods.ComputerTechnologies.ComputerAccessories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.ValueObjects
{
    public class ConnectorType
    {
        [Key]
        [Column(TypeName = "nvarchar(500)")]
        public string Value { get; set; }
        public List<Headphones> Headphones { get; set; }
    }
}
