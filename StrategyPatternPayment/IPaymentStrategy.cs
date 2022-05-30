using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternPayment
{
    public interface IPaymentStrategy
    {
        void Pay(double amount);
    }
}
