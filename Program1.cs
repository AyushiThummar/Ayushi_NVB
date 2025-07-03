using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayushi_NVB
{
    internal class Program1
    {
        public static void Main(string[] args)
        {
            int no;
            no = 1;
            Console.WriteLine("Printing numbers 1 to 10:");
            while (no <= 10)
            {
                Console.WriteLine(no);
                no++;
            }
            Console.WriteLine();
            Console.WriteLine("Printing numbers 10 to 1:");
            no = 10;
            while (no >= 1)
            {
                Console.WriteLine(no);
                no--;
            }
        }
    }
}
