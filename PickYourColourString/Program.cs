using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickYourColourString
{
    /*
     * Takes string and char as input from user returns string
     * in different color based on char selected
     */
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.ForegroundColor = ConsoleColor.Gray;

                Console.WriteLine("Enter your random string: ");
                string sentence = Console.ReadLine();

                char color;

                while (true)
                {
                    Console.WriteLine("Coosey your colour: r for Red, g for Green, o for Other");
                    if (char.TryParse(Console.ReadLine(), out color) && (color == 'r' || color == 'g' || color == 'o')) break;
                    Console.WriteLine("Error! Invalid entry, please try again..");
                }

                color = char.ToLower(color);
                
                /*
                 * Change the color of the string based on char value
                 */
                if (color == 'r')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (color == 'g')
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }

                Console.WriteLine(sentence);

                Console.ForegroundColor = ConsoleColor.Gray;

                Console.WriteLine("Press Any Key to restart or Esc to quit..");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
