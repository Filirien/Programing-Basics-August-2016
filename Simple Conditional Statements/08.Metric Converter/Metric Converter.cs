using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            string inputParam = Console.ReadLine();
            string outputParam = Console.ReadLine();
            double lenghtInMeters = 0;
            if (inputParam == "mm")
            {
                lenghtInMeters = lenght / 1000;
            }
            else if (inputParam == "cm")
            {
                lenghtInMeters = lenght / 100;
            }
            else if (inputParam == "mi")
            {
                lenghtInMeters = lenght / 0.000621371192;
            }
            else if (inputParam == "in")
            {
                lenghtInMeters = lenght / 39.3700787;
            }
            else if (inputParam == "km")
            {
                lenghtInMeters = lenght / 0.001;
            }
            else if (inputParam == "ft")
            {
                lenghtInMeters = lenght / 3.2808399;
            }
            else if (inputParam == "yd")
            {
                lenghtInMeters = lenght / 1.0936133;
            }
            else
            {
                lenghtInMeters = lenght;
            }




            var outputLenght = 0.0;

            if (outputParam == "mm")
            {
                outputLenght = lenghtInMeters * 1000;
            }
            else if (outputParam == "cm")
            {
                outputLenght = lenghtInMeters * 100;
            }
            else if (outputParam == "mi")
            {
                outputLenght = lenghtInMeters * 0.000621371192;
            }
            else if (outputParam == "in")
            {
                outputLenght = lenghtInMeters * 39.3700787;
            }
            else if (outputParam == "km")
            {
                outputLenght = lenghtInMeters * 0.001;
            }
            else if (outputParam == "ft")
            {
                outputLenght = lenghtInMeters * 3.2808399;
            }
            else if (outputParam == "yd")
            {
                outputLenght = lenghtInMeters * 1.0936133;
            }
            else
            {
                outputLenght = lenghtInMeters;
            }
            Console.WriteLine(outputLenght);
        }
    }
}
