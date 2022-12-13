using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouringCsharp5.Inheritance
{
    internal class BaseClass
    {
        private int _value = 20;
        internal string halo = "Hallo";

        public class B : BaseClass
        {
            public int GetValue() => _value;
        }

        public virtual void Method1()
        {
            Console.WriteLine("This is method base class");
        }
    }
}
