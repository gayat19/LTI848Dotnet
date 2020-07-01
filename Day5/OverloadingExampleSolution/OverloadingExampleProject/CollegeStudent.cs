using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolLibrary;

namespace OverloadingExampleProject
{
    class CollegeStudent : Student
    {
        double stipend;
        //default empty constuctor- if no constructor

        public CollegeStudent()//no parameter so default constructor
        {
            Console.WriteLine("College Student Constructor");
        }
        public CollegeStudent(double stipend)//overloaded constructor-Parameterized constructor
        {
            Console.WriteLine("College Student Constructor with stipend");
            this.stipend = stipend;//the instance variable = parameter(local variable)
        }
        public override string ToString()
        {
            return base.ToString() + " The stipend is "+stipend;
        }
        public static bool operator==(CollegeStudent s1,CollegeStudent s2)
        {
            bool result = false;
            if (s1.Stipend == s2.Stipend)
                result = true;
            return result;
        }
        public static bool operator !=(CollegeStudent s1, CollegeStudent s2)
        {
            bool result = false;
            if (s1.Stipend != s2.Stipend)
                result = true;
            return result;
        }

        public static CollegeStudent operator+(CollegeStudent s1, CollegeStudent s2)
        {
            CollegeStudent student = new CollegeStudent();
            student.Stipend = s1.Stipend + s2.Stipend;
            student.Name = s1.Name + " " + s2.Name;
            student.Id = s1.Id + s2.Id;
            return student;
        }
        public double Stipend { get => stipend; set => stipend = value; }
    }
}
