using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MyFirstWebApi.Models;

namespace MyFirstWebApi.Controllers
{
    public class StudentController : ApiController
    {
        static List<Student> students = new List<Student>() { new Student(101, "Ramu", 23)};

        [HttpGet]
        public List<Student> GetAllStudents()
        {
            return students;
        }

        [HttpPost]
        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        [HttpPut]
        public string EditStudent(int id, Student student)
        {
            string result = "Done";
            try
            {
               
                students[students.FindIndex(s => s.Id == id)] = student;
            }
            catch (Exception e)
            {
                result = e.Message;
            }
            return result; 
        }
        [HttpDelete]
        public string DeleteStudent(int id)
        {
            string result = "Done";
            try
            {
                students.Remove(students.Find(s => s.Id == id));
            }
            catch (Exception e)
            {
                result = e.Message;
            }
            return result;
        }

    }
}
