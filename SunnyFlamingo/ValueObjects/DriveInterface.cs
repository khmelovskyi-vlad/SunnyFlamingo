using SunnyFlamingo.Entities.Goods.ComputerTechnologies.ComputerParts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.ValueObjects
{
    public class DriveInterface
    {
        [Key]
        [Column(TypeName = "nvarchar(500)")]
        public string Value { get; set; }
        public List<VideoCard> VideoCards { get; set; }
    }
}
