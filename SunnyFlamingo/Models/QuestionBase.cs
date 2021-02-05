using SunnyFlamingo.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Models
{
    public class QuestionBase<T>
    {
        public string QuestionsKey { get; set; }
        public T Value { get; set; }
        public string Key { get; set; }
        public string Label { get; set; }
        public bool Required { get; set; }
        public int? Order { get; set; }
        public ControlType ControlType { get; set; }
        public InputType Type { get; set; }
        public List<QuestionOption> Options { get; set; }
        public bool? Checked { get; set; }
        public int? AfterBox2 { get; set; }
        public string AfterBox { get; set; }
        public object SelectedFrom { get; set; }
        public object SelectedTo { get; set; }
        public object From { get; set; }
        public object To { get; set; }
    }
}
