﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisionCounter
{
    /*
     * Calculates the number of times number n (user input)
     * can be divided by 2
     */
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double number;
                while (true)
                {
                    Console.WriteLine("Enter your number: ");
                    if (double.TryParse(Console.ReadLine(), out number)) break;
                    Console.WriteLine("Error! Invalid entry, please try again..");
                }

                int count = CountDivisions(number);

                Console.WriteLine($"Total number of divisions: {count}");

                Console.WriteLine("Press Any Key to restart or Esc to quit..");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }

        /*
         * Count the number of times the parsed number can be divided by 2 recusively
         */
        public static int CountDivisions(double number)
        {
            int count = 0;

            if(number > 0 && number % 2 == 0)
            {
                count++;
                number /= 2;

                return count += CountDivisions(number);
            }

            return count;
        }
    }
}
