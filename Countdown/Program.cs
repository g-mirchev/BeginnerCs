using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Countdown
{
    /*
     * Prints out the numbers from n (user input) to 1
     * n must be greater than 1
     */
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int n;
                while (true)
                {
                    Console.WriteLine("Enter number n that is greater than 1: ");
                    if (int.TryParse(Console.ReadLine(), out n) && n > 1) break;
                    Console.WriteLine("Error! Invalid entry, please try again..");
                }

                /*
                 * Let I be equal to n, if I is greater than one, print out i,
                 * then decrement i by 1 and repeat until i is equal to 1 thus
                 * printing each number from n to 1
                 */
                for(int i = n; i >= 1; i--)
                {
                    Console.WriteLine(i);
                }

                Console.WriteLine("Press Any Key to restart or Esc to quit..");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
