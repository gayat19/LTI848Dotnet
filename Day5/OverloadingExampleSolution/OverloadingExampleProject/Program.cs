using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingExampleProject
{
    class Program
    {
        void add()
        {
            Console.WriteLine("Nothing to add");
        }
        void add(int num1)
        {
            num1++;
            Console.WriteLine("Heyyy we got a number to increment "+num1);
        }
        void add(int num1,float num2)
        {
            Console.WriteLine("Int and float");
            Console.WriteLine("Heyyy we got 2 numbers  " + (num1+num2));
        }
        void add(float num1, int num2)
        {
            Console.WriteLine("Float and int");
            Console.WriteLine("we got 2 numbers  " + (num1 + num2));
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.add(10, 12.2f);
            program.add(10);//method call
            //program.add(12,12.2,9);
            Console.ReadKey();

        }
    }
}
