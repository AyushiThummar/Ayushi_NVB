using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayushi_NVB
{
    class Student
    {
        int rlno;
        string name;

        public Student() // Default Constructor
        {
            //rlno = 35; // Assigning default values
            //name = "Ayushi";

            Console.WriteLine("Enter roll no. : ");
            rlno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter name : ");
            name = Console.ReadLine();

        }
        public void showData()
        {
            Console.WriteLine("Roll no. is : " + rlno);
            Console.WriteLine("Name is : " + name);
        }
    }
    internal class Constructor
    {
        public static void Main(string[] args)
        {
            Student s1 = new Student();  // Constructor is called here.
            s1.showData(); // This will call the method to display student data.
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Student s2 = new Student();
            s2.showData();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Student s3 = new Student();
            s3.showData();
        }
    }
}
