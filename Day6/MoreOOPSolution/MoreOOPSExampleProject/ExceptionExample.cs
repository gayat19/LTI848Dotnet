using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreOOPSExampleProject
{
    class ExceptionExample
    {
        void Calculate()
        {
            int num1=0, num2=0, res=0;
           try
            {
                Console.WriteLine("Please enter the first number");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the second number");
                num2 = Convert.ToInt32(Console.ReadLine());
                if (num1 < 10 || num2 < 10)
                    throw new InvalidNumberException();
                res = num1 + num2;
                Console.WriteLine("The sum is " + res);
                res = num1 - num2;
                Console.WriteLine("num1 - num2 " + res);
                try
                {
                    res = num1 / num2;
                    Console.WriteLine("num1 / num2 " + res);
                }
                catch (DivideByZeroException divideByZero)
                {
                    Console.WriteLine(divideByZero.Message);
                    Console.WriteLine("The dinominator resulted in 0. We cannot divide by zero");
                }
                res = num1 * num2;
                Console.WriteLine("The product is " + res);
            }
            catch (InvalidNumberException ie)
            {
                Console.WriteLine(ie.Message);
                Console.WriteLine(ie.StackTrace);
            }
            catch (FormatException formatException)
            {
                Console.WriteLine(formatException.Message);
                Console.WriteLine("The input should have been an number");
               // Console.WriteLine(formatException.StackTrace);
            }
            catch (Exception exception)
            {
                Console.WriteLine("Some error");
            }
            finally
            {
                Console.WriteLine("Always");
            }
            Console.WriteLine("After the catch block");

            
        }
        static void Main(string[] args)
        {
            ExceptionExample exceptionExample  = new ExceptionExample();
            exceptionExample.Calculate();
            Console.ReadKey();
        }
    }
}
