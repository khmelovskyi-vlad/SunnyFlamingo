﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Models
{
    public class BanModification
    {
        public Guid[] BanIds { get; set; }
        public Guid[] UnbanIds { get; set; }
    }
}
