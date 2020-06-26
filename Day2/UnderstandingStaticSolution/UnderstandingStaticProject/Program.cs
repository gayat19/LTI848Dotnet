using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingStaticProject
{
    class Program
    {
        //instance member
        int num1;
        //static member
        static int num2;
        const int num3 = 1000;
        void m1()
        {
            //instance member in instance context
            num1 = 100;
            //static member in instance context
            num2 = 200;
            //constant member cannot be changed
            //num3 = 2000;
        }

        void addOne()
        {
            Console.WriteLine("The value of num1 - instance initially is "+num1);
            Console.WriteLine("The value of num2 - static initially is " + num2);
            num1++;
            num2++;
            Console.WriteLine("The value of num1 - instance after increment is " + num1);
            Console.WriteLine("The value of num2 - static after increment is " + num2);
        }
        static void Main(string[] args)
        {
            Program p1 = new Program();
            Program p2 = new Program();
            p1.addOne();
            p2.addOne();
            Console.ReadKey();
        }
    }
}
