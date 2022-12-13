using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouringCsharp5.Inheritance
{
    internal class DerivedClass : BaseClass
    {
        // public int GetValue() => _value; // error

        public override void Method1()
        {
            Console.WriteLine("This is method in Derived class");
        }
    }
}
