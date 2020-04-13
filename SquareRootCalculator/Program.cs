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
                /*
                 * try to get input from user. If the input is not convertable to int
                 * the program will catch an exception (This is an example to demonstrate exception
                 * handling, I strongly reccomend using int.TryParse() when reading user input as this
                 * method is a bit overkill in my opinion.
                 */
                try
                {
                    Console.WriteLine("Enter your number: ");
                    int num = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(Math.Sqrt(num));      // calculate the square root of num
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
