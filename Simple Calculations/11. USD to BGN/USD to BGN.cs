using System;
namespace _11.USD_to_BGN
{
    class Program
    {
        static void Main()
        {
            var USD = double.Parse(Console.ReadLine());
            var BG = USD * 1.79549;
            Console.WriteLine(Math.Round(BG, 2));
        }
    }
}