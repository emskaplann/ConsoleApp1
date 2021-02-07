using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 6;
            if (a + b > 10)
                Console.WriteLine("The answer is greater than 10.");
            else
                Console.WriteLine("The answer is not greater than 10.");

            //int counter = 0;
            //while (counter < 10)
            //{
            //    Console.WriteLine($"Counter is at {counter + 1}");
            //    counter++;
            //}

            int total = 0;
            for (int index = 1; index <= 20; index++)
            {
                if (index % 3 == 0)
                    total += index;
            }

            Console.WriteLine($"Sum of all integers 1 through 20 that are divisible by 3: {total}");

            var names = new List<string> {"Emirhan", "Melik", "Sencer", "Kaplan"};
            names.Remove("Kaplan");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            names.Add("Kaplan");
            Console.WriteLine();
            names.Sort();

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            var fibonacciNumbers = new List<int> {1, 1};

            int n = 20;
            for (int i = 0; i < n - 2; i++)
            {
                int prev = fibonacciNumbers[fibonacciNumbers.Count - 1];
                int prev2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
                fibonacciNumbers.Add(prev + prev2);
            }

            Console.WriteLine();
            Console.WriteLine($"{n}. Fibonacci Number is: {fibonacciNumbers[fibonacciNumbers.Count - 1]}");
        }
    }
}
