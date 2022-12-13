using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouringCsharp5.Inheritance.Shape
{
    internal class Circle : Shape
    {
        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Area => Math.Round(Math.PI * Math.Pow(Radius, 2), 2);

        public override double Parimeter => Math.Round(Math.PI * 2 * Radius, 2);

        // Define a circumference, since it's the more familiar term.
        public double Circumference => Parimeter;

        public double Radius { get; }

        public double Diameter => Radius * 2;
    }
}
