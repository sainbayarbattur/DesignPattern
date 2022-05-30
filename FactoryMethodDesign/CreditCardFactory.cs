﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesign
{
    public abstract class CreditCardFactory
    {
        protected abstract CreditCard MakeProduct();
        public CreditCard CreateProduct()
        {
            return this.MakeProduct();
        }
    }
}

