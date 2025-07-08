using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayushi_NVB
{
    internal class Array_Max
    {
        public static void Main(string[] args)
        {
            int[] ary = new int[5];
            Console.WriteLine("Enter array elements : ");
            for (int i = 0; i < ary.Length; i++)
            {
                ary[i] = Int32.Parse(Console.ReadLine());
            }

            // To find maximum element in array.
            int max = ary[0];
            for(int i =0; i < ary.Length; i++)
            {
                if (ary[i] > max)
                {
                    max = ary[i];
                }
            }
            Console.WriteLine("Maximum element in array: " + max);
        }
    }
}
