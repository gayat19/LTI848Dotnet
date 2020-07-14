using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumPrefix
{
    class Program
    {

        /* long[] CalculateSum(long[] nums)
         {
             long[] sums = new long[nums.Length + 1];
             sums[0] = 0;
             for (int i = 0; i < nums.Length; i++)
             {
                 sums[i + 1] = sums[i]+nums[i];
             }
             return sums;
         }

         long CountTotal(long[] nums, int start, int end)
         {
             return nums[end + 1] - nums[start];
         }
         long MushroomPick(long[] nums, int start, int moves)
         {
             long total = 0;
             long[] maxTotal = CalculateSum(nums);
             int len = nums.Length;
             int leftPos=0, rightPos=0;
             for (int i = 0; i < ((start < moves ? start : moves) + 1); i++)
             {
                 leftPos = start - i;
                 rightPos = Math.Min(len - 1, Math.Max(start, start + moves - 2 * i));
                 total = Math.Max(total, CountTotal(maxTotal, leftPos, rightPos));
             }
             int value = Math.Min(moves + 1, len - start);
             for (int i = 0; i < value; i++)
             {
                 rightPos = start + i;
                 leftPos = Math.Max(0, Math.Min(start, (start - (moves - 2 * i))));
                 total = Math.Max(total, CountTotal(maxTotal, leftPos, rightPos));
             }
             return total;
         }*/
        class ValueClass
        {
            public int val;
            public int? next_min;
        }

        public int[] solution(string S, int[] P, int[] Q)
        {
            int strLen = S.Length;
            ValueClass[] minImpact = new ValueClass[strLen];
            Stack<ValueClass> dataStack = new Stack<ValueClass>();
            Dictionary<char, int> nucleotide = new Dictionary<char, int>(){
            {'A',1},
            {'C',2},
            {'G',3},
            {'T',4}
        };
            for (int i = -1; ++i < strLen;)
            {
                minImpact[i] = new ValueClass()
                {
                    val = nucleotide[S[i]],
                    next_min = null
                };
                while (dataStack.Count > 0 && minImpact[i].val < dataStack.Peek().val)
                    dataStack.Pop().next_min = i;
                if (minImpact[i].val > 1)
                    dataStack.Push(minImpact[i]);
            }
            int[] result = new int[P.Length];
            for (int i = -1; ++i < P.Length;)
            {
                ValueClass current = minImpact[P[i]];
                if (current.val > 1)
                    while ((current.next_min ?? Q[i] + 1) <= Q[i])
                        current = minImpact[current.next_min.Value];
                result[i] = current.val;
            }
            return result;

        }
        //void FillArray(ref int[][] mins, int row_num, int start, int end, int min)
        //{
        //    for (int i = start; i < end; i++)
        //    {
        //        mins[row_num][i] = min;
        //    }
        //}

        static void Main(string[] args)
        {
            //long[] spots = {2,3,7,5,1,3,9 };
            //long tot = new Program().MushroomPick(spots, 4, 6);
            //Console.WriteLine("Total Mushrroms Collected "+tot);
            string S = "CAGCCTA";
            int[] P = {2,5,0 };
            int[] Q = {4,5,6 };
            int[] res = new Program().solution(S, P, Q);
            foreach (var item in res)
            {
                Console.Write(item+" ,");
            }
            Console.ReadKey();
        }
    }
}
