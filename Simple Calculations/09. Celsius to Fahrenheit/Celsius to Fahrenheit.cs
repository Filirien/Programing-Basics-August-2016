using System;
namespace _09.Celsius_to_Fahrenheit
{
    class Program
    {
        static void Main()
        {
            var Celzii = double.Parse(Console.ReadLine());
            var FR = Celzii * 1.8 + 32;
            Console.WriteLine($"{FR:F2}");
        }
    }
}