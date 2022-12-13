using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouringCsharp5.Inheritance.Hubungan
{
    internal class AutoMobile
    {
        public AutoMobile(string make, string model, int year)
        {
            if (make == null)
                throw new ArgumentNullException(nameof(make), "The make cannot be null.");
            else if (string.IsNullOrWhiteSpace(make))
                throw new ArgumentException("make cannot be an empty string or have space character");
            this.Make = make;

            if (model == null)
                throw new ArgumentNullException(nameof(model), "The make cannot be null.");
            else if (string.IsNullOrWhiteSpace(model))
                throw new ArgumentException("model cannot be an empty string or have space character");
            this.Model = model;

            if (year < 1857 || year > DateTime.Now.Year + 2)
                throw new ArgumentException("The year is out the range.");
            this.Year = year;
        }

        public string Make { get; }
        public string Model { get; }
        public int Year { get; }

        public override string ToString()
        {
            return $"{Year} {Make} {Model}";
        }
    }
}
