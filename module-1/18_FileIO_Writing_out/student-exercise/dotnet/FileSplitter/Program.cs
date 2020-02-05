using System;
using System.IO;
using System.Linq;


namespace FileSplitter
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileSource = GetFilePath();
            int linesPerFile = GetLinesPerFile();

            try
            {
                using (StreamReader sr = new StreamReader(fileSource))
                {
                    while (!sr.EndOfStream)
                    {
                        string outputFile = Path.GetFileNameWithoutExtension(fileSource);
                        //string filename = "input.txt";
                        //string fullPath = Path.Combine(directory, filename);
                        int fileSuffix = 1;
                        int linescount = File.ReadLines(fileSource).Count();

                        int count = 0;
                       
                            for (int i = 0; i < linescount; i++)
                            {
                                using (StreamWriter sw = new StreamWriter(($"{outputFile}-{fileSuffix}.txt"), true))
                                {

                                    sw.WriteLine(sr.ReadLine());
                                    count++;

                                    if (count == linesPerFile)
                                    {
                                        fileSuffix++;
                                        count = 0;
                                    }
                                }
                            

                            }
                    }
                }
            }
            catch (IOException e) //catch a specific type of Exception
            {
                Console.WriteLine("Error reading the file");
                Console.WriteLine(e.Message);
            }
          
        }
      
        public static string GetFilePath()
        {
            string filePath = "";
            bool isValidFilePath;

            Console.WriteLine("Enter complete path of file to split: ");
            filePath = Console.ReadLine();

            isValidFilePath = ValidateFilePath(filePath);

            if (!isValidFilePath)
            {
                Console.Write("The specified file path was invalid, would you re-enter it? Y/N");
                string response = Console.ReadLine();
                if (response.ToUpper() == "Y")
                {
                    filePath = GetFilePath();
                }
                else
                {
                    filePath = "";
                }
            }
            return filePath;
        }

        public static bool ValidateFilePath(string filePath)
        {
            bool isValid = File.Exists(filePath);
            return isValid;
        }

        public static int GetLinesPerFile()
        {
            Console.Write("Enter the number of lines per file: ");
            int lines = int.Parse(Console.ReadLine());
            return lines;
           
        }

        
    }


}
