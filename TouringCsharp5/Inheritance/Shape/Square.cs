using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouringCsharp5.Inheritance.Shape
{
    internal class Square : Shape
    {
        public Square(double side)
        {
            this.Side = side;
        }

        public double Side { get; }

        public override double Area => Math.Pow(Side, 2);

        public override double Parimeter => 4 * Side;

        public double Diagonal => Math.Round(Math.Sqrt(2) * Side, 2);
    }
}
