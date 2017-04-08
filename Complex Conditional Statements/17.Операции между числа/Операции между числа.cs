using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_Logo
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            for (int i = 0; i < 2 * N; i++)
            {
                Console.Write(new string('.', (12 * N - 5) / 2 - i * 3));
                Console.Write(new string('#', ((12 * N - 5) - (12 * N - 6) + i * 6)));
                Console.WriteLine(new string('.', (12 * N - 5) / 2 - i * 3));
            }
            for (int i = 1; i <= 2 * N - 2; i++)
            {
                if (i <= N - 1)
                {
                    Console.Write("|");
                    Console.Write(new string('.', i * 3 - 1));
                    Console.Write(new string('#', (12 * N - 5) - i * 6));
                    Console.WriteLine(new string('.', i * 3));

                }
             if (i > N - 1)
             {
                 Console.Write("|");
                 Console.Write(new string('.', i * 3 + 3));
                 Console.Write(new string('#', (12 * N - 5) / 2 - (i * 3 + 4)));
                 Console.WriteLine();
             }
            }
        }
    }
}