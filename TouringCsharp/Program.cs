using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static TouringCsharp.Introducing;

namespace TouringCsharp
{
    internal class Program
    {
        [Flags]
        internal enum Seasons
        {
            None = 0,
            Summer, 
            Autum, Winter,
            Spring,
            All = Summer | Autum | Spring
        }

        static void Main(string[] args)
        {
            Pair<int,string> pair = new Pair<int, string>(1, "Hallo world");
            Point point = new Point(2, 8);
            Point point3d = new Point3D(2, 3, 9);

            Point2D point2D = new Point2D(2, 9);

            (double sum, int count) t = (2, 9);

            //Console.WriteLine(t.sum + t.count);

            int a = 20;
            int b = 10;

            Console.WriteLine($"{a} {b}");
            Swap(ref a, ref b);
            Console.WriteLine($"{a} {b}");
            Divide(a, b, out int c);

            Console.WriteLine(c);

            Multiply(a, b);
            RetrieveDocsHomePage();

            Type widgetType = typeof(Widget);

            object[] widgetClassAttributes = widgetType.GetCustomAttributes(typeof(HelpAttribute), false);

            if (widgetClassAttributes.Length > 0)
            {
                HelpAttribute attr = (HelpAttribute)widgetClassAttributes[0];
                Console.WriteLine($"Widget class help URL : {attr.Url} - Related topic : {attr.Topic}");
            }

            System.Reflection.MethodInfo displayMethod = widgetType.GetMethod(nameof(Widget.Display));

            object[] displayMethodAttributes = displayMethod.GetCustomAttributes(typeof(HelpAttribute), false);

            if (displayMethodAttributes.Length > 0)
            {
                HelpAttribute attr = (HelpAttribute)displayMethodAttributes[0];
                Console.WriteLine($"Display method help URL : {attr.Url} - Related topic : {attr.Topic}");
            }
        }

        private static void Multiply(int a, int b)
        {
            long j;
            while(a <= b)
            {
                j = Math.BigMul(a, a);
                Console.WriteLine($"{a} * {b} = {j}");
                a++;
            }
        }

        private static void Divide(int a, int b, out int c)
        {
            c = (int)Decimal.Divide(a, b);
        }

        private static void Swap(ref int a, ref int b)
        {
            int x = b;
            b = a;
            a = x;

        }

        public static async Task<int> RetrieveDocsHomePage()
        {
            var client = new HttpClient();
            byte[] content = await client.GetByteArrayAsync("https://docs.microsoft.com/");

            Console.WriteLine($"{nameof(RetrieveDocsHomePage)}: finished downloading.");

            return content.Length;
        }
    }
}
