using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullNameGenerator
{
    /*
    * Takes two strings as input from the user to generate full name
    */
    class Program
    {
        static void Main(string[] args)
        {
            do
            { 
                Console.WriteLine("What is your first name:");
                string name = Console.ReadLine();

                Console.WriteLine("What is your last name:");
                string lastName = Console.ReadLine();

                string fullName = name + " " + lastName;        // concatinate the two strings with an empty space in between
                Console.WriteLine($"Your full name is: {fullName}");

                Console.WriteLine("Press Any Key to restart or Esc to quit..");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
