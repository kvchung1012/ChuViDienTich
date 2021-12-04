using System;
using System.Collections.Generic;
using System.Text;

namespace Quadrangle.Model
{
    public class TamGiac
    {
        public ToaDo dinh1 { get; set; }
        public ToaDo dinh2 { get; set; }
        public ToaDo dinh3 { get; set; }

        public double DienTich()
        {
            double a = dinh1.KhoangCach(dinh2);
            double b = dinh2.KhoangCach(dinh3);
            double c = dinh3.KhoangCach(dinh1);

            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return s;
        }
    }
}
