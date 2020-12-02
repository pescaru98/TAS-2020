using System;
using System.Collections.Generic;
using System.Text;

namespace C1NUnitTest.CurrencyConverter
{
    public interface ICurrencyConverter
    {
        double convertFromEurToRon(double amount);
        double convertFromRonToEur(double amount);
    }
}
