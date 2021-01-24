using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Models
{
    public class QuestionsBase<T>
    {
        public T Value { get; set; }
        public string Key { get; set; }
        public int Order { get; set; }
        public List<QuestionBase<T>> QuestionBaseList { get; set; }
    }
}
