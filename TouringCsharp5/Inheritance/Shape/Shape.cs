using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouringCsharp5.Inheritance.Shape
{
    internal abstract class Shape
    {
        public abstract double Area { get; }
        public abstract double Parimeter { get; }
        public override string ToString()
        {
            return GetType().Name;
        }
        public static double GetArea(Shape shape) => shape.Area;
        public static double GetPerimeter(Shape shape) => shape.Parimeter;
    }
}
