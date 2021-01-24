using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SunnyFlamingo.Data;
using SunnyFlamingo.Entities;
using SunnyFlamingo.Models;
using SunnyFlamingo.ValueObjects;

namespace SunnyFlamingo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoodsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public GoodsController(ApplicationDbContext context)
        {
            _context = context;
        }
        //[HttpGet]
        //public async Task<GoodsInformation<string>> GetGoodsInformation()
        //{
        //    var res = await _context.Goods
        //        .Take(20)
        //        .Select(g => new GoodCellModel() 
        //        { 
        //            Id = g.Id,
        //            Name = g.Name,
        //            IsAvailable = g.IsAvailable,
        //            Price = g.Price,
        //            ImgId = g.ImageInfo.FirstOrDefault().Id
        //        })
        //        .ToListAsync();
        //    var questions = await _context.Goods
                
        //        .FirstOrDefaultAsync();
        //}
        private QuestionsBase<string> GetProduserQuestionsBase(List<Good> goods)
        {
            //var result = new QuestionsBase<string>() 
            //{
            //    Key = "Producer",
            //    Value = "Select producer",
            //    Order = 1
            //};
            //var asd = goods.Select(g => g.Producer.Name).Select((producer, i) => new QuestionBase<string>()
            //{
            //    AfterBox = goods.Count(g => g.Producer.Name == producer).ToString(),
            //    Checked = false,
            //    ControlType = ControlType.Checkbox,
            //    Key = producer,
            //    Label = producer,
            //    Required = false,
            //    Type = InputType.Checkbox,
            //    Order = i
            //});
            //foreach (var producer in goods.Select(g => g.Producer.Name))
            //{
            //    var i = 0;
            //    result.QuestionBaseList.Add(new QuestionBase<string>() 
            //    { 
            //        AfterBox = goods.Count(g => g.Producer.Name == producer).ToString(),
            //        Checked = false,
            //        ControlType = ControlType.Checkbox,
            //        Key = producer,
            //        Label = producer,
            //        Required = false,
            //        Type = InputType.Checkbox,
            //        Order = i

            //    });
            //    i++;
            //}
            //return result;
            return new QuestionsBase<string>()
            {
                Key = "Producer",
                Value = "Select producer",
                Order = 1,
                //QuestionBaseList =
                //goods.Select(g => g.Producer.Name).Select((producer, i) => new QuestionBase<string>()
                //{
                //    AfterBox = goods.Count(g => g.Producer.Name == producer).ToString(),
                //    Checked = false,
                //    ControlType = ControlType.Checkbox,
                //    Key = producer,
                //    Label = producer,
                //    Required = false,
                //    Type = InputType.Checkbox,
                //    Order = i
                //}).ToList()
            };
        }
    }
}
