using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{

    public static void Main()
    {
        double corridorWidth = 1.0;
        double deskHeight = 1.2;
        double deskWidth = 0.7;

        Console.Write("Give height ");
        double height = double.Parse(Console.ReadLine());

        Console.Write("Give width ");
        double width = double.Parse(Console.ReadLine());
        
        double desksPerRow =Math.Floor((width - corridorWidth) / deskWidth);
        double desksPerColumn =Math.Floor(height / deskHeight);
        Console.WriteLine(desksPerRow * desksPerColumn - 3);
    }
}