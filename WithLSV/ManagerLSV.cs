using System;

namespace WithLSV
{
    public class ManagerLSV : EmployeeLSV, IManager
    {
        public override void AssignManager(IEmployee manager)
        {
            Manager = manager;
        }

        public override void CalculateSalary()
        {
            decimal baseSalary = 100M;
            Salary = baseSalary + 100;
        }

        public void GeneratePerformanceReview()
        {
            Console.WriteLine("GenerateReview");
        }
    }
}
