using System;


namespace _07.SumSeconds
{
    class SumSeconds
    {
        static void Main()
        {
            double firstScore = double.Parse(Console.ReadLine());
            double secondScore = double.Parse(Console.ReadLine());
            double thurdScore = double.Parse(Console.ReadLine());
            double sumSeconds = firstScore + secondScore + thurdScore;
            double minutes = sumSeconds / 60;   
            double second = sumSeconds % 60;

            Console.WriteLine("{0}:{1:00}", minutes, second);
        }
    }
}