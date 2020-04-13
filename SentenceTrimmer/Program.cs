using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentenceTrimmer
{
    /*
     * Removes the first and last word of a sentence
     */
    class Program
    {
        static void Main(string[] args)
        {
            do
            { 
                Console.WriteLine("Enter your sentence (at least 3 words to demonstrate full effect): ");

                string sentence = Console.ReadLine();

                int firstBlankPosition = sentence.IndexOf(' ');

                string withoutFirstWord = sentence.Remove(0, firstBlankPosition + 1);       // remove everything untill the first empty space 

                int lastBlankPosition = withoutFirstWord.LastIndexOf(' ');

                string withoutFirstAndLast = withoutFirstWord.Remove(lastBlankPosition);    // remove everything after the last empty space

                Console.WriteLine(withoutFirstAndLast);

                Console.WriteLine("Press Any Key to restart or Esc to quit..");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
