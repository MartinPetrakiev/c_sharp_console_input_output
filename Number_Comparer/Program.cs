using System;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            double? Temp_A = double.TryParse(Console.ReadLine(), out a)
                        ? (double?)a
                        : null;
            double? Temp_B = double.TryParse(Console.ReadLine(), out b)
                        ? (double?)b
                        : null;

            double result = a >= b ? a : b;
            Console.WriteLine(result);

        }
    }
}

/*
Description
Write a program that gets two numbers from the console and prints the greater of them.

Input
On the first two lines you will receive the two numbers, A and B

Output
On the only line print the larger of the two numbers
*Try implementing it without using if-statements

Constraints
The input will always be valid and in the described format.
The numbers A and B will always be valid real number
Time limit: 0.1s
Memory limit: 16MB
*/