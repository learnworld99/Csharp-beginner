using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TouringCsharp5.Classes;
using TouringCsharp5.Inheritance;
using TouringCsharp5.Inheritance.Books;
using TouringCsharp5.Inheritance.Hubungan;
using TouringCsharp5.Inheritance.Shape;

namespace TouringCsharp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo culture = new CultureInfo("id-ID");

            #region Class Intro
            //BankAccount account = new BankAccount(
            //    owner: "Lorep Ipsum",
            //    initialBalance: 900);

            //Console.WriteLine($"New Account successfuly created by:\n{nameof(account.Owner)} = {account.Owner}\n{nameof(account.Balance)} = {account.Balance.ToString("C", culture)}");

            //account.MakeWithdrawal(
            //    amount: 100,
            //    date: DateTime.Now,
            //    note: "Rent payment");

            //account.MakeDeposit(
            //    amount: 800,
            //    date: DateTime.Now,
            //    note: "Friend paid me back");

            //string getAccountHistory = account.GetAccountHistory();
            //Console.WriteLine(getAccountHistory);

            //BankAccount invalid;

            //try
            //{
            //    invalid = new BankAccount(
            //        owner: "Invalid Testing",
            //        initialBalance: -80);
            //}
            //catch (ArgumentOutOfRangeException e)
            //{
            //    Console.WriteLine(e.Message);
            //    throw;
            //}

            //Console.WriteLine();

            //var giftCard = new GiftCardAccount("gift card", 100, 50);
            //giftCard.MakeWithdrawal(20, DateTime.Now, "get expensive coffee");
            //giftCard.MakeWithdrawal(50, DateTime.Now, "buy groceries");
            //giftCard.PerformMonthEndTransactions();
            //// can make additional deposits:
            //giftCard.MakeDeposit(27.50m, DateTime.Now, "add some additional spending money");
            //Console.WriteLine(giftCard.GetAccountHistory());

            //var savings = new InterestEarningAccount("savings account", 10000);
            //savings.MakeDeposit(750, DateTime.Now, "save some money");
            //savings.MakeDeposit(1250, DateTime.Now, "Add more savings");
            //savings.MakeWithdrawal(250, DateTime.Now, "Needed to pay monthly bills");
            //savings.PerformMonthEndTransactions();
            //Console.WriteLine(savings.GetAccountHistory());

            //var lineOfCredit = new LineOfCreditAccount("line of credit", 0);
            //// How much is too much to borrow?
            //lineOfCredit.MakeWithdrawal(1000m, DateTime.Now, "Take out monthly advance");
            //lineOfCredit.MakeDeposit(50m, DateTime.Now, "Pay back small amount");
            //lineOfCredit.MakeWithdrawal(5000m, DateTime.Now, "Emergency funds for repairs");
            //lineOfCredit.MakeDeposit(150m, DateTime.Now, "Partial restoration on repairs");
            //lineOfCredit.PerformMonthEndTransactions();
            //Console.WriteLine(lineOfCredit.GetAccountHistory());

            //var lineOfCredit = new LineOfCreditAccount("line of credit", 0, 2000);
            //// How much is too much to borrow?
            //lineOfCredit.MakeWithdrawal(1000m, DateTime.Now, "Take out monthly advance");
            //lineOfCredit.MakeDeposit(50m, DateTime.Now, "Pay back small amount");
            //lineOfCredit.MakeWithdrawal(5000m, DateTime.Now, "Emergency funds for repairs");
            //lineOfCredit.MakeDeposit(150m, DateTime.Now, "Partial restoration on repairs");
            //lineOfCredit.PerformMonthEndTransactions();
            //Console.WriteLine(lineOfCredit.GetAccountHistory());

            #endregion

            #region Inheritance Intro
            var b = new BaseClass.B();
            Console.WriteLine(b.GetValue());

            var c = new DerivedClass();
            Console.WriteLine(c.halo);
            c.Method1();

            Console.WriteLine();

            Type t = typeof(SampleA);
            BindingFlags flags = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy;

            MemberInfo[] members = t.GetMembers(flags);
            Console.WriteLine($"Type {t.Name} has {members.Length} members");

            foreach (MemberInfo member in members)
            {
                string access = "";
                string stat = "";
                var method = member as MethodBase;

                if (method.IsPublic)
                    access = "public";
                else if (method.IsPrivate)
                    access = " Private";
                else if (method.IsFamily)
                    access = " Protected";
                else if (method.IsAssembly)
                    access = " Internal";
                else if (method.IsFamilyOrAssembly)
                    access = " Protected Internal ";
                if (method.IsStatic)
                    stat = " Static";

                string output = $"{member.Name} ({member.MemberType}): {access}{stat}, Declared by {member.DeclaringType}";
                Console.WriteLine(output);
                Console.WriteLine();

                var packard = new AutoMobile(
                    make: "Packard",
                    model: "Custom Eight",
                    year: 1948);

                Console.WriteLine(packard.ToString());

                Console.WriteLine();
                SampleA sampleA = new SampleA();
            }

            var book = new Book("The Tempest", "0971655819", "Shakespeare, William",
                           "Public Domain Press");
            ShowPublicationInfo(book);
            book.Publish(new DateTime(2016, 8, 18));
            ShowPublicationInfo(book);

            var book2 = new Book("The Tempest", "Classic Works Press", "Shakespeare, William");
            Console.Write($"{book.Title} and {book2.Title} are the same publication: " +
                  $"{((Publication)book).Equals(book2)}");
            Console.WriteLine();
            Console.WriteLine(book);
            #endregion

            #region Abstract
            Console.WriteLine();
            Shape[] shapes = new Shape[] { new Circle(radius: 8), new Rectangle(width: 8, length: 9), new Square(side: 2) };

            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.ToString());
                Console.WriteLine($"{shape}: area, {Shape.GetArea(shape)}; " +
                                  $"perimeter, {Shape.GetPerimeter(shape)}");
                if (shape is Rectangle rect)
                {
                    Console.WriteLine($"   Is Square: {rect.IsSquare()}, Diagonal: {rect.Diagonal}");
                    continue;
                }
                if (shape is Square sq)
                {
                    Console.WriteLine($"   Diagonal: {sq.Diagonal}");
                    continue;
                }
            }
            #endregion
        }

        private static void ShowPublicationInfo(Publication pub)
        {
            string pubDate = pub.GetPublicationDate();
            Console.WriteLine($"{pub.Title}, " +
                      $"{(pubDate == "NYP" ? "Not Yet Published" : "published on " + pubDate):d} by {pub.Publisher}");
        }
    }
}
