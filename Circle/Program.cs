using System;

namespace MyProject
{
    class Program
    {
        public static double CalculateArea(double r)
        {
            double pi = Math.PI;
            return pi * Math.Pow(r, 2);
        }

        public static double CalculatePerimeter(double r)
        {
            double pi = Math.PI;
            return 2 * pi * r;
        }

        static void Main(string[] args)
        {
            double radius;
            double? Temp_Radius = double.TryParse(Console.ReadLine(), out radius)
            ? (double?)radius
            : null;

            Console.WriteLine("{0:F2} {1:F2}", CalculatePerimeter(radius), CalculateArea(radius));

        }
    }
}

/*
 Description
 Write a program that reads from the console the radius r of a circle and prints its perimeter and area, rounded and formatted with 2 digits after the decimal point.

 Input
 On the only line of the input you will receive the radius of the circle - r

 Output
 You should print one line only: the perimeter and the area of the circle, separated by a whitespace, and with 2 digits precision

 Constraints
 The radius r will always be a valid and positive real number
 Time limit: 0.1s
 Memory limit: 16MB
 */