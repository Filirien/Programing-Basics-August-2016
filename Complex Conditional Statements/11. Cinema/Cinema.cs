namespace _11.Cinema
{
using System;
    class Cinema
    {
        static void Main()
        {
            string vid = Console.ReadLine().ToLower();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (vid == "premiere")
            {
                Console.WriteLine("{0:f2}", 12.00 * c * r);
            }
            else if (vid == "normal")
            {
                Console.WriteLine("{0:f2}", 7.50 * c * r);

            }
            else if (vid == "discount")
            {
                Console.WriteLine("{0:f2}", 5.00 * c * r);
            }
        }
    }
}
