using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeLibrary;

namespace CompanyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.TakeEmployeeDetailsFromUser();
            employee.PrintEmployeeDetails();
            Console.ReadKey();
        }
    }
}
