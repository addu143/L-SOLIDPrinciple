namespace WithoutLSV
{
    public class Manager : Employee 
    {
        public override void CalculateSalary()
        {
            decimal baseSalary = 100M;
            Salary = baseSalary + 100;
        }
    }
}
