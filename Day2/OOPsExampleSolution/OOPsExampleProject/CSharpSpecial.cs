using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsExampleProject
{
    class CSharpSpecial
    {

        public CSharpSpecial()//constructor
        {
            Console.WriteLine("Hey look you have constructed a object");
        }
         ~CSharpSpecial()//destructor
        {
            Console.WriteLine("Object going going... gone.");
        }
        void SpecialShow()
        {
            int iNum1 = int.MaxValue;
            //checked//Checked block
            //{
            //    Console.WriteLine(iNum1);
            //    iNum1++;
            //    Console.WriteLine(iNum1);
            //}
            string strNum = null;
            //iNum1 = int.Parse(strNum);// will not handle null
            //iNum1 = Convert.ToInt32(strNum);//Will handle null
            //iNum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number");
            if(int.TryParse(Console.ReadLine(), out iNum1) == false)//Error Handling
                Console.WriteLine("Invalid Input");
            iNum1 = iNum1 + 10;
            Console.WriteLine(iNum1);

        }

        static void Main(string[] a)
        {
            CSharpSpecial obj = new CSharpSpecial();
            //new CSharpSpecial().SpecialShow();//anon object
            obj.SpecialShow();
            obj = null;
            GC.Collect();//will deallocate the memory of objects that do not have valid refference
            Console.ReadKey();
        }
    }
}
