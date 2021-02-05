using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Entities
{
    public class Comment
    {
        public Guid Id { get; set; }
        [Column(TypeName = "nvarchar(500)")]
        public string Value { get; set; }
        public DateTime SendTime { get; set; }

        public Guid UserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
