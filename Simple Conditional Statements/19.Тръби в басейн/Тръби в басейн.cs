using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Тръби_в_басейн
{
    class Program
    {
        static void Main(string[] args)
        {
            var poolV = int.Parse(Console.ReadLine());
            var P1Deb = int.Parse(Console.ReadLine());
            var P2Deb = int.Parse(Console.ReadLine());
            var time = double.Parse(Console.ReadLine());
            var poolWater = ((P1Deb + P2Deb) * time);
            int poolPrFull = (int)(poolWater * (100.0 / poolV));
            int P1Pr = (int)((P1Deb * time) * (100.0 / poolWater));
            int P2Pr = (int)((P1Deb * time) * (100.0 / poolWater));
            if (poolV < poolWater)
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", time, poolWater - poolV);
            }
            else
            {
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", poolPrFull, P1Pr, P2Pr);
            }
        }
    }
}
