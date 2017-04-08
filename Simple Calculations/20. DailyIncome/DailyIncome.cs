using System; 
namespace _20.Daily_Income
{
    class Program
    {
        static void Main()
        {
            double workDays = double.Parse(Console.ReadLine());
            double moneyPerDay = double.Parse(Console.ReadLine());
            double dollar = double.Parse(Console.ReadLine());

            var Salary = workDays * moneyPerDay;
            var annualIncome = Salary * 12 + Salary * 2.5;
            var assess = 0.25 * annualIncome;
            var ClearAnnualIncome = (annualIncome - assess) * dollar;
            var MidSalaryPerDay = ClearAnnualIncome / 365;
            Console.WriteLine(Math.Round(MidSalaryPerDay, 2));
        }
    }
}