using System;
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
                Console.WriteLine("Enter the integer n number:");
                int n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the integer m number:");
                int m = Convert.ToInt32(Console.ReadLine());

                int sum = 0;

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
