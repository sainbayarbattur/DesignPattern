using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternPayment
{
    public class CreditCardPaymentStrategy : IPaymentStrategy
    {
        public void Pay(double amount)
        {
            Console.WriteLine("Customer pays Rs " + amount + " using Credit Card");
        }
    }
}
