using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouringCsharp2.Inheritance;

namespace TouringCsharp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Lamborgini", "2022", "2022");
            Car car1 = new Car("BMW", "2021", "2012");
            Car sameCar = car;

            string fmt = "{0}{1,30}{2,30}";
            Console.WriteLine(fmt, "Make", "Model", "Year");
            Console.WriteLine(fmt, car.Make, car.Model, car.Year);
            Console.WriteLine(fmt, sameCar.Make, sameCar.Model, sameCar.Year);

            Console.WriteLine($"{nameof(car)} apakah sama dengan {nameof(sameCar)} = {car.Equals(sameCar)} ");

            Object obj = new { };


            //Console.WriteLine(car.Equals(car1));


            var products = new[] { new { name = "apple", price = 3.9 } };

            var mango = new { Name = "Mango", Price = 90 };

            GetName(mango);

            Console.WriteLine();

            WorkItem item = new WorkItem(
                                title: "fix bugs",
                                description: "fix all bugs in my code branch",
                                jobLength: new TimeSpan(4, 0, 0, 0));

            ChangeRequest change = new ChangeRequest(
                                    title: "change base class design",
                                    desc: "add members to the class",
                                    jobLength: new TimeSpan(4, 0, 0, 0),
                                    originalID: 1);


            Console.WriteLine(item.ToString());

            change.Update(
                    title: "change the design of the base class",
                    jobLength: new TimeSpan(4, 0, 0));

            Console.WriteLine(change.ToString());
        }

        private static void GetName(object mango)
        {
            Console.WriteLine(mango.ToString());
        }
    }
}
