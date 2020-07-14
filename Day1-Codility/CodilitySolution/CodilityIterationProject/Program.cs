using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityIterationProject
{
    class Program
    {

        static void Main(string[] args)
        {
            Program program = new Program();
            program.CountNumberOfDigits(1323432);
            //double result = new Program().FindFactorial(10);
            //Console.WriteLine(result);
            Console.ReadKey();
        }

        private void UnderstandingOperators()
        {
            int num1 = 20, num2 = 80;
            int sum = (num1 > num2) ? (num1 + num2) : (num2 + 100);//tenary Operator
            Console.WriteLine(sum);
        }
        void Print100()
        {
            for(int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
        }
        //Write a method which will find factorial of a given number
        double FindFactorial(int num)
        {
            double factorial = 1;//If not, If we initialize with 0 then everything will be 0
            for (int i = 2; i <= num; i++)
            {
                factorial *= i;
                //factorial = factorial * i;
            }
            return factorial;
        }
        void PrintStarTriangle(int num)
        {
            //string symbol = "*";
            //for (int i = 0; i < num; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write(symbol);
            //    }
            //    Console.WriteLine();
            //}
            for (int i = 0; i < num; i++)            {                for (int j = 0; j < i; j++)                {                    Console.Write(' ');                }                for (int k = i; k <= num - i + 1; k++)                {                    Console.Write('*');                }                Console.WriteLine();            }
        }
        void CountNumberOfDigits(double num)
        {
            //132343
            Console.WriteLine("Inside method");
            int count = 1;
            while(num>10)
            {
                if(num/10 >0)
                {
                    count++;
                    num = num / 10;
                }
            }
            Console.WriteLine("The number os digits in {0} are {1}",num,count);
        }
    }
}
