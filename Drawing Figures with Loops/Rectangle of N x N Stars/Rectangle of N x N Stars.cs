namespace Rectangle_of_N_x_N_Stars
{
using System;
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('*', n));
                Console.WriteLine();
            }
        }
    }
}
