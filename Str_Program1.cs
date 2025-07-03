using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayushi_NVB
{
    internal class Str_Program1
    {
        public static void Main(string[] args)
        {
            string str1, str2, str3;
            Console.WriteLine("Enter string 1 : ");
            str1 = Console.ReadLine();
            Console.WriteLine("Enter string 2 : ");
            str2 = Console.ReadLine();
            int len = str1.Length;
            Console.WriteLine("Length of string 1 is : " + len);
            str3 = str1.ToLower();
            Console.WriteLine("String 1 in lower case : " + str3);
            str3 = str2.ToUpper();
            Console.WriteLine("String 2 in upper case : " + str3);
        }
    }
}
