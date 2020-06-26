using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsExampleProject
{
    class ProductManager
    {
        //creating ref
        Product p1; 
        //P!=p
        //Method
        public void AddProduct()
        {
            //instantiation the ref
            p1 = new Product();
            p1.CreateProduct();//Method call
        }
        public void PrintProductDetails()
        {
            Console.WriteLine("The ref is ");
            Console.WriteLine(p1);
            Console.WriteLine("Done");
            p1.PrintProduct();
            //int sum = p1.Add();
            //Console.WriteLine("The result is "+sum);
            
        }
    }
}
