namespace _01.Rectangle_of_10_x_10_Stars
{
    using System;
    class Program
    {
        static void Main()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(new string('*', 10));
                Console.WriteLine();
            }
        }
    }
}
