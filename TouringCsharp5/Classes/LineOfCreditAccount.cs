using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouringCsharp5.Classes
{
    internal class LineOfCreditAccount : BankAccount
    {
        public LineOfCreditAccount(string owner, decimal initialBalance, decimal creditLimit) : base(owner, initialBalance, -creditLimit)
        {
        }

        public override void PerformMonthEndTransactions()
        {
            if (Balance < 0)
            {
                decimal interest = -Balance * 0.07m;
                MakeWithdrawal(
                    amount: interest,
                    date: DateTime.Now,
                    note: "Charge montly");
            }
        }
        protected override Transaction CheckWithdrawalLimit(bool isOverdrawn) =>
    isOverdrawn
    ? new Transaction(-20, DateTime.Now, "Apply overdraft fee")
    : default;
    }
}
