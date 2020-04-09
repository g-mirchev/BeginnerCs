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
                Console.WriteLine("Enter the first number: ");
                int first = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the second number: ");
                int second = Convert.ToInt32(Console.ReadLine());

                string resultString = "The greater number is ";

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
