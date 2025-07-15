using System;

namespace Ayushi_NVB
{
    internal class Array_2D
    {
        public static void Main(string[] args)
        {
            //int[,] ary = new int[2, 2];
            //ary[0, 0] = 1;      // First row, First column
            //ary[0, 1] = 2;      // First row, Second column
            //ary[1, 0] = 3;      // Second row, First column
            //ary[1, 1] = 4;      // Second row, Second column
            //Console.WriteLine("First element : " + ary[0, 0]);

            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            //int[,] ary = { { 1, 2 }, { 3, 4} };
            //Console.WriteLine("First element : " + ary[1, 0]);

            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            //int[,] ary = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            //Console.WriteLine("First element : " + ary[2, 1]);

            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            //int[,] ary = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            //for(int i=0; i< ary.GetLength(0); i++) // Number of Rows
            //{
            //    for(int j=0; j< ary.GetLength(1); j++) // Number of Columns
            //    {
            //        Console.Write(ary[i, j]);
            //    }
            //    Console.WriteLine();    // For new row in new line.
            //}

            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            int[,] ary = new int[3,3];
            Console.WriteLine("Enter elements of 3*3 array.");
            for (int i = 0; i < ary.GetLength(0); i++) // Number of Rows
            {
                for (int j = 0; j < ary.GetLength(1); j++) // Number of Columns
                {
                    ary[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < ary.GetLength(0); i++) // Number of Rows
            {
                for (int j = 0; j < ary.GetLength(1); j++) // Number of Columns
                {
                    Console.Write(ary[i, j] + " ");
                }
                Console.WriteLine();    // For new row in new line.
            }
        }
    }
}
