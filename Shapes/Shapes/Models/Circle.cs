using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shapes.Models
{
    public class Circle
    {
        public float Radius { set; get; } ///bán kính hình tròn

        public float Perimeter() => (float)(Math.PI * Radius * 2);
        public float Acreage() => (float)(Math.PI * Radius * Radius);
    }
}