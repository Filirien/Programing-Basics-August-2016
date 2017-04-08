namespace _04.Fruit_or_Vegetable
{
using System;
    class Program
    {
        static void Main()
        {
            string product = Console.ReadLine();

            if (product == "banana" || product == "apple" || product == "kiwi" || product == "lemon" || product == "grapes" || product == "cherry")
            {
                Console.WriteLine("fruit");
            }
            else if (product == "tomato" || product == "cucumber" || product == "pepper" || product == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
