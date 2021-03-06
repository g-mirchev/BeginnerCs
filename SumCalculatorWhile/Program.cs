﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumCalculatorWhile
{
    /*
     * Calculates the sum of numbers between n and m (user input)
     * with the use of a while loop
     */
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int n;
                int m;

                while (true)
                {
                    Console.WriteLine("Enter the first number:");
                    if (int.TryParse(Console.ReadLine(), out n)) break;
                    Console.WriteLine("Error! Invalid entry, please try again..");
                }

                while (true)
                {
                    Console.WriteLine("Enter the second number (must be greater than the first):");
                    if (int.TryParse(Console.ReadLine(), out m) && m > n) break;
                    Console.WriteLine("Error! Invalid entry, please try again..");
                }

                long sum = 0;

                /*
                 * If n is initially less than or equal to m add n to the sum 
                 * and increment it with each iteration until n is greater than m
                 */
                while (n <= m)
                {
                    sum += n;
                    n++;
                }

                Console.WriteLine($"Sum from n to m is {sum}");

                Console.WriteLine("Press Any Key to restart or Esc to quit..");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
