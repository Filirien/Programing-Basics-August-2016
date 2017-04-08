using System;

namespace Equal_Pairs
{
    class MainClass
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0; // тук ще пазиме сумата
            double oldPairs = 0; // тази стойност ще я приравняваме на sum в края на цикъла
            double difference = 0;  // тук разликата

            for (int i = 0; i < n; i++)
            {
                double Odd = double.Parse(Console.ReadLine());     // четеме числа
                double Even = double.Parse(Console.ReadLine());    // четеме числа
                sum = Odd + Even;   // сумата на двете числа
                difference = Math.Max(sum, oldPairs) - Math.Min(sum, oldPairs);  // от по голямата сума вадим по малката   ( сегашмата сума и предходната, първия път когато се върти цикъла oldPairs=0)
                oldPairs = sum;  // с този ред казваш че oldPairs=sum   тоест взима стойноста на sum
            }

            if (n == 1)
            {
                Console.WriteLine("Yes, value={0}", difference);
            }
            else
            {
                if (difference == 0)
                {
                    Console.WriteLine("Yes, value={0}", sum);
                }
                else
                {
                    Console.WriteLine("No, maxdiff={0}", difference);
                }
            }
        }
    }
}