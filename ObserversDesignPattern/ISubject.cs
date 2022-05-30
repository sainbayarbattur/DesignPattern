﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ObserversDesignPattern
{
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers();
    }
}
