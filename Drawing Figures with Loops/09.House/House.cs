namespace _09.House
{
using System;
    class House
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var s = 1;
            if (n % 2 == 0)
            {
                s += 1;
            }
            for (int i = 0; i < (n + 1) / 2; i++)
            {//draw roof
                var f = ((n - s) / 2);
                Console.Write(new string('-', f));
                Console.Write(new string('*', s));
                Console.WriteLine(new string('-', f));
                s = s + 2;
            }
            if (n % 2 == 0)
            {
                for (int i = 0; i < n / 2; i++)
                {

                    Console.Write("|");
                    Console.Write(new string('*', n - 2));
                    Console.WriteLine("|");

                }
            }
            else
            {
                for (int i = 0; i < n / 2; i++)
                {


                    Console.Write("|");
                    Console.Write(new string('*', n - 2));
                    Console.WriteLine("|");
                }

            }
        }
    }
}
