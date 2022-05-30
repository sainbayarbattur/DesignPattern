using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityDesignPatternRealTimeExample
{
    public abstract class Employee
    {
        // next element in chain or responsibility
        protected Employee supervisor;
        public void setNextSupervisor(Employee supervisor)
        {
            this.supervisor = supervisor;
        }
        public abstract void applyLeave(string employeeName, int numberofDaysLeave);
    }
}
