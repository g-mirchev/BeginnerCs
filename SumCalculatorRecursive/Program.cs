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
                Console.WriteLine("Enter number n: ");
                int n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter number m: ");
                int m = Convert.ToInt32(Console.ReadLine());

                int sum = CalculateSumRecursively(n, m);

                Console.WriteLine(sum);

                Console.WriteLine("Press Any Key to restart or Esc to quit..");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }

        public static int CalculateSumRecursively(int n, int m)
        {
            int sum = n;
            
            if(n < m)
            {
                n++;
                return sum += CalculateSumRecursively(n, m);
            }

            return sum;
        }
    }
}
