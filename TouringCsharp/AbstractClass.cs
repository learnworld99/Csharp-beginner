﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouringCsharp
{
    internal class AbstractClass
    {
        public abstract class Expression
        {
            public abstract double Evaluate(Dictionary<string, object> verb);
        }

        public class Constant : Expression
        {
            private double _value;

            public Constant(double value)
            {
                this._value = value;
            }

            public override double Evaluate(Dictionary<string, object> verb)
            {
                return _value;
            }
        }
    }
}
