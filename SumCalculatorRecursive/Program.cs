using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumCalculatorRecursive
{
    /*
     * Calculates recursively the sum of numbers from n to m (user input)
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

                long sum = CalculateSumRecursively(n, m);

                Console.WriteLine(sum);

                Console.WriteLine("Press Any Key to restart or Esc to quit..");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }

        /*
         * Assign the initial sum value to n, if n is equal to m return the sum
         * if not, call the method again with the incremented value and add that return to the sum
         * repeat untill n is equal to m
         */
        public static long CalculateSumRecursively(int n, int m)
        {
            long sum = n;
            
            if(n < m)
            {
                n++;
                return sum += CalculateSumRecursively(n, m);
            }

            return sum;
        }
    }
}
