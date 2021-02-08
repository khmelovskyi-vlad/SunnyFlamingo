﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SunnyFlamingo.Entities
{
    public class Ip
    {
        public Guid Id { get; set; }
        [MaxLength(500)]
        public string Value { get; set; }
        public bool IsInBan { get; set; }

        public List<UserIp> UserIps { get; set; }
    }
}
