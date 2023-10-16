using System;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int firstNum = 0;
            int secondNum = 1;
            int nextNum = 0;
            string fibonacciSequenece = "0";

            if (n == 1)
            {
                Console.WriteLine(fibonacciSequenece);
            }

            fibonacciSequenece += ", 1";

            for (int i = 3; i <= n; i++)
            {
                nextNum = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = nextNum;

                fibonacciSequenece += ", " + nextNum;
            }

            Console.WriteLine(fibonacciSequenece);
        }
    }
}



/*
Description
Write a program that reads a number N and prints on the console the first N members of the Fibonacci sequence (at a single line, separated by comma and space - ", ") : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….

Input
On the only line you will receive the number N

Output
On the only line you should print the first N numbers of the sequence, separated by ", " (comma and space)

Constraints
1 <= N <= 50
N will always be a valid positive integer number
Time limit: 0.1s
Memory limit: 16MB
*/