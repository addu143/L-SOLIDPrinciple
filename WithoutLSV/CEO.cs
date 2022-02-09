using System;

namespace WithoutLSV
{
    public class CEO : Employee
    {
        public override void AssignManager(Employee manager)
        {
            throw new InvalidOperationException("The CRO has no manager.");
        }

        public override void CalculateSalary()
        {
            decimal baseSalary = 100M;
            Salary = baseSalary + 100;
        }
    }
}
