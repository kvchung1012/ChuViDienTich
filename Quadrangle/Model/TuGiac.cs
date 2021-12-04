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
            double a = dinh1.KhoangCach(dinh2);
            double b = dinh2.KhoangCach(dinh4);
            double c = dinh3.KhoangCach(dinh4);
            double d = dinh1.KhoangCach(dinh3);
            return a + b + c + d;
        }

        public double DienTich()
        {
            TamGiac t1 = new TamGiac()
            {
                dinh1 = dinh1,
                dinh2 = dinh2,
                dinh3 = dinh3,
            };
            TamGiac t2 = new TamGiac()
            {
                dinh1 = dinh2,
                dinh2 = dinh3,
                dinh3 = dinh4,
            };
            return t1.DienTich() + t2.DienTich();

            //double a = dinh1.KhoangCach(dinh2);
            //double b = dinh2.KhoangCach(dinh4);
            //double c = dinh3.KhoangCach(dinh4);
            //double d = dinh1.KhoangCach(dinh3);
            //double p = (a + b + c + d) / 2;
            //return Math.Sqrt((p-a)*(p-b)*(p-c)*(p-d));
        }
    }
}
