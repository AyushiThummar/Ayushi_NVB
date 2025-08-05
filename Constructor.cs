using System;

namespace Ayushi_NVB
{
    class Student
    {
        int rlno;
        string name;

        // 🔹 Static Constructor (executes once for all objects)
        static Student()
        {
            Console.WriteLine("Static Constructor Called — Initial setup done.\n");
        }

        // 🔹 Default Constructor
        public Student()
        {
            Console.Write("Enter roll no: ");
            rlno = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter name: ");
            name = Console.ReadLine();
        }

        // 🔹 Parameterized Constructor
        public Student(int r, string n)
        {
            rlno = r;
            name = n;
        }

        // 🔹 Copy Constructor
        public Student(Student s)
        {
            rlno = s.rlno;
            name = s.name;
        }

        // 🔹 Display Method
        public void showData()
        {
            Console.WriteLine("Roll no. is : " + rlno);
            Console.WriteLine("Name is     : " + name);
        }
    }

    internal class Constructor
    {
        public static void Main(string[] args)
        {
            // 🔸 s1: Parameterized Constructor
            Student s1 = new Student(35, "Ayushi");
            Console.WriteLine("Student s1 (Parameterized):");
            s1.showData();

            Console.WriteLine();

            // 🔸 s2: Default Constructor (User Input)
            Console.WriteLine("Enter details for Student s2 (Default):");
            Student s2 = new Student();
            Console.WriteLine("Student s2 (Default):");
            s2.showData();

            Console.WriteLine();

            // 🔸 s3: Default Constructor (User Input)
            Console.WriteLine("Enter details for Student s3 (Default):");
            Student s3 = new Student();
            Console.WriteLine("Student s3 (Default):");
            s3.showData();

            Console.WriteLine();

            // 🔸 s4: Copy Constructor (Copied from s1)
            Student s4 = new Student(s1);
            Console.WriteLine("Student s4 (Copied from s1):");
            s4.showData();

            Console.WriteLine();

            // 🔸 s5: Copy Constructor (Copied from s2)
            Student s5 = new Student(s2);
            Console.WriteLine("Student s5 (Copied from s2):");
            s5.showData();

            Console.ReadLine(); // Pause to view output
        }
    }
}