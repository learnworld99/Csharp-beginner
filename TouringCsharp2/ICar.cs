using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouringCsharp2
{
    internal interface ICar<T> where T : class
    {
        bool Equals(T obj);
    }
}
