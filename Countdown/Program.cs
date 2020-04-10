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
                for(int i = n; i >= 1; i--)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("Press Any Key to restart or Esc to quit..");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
