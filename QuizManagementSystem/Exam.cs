using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizManagementSystem
{
    internal static class Exam
    {
        public static void Run(int QuestionsNumber, Student? student)
        {
            var questions = QuestionBank.RandomQuestions(QuestionsNumber);
            QuestionBank.Quiz(questions, student);
        }
        public static void ExamValidator(int StudentChoice, Question? obj, Student? student)
        {
            if (StudentChoice == obj.CorrectAnswer)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct Answer\n");
                student.Score += obj.Mark;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"The Correct Answer: {obj.CorrectAnswer}\n");
            }

                Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
