using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysInMonth
{
    /*
     * Takes month number as input and returns the number of days in that month
     */
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int month;
                while (true)
                {
                    Console.WriteLine("Enter the month number from 1 to 12");
                    if (int.TryParse(Console.ReadLine(), out month)) break;
                    Console.WriteLine("Error! Invalid entry, please try again..");
                }

                /*
                 * If the user has picked a long month print out 31 days,
                 * if the user has picked a short month, print out 30 days,
                 * if the user has picked February print out 28 or 29 days,
                 * If neither of those, the default case will notify the user of their mistake
                 */
                switch (month)
                {
                    case 1: case 3: case 5:
                    case 7: case 8:
                    case 10: case 12:
                        Console.WriteLine("Number of days is 31");
                        break;
                    case 4: case 6:
                    case 9: case 11:
                        Console.WriteLine("Number of days is 30");
                        break;
                    case 2:
                        Console.WriteLine("Number of days is 28 or 29");
                        break;
                    default:
                        Console.WriteLine("Your number is not between 1 and 12");
                        break;
                }

                Console.WriteLine("Press Any Key to restart or Esc to quit..");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
