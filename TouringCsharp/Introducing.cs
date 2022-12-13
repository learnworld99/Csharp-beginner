using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TouringCsharp.Program;

namespace TouringCsharp
{
    internal class Introducing
    {
        public class HelpAttribute : Attribute
        {
            string _url;
            string _topic;

            public HelpAttribute(string url) => _url = url;

            public string Url  => _url;
            public string Topic
            {
                get => _topic;
                set => _topic = value;
            }
           
        }
        [Help("https://docs.microsoft.com/dotnet/csharp/tour-of-csharp/features")]
        public class Widget
        {
            [Help("https://docs.microsoft.com/dotnet/csharp/tour-of-csharp/features",
            Topic = "Display")]
            public void Display(string text) { }
        }

        public class Point
        {
            public int X { get; set; }
            public int Y { get; set; }

            public Point(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }
        }

        public class Point3D : Point
        {
            public int Z { get; set; }

            public Point3D(int x, int y, int z) : base(x, y)
            {
                this.Z = z;
            }
        }

        public class Pair<TFirst, TSecond>
        {
            public TFirst First { get; }
            public TSecond Second { get; }
            public static readonly Seasons seasons = Seasons.All;

            public Pair(TFirst first, TSecond second)
            {
                this.First = first;
                this.Second = second;
            }

            public override string ToString() => seasons.ToString();
        }

        public struct Point2D
        {
            public int X { get; set; }
            public int Y { get; set; }

            public Point2D(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }
        }
    }
}
