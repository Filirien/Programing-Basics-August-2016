namespace _12.Volleyball
{
using System;
    class Volleyball
    {
        static void Main()
        {
            string year = Console.ReadLine();
            double p = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double games = 1;
            if (year == "normal")
            {
                games = ((48 - h) * (3 / 4.0)) + (p * 2 / 3.0) + h;
                Console.WriteLine(Math.Truncate(games));
            }
            else if (year == "leap")
            {
                games = ((48 - h) * 3.0 / 4) + (p * 2.0 / 3) + h;
                Console.WriteLine(Math.Truncate(games * 1.15));
            }
        }
    }
}
