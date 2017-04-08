using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            double rekolta = y * x;
            double wine = 0.4 * rekolta / 2.5;
            double ostava = Math.Ceiling(Math.Abs(wine - z));
            double rabotnik = Math.Ceiling(ostava / n);
            if (wine >= z)
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(wine));
                Console.WriteLine("{0} liters left -> {1} liters per person.", ostava, rabotnik);
            }
            else
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", ostava);
            }
        }
    }
}