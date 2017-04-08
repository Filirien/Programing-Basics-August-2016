namespace _03.Square_of_Stars
{
using System;
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            for (var row = 1; row <= n; row++)
            {

                for (int col = 0; col < n; col++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
