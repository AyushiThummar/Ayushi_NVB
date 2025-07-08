using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayushi_NVB
{
    internal class Array
    {
        public static void Main(string[] args)
        {
            //int[] ary = new int[5];     // Declaration of array
            //// Initializing array elements
            //ary[0] = 14;
            //ary[1] = 20;
            //ary[2] = 25;
            //ary[3] = 86;
            //ary[4] = -1425;
            //Console.WriteLine(ary[0]);
            //Console.WriteLine(ary[1]);
            //Console.WriteLine(ary[2]);
            //Console.WriteLine(ary[3]);
            //Console.WriteLine(ary[4]);

            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            //int[] ary = {14,20, 25, 86, -1425 }; // Declaration and initialization of array
            //Console.WriteLine(ary[0]);
            //Console.WriteLine(ary[1]);
            //Console.WriteLine(ary[2]);
            //Console.WriteLine(ary[3]);
            //Console.WriteLine(ary[4]);

            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            //int[] ary = { 14, 20, 25, 86, -1425 };
            //for (int i = 0; i < ary.Length; i++)    // Printing array elements using for loop
            //{
            //    Console.WriteLine(ary[i]);
            //}

            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            int[] ary = { 14, 20, 25, 86, -1425 };
            foreach (int i in ary) 
            {
                Console.WriteLine(i);
            }
        }
    }
}
