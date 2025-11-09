using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3___Polymorfism
{
    public class Rectangle : Geometry
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle()
        {
            Width = 4;
            Height = 3;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}
