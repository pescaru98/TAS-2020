using System;
using System.Collections.Generic;
using System.Text;

namespace C1NUnitTest
{
    public class BankAccountSpy : BankAccount
    {
        public int countDeposit { get; private set; } = 0;
        public int countWithdraw { get; private set; } = 0;
        public int countTransfer { get; private set; } = 0;

        public new void Deposit(double amount)
        {
            base.Deposit(amount);
            countDeposit++;
        }

        public new void Withdraw(double amount)
        {
            base.Withdraw(amount);
            countWithdraw++;
        }

        public new void Transfer(BankAccount destination, double amount)
        {
            base.Transfer(destination, amount);
            countTransfer++;
        }
    }
}
