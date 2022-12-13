using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouringCsharp2
{
    internal class Car : ICar<Car>
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }

        public Car(
            string make, 
            string model,
            string year)
        {
            this.Make = make;
            this.Year = year;
            this.Model = model;
        }
        public bool Equals(Car car)
        {
           return (this.Make, 
                this.Model,
                this.Year) == 
                (car.Make, 
                car.Model, 
                car.Year);
        }
    }
}
