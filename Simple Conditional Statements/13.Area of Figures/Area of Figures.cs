using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string Area = Console.ReadLine();
            if (Area == "square")
            {
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine(a * a);
            }
            if (Area == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine(a * b);
            }
            if (Area == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.PI * r * r);
            }
            if (Area == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                Console.WriteLine(a * h / 2);
            }

        }
    }
}
