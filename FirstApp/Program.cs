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
                string testString = "This is some string to use for examples";  // declare the initial test string

                string partWithoutLength = testString.Substring(10);        // copy the string starting from index 10
                string partWithLength = testString.Substring(5, 10);        // copy 10 indexes worth of the string starting from index 5

                int charPosition = testString.IndexOf('i');         // get the index of the first instance of character 'i'
                int stringPosition = testString.IndexOf("some");        // get the starting index of the first instance of the string "some"
                int charPositionWithStartIndex = testString.IndexOf('s', 10);       // get the index of the first appearance of char 's' after index 10
                int stringPositionWithStartIndex = testString.IndexOf("some", 10);      // get the starting index of the first instance of the string "some" after index 10

                int lastPosition = testString.LastIndexOf('o');     // get the index of the last instance of character 'o'
                int stringLastPosition = testString.LastIndexOf("is");      // get the index of the last instance of string "is"

                bool containsResult = testString.Contains("for");       // check if the string contains the substring "for"

                bool startsWithResult = testString.StartsWith("bad");       // check if the string starts with "bad" 
                bool endsWithResult = testString.EndsWith("example");       // check if the string ends with "example"

                string loweredString = testString.Remove(10);       // delete everything after index 10
                string loweredStringWithCount = testString.Remove(10, 9);       // delete 9 indexes after index 10 

                string stringWithInsert = testString.Insert(13, "UPDATED");     // insert the substring "UPDATED" starting at index 13

                string loweCaseString = testString.ToLower();       // convert the string to lower case
                string upperCaseString = testString.ToUpper();      // convert the string to upper case

                /*
                 * Print out the result strings from the above operations
                 */
                Console.WriteLine(testString);

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

                /*
                 * Close the program if Escape is pressed, 
                 * or execute again if any other key is pressed
                 */
                Console.WriteLine("Press Any Key to restart or Esc to quit..");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
