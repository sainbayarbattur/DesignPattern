using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternPayment
{
    public class CashPaymentStrategy : IPaymentStrategy
    {
        public void Pay(double amount)
        {
            Console.WriteLine("Customer pays Rs " + amount + " By Cash");
        }
    }
}
