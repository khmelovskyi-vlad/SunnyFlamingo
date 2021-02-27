using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SunnyFlamingo.Data;
using SunnyFlamingo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public UsersController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [Authorize("GetBasicData")]
        [HttpGet]
        [Route("GetUserModel")]
        public async Task<UserModel> GetGoodInformation()
        {
            return await _context.Users.Where(user => user.Email == User.Identity.Name).ProjectTo<UserModel>(_mapper.ConfigurationProvider).FirstOrDefaultAsync();
        }
    }
}
