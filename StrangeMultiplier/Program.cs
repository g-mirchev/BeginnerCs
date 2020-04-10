using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrangeMultiplier
{
    /*
     * Takes a number between 1 and 100. If lower than 50 outputs multiplication by 5
     * If greater than 50 outputs multiplication by 2 for even or by 3 for odd numbers
     */
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int number;

                while (true)
                {
                    Console.WriteLine("Enter your number between 1 and 100: ");
                    if (int.TryParse(Console.ReadLine(), out number) && number >= 1 && number <= 100) break;
                    Console.WriteLine("Error! Invalid entry, please try again..");
                }

                if (number > 50) 
                {
                    if(number % 2 == 0)
                    {
                        Console.WriteLine(number * 2);
                    }
                    else
                    {
                        Console.WriteLine(number * 3);
                    }
                }
                else
                {
                    Console.WriteLine(number * 5);
                }

                Console.WriteLine("Press Any Key to restart or Esc to quit..");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
