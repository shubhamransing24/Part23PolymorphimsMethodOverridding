using System;

namespace Part23PolymorphimsMethodOverridding
{
    class Employee
    {
        public string firstname = "Shubham";
        public string lastname = "Ransing";
        public virtual void PrintFullName()
        {
            Console.WriteLine("Full Name ={0} {1}-Employee", firstname, lastname);

        }
    }
    class PartTimeEmployee :Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine("Full Name ={0} {1} -ParttimeEmp", firstname, lastname);

        }
    }
    class FullTimeEmployee:Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine("Full Name ={0} {1} -FulltimeEmp", firstname, lastname);

        }
    }
    class TemporaryEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine("Full Name ={0} {1} -Temporary Employee", firstname, lastname);

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[4];
            employees[0] = new Employee();
            employees[1] = new PartTimeEmployee();
            employees[2] = new FullTimeEmployee();
            employees[3] = new TemporaryEmployee();

            foreach(Employee e in employees)
            {
                e.PrintFullName();
            }
        }
    }
}
