using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjInheritanceExampleProject
{
    class Automobile
    {
        public Automobile()
        {
            Console.WriteLine("Automobile created");
        }
        ~Automobile()
        {
            Console.WriteLine("NO more automobile");
        }
        protected void AddParts()
        {
            Console.WriteLine("Adding the required parts");
        }
    }
    class Car : Automobile
    {
        public Car()
        {
            Console.WriteLine("It is a car");
        }
        ~Car()
        {
            Console.WriteLine("Car is gone");
        }
        public void Run()
        {
          
            Console.WriteLine("Runs in speed");
        }
    }

    class Audi:Car
    {
        public Audi()
        {
            Console.WriteLine("It is Audi car");
        }
        ~Audi()
        {
            Console.WriteLine("Not a Audi Brand ");
        }
        public void AddBrand()
        {
            AddParts();
            Console.WriteLine("Audi is a good brand");
        }
    }

    class UnderstandingConstructorsWithInheritance
    {
        static void Main(string[] args)
        {
            Audi a8 = new Audi();
            //a8.AddParts();
            a8.Run();
            a8.AddBrand();
            a8 = null;
            GC.Collect();
            Console.ReadKey();
        }
    }
}
