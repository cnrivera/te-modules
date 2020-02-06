using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using file_io_part1_exercises.Classes;

namespace file_io_part1_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Environment.CurrentDirectory;
            string file = "sample-quiz-file.txt";
            string filepath = Path.Combine(path, file);

            try
            {
                using (StreamReader sr = new StreamReader(filepath))
                {
                   while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] originalList = line.Split("|");
                        string question = originalList[0];
                        string[] answerArray = { originalList[1], originalList[2], originalList[3], originalList[4] };
                        string correctAnswer = "";
                        
                        Console.WriteLine(question);
                        
                        for (int i = 1; i < originalList.Length; i++)
                        {
                            bool hasStar = originalList[i].EndsWith('*');
                            while (originalList[i].EndsWith('*'))
                            {
                                originalList[i] = originalList[i].TrimEnd('*');
                                correctAnswer = originalList[i].ToLower();
                            }
                           
                            Console.WriteLine(originalList[i]);
                        }
                       
                        //QuizMakerClass qmc = new QuizMakerClass(question, correctAnswer, answerArray.ToList());
                        //Console.WriteLine(qmc);
                        string userInput = Console.ReadLine();

                        if (userInput == correctAnswer)
                        {
                            Console.WriteLine("Correct!");

                        }
                        else
                        {
                            Console.WriteLine("Sorry, incorrect.");
                        }

                        


                    }


                };
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            Console.ReadLine();
        }
    }
}
