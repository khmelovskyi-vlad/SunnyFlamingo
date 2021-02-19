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
        public GoodController(ApplicationDbContext context, IParametersCreator parametersCreator, IQuestionsGrouper questionsGrouper, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        [Route("Good")]
        public async Task<GoodInformation> GetGoodInformation(Guid id)
        {
            return await _context.Goods.Where(good => good.Id == id).ProjectTo<GoodInformation>(_mapper.ConfigurationProvider).FirstOrDefaultAsync();
        }
        [HttpGet]
        [Route("ComputerTechnology")]
        public async Task<GoodInformation> GetComputerTechnologyInformation(Guid id)
        {
            return await _context.ComputerTechnology.Where(good => good.Id == id).ProjectTo<GoodInformation>(_mapper.ConfigurationProvider).FirstOrDefaultAsync();
        }
        [HttpGet]
        [Route("Laptop")]
        public async Task<GoodInformation> GetLaptopInformation(Guid id)
        {
            return await _context.Laptops.Where(good => good.Id == id).ProjectTo<GoodInformation>(_mapper.ConfigurationProvider).FirstOrDefaultAsync();
        }
        [HttpGet]
        [Route("Computer")]
        public async Task<GoodInformation> GetComputerInformation(Guid id)
        {
            return await _context.Computers.Where(good => good.Id == id).ProjectTo<GoodInformation>(_mapper.ConfigurationProvider).FirstOrDefaultAsync();
        }
        [HttpGet]
        [Route("FlashDrive")]
        public async Task<GoodInformation> GetFlashDriveInformation(Guid id)
        {
            return await _context.FlashDrives.Where(good => good.Id == id).ProjectTo<GoodInformation>(_mapper.ConfigurationProvider).FirstOrDefaultAsync();
        }
        [HttpGet]
        [Route("ComputerPart")]
        public async Task<GoodInformation> GetComputerPartInformation(Guid id)
        {
            return await _context.ComputerParts.Where(good => good.Id == id).ProjectTo<GoodInformation>(_mapper.ConfigurationProvider).FirstOrDefaultAsync();
        }
        [HttpGet]
        [Route("ComputerAccessory")]
        public async Task<GoodInformation> GetComputerAccessoryInformation(Guid id)
        {
            return await _context.ComputerAccessories.Where(good => good.Id == id).ProjectTo<GoodInformation>(_mapper.ConfigurationProvider).FirstOrDefaultAsync();
        }
        [HttpGet]
        [Route("ComputerDrive")]
        public async Task<GoodInformation> GetComputerDriveInformation(Guid id)
        {
            return await _context.ComputerDrives.Where(good => good.Id == id).ProjectTo<GoodInformation>(_mapper.ConfigurationProvider).FirstOrDefaultAsync();
        }
        [HttpGet]
        [Route("Cooler")]
        public async Task<GoodInformation> GetCoolerInformation(Guid id)
        {
            return await _context.Coolers.Where(good => good.Id == id).ProjectTo<GoodInformation>(_mapper.ConfigurationProvider).FirstOrDefaultAsync();
        }
        [HttpGet]
        [Route("CPU")]
        public async Task<GoodInformation> GetCPUInformation(Guid id)
        {
            return await _context.CPUs.Where(good => good.Id == id).ProjectTo<GoodInformation>(_mapper.ConfigurationProvider).FirstOrDefaultAsync();
        }
        [HttpGet]
        [Route("VideoCard")]
        public async Task<GoodInformation> GetVideoCardInformation(Guid id)
        {
            return await _context.VideoCards.Where(good => good.Id == id).ProjectTo<GoodInformation>(_mapper.ConfigurationProvider).FirstOrDefaultAsync();
        }
        [HttpGet]
        [Route("Mause")]
        public async Task<GoodInformation> GetMauseInformation(Guid id)
        {
            return await _context.Mice.Where(good => good.Id == id).ProjectTo<GoodInformation>(_mapper.ConfigurationProvider).FirstOrDefaultAsync();
        }
        [HttpGet]
        [Route("Keyboard")]
        public async Task<GoodInformation> GetKeyboardInformation(Guid id)
        {
            return await _context.Keyboards.Where(good => good.Id == id).ProjectTo<GoodInformation>(_mapper.ConfigurationProvider).FirstOrDefaultAsync();
        }
        [HttpGet]
        [Route("Headphones")]
        public async Task<GoodInformation> GetHeadphonesInformation(Guid id)
        {
            return await _context.Headphones.Where(good => good.Id == id).ProjectTo<GoodInformation>(_mapper.ConfigurationProvider).FirstOrDefaultAsync();
        }
    }
}
