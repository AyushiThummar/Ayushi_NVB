/*
 * Properties in c#
To access private members of class from outside
Encapsulation -private 
=> special method  – accessor

 	Set and get

-intermediate - only to transfer the data 
Set property : is used to set the values
Get property : is used to retrieve the values 

Types:
Read-Write property
Read only property
Write only property
Auto implemented property
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayushi_NVB
{
    public class Demo1
    {
        int x;//private value of x member
        int y;
        //public Demo1(int x, int y) // constructor
        //{
        //    this.x = x;
        //    this.y = y;
        //}
        public int X
        {
            //set { x = value; }  // initialize value
            //get { return x; }   // read-write properties

            get { return x; }   // read-only properties

            set { x = value; }// write-only properties
        }
        public int Y
        {
            //set { y = value; }
            //get { return y; }

            set { y = value; }
        }
        public void Show()
        {
            Console.WriteLine("Value of private x : " + x);
            Console.WriteLine("Value of private y : " + y);
            Console.WriteLine("Addition of x and y : " + (x + y));
        }
    }
    internal class PropertyDemo
    {
        public static void Main(string[] args)
        {
            //Demo1 ob = new Demo1(100,200);
            ////ob.X = 50;
            //Console.WriteLine("Value of private x : " + ob.X);
            ////ob.Y = 150;
            //Console.WriteLine("Value of private y : " + ob.Y);
            //Console.WriteLine("Addition of x and y : " + (ob.X + ob.Y));

            Demo1 ob = new Demo1();
            ob.X = 50;   
            ob.Y = 150;  
            ob.Show(); // Use method to see the values
        }
    }
}
