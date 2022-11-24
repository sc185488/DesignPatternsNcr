using DesignPatternsNew.AdapterDesignPattern.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsNew
{
    class Program
    {
        public static void Main(string[] args)
        {
            EmployeeManager employeeManager = new EmployeeManager();
            Console.WriteLine(employeeManager.GetAllEmployeesInXml());
            IEmployee iEmployee = new EmployeeAdapter(new EmployeeManager());
            Console.WriteLine(iEmployee.GetAllEmployees()); 
        }
    }
}
