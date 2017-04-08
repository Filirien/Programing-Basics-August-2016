using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            min =min+ 15;

            if (min > 59)
            {

                hour =hour + 1;
                min =min - 60;
                if (hour > 23)
                {
                    hour = 0;
                }
                if (min < 10)
                {
                    Console.WriteLine("{0}:0{1}", hour, min);
                }
                else
                {
                    Console.WriteLine(hour + ":" + min);
                }
            }
            else
            {
                Console.WriteLine(hour + ":" + min);
            }
        }
    }
}