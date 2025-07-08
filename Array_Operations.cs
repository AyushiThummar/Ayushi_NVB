using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayushi_NVB
{
    internal class Array_Operations
    {
        public static void Main(string[] args)
        {
            int[] ary = new int[5];
            Console.WriteLine("Enter array elements : ");
            for (int i = 0; i < ary.Length; i++)
            {
                ary[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            int sum = 0;
            for (int i = 0; i<ary.Length; i++)
            {
                sum = sum + ary[i];
            }
            //average:
            double average = (double)sum / ary.Length;

            // Display sum and average
            Console.WriteLine("Sum of array elements: " + sum);
            Console.WriteLine("Average of array elements: " + average);

        }
    }
}
