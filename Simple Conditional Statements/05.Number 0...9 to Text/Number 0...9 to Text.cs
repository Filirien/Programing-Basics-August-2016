using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Number_0._._._9_to_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());

            if (num1 == 1)
            {
                Console.WriteLine("One");
            }
           else if (num1 == 2)
            {
                Console.WriteLine("Two");
            }
            else if (num1 == 3)
            {
                Console.WriteLine("Three");
            }
            else if (num1 == 4)
            {
                Console.WriteLine("Four");
            }
            else if (num1 == 5)
            {
                Console.WriteLine("Five");
            }
            else if (num1 == 6)
            {
                Console.WriteLine("Six");
            }
            else if (num1 == 7)
            {
                Console.WriteLine("Seven");
            }
            else if (num1 == 8)
            {
                Console.WriteLine("Eight");
            }
            else if (num1 == 9)
            {
                Console.WriteLine("Nine");
            }
            else if (num1 > 9)
            {
                Console.WriteLine("number too big");
            }
        }
    }
}
