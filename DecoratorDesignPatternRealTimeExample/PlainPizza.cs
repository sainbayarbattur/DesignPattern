using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesignPatternRealTimeExample
{
    public class PlainPizza : Pizza
    {
        public string MakePizza()
        {
            return "Plain Pizza";
        }
    }
}
