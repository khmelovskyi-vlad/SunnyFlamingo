using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Entities
{
    public class Comment
    {
        public Guid Id { get; set; }
        [MaxLength(500)]
        public string Value { get; set; }
        public DateTime SendTime { get; set; }

        public Guid UserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
