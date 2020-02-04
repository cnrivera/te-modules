using System;
using System.IO;

namespace WordSearch
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter the full file path of the file to search: ");
            string filePath = Console.ReadLine();
            // TK Add instructions to catch problems in command path

            while (!File.Exists(filePath))
            {
                Console.WriteLine("Invalid file name. Please re-enter: ");
                filePath = Console.ReadLine();
            }
            
            Console.Write("Enter the word to search for: ");
            string wordToSearch = Console.ReadLine();

            
            Console.Write("Should the search be case sensitive? Y/N? ");
            string caseSensitive = Console.ReadLine().ToUpper();

            
            try
            {
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        int lineNumber = 0;
                        bool found = false;
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            lineNumber++;

                            int position = line.IndexOf(wordToSearch);
                            if (caseSensitive.Equals("N"))
                        {
                            position = line.ToLower().IndexOf(wordToSearch.ToLower());
                        }


                            if (position != -1)
                            {
                            found = true;
                                Console.WriteLine("{0}: {1}", lineNumber, line);

                            }

                        }
                        if (!found)
                    {
                        Console.WriteLine("Word not found.");
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


