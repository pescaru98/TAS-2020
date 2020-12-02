using C1NUnitTest.CurrencyConverter;
using System;
using System.Collections.Generic;
using System.Text;

namespace C1NUnitTest
{
    public class BankAccount
    {
        //Balance -> [0,10000]
        public double Balance { get; set; }
        public static double MIN_BALANCE { get; } = 0.0;
        public static double MAX_BALANCE { get; } = 10000.0;

        public BankAccount()
        {
            this.Balance = 0;
        }

        public void Deposit(double amount)
        {
            if (amount < 0) throw new NegativeNumberException("You provided a negative number");
            if (this.Balance + amount > MAX_BALANCE) throw new TooManyFundsException("Exceeded limit "+MAX_BALANCE);
            this.Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount < 0) throw new NegativeNumberException("You provided a negative number");
            if (this.Balance - amount < MIN_BALANCE) throw new NotEnoughFundsException("Not enough funds!");
            this.Balance -= amount;
        }

        public void Transfer(BankAccount destination, double amount)
        {
            destination.Deposit(amount);
            this.Withdraw(amount);
        }

        public void TransferFromEurToRon(BankAccount destination, double amountInEur, ICurrencyConverter converter)
        {
            destination.Deposit(converter.convertFromEurToRon(amountInEur));
            this.Withdraw(converter.convertFromEurToRon(amountInEur));
        }
    }
}
