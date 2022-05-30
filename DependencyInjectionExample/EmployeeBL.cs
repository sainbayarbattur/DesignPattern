using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyInjectionExample;


namespace DependencyInjectionExample
{
    public EmployeeDAL employeeDAL;
    public List<Employee> AllEmployees
    {
        get
        {
            EmployeeDAL = new EmployeeDAL();
            return employeeDAL.SelectAllEmployees();
        }
    }
}
