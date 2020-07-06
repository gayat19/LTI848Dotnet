using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExampleProject
{
    class Program
    {
        //Creating our own delegate type
        //public delegate void myDel(int number1, int number2);//used to point to a method which has void as return and 2 int parameters
        // myDel calDel;//creating the reff for our deletegate type

       public Program()
        {
            //calDel = new myDel(Mul);//instantiating the reff
        }
       public void Add(int n1,int n2)
        {
            int res = n1 + n2;
            Console.WriteLine("Simply add 2 numbers "+res);
        }
        public void Mul(int n1, int n2)
        {
            int res = n1 * n2;
            Console.WriteLine("Simply Mul 2 numbers " + res);
        }

        internal void CalculateTax(Func<int,double> p)
        {
            Console.WriteLine("Please enter the base price");
            int prc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The tax amount is "+p(prc)); 
        }

        internal void Login(Predicate<User> pre)
        {
            User user1 = new User();
            user1.TakeUserData();
            if(pre(user1))
                Console.WriteLine("Welcome");
            else
                Console.WriteLine("Get lost");
        }

        //Action is an Inbuilt delegate type - Action, Func,Predicate
        public void GetNumbers(Action<int,int> del)
        {
            Console.WriteLine("Please enter the number 1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the number 2");
            int num2 = Convert.ToInt32(Console.ReadLine());
            del(num1,num2); //method reff
           //Calculate(num1, num2);//passing the method as paramter
        }

        
        //public  void Calculate(int num1, int num2 )
        //{
        //    //passing parameters to method using delegate
        //    calDel(num1, num2);//using the reference to invoke the delegate
        //}

        //static void Main(string[] args)
        //{
        //    new Program().GetNumbers();
        //    Console.ReadKey();
        //}
    }
}
