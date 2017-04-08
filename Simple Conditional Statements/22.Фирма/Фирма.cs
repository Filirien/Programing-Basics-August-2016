using System;
namespace Business
{
    class Business
    {
        static void Main()
        {
            int Hours = int.Parse(Console.ReadLine());
            int Day = int.Parse(Console.ReadLine());
            int Works = int.Parse(Console.ReadLine());
            double WorkProgect = 0.9 * Day * 8 + Works * 2 * Day;
            if (WorkProgect >= Hours)
            {
                Console.WriteLine("Yes!{0} hours left.", Math.Floor(WorkProgect - Hours));
            }
            else
            {
                Console.WriteLine("Not enough time!{0} hours needed.", Math.Ceiling(Hours - WorkProgect));
            }
        }
    }
}