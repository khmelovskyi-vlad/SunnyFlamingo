using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Models
{
    public class DBQuestionBase
    {
        public string QuestionsKey { get; set; }
        public int? AfterBox { get; set; }
        public bool? Checked { get; set; }
        public string Key { get; set; }
        public string Label { get; set; }
        public string From { get; set; }
        public string To { get; set; }
    }
}
