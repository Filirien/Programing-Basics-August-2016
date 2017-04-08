using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine().ToLower();

            var rows = int.Parse(Console.ReadLine());
            var columns = int.Parse(Console.ReadLine());
            var hall = rows * columns;
            var praice = 0.0;

            if (projection == "premiere")
            {
                praice = 12.00;
            }
            else if (projection == "normal")
            {
                praice = 7.50;
            }
            else if (projection == "discount")
            {
                praice = 5.00;
            }
            Console.WriteLine($"{hall * praice:f2}" +" "+ "leva");
        }
    }
}