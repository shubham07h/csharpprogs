using System;

namespace eucledian_distance
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2;
            x1 = 3;
            x2 = 4;
            y1 = 5;
            y2 = 2;
            var distance = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
            Console.WriteLine($"The Eucledian distance between the two points is: {Math.Round(distance, 4)}");
        }
    }
}