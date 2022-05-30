using System;
using System.Collections.Generic;
using System.Text;

namespace StateDesignPatern
{
    interface ATMState
    {
        void InsertDebitCard();
        void EjectDebitCard();
        void EnterPin();
        void WithdrawMoney();
    }
}
