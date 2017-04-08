namespace _05.Invalid_Number
{
using System;
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            bool inRange = (num >= 100 && num <= 200 || num == 0);
            if (!inRange)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
