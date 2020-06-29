using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjInheritanceExampleProject
{
    //take a num
    //check if / by any other than 1 and itself
    //print result
    class PrimeCheck
    {
        int num;
        /// <summary>
        /// 
        /// </summary>
        void TakeNumebrFromUser()
        {
            Console.WriteLine("Please enter a number");
            while (Int32.TryParse(Console.ReadLine(), out num)==false || num<2)
            {
                Console.WriteLine("Invalid Input. Try again");
            }
        }
        void CheckPrime()
        {
            bool isPrime = true;
            for (int i = 2; i < (num/2); i++)
            {
                if(num%i ==0)
                {
                    isPrime = false;
                    break;
                }
            }
            PrintResult(isPrime);
        }

        private void PrintResult(bool isPrime)
        {
            if(isPrime)
                Console.WriteLine("{0} is a Prime Number",num);
            else
                Console.WriteLine("{0} is not a prime number",num);
        }

        static void Main(string[] args)
        {
            PrimeCheck pc = new PrimeCheck();
            pc.TakeNumebrFromUser();
            pc.CheckPrime();
            Console.ReadKey();
        }
    }
}
