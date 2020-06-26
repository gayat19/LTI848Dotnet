using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.PrintStudentDetails();
            student1.Learn();
            Console.ReadKey();
        }
    }
}
