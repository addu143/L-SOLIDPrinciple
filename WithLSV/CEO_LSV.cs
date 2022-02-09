using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithLSV
{
    public class CEO_LSV : BaseEmployee, IManager
    {
        public void GeneratePerformanceReview()
        {
            Console.WriteLine("Generate Performance review");
        }

        public override void CalculateSalary()
        {
            Salary = 9000;
        }
    }
}
