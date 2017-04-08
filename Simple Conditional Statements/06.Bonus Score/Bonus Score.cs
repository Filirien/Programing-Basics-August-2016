using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            double Score = double.Parse(Console.ReadLine());
            double bonusPoints = 0;
            if (Score <= 100)
            {
                bonusPoints = 5;
            }
            else if (Score > 100 && Score <= 1000)
            {
                bonusPoints = (Score * 0.2);
            }
            else
            {
                bonusPoints = (Score * 0.1);
            }
            if (Score % 2 == 0)
            {
                bonusPoints += 1;
            }
            if (Score % 10 == 5)
            {
                bonusPoints += 2;
            }
            Console.WriteLine(bonusPoints);
            Console.WriteLine(Score + bonusPoints);
        }
    }
}