using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouringCsharp5.Classes
{
    internal class InterestEarningAccount : BankAccount
    {
        public InterestEarningAccount(string owner, decimal initialBalance) : base(owner, initialBalance)
        {
        }

        public override void PerformMonthEndTransactions()
        {
            if (Balance < 500m)
            {
                decimal interest = Balance * 0.5m;
                MakeDeposit(
                    amount: interest,
                    date: DateTime.Now,
                    note: "Apply monthly interest");
            }
        }
    }
}
