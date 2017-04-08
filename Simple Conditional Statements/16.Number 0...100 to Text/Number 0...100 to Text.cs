using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_0_to_100
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine("invalid number");
            }
            else if (num <= 10)
            {
                if (num == 0)
                {
                    Console.WriteLine("zero");
                }
                else if (num == 1)
                {
                    Console.WriteLine("one");
                }
                else if (num == 2)
                {
                    Console.WriteLine("two");
                }
                else if (num == 3)
                {
                    Console.WriteLine("three");
                }
                else if (num == 4)
                {
                    Console.WriteLine("four");
                }
                else if (num == 5)
                {
                    Console.WriteLine("five");
                }
                else if (num == 6)
                {
                    Console.WriteLine("six");
                }
                else if (num == 7)
                {
                    Console.WriteLine("seven");
                }
                else if (num == 8)
                {
                    Console.WriteLine("eight");
                }
                else if (num == 9)
                {
                    Console.WriteLine("nine");
                }
                else
                {
                    Console.WriteLine("ten");
                }
            }
            else if (num <= 20)
            {
                if (num == 11)
                {
                    Console.WriteLine("eleven");
                }
                else if (num == 12)
                {
                    Console.WriteLine("twelve");
                }
                else if (num == 13)
                {
                    Console.WriteLine("thirteen");
                }
                else if (num == 14)
                {
                    Console.WriteLine("fourteen");
                }
                else if (num == 15)
                {
                    Console.WriteLine("fifteen");
                }
                else if (num == 16)
                {
                    Console.WriteLine("sixteen");
                }
                else if (num == 17)
                {
                    Console.WriteLine("seventeen");
                }
                else if (num == 18)
                {
                    Console.WriteLine("eighteen");
                }
                else if (num == 19)
                {
                    Console.WriteLine("nineteen");
                }
                else
                {
                    Console.WriteLine("twenty");
                }
            }
            else if (num <= 30)
            {
                string secondDigit = "";

                if (num == 21)
                {
                    secondDigit = "one";
                }
                else if (num == 22)
                {
                    secondDigit = "two";
                }
                else if (num == 23)
                {
                    secondDigit = "three";
                }
                else if (num == 24)
                {
                    secondDigit = "four";
                }
                else if (num == 25)
                {
                    secondDigit = "five";
                }
                else if (num == 26)
                {
                    secondDigit = "six";
                }
                else if (num == 27)
                {
                    secondDigit = "seven";
                }
                else if (num == 28)
                {
                    secondDigit = "eight";
                }
                else if (num == 29)
                {
                    secondDigit = "nine";
                }
                else if (num == 30)
                {
                    Console.WriteLine("thirty");
                }
                if (num < 30 && num > 20)
                {
                    Console.WriteLine("twenty" + " " + secondDigit);
                }
            }
            else if (num <= 40)
            {
                string secondDigit = "";

                if (num == 31)
                {
                    secondDigit = "one";
                }
                else if (num == 32)
                {
                    secondDigit = "two";
                }
                else if (num == 33)
                {
                    secondDigit = "three";
                }
                else if (num == 34)
                {
                    secondDigit = "four";
                }
                else if (num == 35)
                {
                    secondDigit = "five";
                }
                else if (num == 36)
                {
                    secondDigit = "six";
                }
                else if (num == 37)
                {
                    secondDigit = "seven";
                }
                else if (num == 38)
                {
                    secondDigit = "eight";
                }
                else if (num == 39)
                {
                    secondDigit = "nine";
                }
                else if (num == 40)
                {
                    Console.WriteLine("forty");
                }
                if (num < 40 && num > 30)
                {
                    Console.WriteLine("thirty" + " " + secondDigit);
                }
                else
                {
                    Console.WriteLine("thirty");
                }
            }
            else if (num <= 50)
            {
                string secondDigit = "";

                if (num == 41)
                {
                    secondDigit = "one";
                }
                else if (num == 42)
                {
                    secondDigit = "two";
                }
                else if (num == 43)
                {
                    secondDigit = "three";
                }
                else if (num == 44)
                {
                    secondDigit = "four";
                }
                else if (num == 45)
                {
                    secondDigit = "five";
                }
                else if (num == 46)
                {
                    secondDigit = "six";
                }
                else if (num == 47)
                {
                    secondDigit = "seven";
                }
                else if (num == 48)
                {
                    secondDigit = "eight";
                }
                else if (num == 49)
                {
                    secondDigit = "nine";
                }
                else if (num == 50)
                {
                    Console.WriteLine("fifty");
                }
                if (num < 50 && num > 40)
                {
                    Console.WriteLine("fourty" + " " + secondDigit);
                }
            }
            else if (num <= 60)
            {
                string secondDigit = "";

                if (num == 51)
                {
                    secondDigit = "one";
                }
                else if (num == 52)
                {
                    secondDigit = "two";
                }
                else if (num == 53)
                {
                    secondDigit = "three";
                }
                else if (num == 54)
                {
                    secondDigit = "four";
                }
                else if (num == 55)
                {
                    secondDigit = "five";
                }
                else if (num == 56)
                {
                    secondDigit = "six";
                }
                else if (num == 57)
                {
                    secondDigit = "seven";
                }
                else if (num == 58)
                {
                    secondDigit = "eight";
                }
                else if (num == 59)
                {
                    secondDigit = "nine";
                }
                else if (num == 60)
                {
                    Console.WriteLine("sixty");
                }
                if (num < 60 && num > 50)
                {
                    Console.WriteLine("fifty" + " " + secondDigit);
                }
                else
                {
                    Console.WriteLine("fifty");
                }
            }
            else if (num <= 70)
            {
                string secondDigit = "";

                if (num == 61)
                {
                    secondDigit = "one";
                }
                else if (num == 62)
                {
                    secondDigit = "two";
                }
                else if (num == 63)
                {
                    secondDigit = "three";
                }
                else if (num == 64)
                {
                    secondDigit = "four";
                }
                else if (num == 65)
                {
                    secondDigit = "five";
                }
                else if (num == 66)
                {
                    secondDigit = "six";
                }
                else if (num == 67)
                {
                    secondDigit = "seven";
                }
                else if (num == 68)
                {
                    secondDigit = "eight";
                }
                else if (num == 69)
                {
                    secondDigit = "nine";
                }
                else if (num == 70)
                {
                    Console.WriteLine("seventy");
                }
                if (num < 70 && num > 60)
                {
                    Console.WriteLine("sixty" + " " + secondDigit);
                }
                else
                {
                    Console.WriteLine("sixty");
                }
            }
            else if (num <= 80)
            {
                string secondDigit = "";

                if (num == 71)
                {
                    secondDigit = "one";
                }
                else if (num == 72)
                {
                    secondDigit = "two";
                }
                else if (num == 73)
                {
                    secondDigit = "three";
                }
                else if (num == 74)
                {
                    secondDigit = "four";
                }
                else if (num == 75)
                {
                    secondDigit = "five";
                }
                else if (num == 76)
                {
                    secondDigit = "six";
                }
                else if (num == 77)
                {
                    secondDigit = "seven";
                }
                else if (num == 78)
                {
                    secondDigit = "eight";
                }
                else if (num == 79)
                {
                    secondDigit = "nine";
                }
                else if (num == 80)
                {
                    Console.WriteLine("eighty");
                }
                if (num < 80 && num > 70)
                {
                    Console.WriteLine("seventy" + " " + secondDigit);
                }
                else
                {
                    Console.WriteLine("seventy");
                }
            }
            else if (num <= 90)
            {
                string secondDigit = "";

                if (num == 81)
                {
                    secondDigit = "one";
                }
                else if (num == 82)
                {
                    secondDigit = "two";
                }
                else if (num == 83)
                {
                    secondDigit = "three";
                }
                else if (num == 84)
                {
                    secondDigit = "four";
                }
                else if (num == 85)
                {
                    secondDigit = "five";
                }
                else if (num == 86)
                {
                    secondDigit = "six";
                }
                else if (num == 87)
                {
                    secondDigit = "seven";
                }
                else if (num == 88)
                {
                    secondDigit = "eight";
                }
                else if (num == 89)
                {
                    secondDigit = "nine";
                }
                else if (num == 90)
                {
                    Console.WriteLine("ninty");
                }
                if (num < 90 && num > 80)
                {
                    Console.WriteLine("eighty" + " " + secondDigit);
                }
                else
                {
                    Console.WriteLine("eighty");
                }
            }
            else if (num <= 100)
            {
                string secondDigit = "";

                if (num == 91)
                {
                    secondDigit = "one";
                }
                else if (num == 92)
                {
                    secondDigit = "two";
                }
                else if (num == 93)
                {
                    secondDigit = "three";
                }
                else if (num == 94)
                {
                    secondDigit = "four";
                }
                else if (num == 95)
                {
                    secondDigit = "five";
                }
                else if (num == 96)
                {
                    secondDigit = "six";
                }
                else if (num == 97)
                {
                    secondDigit = "seven";
                }
                else if (num == 98)
                {
                    secondDigit = "eight";
                }
                else if (num == 99)
                {
                    secondDigit = "nine";
                }
                else if (num == 100)
                {
                    Console.WriteLine("one hundred");
                }
                if (num < 100 && num > 90)
                {
                    Console.WriteLine("ninety" + " " + secondDigit);
                }
                else if (num == 90)
                {
                    Console.WriteLine("ninety");
                }
            }
            else if (num > 100)
            {
                Console.WriteLine("invalid number");
            }
        }
    }
}