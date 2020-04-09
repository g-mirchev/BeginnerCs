﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumGenerator
{
    /*
     * Takes two numbers as input from the user to calculate the sum
     */
    class Program
    {
        static void Main(string[] args)
        {
            do
            { 
                Console.WriteLine("Write the first integer:");
                int first = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Write the second integer:");
                int second = Convert.ToInt32(Console.ReadLine());

                int result = first + second;

                Console.WriteLine($"The result is {result}");

                Console.WriteLine("Press Any Key to restart or Esc to quit..");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
