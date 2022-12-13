using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouringCsharp4
{
    internal class ExceptionTest
    {
        public static double SafeDivision(double a, double b)
        {
            if (a == 0)
                throw new DivideByZeroException($"Tidak bisa membagi  {b} dengan nol.");

            return b / a;
        }
    }
}
