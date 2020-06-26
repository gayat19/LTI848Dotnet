using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
 
    class Customer
    {
        //Attributes
        int age;
        string name;
        //CTRL+R+E

        //Property
        public int Age { get => age; set => age = value; }
        public string Name { get => name; set => name = value; }


        //Behaviour
        public void BuyProduct()
        {
            Console.WriteLine("Customer with name {0} has bought the product", Name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer myCustomer = new Customer();
            myCustomer.Age = 21;
            myCustomer.Name = "Ramu";
            myCustomer.BuyProduct();
            Console.ReadKey();

        }
    }
}
