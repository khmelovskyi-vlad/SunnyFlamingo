using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Entities
{
    public class ImageInfo
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string MimeType { get; set; }
        public long Size { get; set; }

        public Guid? UserId { get; set; }
        public ApplicationUser User { get; set; }
        public Guid? GoodId { get; set; }
        public Good Good { get; set; }
    }
}
