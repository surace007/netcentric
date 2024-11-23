using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Program to print calendar using jagged arrray

            Console.WriteLine("Printing the calendar using jagged array (one month).\n\n");
            //initializing jagged array
            int[][] calendar =
            {
                new int[] {1,2,3,4,5,6,7},
                new int[] {8,9,10,11,12,13,14},
                new int[] {15,16,17,18,19,20,21 },
                new int[] {22,23,24,25,26,27,28},
                new int[] {29,30,31,32}

            };
            Console.WriteLine("Sun    Mon   Tue   Wed   Thu   Fri   Sat");
            for (int i = 0; i < calendar.Length; i++)
            {
                for (int j = 0; j < calendar[i].Length; j++)
                {
                    //using format method to align output
                    Console.Write(String.Format("{0,-7}", calendar[i][j]));
                }
                Console.WriteLine();
            }
        }
    }
}
