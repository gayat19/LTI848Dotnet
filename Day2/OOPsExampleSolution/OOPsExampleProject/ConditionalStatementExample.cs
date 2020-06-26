using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsExampleProject
{
    class ConditionalStatementExample
    {
        void FindGreatest()
        {
            int num1 = 100, num2 = 100;
            if(num1==num2)
                Console.WriteLine("Both are equal");
            else if(num1>num2)
                Console.WriteLine("Num 1 is greatest");
            else
                Console.WriteLine("Num 2 is greatest");
        }
        static void Main(string[] s)
        {
            new ConditionalStatementExample().FindGreatest();
            Console.ReadKey();
        }
    }
}
