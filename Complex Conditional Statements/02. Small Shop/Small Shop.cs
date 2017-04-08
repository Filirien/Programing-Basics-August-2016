namespace _02.Small_Shop
{
using System;
    class Program
    {
        static void Main()
        {
            var produkt = Console.ReadLine().ToLower();
            var grad = Console.ReadLine().ToLower();
            var kolichestvo = double.Parse(Console.ReadLine());
            if (grad == "sofia")
            {
                if (produkt == "coffee")
                {
                    Console.WriteLine(kolichestvo * 0.5);
                }
                else if (produkt == "water")
                {
                    Console.WriteLine(kolichestvo * 0.8);
                }
                else if (produkt == "beer")
                {
                    Console.WriteLine(kolichestvo * 1.2);
                }
                else if (produkt == "sweets")
                {
                    Console.WriteLine(kolichestvo * 1.45);
                }
                else if (produkt == "peanuts")
                {
                    Console.WriteLine(kolichestvo * 1.6);
                }
            }



            else if (grad == "plovdiv")
            {
                if (produkt == "coffee")
                {
                    Console.WriteLine(kolichestvo * 0.4);
                }
                else if (produkt == "water")
                {
                    Console.WriteLine(kolichestvo * 0.7);
                }
                else if (produkt == "beer")
                {
                    Console.WriteLine(kolichestvo * 1.15);
                }
                else if (produkt == "sweets")
                {
                    Console.WriteLine(kolichestvo * 1.3);
                }
                else if (produkt == "peanuts")
                {
                    Console.WriteLine(kolichestvo * 1.5);
                }
            }


            else if (grad == "varna")
            {
                if (produkt == "coffee")
                {
                    Console.WriteLine(kolichestvo * 0.45);
                }
                else if (produkt == "water")
                {
                    Console.WriteLine(kolichestvo * 0.7);
                }
                else if (produkt == "beer")
                {
                    Console.WriteLine(kolichestvo * 1.10);
                }
                else if (produkt == "sweets")
                {
                    Console.WriteLine(kolichestvo * 1.35);
                }
                else if (produkt == "peanuts")
                {
                    Console.WriteLine(kolichestvo * 1.55);
                }
            }
        }
    }
}
