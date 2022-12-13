using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouringCshap3.Film;
using TouringCshap3.Polimorfisme;

namespace TouringCshap3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
            int? maybe = 12;

            if (maybe is int number)
                Console.WriteLine($"The nullable int 'maybe' has the value {number}");
            else
                Console.WriteLine($"The nullable int 'maybe' does't hold a value");

            _ = "Hallo world";
            Console.WriteLine();

            (string name, int year, int year2) tuple = ("new york city", 1960, 2010);

            Person p = new Person(
                            firstname: "joe doe",
                            lastName: "ermando sugio",
                            city: "Mexico",
                            state: "Europe");

            Console.WriteLine(p.ID);

            string[] dateStrings = {"05/01/2018 14:57:32.8", "2018-05-01                 14:57:32.8",
                      "2018-05-01T14:57:32.8375298-04:00", "5/01/2018",
                      "5/01/2018 14:57:32.80 -07:00",
                      "1 May 2018 2:57:32.8 PM", "16-05-2018 1:00:32 PM",
                      "Fri, 15 May 2018 20:10:57 GMT" };

            foreach (var date in dateStrings)
            {
                if (DateTime.TryParse(date, out _))
                    Console.WriteLine(date + " is valid");
                else
                    Console.WriteLine(date + " is not valid");
            }

            // Standard comment pisahkan char awal dengan spasi dan di awali dengan huruf besar dan di akhiri dengan titik

            string t = "hallo world";

            var p1 = p;


            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"Argument {args[i]}");
            }


            BankAccount account = new BankAccount(
                                    name: "Lorep Ipsum",
                                    initialBalance: 20000);

            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance:N0}");

            account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            Console.WriteLine(account.Balance);
            account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
            Console.WriteLine(account.Balance);

            // Test that the initial balances must be positive.
            BankAccount invalidAccount;
            try
            {
                invalidAccount = new BankAccount("invalid", -55);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with negative balance");
                Console.WriteLine(e.ToString());
                return;
            }

            // Test for a negative balance.
            try
            {
                account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exception caught trying to overdraw");
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine(account.GetAccountHistory());
            **/

            Person p = new Person(
                firstname: "Joe",
                lastName: "Doe",
                city: "Semarang",
                state: "Indonesia");

            string format = "{0}{1,20}{2,20}";
            Console.WriteLine($"{format}", "full name", "city", "state");
            Console.WriteLine($"{format},{nameof(p),20}",
                string.Join(" ", p.FirstName, p.LastName), 
                p.City, 
                p.State);

            Person p1 = p;
            Console.WriteLine($"{format},{nameof(p1),20}",
               string.Join(" ", p1.FirstName, p1.LastName),
               p1.City,
               p1.State);

            p1.FirstName = "Lorep";
            p1.LastName = "Ipsum";
            p1.City = "Jakarta";

            Console.WriteLine();
            Console.WriteLine($"{format},{nameof(p),20}",
               string.Join(" ", p.FirstName, p.LastName),
               p.City,
               p.State);

            Console.WriteLine($"{format},{nameof(p1),20}",
               string.Join(" ", p1.FirstName, p1.LastName),
               p1.City,
               p1.State);

            Person p3 = new Person(
                firstname: "Dummy",
                lastName: "Alberto",
                city: "Kudus",
                state: "Indonesia");

            Console.WriteLine($"{format},{nameof(p3),20}",
               string.Join(" ", p3.FirstName, p3.LastName),
               p3.City,
               p3.State);

            Console.WriteLine();

            if (p.Equals(p1))
            {
                Console.WriteLine($"{nameof(p)} is equal {nameof(p1)}");

                if (p1.Equals(p3))
                    Console.WriteLine($"{nameof(p3)} is equal {nameof(p1)}");
                else
                    Console.WriteLine($"{nameof(p3)} is not equal {nameof(p1)}");
            }

            GenreAction fastAndFurious = new GenreAction(
                title: "Fast And Furious 2",
                sutradara: "James Holand",
                budget: 20000,
                rating: 4.2,
                genre: "action",
                new List<string> { "Lorep Ipsum", "Joe Doe", "Marcues", "James Mark"});

            fastAndFurious.GetFilm();

            Console.WriteLine();
            List<Shape> shapes = new List<Shape>() 
            { 
                new Circle(),
                new Rectangle()
            };

            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}
