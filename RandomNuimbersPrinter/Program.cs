using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNuimbersPrinter
{
    /*
     * Generates an array of random ints with a user declared capacity
     * and calculates the sum of all elements of that array
     */
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int capacity;

                while(true)
                {
                    Console.WriteLine("Enter an array capacity: ");
                    if (int.TryParse(Console.ReadLine(), out capacity)) break;
                    Console.WriteLine("Error! Invalid entry, please try again..");
                }

                int[] numbers = new int[capacity];

                PopulateArray(numbers);
                Console.WriteLine();
                CalculateSum(numbers);

                Console.WriteLine("Press Any Key to restart or Esc to quit..");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

        }

        public static void PopulateArray(int[] numbers)
        {
            Random r = new Random();

            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = r.Next(1, 101);
                Console.WriteLine($"Element {i + 1} is {numbers[i]}");
            }
        }

        public static void CalculateSum(int[] numbers)
        {
            long sum = 0;

            foreach(int i in numbers)
            {
                sum += i;
            }

            Console.WriteLine($"The sum of all elements is {sum}");
        }
    }
}
