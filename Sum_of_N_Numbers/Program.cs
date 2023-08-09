using System;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            float sum = 0f;

            for (int i = 1; i <= n; i++)
            {
                float nextNumber = float.Parse(Console.ReadLine());
                sum += nextNumber;
            }

            Console.WriteLine(sum);
        }
    }
}

/*
Description
Write a program that enters a number N and after that enters more N numbers and calculates and prints their sum.
Note: You may need to use a for-loop.

Input
On the first line, you will receive the number N
On each of the next N lines, you will receive a floating-point number

Output
On must output only one number - the sum of the N numbers

Constraints
1 <= N <= 200
All numbers will be valid floating-point numbers in the range [-1000, 1000]
Time limit: 0.1s
Memory limit: 16MB
*/
