using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterNumber
{
    /*
     * Takes two numbers as input and compares them
     */
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int first;
                int second;

                while (true)
                {
                    Console.WriteLine("Enter the first number: ");
                    if (int.TryParse(Console.ReadLine(), out first)) break;
                    Console.WriteLine("Error! Invalid entry, please try again..");
                }

                while (true)
                {
                    Console.WriteLine("Enter the second number: ");
                    if (int.TryParse(Console.ReadLine(), out second)) break;
                    Console.WriteLine("Error! Invalid entry, please try again..");
                }

                string resultString = "The greater number is ";

                /*
                 * Check if the first number is greater than the seccond,
                 * if not check if it's smaller, if not decide that they are equal
                 */
                if(first > second)
                {
                    Console.WriteLine(resultString + first);
                }
                else if(first < second)
                {
                    Console.WriteLine(resultString + second);
                }
                else
                {
                    Console.WriteLine("The numbers are equal");
                }

                Console.WriteLine("Press Any Key to restart or Esc to quit..");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
