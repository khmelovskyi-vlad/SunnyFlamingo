using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.ValueObjects
{
    public class QuestionValidator
    {
        public int? Max { get; set; }
        public int? Min { get; set; }
        public int? MaxLength { get; set; }
        public int? MinLength { get; set; }
        public bool Required { get; set; }
    }
}
