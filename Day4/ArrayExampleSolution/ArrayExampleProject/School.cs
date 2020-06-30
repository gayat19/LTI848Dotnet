using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolLibrary;
namespace ArrayExampleProject
{
    class School
    {
        void AddStudent()
        {
            Student student = new Student();
            student.GetStudentDetailsFromUser();
            student[0] = "C";
            student[1] = "Java";
            student[2] = "Dotnet";//Ref is in LHS so will call the set of indexer 
            string skill2 = student[1];//Ref is in RHS so will call the get of indexer
            Console.WriteLine(student);//call the ToString() method
           // student.PrintStudentDetails();
        }
        static void Main(string[] args)
        {
            School school = new School();
            school.AddStudent();
            Console.ReadKey();
        }
    }
}
