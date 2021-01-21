using SunnyFlamingo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Models
{
    public class UserBanModel
    {
        public List<ApplicationUser> BannedUsers { get; set; }
        public List<ApplicationUser> NoBannedUsers { get; set; }
    }
}
