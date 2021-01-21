﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Entities
{
    public class ApplicationRoleClaim : IdentityRoleClaim<Guid>
    {
        public ApplicationRole Role { get; set; }
    }
}
