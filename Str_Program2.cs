﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayushi_NVB
{
    internal class Str_Program2
    {
        public static void Main(string [] args)
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
            // Combine or concate two strings
            str3 = str1 + " " + str2;
            Console.WriteLine("Combine string is : " + str3);
            // Using concat
            str3 = String.Concat(str1, " ", str2);
            Console.WriteLine("Combine string using concat : " + str3);
            // Interpolation of string
            int no = 100;
            str3 = $"Multiplication of number is :{no * 10}";
            Console.WriteLine("String 3 is : " + str3);

            Console.Read();
        }
    }
}
