/*
 The employee list for a company contains employee code,name,designation,instName and basic pay. 
The employee is given a house rent allowance(HRA) of 10% of the basic pay and dearness allowance (DA) of 45% of the basic pay. 
The total pay of the employee is calculated as Basic PAy + HRA + DA and total. 
Write a class to define the details of the employee. Write a constructor to assign the required initial values. 
Add a method to calculate HRA , DA and total pay and print them. 
Use properties and static keyword whenever required. 
Create objects of two different and display employee details who is having highest total pay.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NVB
{
    public class Employee
    {
        int ecode;
        string name;
        string designation;
        string instName;
        double basicPay;

        public int Code { get { return ecode; } }
        public string Name { get { return name; } }
        public string Designation { get { return designation; } }
        public string InstName { get { return instName; } }
        public double BasicPay { get { return basicPay; } }

        public double HRA { get; private set; }
        public double DA { get; private set; }
        public double TotalPay { get; private set; }

        // Constructor
        public Employee(int ecode, string name, string designation, string instName, double basicPay)
        {
            this.ecode = ecode;
            this.name = name;
            this.designation = designation;
            this.instName = instName;
            this.basicPay = basicPay;

            CalculatePay(); // calculate HRA, DA, Total at creation
        }
        private void CalculatePay()
        {
            HRA = 0.10 * basicPay;
            DA = 0.45 * basicPay;
            TotalPay = basicPay + HRA + DA;
        }

        // Method to display employee details
        public void ShowDetails()
        {
            Console.WriteLine("Employee Code   : " + ecode);
            Console.WriteLine("Name            : " + name);
            Console.WriteLine("Designation     : " + designation);
            Console.WriteLine("Institute Name  : " + instName);
            Console.WriteLine("Basic Pay       : " + basicPay);
            Console.WriteLine("HRA (10%)       : " + HRA);
            Console.WriteLine("DA (45%)        : " + DA);
            Console.WriteLine("Total Pay       : " + TotalPay);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }

        // Static method to compare two employees
        public static Employee GetHighestPaid(Employee e1, Employee e2)
        {
            return (e1.TotalPay > e2.TotalPay) ? e1 : e2;
        }
    }
    internal class PropertyEmp
    {
        public static void Main(string[] args)
        {
            // Create two employees
            Employee emp1 = new Employee(101, "abc", "Manager", "NVB Ltd", 40000);
            Employee emp2 = new Employee(102, "xyz", "Engineer", "NVB Ltd", 35000);

            Console.WriteLine("=== Employee Details ===");
            emp1.ShowDetails();
            emp2.ShowDetails();

            // Find highest paid
            Employee highest = Employee.GetHighestPaid(emp1, emp2);

            Console.WriteLine("=== Employee with Highest Total Pay ===");
            highest.ShowDetails();
        }
    }
}
