using System;

namespace _203.LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double x11 = double.Parse(Console.ReadLine());
            double y11 = double.Parse(Console.ReadLine());
            double x12 = double.Parse(Console.ReadLine());
            double y12 = double.Parse(Console.ReadLine());
            double x21 = double.Parse(Console.ReadLine());
            double y21 = double.Parse(Console.ReadLine());
            double x22 = double.Parse(Console.ReadLine());
            double y22 = double.Parse(Console.ReadLine());

            double length1 = LengthOfLine(x11, y11, x12, y12);
            double length2 = LengthOfLine(x21, y21, x22, y22);

            if (length1 >= length2)
            {
                double distance1 = DistanceFromCenter(x11, y11);
                double distance2 = DistanceFromCenter(x12, y12);
                
                if (distance1<= distance2)
                {
                    Console.WriteLine($"({x11}, {y11})({x12}, {y12})");
                }
                else
                {
                    Console.WriteLine($"({x12}, {y12})({x11}, {y11})");
                }
            }
            else
            {
                double distance1 = DistanceFromCenter(x21, y21);
                double distance2 = DistanceFromCenter(x22, y22);

                if (distance1 <= distance2)
                {
                    Console.WriteLine($"({x21}, {y21})({x22}, {y22})");
                }
                else
                {
                    Console.WriteLine($"({x22}, {y22})({x21}, {y21})");
                }
            }
        }

        private static double DistanceFromCenter(double x, double y)
        {
            double distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            return distance;
        }

        private static double LengthOfLine(double x1, double y1, double x2, double y2)
        {
            double length = Math.Sqrt(Math.Pow(Math.Abs(x1 - x2), 2) + Math.Pow(Math.Abs(y1 - y2), 2));

            return length;
        }
    }
}
