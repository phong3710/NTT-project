using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shapes.Models
{
    public class Triangle
    {
        public float FirstEdge { set; get; }
        public float SecondEdge { set; get; }
        public float ThirdEdge { set; get; }

        public bool LaTamGiac() => 
            (FirstEdge + SecondEdge > ThirdEdge) && 
            (SecondEdge + ThirdEdge > FirstEdge) && 
            (FirstEdge + ThirdEdge > SecondEdge);

        public float Perimeter() => FirstEdge + SecondEdge + ThirdEdge;

        public float Acreage()
        {
            float p = Perimeter() / 2;
            float value = (float)Math.Sqrt(p * (p - FirstEdge) * (p - SecondEdge) * (p - ThirdEdge));

            return (float)Math.Round(value, 2);
        }

    }
}