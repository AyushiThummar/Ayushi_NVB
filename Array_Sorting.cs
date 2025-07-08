using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayushi_NVB
{
    internal class Array_Sorting
    {
        public static void Main(string[] args)
        {
            int[] ary = new int[5];
            Console.WriteLine("Enter array elements : ");
            for (int i = 0; i < ary.Length; i++)
            {
                ary[i] = Int32.Parse(Console.ReadLine());
            }

            // Sorting
            for(int i = 0;i < ary.Length; i++)
            {
                for(int j = i+1; j < ary.Length; j++)
                {
                    if(ary[i] > ary[j])
                    {
                        int temp = ary[i];
                        ary[i] = ary[j];
                        ary[j] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted Array Elements : ");
            for(int i = 0;i<ary.Length;i++)
            {
                Console.WriteLine(ary[i]);
            }
        }
    }
}