namespace _04.Triangle_of_Dollars
{
using System;
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string str = "$";

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(str);
                str += " $";
            }
        }
    }
}
