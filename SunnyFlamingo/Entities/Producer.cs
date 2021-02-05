using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SunnyFlamingo.Entities
{
    public class Producer
    {
        public Guid Id { get; set; }
        [Column(TypeName = "nvarchar(500)")]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(500)")]
        public string Address { get; set; }

        public Guid CountryId { get; set; }
        public Country Country { get; set; }


        public List<Good> Goods { get; set; }
    }
}
