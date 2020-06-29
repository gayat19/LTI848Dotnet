using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjInheritanceExampleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.SampleIteration();
            Console.ReadKey();

        }
        void SampleIteration()
        {
            //for loop
            //Init;Cond;Upd
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("hello from for "+i);
            //}
            //While Loop
            //Cond
            int j = 0;
            //while (j < 10)
            //{
            //    Console.WriteLine("hello from while " + j);
            //    j++;
            //}
            //do-While Loop
            do
            {
                j++;
                if (j == 3)
                    continue;//will start the next iteration
                if (j%7 == 0)
                    break;//exit out of the loop
                Console.WriteLine("From Do While Loop "+j);
               
            } while (j<10);
        }
        void UseSwitchCase()
        {
            Console.WriteLine("Please enter your choice");
            string choice = Console.ReadLine().ToLower();
            //if(choice=="Yes")
            //{
            //    Console.WriteLine("You have accepted");
            //}
            //else if (choice == "No")
            //    Console.WriteLine("You have not accepted to the terms");
            //else
            //    Console.WriteLine("Invaid choice");
            switch (choice)
            {
                case "yes":
                    Console.WriteLine("You have accepted");
                    break;//control shifting statement
                case "no":
                    Console.WriteLine("You have not accepted to the terms");
                    break;
                case "may be":
                    Console.WriteLine("You have to either say yes or no");
                    break;
                default:
                    Console.WriteLine("You have entered an invalid choice");
                    break;
            }
        }
        void CreatePhone()
        {
            Phone iPhoneXI = new SmartPhone();//Every SmartPhone is phone
            //SmartPhone iPhoneX = new Phone();//Every Phone is not a smartphone
            //iPhoneXI.Charge();
            SatillitePhone sp = new SatillitePhone();//Satillite Phone is also a phone
            sp.Color = "Black";
            sp.RingingVolume = 1;
            sp.Ring();
            sp.ReceiveCall("9876543210");
            sp.MakeCallFromAnywhere();
            //iPhoneXI.RingingVolume = 8;
            //iPhoneXI.Color = "Red";
            //iPhoneXI.Charge();
            //iPhoneXI.CarryPhone();
            //iPhoneXI.MakeCall("Mom");
            //iPhoneXI.Ring();
            //iPhoneXI.ReceiveCall("1234567890");
            //iPhoneXI.PlayGame();
            //iPhoneXI.WhatsApping();
            
        }
    }
}
