using System;
using System.Collections.Generic;
using System.Text;

namespace Quadrangle.Model
{
    public class ToaDo
    {
        public double x { get; set; }
        public double y { get; set; }

        public double KhoangCach(ToaDo toa)
        {
            return Math.Sqrt(((x - toa.x) * (x - toa.x)) + ((y - toa.y) * (y - toa.y)));
        }
    }

}
