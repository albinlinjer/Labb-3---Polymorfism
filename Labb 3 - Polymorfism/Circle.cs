using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3___Polymorfism
{
    internal class Circle : Geometry
    {
        public double Radius { get; set; }

        // Konstruktor med fast värde
        public Circle()
        {
            Radius = 4;
        }

        // Override av Area() för cirkelns area
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
