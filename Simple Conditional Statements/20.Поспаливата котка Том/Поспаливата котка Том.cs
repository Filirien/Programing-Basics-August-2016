using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ta
{
    class Program
    {
        static void Main(string[] args)
        {
            int vac = int.Parse(Console.ReadLine());

            int workdays = 1;
            int relax = 1;
            int minutesplay = 1;
            int hours = 1;
            int M = 1;
            workdays = 365 - vac;
            minutesplay = workdays * 63 + vac * 127;
            relax = Math.Abs(minutesplay - 30000);
            hours = Math.Abs(relax / 60);
            M = Math.Abs(relax % 60);
            if (minutesplay > 30000)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", hours, M);
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", hours, M);
            }


        }
    }
}