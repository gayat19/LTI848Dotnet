using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsExampleProject
{
    class Supplier
    {
        string id, name;
        double amount;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Amount { get => amount; set => amount = value; }

        public void PrintDetails()
        {
            Console.WriteLine("Supplier ID "+id);
            Console.WriteLine("Supplier Name " + name);
            Console.WriteLine("Supplier Pending Amount " + amount);
            Console.WriteLine("-------------------------------");
        }
    }
}
