using System;
using System.Collections.Generic;
using System.Text;

namespace Quadrangle.Model
{
    public class TuGiac
    {
        public ToaDo dinh1 { get; set; }
        public ToaDo dinh2 { get; set; }
        public ToaDo dinh3 { get; set; }
        public ToaDo dinh4 { get; set; }

        public double ChuVi()
        {
            return dinh1.KhoangCach(dinh2) + dinh2.KhoangCach(dinh4) + dinh3.KhoangCach(dinh4) + dinh1.KhoangCach(dinh3);
        }

        public double DienTich()
        {

            double a = dinh1.KhoangCach(dinh2);
            double b = dinh2.KhoangCach(dinh4);
            double c = dinh3.KhoangCach(dinh4);
            double d = dinh1.KhoangCach(dinh3);

            double p = (a + b + c + d) / 2;
            double s = Math.Sqrt((p - a) + (p - b) + (p - c) + (p - d));
            return s;
        }
    }
}
