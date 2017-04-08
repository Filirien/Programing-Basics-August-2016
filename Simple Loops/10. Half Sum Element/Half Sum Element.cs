using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int greater = int.MinValue;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {

                int num = int.Parse(Console.ReadLine());
                if (num > greater)
                {
                    greater = num;
                }
                sum += num;
            }
            if (sum - greater == greater)
            {
                Console.WriteLine("Yes Sum=" + greater);
            }
            else
            {
                Console.WriteLine("No Diff=" + Math.Abs(sum - greater * 2));
            }

        }
    }
}