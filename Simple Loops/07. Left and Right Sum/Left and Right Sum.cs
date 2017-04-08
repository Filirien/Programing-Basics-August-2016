using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSUm = 0;

            for (int i = 0; i < 2 * n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i < n)
                {
                    leftSum += num;
                }
                else
                {
                    rightSUm += num;
                }
            }
            if (leftSum == rightSUm)
            {
                Console.WriteLine("Yes,sum={0}", leftSum);
            }
            else
            {
                Console.WriteLine("No,diff = {0}", Math.Abs(leftSum - rightSUm));
            }
        }
    }
}