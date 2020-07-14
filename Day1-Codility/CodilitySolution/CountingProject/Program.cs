using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingProject
{
    class Program
    {
        List<long> CountOccurance(List<long> a, long num)
        {
            long[] counts = new long[num+1];
            for (int i = 0; i < a.Count; i++)
            {
                counts[a[i]] += 1;
            }
            return counts.ToList();
        }

        bool Fast_Solution(List<long> A, List<long> B, long num)
        {
            int length = A.Count;
            long sumA = A.Sum();
            long sumB = B.Sum();
            Console.WriteLine("Sum A {0}, Sum B {1}",sumA,sumB);
            long diff = sumB - sumA;
            Console.WriteLine("Diff "+diff);
            if(diff%2 == 1)
            {
                return false;
            }
            List<long> counts = CountOccurance(A, num);
            foreach (var item in counts)
            {
                Console.WriteLine(item);
            }
            diff /= 2;
            for (int i = 0; i < length; i++)
            {
                if (0 < B[i] - diff && B[i] - diff <= num && counts[((int)B[i] - (int)diff)] > 0)
                    return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            long[] nums1 = { 10,6,7 };
            long[] nums2 = { 2,1,4 };
            long num = nums1.Max()>nums2.Max()?nums1.Max():nums2.Max();
            Program program = new Program();
            bool res = program.Fast_Solution(nums1.ToList(), nums2.ToList(), num);
            Console.WriteLine(res);
            //int cnt = program.CountOccurance(nums.ToList(), num);
            //Console.WriteLine("The number of times {0} occoured is {1}",num,cnt);
            Console.ReadKey();
        }
    }
}
