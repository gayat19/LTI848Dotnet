using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class Employee
    {
        int id, age;
        string name;

        public int Id { get => id; set => id = value; }
        public int Age { get => age; set => age = value; }
        public string Name { get => name; set => name = value; }

        public void TakeEmployeeDetailsFromUser()
        {
            Console.WriteLine("Please enter the employee ID");
            while (!Int32.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Invalid Entry for ID. Please try again");
            }
            Console.WriteLine("Please enter the Employee Name");
            name = Console.ReadLine();
            Console.WriteLine("Please enter the employee Age");
            while (!Int32.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Invalid Entry for age. Please try again");
            }
        }
        public void PrintEmployeeDetails()
        {
            Console.WriteLine("Employee ID {0}, Name {1}, Age {2}",id,name,age);
        }
        internal void SampleInternalMethod()
        {
            Console.WriteLine("Internal method");
        }
    }
    //class Another
    //{
    //    void CallInternalMethod()
    //    {
    //        Employee e1 = new Employee();
    //        e1.SampleInternalMethod();
    //    }
    //}
}
