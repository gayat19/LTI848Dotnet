using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityArrayProject
{
    class Program
    {
        void UnderstandingArray()
        {
            int[,] numbers = new int[3, 4];//{ { 1, 2, 3, 4 }, { 6, 7, 8, 9 }, { 10, 11, 12, 14 } };
            int[][] specialArray = new int[4][];//Jagged array
            specialArray[0] = new int[4];
            specialArray[1] = new int[2];
            specialArray[2] = new int[3];
            specialArray[3] = new int[5];
            /* jagged array
             * 1 2 3 4
             * 1 2
             * 1 2 3
             * 1 2 3 4 5
             * */
            /*Normal Multi Dim array
             * 1 2 3 4
             * 5 6 7 8
             * 9 1 0 1
             * 8 6 5 4
             * */
            for (int i = 0; i < specialArray.Length; i++)
            {
                for (int j = 0; j < specialArray[i].Length; j++)
                {
                    Console.Write(specialArray[i][j]+" ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            new Program().UnderstandingArray();
            Console.ReadKey();
        }
    }
}
