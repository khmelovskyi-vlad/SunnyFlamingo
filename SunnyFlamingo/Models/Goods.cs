using SunnyFlamingo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Models
{
    public class Goods
    {
        public IQueryable<Good> GoodList { get; set; }
    }
}
