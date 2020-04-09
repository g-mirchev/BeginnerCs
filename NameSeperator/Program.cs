using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSeperator
{
    /*
     * Takes the full name seperated by a blank space as input from user
     * returns the first and last names on seperate lines
     */
    class Program
    {
        static void Main(string[] args)
        {
            do
            { 
                Console.WriteLine("Enter your full name, seperated by blank space");
                string fullName = Console.ReadLine();

                int blankPosition = fullName.IndexOf(' ');
                string name = fullName.Substring(0, blankPosition);
                string lastName = fullName.Substring(blankPosition + 1);

                Console.WriteLine(name);
                Console.WriteLine(lastName);

                Console.WriteLine("Press Any Key to restart or Esc to quit..");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
