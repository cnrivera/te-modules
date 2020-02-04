using System;
using System.IO;

namespace WordSearch
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter the word to search for.");
            string wordToSearch = Console.ReadLine();

            Console.WriteLine("Enter the full file path of the file to search.");
            string filePath = Console.ReadLine();
            // TK Add instructions to catch problems in command path

                try
                {
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        int lineNumber = 0;
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            lineNumber++;

                            int position = line.IndexOf(wordToSearch);
                            if (position != -1)
                            {

                                Console.WriteLine("{0}: {1}", lineNumber, line);

                            }

                        }

                    }
                }
                catch (IOException e)
                {
                    Console.WriteLine("Error reading the file");
                    Console.WriteLine(e.Message);
                }
            

        }
    }
}


