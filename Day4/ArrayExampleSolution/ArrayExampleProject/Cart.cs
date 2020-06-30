using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExampleProject
{
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("All animals eat food");
        }
        public void Sleep()
        {
            Console.WriteLine("zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz");
        }
        public virtual void Run()
        {
            Console.WriteLine("Run");
        }
    }
    class Horse : Animal
    {
        public override void Run()
        {
            Console.WriteLine("Tok a tok. tok a tok.");
        }
    }
    class Donkey: Animal
    {
        public override void Run()
        {
            Console.WriteLine("Tok...tok....tok...tok.");
        }
    }
    class Cart
    {
        void CreateCart()
        {
            Console.WriteLine("Choose an animal for pulling the cart");
            string choice = Console.ReadLine().ToLower();
            Animal myAnimal = null;
            switch (choice)
            {
                case "horse":
                    myAnimal = new Horse();
                    break;
                case "donkey":
                    myAnimal = new Donkey();
                    break;
                case "any":
                    myAnimal = new Animal();
                    break;
                default:
                    Console.WriteLine("No animal in that name for cart. Go go..." );
                    break;
            }
            PullCart(myAnimal);
        }
        void PullCart(Animal animal)
        {
            if (animal != null)
            {
                animal.Eat();
                animal.Run();
                animal.Sleep();
            }
        }
        static void Main(string[] args)
        {
            new Cart().CreateCart();
            Console.ReadKey();
        }
    }
}
