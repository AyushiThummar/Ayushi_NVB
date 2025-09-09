using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Ayushi_NVB
{
    class Employee
    {
        int eId;
        string eName;
        string eSalary;

        public Employee()
        {
            Console.Write("Enter Employee ID: ");
            eId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employee Name : ");
            eName = Console.ReadLine();
            Console.Write("Enter Employee Salary: ");
            eSalary = Console.ReadLine();
        }
        public void showData()
        {
            Console.WriteLine("Employee ID is : "+eId);
            Console.WriteLine("Employee name is : "+eName);
            Console.WriteLine("Employee salary is :"+eSalary);
        }
    }
    internal class Exercise_Employee
    {
        public static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.showData();
        }
    }
}
