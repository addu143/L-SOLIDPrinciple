using System;
using WithLSV;
using WithoutLSV;

namespace L_SOLIDPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetEmployeesWithLSV();

            //GetEmployeesWithoutLSV();
        }

        public static void GetEmployeesWithLSV() 
        {
            IManager manager = new CEO_LSV();
            manager.FirstName = "TestManager";
            manager.LastName = "TestLastManager";
            manager.CalculateSalary();

            IManagedBy emp = new EmployeeLSV();
            emp.FirstName = "Muhammad";
            emp.LastName = "Adnan";
            emp.AssignManager(manager);
            emp.CalculateSalary();

            Console.WriteLine($"{emp.FirstName} salary is {emp.Salary}");
            Console.ReadLine();
        }
        public static void GetEmployeesWithoutLSV()
        {
            Manager manager = new Manager();
            manager.FirstName = "TestManager";
            manager.LastName = "TestLastManager";
            manager.CalculateSalary();

            //Violetes the rule of LSP, objects of a superclass shall be replaceable with
            //objects of its subclasses without breaking the application

            Employee emp = new Employee();
            //Employee emp = new CEO();

            emp.FirstName = "Muhammad";
            emp.LastName = "Adnan";
            emp.AssignManager(manager);
            emp.CalculateSalary();

            Console.WriteLine($"{emp.FirstName} salary is {emp.Salary}");
            Console.ReadLine();
        }
    }
}
