using System;
using System.Globalization;

namespace _1000DaysAfterBirth
{
    class Program
    {
        static void Main()
        {
            var userBirthday = DateTime.ParseExact(Console.ReadLine(),"dd-MM-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(userBirthday.AddDays(999).ToString("dd-MM-yyyy"));
        }
    }
}