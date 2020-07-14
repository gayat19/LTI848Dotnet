using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 100, 89, 34, 98, 67, 67, 45, 30, 99, 70 };
            List<int> nums = new List<int>();
            nums.AddRange(A.ToList());
            var grad = nums.Where(n => n > 80);//LINQ - with predicate in where clause
            foreach (var item in grad)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
