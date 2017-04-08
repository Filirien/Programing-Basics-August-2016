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
            int odd = 0;
            int even = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    odd += num;
                }
                else
                {
                    even += num;
                }
            }
            if (odd == even)
            {
                Console.WriteLine("Yes,sum={0}", odd);
            }
            else
            {
                Console.WriteLine("No,diff = {0}", Math.Abs(odd - even));
            }
        }
    }
}
