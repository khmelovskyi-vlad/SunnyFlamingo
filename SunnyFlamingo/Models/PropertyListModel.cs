using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Models
{
    public class PropertyListModel
    {
        public PropertyListModel()
        {

        }
        public PropertyListModel(string key, List<string> value)
        {
            Key = key;
            Value = value;
        }
        public string Key { get; set; }
        public List<string> Value { get; set; }
    }
}
