using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApplication
{
    class Student
    {
        int id;
        string name;
        DateTime dateOfBirth;
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }

        //constructor--same name as class name
        //Defines an object's behaviour initially
        //used for initializations
        public Student()
        {
            id = 101;
            name = "Ramu";
            dateOfBirth = DateTime.Now;
        }

        //[AccessSpecifier] ReturnType Identifier([parameter List])
        public void Learn()
        {
            Console.WriteLine("Learning C#");
        }

        public void PrintStudentDetails()
        {
            Console.WriteLine("Student ID "+id);
            Console.WriteLine("Student Name " + name);
            Console.WriteLine("Student Date of Birth " + dateOfBirth);
        }
    }
}
