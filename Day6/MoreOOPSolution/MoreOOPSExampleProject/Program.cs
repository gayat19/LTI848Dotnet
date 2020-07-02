using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreOOPSExampleProject
{
    interface I2
    {
        void M2();
    }
    interface I1:I2
    {
        void M1();
    }
    abstract class C1 : I1
    {
        public abstract void M1();
        public  void M2()
        {
            Console.WriteLine("M2");
        }
    }
    class Parent
    {
        public virtual void Sample()
        {
            Console.WriteLine("Hello from Sample in Parent");
        }
    }
    class Child:Parent
    {
        public new void Sample()//shadowing
        {
            Console.WriteLine("Hi from Sample in Child");
        }
        public void Another()
        {
            Console.WriteLine("another method");
        }
    }

    abstract class Animal//a class that cannot be instantiated
    {
        public void Eat()
        {
            Console.WriteLine("All animals eat");
        }
        public void Breathe()
        {
            Console.WriteLine("Breathe in..... Breathe out..... Repeat");
        }
        public abstract void Look();//Child class much override
    }
    class Monkey : Animal
    {
        public override void Look()
        {
            Console.WriteLine("Two legs and Two hands, but uses hands like leg. Jums");
        }
    }
    interface IFlying
    {
        void TakeOff();
        void Fly();
        void Land();
    }
    class Bird : Animal,IFlying
    {
        public void Fly()
        {
            Console.WriteLine("Flap slow and keep altitute");
        }
        public void Land()
        {
            Console.WriteLine("Stop flapping");
        }
        public override void Look()
        {
            Console.WriteLine("With wings and light weight");
        }

        public void TakeOff()
        {
            Console.WriteLine("Flap Wings");
        }
    }
    class Plane : IFlying
    {
        public void Fly()
        {
            Console.WriteLine("Auto Pilot");
        }

        public void Land()
        {
            Console.WriteLine("Landing Gear");
        }

        public void TakeOff()
        {
            Console.WriteLine("Pick up speed and take off...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Parent parent = new Parent();//Parent ref = Parent Object
            //parent.Sample();//Parent method
            //Parent parent = new Child();//Parent ref = Child Object
            //parent.Sample();//Child method
            //Parent child = new Child();//Parent ref = Child Object
            //child.Sample();//Child method
            //Animal animal = new Monkey();
            //animal.Eat();
            //animal.Breathe();
            //animal.Look();
            Bird bird = new Bird();
            IFlying flyingObject = bird;
            flyingObject.TakeOff();
            flyingObject.Fly();
            flyingObject.Land();
            Animal animal = bird;
            animal.Breathe();
            Console.ReadKey();
        }
    }
}
