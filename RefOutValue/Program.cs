using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOutValue
{
    /*
     * Demonstrates the use of Ref and Out keywords when used with a value
     */
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int number;
                Console.WriteLine($"Original number value is unasigned");

                ChangeOut(out number);
                Console.WriteLine($"After ChangeOut number value is {number}");

                ChangeAndWrite(number);
                Console.WriteLine($"After ChangeAndWrite number value is {number}");

                ChangeRef(ref number);
                Console.WriteLine($"After CangeRef number value is {number}")

                Console.WriteLine("Press Any Key to restart or Esc to quit..");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }

        public static void ChangeAndWrite(int number)
        {
            number = 10;
            Console.WriteLine($"Inside ChangeAndWrite number value is: {number}");
        }

        public static void ChangeRef(ref int number)
        {
            number = 25;
            Console.WriteLine($"Inside ChangeRef number value is: {number}");
        }

        public static void ChangeOut(out int number)
        {
            number = 60;
            Console.WriteLine($"Inside ChangeOut number value is: {number}");
        }
    }
}
