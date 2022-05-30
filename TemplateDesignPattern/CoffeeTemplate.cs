using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateDesignPattern
{
    public abstract class CoffeeTemplate
    {
        // PrepareCoffee method is the template method
        public void PrepareCoffee()
        {
            BoilWater();
            AddMilk();
            AddSugar();
            AddCoffeePowder();
            Console.WriteLine(this.GetType().Name + " is Ready");
        }
        protected abstract void BoilWater();
        protected abstract void AddMilk();
        protected abstract void AddSugar();
        protected abstract void AddCoffeePowder();
    }
}
