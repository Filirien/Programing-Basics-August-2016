namespace _01.Personal_Titles
{
    using System;
    class Program
    {
        static void Main()
        {
            var age = double.Parse(Console.ReadLine());
            var pol = Console.ReadLine();
            if (pol=="m")
            {
                if (age>=16)
                {
                    Console.WriteLine("Mr.");
                }
                else
                {
                    Console.WriteLine("Master");
                }
            }
            else if (pol=="f")
            {
                if (age>=16)
                {
                    Console.WriteLine("Ms.");
                }
                else 
                {
                    Console.WriteLine("Miss");
                }
            }
        }
    }
}
