using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouringCsharp4.IntroException
{
    internal class CustomException : Exception
    {
        public CustomException(string message)
        {

        }

        private static void TestTrwo()
        {
            throw new CustomException("Custome exception in Test Throw");
        }
    }
}
