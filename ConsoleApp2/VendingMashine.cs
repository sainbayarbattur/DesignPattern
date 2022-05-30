using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class VendingMachine : IVendingMachineState
    {
        //Createing a variable to maintain the internal state
        public IVendingMachineState vendingMachineState { get; set; }
        //Initially the vending machine has NoMoneyState
        public VendingMachine()
        {
            vendingMachineState = new NoMoneyState();
        }

        public void SelectProductAndInsertMoney(int amount, string productName)
        {
            vendingMachineState.SelectProductAndInsertMoney(amount, productName);
            // Money has been inserted so vending Machine internal state 
            // changed to 'hasMoneyState'
            if (vendingMachineState is NoMoneyState)
            {
                vendingMachineState = new HasMoneyState();
                Console.WriteLine("VendingMachine internal state has been moved to : "
                                + vendingMachineState.GetType().Name);
            }
        }
        public void DispenseProduct()
        {
            vendingMachineState.DispenseProduct();
            // Product has been dispensed so vending Machine changed the
            // internal state to 'NoMoneyState'
            if (vendingMachineState is HasMoneyState)
            {
                vendingMachineState = new NoMoneyState();
                Console.WriteLine("VendingMachine internal state has been moved to : "
                                + vendingMachineState.GetType().Name);
            }
        }
    }
}
