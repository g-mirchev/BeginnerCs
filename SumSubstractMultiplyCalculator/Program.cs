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
                Console.WriteLine("Enter the first number: ");
                int first = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the second number: ");
                int second = Convert.ToInt32(Console.ReadLine());

                Sum(first, second);
                Substract(first, second);
                Multiply(first, second);

                Console.WriteLine("Press Any Key to restart or Esc to quit..");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }

        public static void Sum(int first, int second)
        {
            int result = first + second;
            Console.WriteLine($"Sum result: {result}");
        }

        public static void Substract(int first, int second)
        {
            int result = first - second;
            Console.WriteLine($"Multiplication result: {result}");
        }

        public static void Multiply(int first, int second)
        {
            int result = first * second;
            Console.WriteLine($"Multiplication result: {result}");
        }
    }
}
