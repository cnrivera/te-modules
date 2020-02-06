using System;
using System.Collections.Generic;
using System.Text;

namespace file_io_part1_exercises.Classes
{
    public class QuizMakerClass
    {
        public string Question { get; }
        public List<string> Answer { get;}
        private string correctAnswer;
        
        public QuizMakerClass(string question, string correctAnswer, List<string> answer)
        {
            Question = question;
            this.correctAnswer = correctAnswer;
            Answer = answer;

        }

       public bool isAnswerCorrect (string choice)
        {
            if (choice == correctAnswer)
            {
                return true;
            }
            return false;
            
        }

        public override string ToString()
        {
            string result = $"{Question} \n 1. {Answer[0]} \n 2. {Answer[1]} \n 3. {Answer[2]} \n 4. {Answer[3]} \n";
            return result;
        }
    }
}
