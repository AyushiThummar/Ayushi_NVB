using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ayushi_NVB
{
    class A
    {
        protected int x;
        public void MethodA1()
        {
            Console.WriteLine("Method A1 from A");
            Console.WriteLine("Value of x is " + x);
        }
        void MethodA2()//private method of base class is not inherited
        {
            Console.WriteLine("Method A2 from A");
        }
        protected void MethodA3()//protected method of base class is inherited
        {
            Console.WriteLine("Method A3 from A");
        }
        public A(int x)
        {
            Console.WriteLine("Constructor of A");
            this.x = x;
        }

    }
    class B : A
    {
        int y;
        public void MethodB1()
        {
            Console.WriteLine("Method B1 from B");
            MethodA3();//protected method of base class is accessible in derived class
            Console.WriteLine("Value of y is " + y);
        }
        public B(int x, int y) : base(x)
        {
            Console.WriteLine("Constructor of child class B");
            this.y = y;
        }
        public void calcAvg()
        {
            double avg = (double)(x + y) / 2;
            Console.WriteLine("average is " + avg);
        }
    }
    internal class Inheritance
    {
        static void Main(string[] args)
        {
            //B b = new B(5, 2);
            //b.MethodB1();
            //b.MethodA1();
            ////b.MethodA2(); //not accessible
            ////b.MethodA3(); //not accessible
            //b.calcAvg();

            B obj = new B(10, 20);
            obj.MethodA1();
            obj.MethodB1();
        }
    }
}