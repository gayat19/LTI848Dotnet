using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingExampleProject
{
    class College
    {
        void addStudent()
        {
            CollegeStudent student1 = new CollegeStudent(12000);
            //student.Stipend = 10000;
            student1.GetStudentDetailsFromUser();
            Console.WriteLine(student1);
            CollegeStudent student2 = new CollegeStudent(12000);
            student2.GetStudentDetailsFromUser();
            Console.WriteLine(student2);
            //if(student1.Stipend == student2.Stipend)
            //{

            //}
            CollegeStudent student3 = student2 + student1;
            Console.WriteLine("The added student is "+student3);
            if(student1 == student2)
                Console.WriteLine("Same stipend");
            else
                Console.WriteLine("Sipend differs");
        }
        static void Main(string[] args)
        {
            new College().addStudent();
            Console.ReadKey();
        }
    }
}
