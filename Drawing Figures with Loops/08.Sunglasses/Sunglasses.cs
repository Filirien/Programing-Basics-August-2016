namespace _08.Sunglasses
{
using System;
    class Sunglasses
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('*', n * 2) + new string(' ', n) + new string('*', 2 * n));
            for (int i = 0; i < n - 2; i++)
            {

                if (i == (n - 1) / 2 - 1)
                {
                    Console.WriteLine("*" + new string('/', 2 * n - 2) + "*" + new string('|', n) + "*" + new string('/', 2 * n - 2) + "*");
                }
                else
                {
                    Console.WriteLine("*" + new string('/', 2 * n - 2) + "*" + new string(' ', n) + "*" + new string('/', 2 * n - 2) + "*");
                }
            }
            Console.WriteLine(new string('*', n * 2) + new string(' ', n) + new string('*', 2 * n));
        }
    }
}
