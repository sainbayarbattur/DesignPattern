using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public interface IVendingMachineState
    {
        void SelectProductAndInsertMoney(int amount, String productName);
        void DispenseProduct();
    }
}
