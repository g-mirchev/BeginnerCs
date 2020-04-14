using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DirectoryHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                string path;
                AskForPath(out path);

                DirectoryInfo di; 

                for (int i = 1; i <= 5; i++)
                {
                    di = Directory.CreateDirectory(path + @"\MyTestDir" + i);
                    Console.WriteLine($"Full name: {di.FullName}, Name: {di.Name}, Parent {di.Parent}");
                }

                Console.WriteLine();
                Console.WriteLine("Directories created:");
                PrintDir(path);

                Directory.Delete(path + @"\MyTestDir2");

                Console.WriteLine();
                Console.WriteLine("Directory list after deleting MyTestDir2");
                PrintDir(path);

                Directory.Move(path + @"\MyTestDir5", path + @"\MyTestDir4\MyTestDir5");

                Console.WriteLine();
                Console.WriteLine("Directory list after moving MyTestDir5 to MyTestDir4");
                PrintDir(path);

                Console.WriteLine("Press Any Key to restart or Esc to quit..");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }

        public static void AskForPath(out string path)
        {
            while (true)
            {
                Console.WriteLine("Write the path of the folder in which you would like the demo directory to be created");
                string temp = @"" + Console.ReadLine();
                if (Directory.Exists(temp))
                {
                    path = temp;
                    break;
                }
                Console.WriteLine($"Directory not found at {temp} please try again");
            }
        }

        public static void PrintDir(string path)
        {
            string[] directories = Directory.GetDirectories(path);
            foreach (string d in directories)
            {
                Console.WriteLine(d);
            }
        }
    }
}
