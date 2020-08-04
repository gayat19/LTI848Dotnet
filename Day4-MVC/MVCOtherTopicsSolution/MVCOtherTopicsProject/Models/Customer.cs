using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCOtherTopicsProject.Models
{
    public class Customer
    {
        int id, age;
        string name;
        string[] skills = new string[3];

        public string this[int index]
        {
            get { return Skills[index]; }
            set { Skills[index] = value; }
        }
        public Customer() { }
        public Customer(int id,string name,int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }

        public int Id { get => id; set => id = value; }
        public int Age { get => age; set => age = value; }
        public string Name { get => name; set => name = value; }
        public string[] Skills { get => skills; set => skills = value; }
    }
}