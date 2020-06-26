using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsExampleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("In the Program Class");
            //ProductManager productManager = new ProductManager();
            //productManager.AddProduct();
            //productManager.PrintProductDetails();
            //Supplier supplier1 = new Supplier();
            //supplier1.Id = "S001";
            //supplier1.Name = "ABC Corp";
            //supplier1.Amount = 1243443;
            ////Supplier supplier2 = new Supplier();
            //Supplier supplier2 = supplier1;
            //supplier2.Id = "S002";
            //supplier2.Name = "XYZ & Co";
            //supplier2.Amount = 86689.32;
            //double totalAmount = supplier1.Amount + supplier2.Amount;
            //supplier1.PrintDetails();
            //supplier2.PrintDetails();
            //Console.WriteLine("Total Amount : " + totalAmount);
            string strName = "Ramu";
            strName = strName.ToLower();

            var data = "Hello";
            //data = 123; - not possible C# is type safe

            int inum = 10;
            float fnum = 123.9f;
            double dnum = 5343.1;
            string snum = "100";
            fnum = inum;//no data loss
            dnum = fnum;//8b=4b - no data loss
            inum = (int)fnum;//4b = 3b.1b=>data loss->explicit casting
            Console.WriteLine(inum);
            fnum = inum;
            fnum = (float)dnum;//4b=8b=>data loss-typecassting
            dnum = Convert.ToDouble(snum);//unboxing
            snum = inum.ToString();//boxing
            Console.ReadKey();
        }
    }
}
