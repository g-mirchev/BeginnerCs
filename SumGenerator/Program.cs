using System;
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
                int n;
                int m;

                while (true)
                {
                    Console.WriteLine("Enter the first number:");
                    if (int.TryParse(Console.ReadLine(), out n)) break;         // try to get user input until the format is correct
                    Console.WriteLine("Error! Invalid entry, please try again..");
                }

                while (true)
                {
                    Console.WriteLine("Enter the second number:");
                    if (int.TryParse(Console.ReadLine(), out m)) break;
                    Console.WriteLine("Error! Invalid entry, please try again..");
                }

                long sum = n + m;

                Console.WriteLine($"The result is {sum}");

                Console.WriteLine("Press Any Key to restart or Esc to quit..");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
