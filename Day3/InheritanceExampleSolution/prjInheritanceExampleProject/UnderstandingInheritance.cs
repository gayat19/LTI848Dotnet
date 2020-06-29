using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjInheritanceExampleProject
{
    class UnderstandingInheritance
    {
        void CheckTypes()
        {
            Phone phone=null ;
            Console.WriteLine("what is the phone that you want???");
            string choice = Console.ReadLine().ToLower();
            switch (choice)
            {
                case "phone":
                    phone = new Phone();
                    break;
                case "smartphone":
                    phone = new SmartPhone();
                    break;
                case "satillite":
                    phone = new SatillitePhone();
                    break;
                default:
                    //phone = new Phone();
                    Console.WriteLine("Invalid phone type");
                    break;
            }
            UsePhone(phone);
        }
        void UsePhone(Phone phone)
        {
            phone.Color = "Blue";
            phone.RingingVolume = 5;
            phone.Ring();
            phone.ReceiveCall("New");
            phone.MakeCall("5432167890");
            if(phone.GetType()==typeof(SmartPhone))
            {
                ((SmartPhone)phone).PlayGame();//typecasting
            }
            else if(phone.GetType() == typeof(SatillitePhone))
            {
                ((SatillitePhone)phone).MakeCallFromAnywhere();
            }

        }
        static void Main(string[] args)
        {
            new UnderstandingInheritance().CheckTypes();
            Console.ReadKey();

        }
    }
}
