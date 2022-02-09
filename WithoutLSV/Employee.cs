using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutLSV
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public Employee Manager { get; set; }

        public virtual void AssignManager(Employee manager)
        { 
            Manager = manager;
        }

        public virtual void CalculateSalary()
        {
            decimal baseSalary = 20M;
            Salary = baseSalary + 100;
        }
    }
}
