using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NumbersReadWrite
{
    /*
     * Writes 5 random integers to a file after which 
     * prints them out line by line determining the max value
     */
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                string relativePath = "numbers.txt";

                WriteToFile(relativePath);

                PrintNumbersAndMax(relativePath);

                Console.WriteLine("Press Any Key to restart or Esc to quit..");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }

        /*
         * Creates a file with the name and path given in an argument
         * loops 5 times to write 5 lines of random numbers
         */
        public static void WriteToFile(string path)
        {
            StreamWriter sw = new StreamWriter(path);
            Random r = new Random();
            for(int i = 1; i <= 5; i++)
            {
                sw.WriteLine(r.Next(1, 101));
            }
            sw.Close();
        }

        /*
         * Reads the first line and prints it, while asigning the value to be max
         * Writes every next line in a loop until the file is closed while comparing
         * the value to the initial max value, to determine the real max value
         */
        public static void PrintNumbersAndMax(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string line = sr.ReadLine();
                Console.WriteLine(line);
                int max = Convert.ToInt32(line);

                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    int temp = Convert.ToInt32(line);
                    if (temp > max)
                    {
                        max = temp;
                    }
                }
                Console.WriteLine($"Max number is: {max}");
            }
        }
    }
}
