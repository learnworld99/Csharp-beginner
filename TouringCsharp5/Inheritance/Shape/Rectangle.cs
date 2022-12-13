using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouringCsharp5.Inheritance.Shape
{
    internal class Rectangle : Shape
    {
        public Rectangle(double width, double length)
        {
            this.Width = width;
            this.Length = length;
        }

        public double Width { get; }
        public double Length { get; }

        public override double Area => Length * Width;

        public override double Parimeter => 2 * (Width + Length);

        public double Diagonal => Math.Round(Math.Sqrt(Math.Pow(Length, 2) + Math.Pow(Width, 2)), 2);

        public bool IsSquare() => Width == Length;
    }
}
