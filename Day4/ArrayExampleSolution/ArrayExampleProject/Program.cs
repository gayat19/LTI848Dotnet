using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExampleProject
{

    //Printing  numbers in asc order
    class Program
    {
        //int num1, num2, num3, num4;
        int[] numbers; 

        Program()
        {
            int size = 0;
            Console.WriteLine("Please enter the number of numbers");
            size = Convert.ToInt32(Console.ReadLine());
            numbers = new int[size];
        }

        void TakeNumbersToArrayFromUser()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("please enter the number {0}",(i+1));
                while (!Int32.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    Console.WriteLine("Invaid num{0}. please enter again",( i + 1));
                }
            }
        }

        void SortArray()
        {
            int temp = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length-1; j++)
                {
                    if(numbers[j]>numbers[j+1])
                    {
                        temp = numbers[j + 1];
                        numbers[j + 1] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
        }

        /*void TakeNumbersFromUser()
        {
            Console.WriteLine("please enter the number 1");
            while (!Int32.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Invaid num1. please enter again");
            }
            Console.WriteLine("please enter the number 2");
            while (!Int32.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Invaid num2. please enter again");
            }
            Console.WriteLine("please enter the number 3");
            while (!Int32.TryParse(Console.ReadLine(), out num3))
            {
                Console.WriteLine("Invaid num3. please enter again");
            }
            Console.WriteLine("please enter the number 4");
            while (!Int32.TryParse(Console.ReadLine(), out num4))
            {
                Console.WriteLine("Invaid num4. please enter again");
            }
        }*/

        void PrintAllNumbers()
        {
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            Console.WriteLine(this.GetType());
            Console.WriteLine("The numbers are");
            foreach (int num in numbers)//foreach(datatype ref in collection)
            {
                Console.WriteLine(num);
                //num = num + 1; //cannot edit
            }
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.TakeNumbersToArrayFromUser();
            Console.WriteLine("Initial Order");
            program.PrintAllNumbers();
            Console.WriteLine("After sorting");
            program.SortArray();
            program.PrintAllNumbers();
            Console.ReadKey();
        }
    }
}
