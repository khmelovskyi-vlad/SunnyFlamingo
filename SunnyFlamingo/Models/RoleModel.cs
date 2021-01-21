﻿using SunnyFlamingo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Models
{
    public class RoleModel : ApplicationRole
    {
        public RoleModel(ApplicationRole applicationRole, string userNames)
        {
            Id = applicationRole.Id;
            Name = applicationRole.Name;
            NormalizedName = applicationRole.NormalizedName;
            ConcurrencyStamp = applicationRole.ConcurrencyStamp;
            Description = applicationRole.Description;
            UserNames = userNames;
        }
        public string UserNames { get; set; }
    }
}
