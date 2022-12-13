using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouringCsharp5.Classes
{
    internal class GiftCardAccount : BankAccount
    {
        private readonly decimal _monthlyDeposit = 0m;

        public GiftCardAccount(string owner, decimal initialBalance, decimal monthlyDeposit) : base(owner, initialBalance)
        {
            _monthlyDeposit = monthlyDeposit;
        }

        public override void PerformMonthEndTransactions()
        {
            if (_monthlyDeposit != 0)
                MakeDeposit(
                    amount: _monthlyDeposit,
                    date: DateTime.Now,
                    note: "Add monthly deposit");
        }
    }
}
