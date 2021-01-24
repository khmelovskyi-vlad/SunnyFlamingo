using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SunnyFlamingo.Data;
using SunnyFlamingo.Entities;
using SunnyFlamingo.Models;
using SunnyFlamingo.ValueObjects;

namespace SunnyFlamingo.Controllers
{
    public class ImagesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ImgOptions _imageOptions;
        private readonly IMapper _mapper;
        public ImagesController(
            ApplicationDbContext context, 
            IOptions<ImgOptions> imageOptions,
            IMapper mapper)
        {
            _context = context;
            _imageOptions = imageOptions.Value;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetImage(ImageType type, Guid id)
        {
            var path = await Task.Run(()=> GetPath(type, id));
            await Test();
            if (path == null)
            {
                return NotFound();
            }
            //var fileInformation = await GetFileInformation(type, name);
            //if (fileInformation == null)
            //{
            //    return NotFound();
            //}
            var stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
            //return File(stream, fileInformation.MimeType);
            return File(stream, "image/jpeg");
        }
        private string GetPath(ImageType type, Guid id)
        {
            switch (type)
            {
                case ImageType.Avatar:
                    //return Path.Combine(_imageOptions.ImagePartPathes.Avatars, imageName);
                case ImageType.GoodImg:
                    var partPath = $"{GetRandomNum()}.jpg";
                    return Path.Combine(_imageOptions.ImgPartPathes.GoodImg, partPath);
                    //return Path.Combine(_imageOptions.ImagePartPathes.GoodImg, imageName);
                default:
                    return null;
            }
        }
        private int GetRandomNum()
        {
            var rand = new Random();
            return rand.Next(0, 10);
        }
        class Foo
        {
            public int Count { get; set; }
            public string Value { get; set; }
        }
        private async Task Test()
        {






            var goodList = new Goods() { GoodList = _context.Goods };
            var result = _mapper.Map<GoodsInformation<string>>(goodList);
            //var asdasd = result.Questions.ToList();
            //foreach (var asd in result.Questions)
            //{
            //    var vsdv = asd.QuestionBaseList.ToList();
            //    foreach (var asdv in asd.QuestionBaseList)
            //    {
            //        var l = asdv;
            //    }
            //}
            //var adasdadasdad = _context.Goods.GroupBy(
            //    g => g.Producer.Name,
            //    g => g,
            //    (key, p) => new Foo() { Value = key, Count = p.Count() }
            //    ).ToList();
            //var adasdadasdergad = _context.Goods.GroupBy(g => g.Producer.Name).Select(g => new Foo() { Value = g.Key, Count = g.Count() }).ToList();
            var goods = _context.Goods.AsQueryable();
            //var asdasd = goods.GroupBy(p => p).Select(p => p.First()).ToList();
            var res = new QuestionsBase<string>()
            {
                Key = "Producer",
                Value = "Select producer",
                Order = 1,
                QuestionBaseList =
                goods
                .Select(g => g.Producer.Name)
                .GroupBy(p => p)
                .Select(p => new Foo() { Count = p.Count(), Value = p.Key } )
                .Select(producer => new QuestionBase<string>()
                {
                    //AfterBox = goods.Count(g => g.Producer.Name == producer).ToString(),
                    Checked = false,
                    ControlType = ControlType.Checkbox,
                    Key = producer.Value,
                    Label = producer.Value,
                    Required = false,
                    Type = InputType.Checkbox,
                    //Order = i
                }).ToList()
                //.GroupBy(p => p.Key)
                //.Select(g => { g.FirstOrDefault().AfterBox = g.Count().ToString(); return g.FirstOrDefault(); })
                //.ToList()
            };
            //foreach (var asd in res.QuestionBaseList)
            //{
            //    var l = asd;
            //}
            //foreach (var ress in rdfbfgb.QuestionBaseList)
            //{
            //    var l = ress;
            //}
            await goods.ToListAsync();

            //var redfv = _mapper.Map<GoodsInformation<string>>(_context.Goods);
        }
        //private QuestionsBase<string> GetTest(IQueryable<Good> goods)
        //{
        //    return new QuestionsBase<string>()
        //    {
        //        Key = "Producer",
        //        Value = "Select producer",
        //        Order = 1,
        //        QuestionBaseList =
        //         goods
        //        .Select(g => g.Producer.Name)
        //        .GroupBy(p => p)
        //        .Select(p => p.FirstOrDefault())
        //        .Select((producer, i) => new QuestionBase<string>()
        //        {
        //            AfterBox = goods.Count(g => g.Producer.Name == producer).ToString(),
        //            Checked = false,
        //            ControlType = ControlType.Checkbox,
        //            Key = producer,
        //            Label = producer,
        //            Required = false,
        //            Type = InputType.Checkbox,
        //            Order = i
        //        })
        //    };
        //}
    }
}
