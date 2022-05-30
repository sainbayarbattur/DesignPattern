using System;
using System.Collections.Generic;
using System.Text;

namespace ObserversDesignPattern
{
    
    public interface IObserver
    {
        void update(string availability);
    }
}

