using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExampleProject
{
    class ShowExample
    {
        void Div(int num1, int num2)
        {
            double res = num1 / num2;
            Console.WriteLine("The division result is "+res);
        }
        double Tax(int price)
        {
            return price * 12.2 / 100;
        }
        void CreateCalculator()
        {
            Program program = new Program();
            //anon method
            //program.GetNumbers(delegate (int num1,int num2){
            //    Console.WriteLine("The sub result is " + (num1-num2));
            //});

            //Lambda Expr
            // program.GetNumbers((num1, num2)=>Console.WriteLine("The sub result is " + (num1 - num2)));
            program.GetNumbers(program.Mul);
            // program.CalculateTax((basePrice) => basePrice * 12.2 / 100);
            program.CalculateTax(Tax);
            program.Login((user)=>user.Username=="Ramu"&&user.Password=="1234");

        }
        static void Main(string[] args)
        {
            new ShowExample().CreateCalculator();
            Console.ReadKey();
        }
    }
    class User
    {
        string username, password;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public void TakeUserData()
        {
            Console.WriteLine("Please enter the username");
            username = Console.ReadLine();
            Console.WriteLine("Please enter the password");
            password = Console.ReadLine();
        }
    }
}
