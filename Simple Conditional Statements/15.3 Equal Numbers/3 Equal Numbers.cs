using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if (a == b && b == c)
            {
                Console.WriteLine("yes");
            }
            else if (a == b && b != c && a != c)
            {
                Console.WriteLine("no");
            }
            else if (a != b && b == c && a != c)
            {
                Console.WriteLine("no");
            }
            else if (a != b && b != c && a == c)
            {
                Console.WriteLine("no");
            }
            else if (a != b && b != c && a != c)
            {
                Console.WriteLine("no");
            }

        }
    }
}
