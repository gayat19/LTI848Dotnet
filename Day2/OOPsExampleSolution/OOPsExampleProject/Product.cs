using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsExampleProject
{
    class Product
    {
        private int id;
        private string name;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        //method declaration->definition -> invocation

        public void PrintProduct()//head - accessspecifier returnType Identifier([Parameters])
            //body{}
        {
            Console.WriteLine("Product Id " + id);
            Console.WriteLine("Product Name " + name);
        }

        public void CreateProduct()
        {
            Console.WriteLine("Please enter the product ID");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the product Name");
            name = Console.ReadLine();
        }
        //function
        public int Add()
        {
            int num1, num2;
            Console.WriteLine("Please enter the first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            return (num1 + num2);
        }
    }
}
