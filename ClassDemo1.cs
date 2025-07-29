using System;

namespace Ayushi_NVB
{
    public class Employee
    {
        int empId;
        string eName;
        double salary;
        //public void getData()
        //{
        //    empId = 111;
        //    eName = "A";
        //    salary = 20000.00;
        //}

        public void getData(int empId, string eName, double salary)
        {
            this.empId = empId;
            this.eName = eName;
            this.salary = salary;
        }
        public double getSalary()
        {
            return salary;
        }
        public void showData()
        {
            Console.WriteLine("Emp ID : "+ empId);
            Console.WriteLine("Emp Name  : " + eName);
            Console.WriteLine("Emp Salary : " + salary);
        }
    }
    internal class ClassDemo1
    {
        public static void Main(string[] args)
        {
            //Employee e1 = new Employee();
            //e1.getData();
            //e1.showData();
            ////e1.eName = "B";   // It will give error

            //Employee e2 = new Employee();
            //e2.getData();
            //e2.showData();

            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            //Employee e1 = new Employee();
            //e1.getData(111, "AA", 20000.00);
            //e1.showData();

            //Employee e2 = new Employee();
            //e2.getData(112, "AB", 25000.00);
            //e2.showData();

            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            Employee e1 = new Employee();
            e1.getData(111, "AA", 20000.00);

            Employee e2 = new Employee();
            e2.getData(112, "AB", 25000.00);

            if (e1.getSalary() > e2.getSalary())
            {
                e1.showData();
            }
            else
            {
                e2.showData();
            }
        }
    }
}
