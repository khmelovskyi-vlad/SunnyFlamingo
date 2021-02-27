using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SunnyFlamingo.Data;
using SunnyFlamingo.Models;
using SunnyFlamingo.Services.Searchers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Controllers
{
    [Route("api/good")]
    [ApiController]
    public class GoodController : ControllerBase
    {

        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public GoodController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        [Route("Good")]
        [Route("Good/{id?}")]
        public async Task<GoodInformation> GetGoodInformation(Guid id)
        {
            return await _context.Goods.Where(good => good.Id == id).ProjectTo<GoodInformation>(_mapper.ConfigurationProvider).FirstOrDefaultAsync();
        }
        [HttpGet]
        [Route("ComputerTechnology")]
        [Route("ComputerTechnology/{id?}")]
        public async Task<GoodInformation> GetComputerTechnologyInformation(Guid id)
        {
            return await _context.ComputerTechnology.Where(good => good.Id == id).ProjectTo<GoodInformation>(_mapper.ConfigurationProvider).FirstOrDefaultAsync();
        }
        [HttpGet]
        [Route("Laptop")]
        [Route("Laptop/{id?}")]
        public async Task<GoodInformation> GetLaptopInformation(Guid id)
        {
            return await _context.Laptops.Where(good => good.Id == id).ProjectTo<GoodInformation>(_mapper.ConfigurationProvider).FirstOrDefaultAsync();
        }
        [HttpGet]
        [Route("Computer")]
        [Route("Computer/{id?}")]
        public async Task<GoodInformation> GetComputerInformation(Guid id)
        {
            return await _context.Computers.Where(good => good.Id == id).ProjectTo<GoodInformation>(_mapper.ConfigurationProvider).FirstOrDefaultAsync();
        }
        [HttpGet]
        [Route("FlashDrive")]
        [Route("FlashDrive/{id?}")]
        public async Task<GoodInformation> GetFlashDriveInformation(Guid id)
        {
            return await _context.FlashDrives.Where(good => good.Id == id).ProjectTo<GoodInformation>(_mapper.ConfigurationProvider).FirstOrDefaultAsync();
        }
        [HttpGet]
        [Route("ComputerPart")]
        [Route("ComputerPart/{id?}")]
        public async Task<GoodInformation> GetComputerPartInformation(Guid id)
        {
            return await _context.ComputerParts.Where(good => good.Id == id).ProjectTo<GoodInformation>(_mapper.ConfigurationProvider).FirstOrDefaultAsync();
        }
        [HttpGet]
        [Route("ComputerAccessory")]
        [Route("ComputerAccessory/{id?}")]
        public async Task<GoodInformation> GetComputerAccessoryInformation(Guid id)
        {
            return await _context.ComputerAccessories.Where(good => good.Id == id).ProjectTo<GoodInformation>(_mapper.ConfigurationProvider).FirstOrDefaultAsync();
        }
        [HttpGet]
        [Route("ComputerDrive")]
        [Route("ComputerDrive/{id?}")]
        public async Task<GoodInformation> GetComputerDriveInformation(Guid id)
        {
            return await _context.ComputerDrives.Where(good => good.Id == id).ProjectTo<GoodInformation>(_mapper.ConfigurationProvider).FirstOrDefaultAsync();
        }
        [HttpGet]
        [Route("Cooler")]
        [Route("Cooler/{id?}")]
        public async Task<GoodInformation> GetCoolerInformation(Guid id)
        {
            return await _context.Coolers.Where(good => good.Id == id).ProjectTo<GoodInformation>(_mapper.ConfigurationProvider).FirstOrDefaultAsync();
        }
        [HttpGet]
        [Route("CPU")]
        [Route("CPU/{id?}")]
        public async Task<GoodInformation> GetCPUInformation(Guid id)
        {
            return await _context.CPUs.Where(good => good.Id == id).ProjectTo<GoodInformation>(_mapper.ConfigurationProvider).FirstOrDefaultAsync();
        }
        [HttpGet]
        [Route("VideoCard")]
        [Route("VideoCard/{id?}")]
        public async Task<GoodInformation> GetVideoCardInformation(Guid id)
        {
            return await _context.VideoCards.Where(good => good.Id == id).ProjectTo<GoodInformation>(_mapper.ConfigurationProvider).FirstOrDefaultAsync();
        }
        [HttpGet]
        [Route("Mause")]
        [Route("Mause/{id?}")]
        public async Task<GoodInformation> GetMauseInformation(Guid id)
        {
            return await _context.Mice.Where(good => good.Id == id).ProjectTo<GoodInformation>(_mapper.ConfigurationProvider).FirstOrDefaultAsync();
        }
        [HttpGet]
        [Route("Keyboard")]
        [Route("Keyboard/{id?}")]
        public async Task<GoodInformation> GetKeyboardInformation(Guid id)
        {
            return await _context.Keyboards.Where(good => good.Id == id).ProjectTo<GoodInformation>(_mapper.ConfigurationProvider).FirstOrDefaultAsync();
        }
        [HttpGet]
        [Route("Headphones")]
        [Route("Headphones/{id?}")]
        public async Task<GoodInformation> GetHeadphonesInformation(Guid id)
        {
            return await _context.Headphones.Where(good => good.Id == id).ProjectTo<GoodInformation>(_mapper.ConfigurationProvider).FirstOrDefaultAsync();
        }
    }
}
