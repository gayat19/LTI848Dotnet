using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstWebApi.Models
{
    [Serializable]
    public class Student
    {
        int id, age;
        string name;
        //public Student() { }
        public Student(int id,string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }
        public int Id { get => id; set => id = value; }
        public int Age { get => age; set => age = value; }
        public string Name { get => name; set => name = value; }
    }
}