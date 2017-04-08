using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Поправка_на_плочки
{
    class Program
    {
        static void Main(string[] args)
        {
            double N = double.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double L = double.Parse(Console.ReadLine());
            double M = double.Parse(Console.ReadLine());
            double O = double.Parse(Console.ReadLine());

            double plate = N * N;
            double area = plate - (M * O);
            double s = W * L;
            double plateNeeded = area / s;
            double time = plateNeeded * 0.2;

            Console.WriteLine(plateNeeded);
            Console.WriteLine(time);
        }
    }
}
