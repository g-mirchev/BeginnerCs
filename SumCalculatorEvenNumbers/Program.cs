using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumCalculatorEvenNumbers
{
    /*
     * Calculates the sum of all even numbers up to n (user input)
     */
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                uint n;

                while (true)
                {
                    Console.WriteLine("Enter the upper border number n (non-negative values only): ");
                    if (uint.TryParse(Console.ReadLine(), out n)) break;
                    Console.WriteLine("Error! Invalid entry, please try again..");
                }

                long sum = 0;
                int startingNumber = 4;
                
                /*
                 * if n is greater than 2 make the initial sum 2
                 */
                if(n >= 2)
                {
                    sum = 2;
                    /*
                     * if starting number is less than or equal to n add startingNumber to sum
                     * and increment it by 2 untill startingNumber is greater than n
                     */
                    while (startingNumber <= n)
                        {
                            sum += startingNumber;
                            startingNumber += 2;
                        }
                }
                
                Console.WriteLine($"Sum of all the even numbers to n is {sum}");

                Console.WriteLine("Press Any Key to restart or Esc to quit..");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
