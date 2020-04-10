using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRootCalculator
{
    /*
     * Calculates the square root of the user input.
     * Uses try-catch to demonstrate exception handling
     */
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    Console.WriteLine("Enter your number: ");
                    int num = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(Math.Sqrt(num));
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine("Press Any Key to restart or Esc to quit..");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape); 
        }
    }
}
