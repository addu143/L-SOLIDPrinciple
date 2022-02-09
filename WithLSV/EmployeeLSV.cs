using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithLSV
{
    public class EmployeeLSV : BaseEmployee, IManagedBy
    {      
        public IEmployee Manager { get; set; }

        public virtual void AssignManager(IEmployee manager)
        {
            Manager = manager;
        }

        public override void CalculateSalary()
        {
            Salary = 100;
        }
    }
}
