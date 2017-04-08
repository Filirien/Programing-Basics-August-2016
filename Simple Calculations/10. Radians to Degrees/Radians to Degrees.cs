using System;
namespace _12.Radians_to_Degrees
{
    class Program
    {
        static void Main()
        {
            var rad = double.Parse(Console.ReadLine());
            var deg = rad * 180 / Math.PI;
            Console.WriteLine(Math.Round(deg, 2));
        }
    }
}