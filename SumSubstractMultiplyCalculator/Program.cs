using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSubstractMultiplyCalculator
{
    /*
     * Returns the Sum, Substraction and Multiplication of two numbers from user input
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
                    if (int.TryParse(Console.ReadLine(), out m)) break;
                    Console.WriteLine("Error! Invalid entry, please try again..");
                }

                Sum(n, m);
                Substract(n, m);
                Multiply(n, m);

                Console.WriteLine("Press Any Key to restart or Esc to quit..");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }

        /*
         * Calculate the sum and print it
         */
        public static void Sum(int first, int second)
        {
            long result = first + second;
            Console.WriteLine($"Sum result: {result}");
        }

        /*
         * Calculate the substraction and print it
         */
        public static void Substract(int first, int second)
        {
            long result = first - second;
            Console.WriteLine($"Multiplication result: {result}");
        }

        /*
         * Calculate the multiplication and print it
         */
        public static void Multiply(int first, int second)
        {
            long result = first * second;
            Console.WriteLine($"Multiplication result: {result}");
        }
    }
}
