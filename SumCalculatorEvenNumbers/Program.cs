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
                Console.WriteLine("Enter the upper border number n: ");
                int n = Convert.ToInt32(Console.ReadLine());

                int sum = 2;
                int startingNumber = 4;

                do
                {
                    sum += startingNumber;
                    startingNumber += 2;
                } while (startingNumber <= n);

                Console.WriteLine($"Sum of all the even numbers to n is {sum}");

                Console.WriteLine("Press Any Key to restart or Esc to quit..");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
