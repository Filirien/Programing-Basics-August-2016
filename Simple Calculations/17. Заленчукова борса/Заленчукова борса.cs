using System;
namespace _17.Vegetables
{
    class Vegetables
    {
        static void Main()
        {

            double vegiPrice = double.Parse(Console.ReadLine());
            double fruitPrice = double.Parse(Console.ReadLine());
            int vegiKG = int.Parse(Console.ReadLine());
            int fruitKG = int.Parse(Console.ReadLine());

            double resultBGN = ((vegiPrice * vegiKG) + (fruitPrice * fruitKG));
            double BGNtoEUR = 1.94;
            Console.WriteLine(resultBGN / BGNtoEUR);
        }
    }
}