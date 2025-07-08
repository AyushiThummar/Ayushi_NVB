using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayushi_NVB
{
    internal class Array_Searching
    {
        public static void Main(string[] args)
        {
            int[] ary = new int[5];
            Console.WriteLine("Enter array elements : ");
            for (int i = 0; i < ary.Length; i++)
            {
                ary[i] = Int32.Parse(Console.ReadLine());
            }
            int searchEle;
            Console.Write("Enter element that you want to search : ");
            searchEle = Convert.ToInt32(Console.ReadLine());
            int flag = 0;
            for(int i = 0;i < ary.Length; i++)
            {
                if(ary[i] == searchEle)
                {
                    flag = 1;
                    Console.WriteLine("Element found in array.");
                    break;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("Element not found in array.");
            }
        }
    }
}
