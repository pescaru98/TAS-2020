using System;
using System.Collections.Generic;
using System.Text;

namespace C1NUnitTest.CurrencyConverter
{
    public class CurrencyConverterStub : ICurrencyConverter
    {
        public static double EurToRonRate { get; } = 4.87f;
        public double convertFromEurToRon(double amount)
        {
            return amount * EurToRonRate;
        }

        public double convertFromRonToEur(double amount)
        {
            throw new NotImplementedException();
        }
    }
}
