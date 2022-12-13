using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouringCsharp4.IntroException
{
    [Serializable]
    internal class InvalidCustomException : Exception
    {
        public InvalidCustomException() : base()
        {

        }

        public InvalidCustomException(string message) : base(message)
        {

        }

        public InvalidCustomException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
