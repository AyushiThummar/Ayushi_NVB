using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayushi_NVB
{
    internal class Conversion
    {
        public static void main(string[] args)
        {
            string str;
            Console.WriteLine("Enter string value : ");
            str = Console.ReadLine();
            Console.WriteLine("String is : " + str);
            int no1;
            int no2;
            Console.WriteLine("Enter two numbers no1 and no2 : ");
            no1 = Convert.ToInt32(Console.ReadLine());
            no2 = int.Parse(Console.ReadLine());
            Console.WriteLine("First number is : " + no1);
            Console.WriteLine("First number is : " + no2);
        }
    }
}
