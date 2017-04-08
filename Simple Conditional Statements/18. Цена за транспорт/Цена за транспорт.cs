using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceJourney
{
    class Program
    {
        static void Main(string[] args)
        {
            int km = int.Parse(Console.ReadLine());
            string daytime = Console.ReadLine().ToString();

            double taxistart = 0.70;
            double taxiday = 0.79;
            double taxinight = 0.90;
            double Bus = 0.09;
            double Train = 0.06;




            if (km < 20 && daytime == "day")
            {
                Console.WriteLine((km * taxiday) + taxistart);
            }
            else if (km <= 20 && daytime == "night")
            {
                Console.WriteLine((km * taxinight) + taxistart);
            }
            else if (km > 20 && km < 100)
            {
                Console.WriteLine(km * Bus);
            }
            else if (km >= 100)
            {
                Console.WriteLine(km * Train);
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}