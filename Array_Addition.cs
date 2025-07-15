using System;

namespace Tanvi_NVB
{
    internal class ary_sum_2d
    {
        static void Main(string[] args)
        {
            int[,] ary1 = new int[2, 2];    // Declare Array1
            Console.WriteLine("Enter the elements of first 2x2 array:");
            for (int i = 0; i < ary1.GetLength(0); i++)
            {
                for (int j = 0; j < ary1.GetLength(1); j++)
                {
                    ary1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int[,] ary2 = new int[2, 2];    // Declare Array2
            Console.WriteLine("Enter the elements of second 2x2 array:");
            for (int i = 0; i < ary2.GetLength(0); i++)
            {
                for (int j = 0; j < ary2.GetLength(1); j++)
                {
                    ary2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("First Array:");
            for (int i = 0; i < ary1.GetLength(0); i++)
            {
                for (int j = 0; j < ary1.GetLength(1); j++)
                {
                    Console.Write(ary1[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Second Array:");
            for (int i = 0; i < ary2.GetLength(0); i++)
            {
                for (int j = 0; j < ary2.GetLength(1); j++)
                {
                    Console.Write(ary2[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Sum of Arrays:");
            int[,] sum = new int[2, 2];
            for (int i = 0; i < sum.GetLength(0); i++)
            {
                for (int j = 0; j < sum.GetLength(1); j++)
                {
                    sum[i, j] = ary1[i, j] + ary2[i, j];
                    Console.Write(sum[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}