using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.ValueObjects
{
    public class ImgOptions
    {
        public string ImgPath { get; set; }
        public ImgPathesOptions ImgPartPathes { get; set; }

        public string Avatars
        {
            get
            {
                return ImgPartPathes.Avatars;
            }
            set
            {
                ImgPartPathes.Avatars = Path.Combine(ImgPath, value);
            }
        }
        public string GoodImages
        {
            get
            {
                return ImgPartPathes.GoodImg;
            }
            set
            {
                ImgPartPathes.GoodImg = Path.Combine(ImgPath, value);
            }
        }
    }
}
