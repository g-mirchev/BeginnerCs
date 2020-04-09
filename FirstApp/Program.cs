using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                string testString = "this is some string to use for examples";

                string partWithoutLength = testString.Substring(10);
                string partWithLength = testString.Substring(5, 10);

                int charPosition = testString.IndexOf('i');
                int stringPosition = testString.IndexOf("some");
                int charPositionWithStartIndex = testString.IndexOf('s', 10);
                int stringPositionWithStartIndex = testString.IndexOf("some", 10);

                int lastPosition = testString.LastIndexOf('o');
                int stringLastPosition = testString.LastIndexOf("is");

                bool containsResult = testString.Contains("for");

                bool startsWithResult = testString.StartsWith("bad");
                bool endsWithResult = testString.EndsWith("example");

                string loweredString = testString.Remove(10);
                string loweredStringWithCount = testString.Remove(10, 9);

                string stringWithInsert = testString.Insert(13, "UPDATED");

                string loweCaseString = testString.ToLower();
                string upperCaseString = testString.ToUpper();

                Console.WriteLine(partWithoutLength);
                Console.WriteLine(partWithLength);

                Console.WriteLine(charPosition);
                Console.WriteLine(stringPosition);
                Console.WriteLine(charPositionWithStartIndex);
                Console.WriteLine(stringPositionWithStartIndex);

                Console.WriteLine(lastPosition);
                Console.WriteLine(stringLastPosition);

                Console.WriteLine(containsResult);

                Console.WriteLine(startsWithResult);
                Console.WriteLine(endsWithResult);

                Console.WriteLine(stringWithInsert);

                Console.WriteLine(loweCaseString);
                Console.WriteLine(upperCaseString);

                Console.WriteLine("Press Any Key to restart or Esc to quit..");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
