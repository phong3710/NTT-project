using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shapes.Models
{
    public class Rectangle
    {
        public float Width { set; get; }
        public float Heigh { set; get; }

        public float Perimeter() => (Heigh + Width) * 2;

        public float Acreage() => Heigh * Width;

    }
}