using System;
using System.Collections.Generic;
using System.Text;

namespace InterPreterDesignPattern
{
    public class Context
    {
        public string expression { get; set; }
        public DateTime date { get; set; }
        public Context(DateTime date)
        {
            this.date = date;
        }
    }
}
