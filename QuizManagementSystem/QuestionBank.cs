using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizManagementSystem
{
    internal static class QuestionBank
    {
        private static Random random = new Random();
        public static IEnumerable<Question> RandomQuestions(int QuestionsNumber = 5)
        {
            return Questions.OrderBy(x => random.Next()).Take(QuestionsNumber);
        }

        public static void Quiz(IEnumerable<Question> questions, Student? student)
        {
            int QuestionNumber = 1;
            foreach (var question in questions)
            {
                Console.WriteLine($"Q{QuestionNumber++}. " + question);
                Console.WriteLine();
                Console.Write("Enter Your Choice: ");
                int StudentChoice;
                while (!int.TryParse(Console.ReadLine(), out StudentChoice) || StudentChoice < 1 || (StudentChoice > 4 && !question.QuestionType) || (StudentChoice > 2) && question.QuestionType)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Invalid input, please enter a valid number: ");
                }
               Console.ForegroundColor = ConsoleColor.White;
                Exam.ExamValidator(StudentChoice, question, student);
            }
        }

        private static List<Question> Questions = new List<Question>()
        {
            new Question
            {
                Title = "What does OOP stand for?",
                choices = new()
                {
                    new Choice{ Option = 1, Answer = "Object Oriented Programming" },
                    new Choice{ Option = 2, Answer = "Objective Operation Program" },
                    new Choice{ Option = 3, Answer = "Original Output Processing" },
                    new Choice{ Option = 4, Answer = "Optional Open Program" }
                },
                CorrectAnswer = 1,
                Mark = 2,
                QuestionType = false
            },

            new Question
            {
                Title = "Which principle hides internal details of a class?",
                choices = new()
                {
                    new Choice{ Option = 1, Answer = "Inheritance" },
                    new Choice{ Option = 2, Answer = "Abstraction" },
                    new Choice{ Option = 3, Answer = "Encapsulation" },
                    new Choice{ Option = 4, Answer = "Polymorphism" }
                },
                CorrectAnswer = 3,
                Mark = 2,
                QuestionType = false
            },

            new Question
            {
                Title = "Which keyword is used for inheritance in C#?",
                choices = new()
                {
                    new Choice{ Option = 1, Answer = "extends" },
                    new Choice{ Option = 2, Answer = "base" },
                    new Choice{ Option = 3, Answer = "inherit" },
                    new Choice{ Option = 4, Answer = "using" }
                },
                CorrectAnswer = 2,
                Mark = 2,
                QuestionType = false
            },

            new Question
            {
                Title = "Which keyword prevents a class from being inherited?",
                choices = new()
                {
                    new Choice{ Option = 1, Answer = "static" },
                    new Choice{ Option = 2, Answer = "sealed" },
                    new Choice{ Option = 3, Answer = "private" },
                    new Choice{ Option = 4, Answer = "final" }
                },
                CorrectAnswer = 2,
                Mark = 2,
                QuestionType = false
            },

            new Question
            {
                Title = "Which keyword is used to access the parent class constructor?",
                choices = new()
                {
                    new Choice{ Option = 1, Answer = "this" },
                    new Choice{ Option = 2, Answer = "base" },
                    new Choice{ Option = 3, Answer = "parent" },
                    new Choice{ Option = 4, Answer = "super" }
                },
                CorrectAnswer = 2,
                Mark = 2,
                QuestionType = false
            },

            new Question
            {
                Title = "Which OOP feature allows many forms?",
                choices = new()
                {
                    new Choice{ Option = 1, Answer = "Encapsulation" },
                    new Choice{ Option = 2, Answer = "Abstraction" },
                    new Choice{ Option = 3, Answer = "Inheritance" },
                    new Choice{ Option = 4, Answer = "Polymorphism" }
                },
                CorrectAnswer = 4,
                Mark = 2,
                QuestionType = false
            },

            new Question
            {
                Title = "Which allows multiple methods with the same name but different parameters?",
                choices = new()
                {
                    new Choice{ Option = 1, Answer = "Overriding" },
                    new Choice{ Option = 2, Answer = "Overloading" },
                    new Choice{ Option = 3, Answer = "Inheritance" },
                    new Choice{ Option = 4, Answer = "Interface" }
                },
                CorrectAnswer = 2,
                Mark = 2,
                QuestionType = false
            },

            new Question
            {
                Title = "Which keyword is used to override a base method?",
                choices = new()
                {
                    new Choice{ Option = 1, Answer = "override" },
                    new Choice{ Option = 2, Answer = "virtual" },
                    new Choice{ Option = 3, Answer = "new" },
                    new Choice{ Option = 4, Answer = "sealed" }
                },
                CorrectAnswer = 1,
                Mark = 2,
                QuestionType = false
            },

            new Question
            {
                Title = "Which type cannot be inherited?",
                choices = new()
                {
                    new Choice{ Option = 1, Answer = "Abstract class" },
                    new Choice{ Option = 2, Answer = "Sealed class" },
                    new Choice{ Option = 3, Answer = "Virtual class" },
                    new Choice{ Option = 4, Answer = "Partial class" }
                },
                CorrectAnswer = 2,
                Mark = 2,
                QuestionType = false
            },

            new Question
            {
                Title = "What is the base class of all .NET classes?",
                choices = new()
                {
                    new Choice{ Option = 1, Answer = "System.Base" },
                    new Choice{ Option = 2, Answer = "System.Object" },
                    new Choice{ Option = 3, Answer = "Root" },
                    new Choice{ Option = 4, Answer = "Main" }
                },
                CorrectAnswer = 2,
                Mark = 2,
                QuestionType = false
            },

            new Question
            {
                Title = "Which keyword allows unimplemented methods?",
                choices = new()
                {
                    new Choice{ Option = 1, Answer = "interface" },
                    new Choice{ Option = 2, Answer = "static" },
                    new Choice{ Option = 3, Answer = "sealed" },
                    new Choice{ Option = 4, Answer = "base" }
                },
                CorrectAnswer = 1,
                Mark = 2,
                QuestionType = false
            },

            new Question
            {
                Title = "Which access modifier allows visibility only inside the class?",
                choices = new()
                {
                    new Choice{ Option = 1, Answer = "protected" },
                    new Choice{ Option = 2, Answer = "internal" },
                    new Choice{ Option = 3, Answer = "private" },
                    new Choice{ Option = 4, Answer = "public" }
                },
                CorrectAnswer = 3,
                Mark = 2,
                QuestionType = false
            },

            new Question
            {
                Title = "Which keyword creates a constant variable?",
                choices = new()
                {
                    new Choice{ Option = 1, Answer = "readonly" },
                    new Choice{ Option = 2, Answer = "const" },
                    new Choice{ Option = 3, Answer = "static" },
                    new Choice{ Option = 4, Answer = "sealed" }
                },
                CorrectAnswer = 2,
                Mark = 2,
                QuestionType = false
            },

            new Question
            {
                Title = "Which of these supports multiple inheritance?",
                choices = new()
                {
                    new Choice{ Option = 1, Answer = "Classes" },
                    new Choice{ Option = 2, Answer = "Structures" },
                    new Choice{ Option = 3, Answer = "Interfaces" },
                    new Choice{ Option = 4, Answer = "Enums" }
                },
                CorrectAnswer = 3,
                Mark = 2,
                QuestionType = false
            },

            new Question
            {
                Title = "Which feature binds method call at runtime?",
                choices = new()
                {
                    new Choice{ Option = 1, Answer = "Static Binding" },
                    new Choice{ Option = 2, Answer = "Dynamic Binding" },
                    new Choice{ Option = 3, Answer = "Encapsulation" },
                    new Choice{ Option = 4, Answer = "Overloading" }
                },
                CorrectAnswer = 2,
                Mark = 2,
                QuestionType = false
            },

            new Question
            {
                Title = "Which keyword identifies a method that can be overridden?",
                choices = new()
                {
                    new Choice{ Option = 1, Answer = "virtual" },
                    new Choice{ Option = 2, Answer = "sealed" },
                    new Choice{ Option = 3, Answer = "abstract" },
                    new Choice{ Option = 4, Answer = "override" }
                },
                CorrectAnswer = 1,
                Mark = 2,
                QuestionType = false
            },

            new Question
            {
                Title = "Which class type cannot be instantiated?",
                choices = new()
                {
                    new Choice{ Option = 1, Answer = "Static class" },
                    new Choice{ Option = 2, Answer = "Abstract class" },
                    new Choice{ Option = 3, Answer = "Partial class" },
                    new Choice{ Option = 4, Answer = "Concrete class" }
                },
                CorrectAnswer = 2,
                Mark = 2,
                QuestionType = false
            },

            new Question
            {
                Title = "Which keyword allows the same method name in derived class?",
                choices = new()
                {
                    new Choice{ Option = 1, Answer = "new" },
                    new Choice{ Option = 2, Answer = "this" },
                    new Choice{ Option = 3, Answer = "base" },
                    new Choice{ Option = 4, Answer = "override" }
                },
                CorrectAnswer = 1,
                Mark = 2,
                QuestionType = false
            },

            new Question
            {
                Title = "What is method overriding?",
                choices = new()
                {
                    new Choice{ Option = 1, Answer = "Same method name, same parameter list" },
                    new Choice{ Option = 2, Answer = "Same method name, different parameters" },
                    new Choice{ Option = 3, Answer = "Different method name, same parameters" },
                    new Choice{ Option = 4, Answer = "Multiple constructors" }
                },
                CorrectAnswer = 1,
                Mark = 2,
                QuestionType = false
            },

            new Question
            {
                Title = "Which keyword calls the current class constructor?",
                choices = new()
                {
                    new Choice{ Option = 1, Answer = "this" },
                    new Choice{ Option = 2, Answer = "base" },
                    new Choice{ Option = 3, Answer = "new" },
                    new Choice{ Option = 4, Answer = "super" }
                },
                CorrectAnswer = 1,
                Mark = 2,
                QuestionType = false
            },

            new Question
            {
                Title = "enum keyword groups constants under a name?",
                choices = new()
                {
                    new Choice{ Option = 1, Answer = "True" },
                    new Choice{ Option = 2, Answer = "False" }
                },
                CorrectAnswer = 1,
                Mark = 2,
                QuestionType = true
            },
            new Question
            {
                Title = "C# supports Object Oriented Programming.",
                choices = new()
                {
                    new Choice{ Option = 1, Answer = "True" },
                    new Choice{ Option = 2, Answer = "False" }
                },
                CorrectAnswer = 1,
                Mark = 2,
                QuestionType = true
            },

            new Question
            {
                Title = "Encapsulation means hiding implementation details.",
                choices = new()
                {
                    new Choice{ Option = 1, Answer = "True" },
                    new Choice{ Option = 2, Answer = "False" }
                },
                CorrectAnswer = 1,
                Mark = 2,
                QuestionType = true
            },

            new Question
            {
                Title = "An abstract class can be instantiated in C#.",
                choices = new()
                {
                    new Choice{ Option = 1, Answer = "True" },
                    new Choice{ Option = 2, Answer = "False" }
                },
                CorrectAnswer = 2,
                Mark = 2,
                QuestionType = true
            },

            new Question
            {
                Title = "A sealed class can be inherited.",
                choices = new()
                {
                    new Choice{ Option = 1, Answer = "True" },
                    new Choice{ Option = 2, Answer = "False" }
                },
                CorrectAnswer = 2,
                Mark = 2,
                QuestionType = true
            },

            new Question
            {
                Title = "Method overloading allows multiple methods with the same name but different parameters.",
                choices = new()
                {
                    new Choice{ Option = 1, Answer = "True" },
                    new Choice{ Option = 2, Answer = "False" }
                },
                CorrectAnswer = 1,
                Mark = 2,
                QuestionType = true
            },

            new Question
            {
                Title = "Interfaces can provide method implementations in C#.",
                choices = new()
                {
                    new Choice{ Option = 1, Answer = "True" },
                    new Choice{ Option = 2, Answer = "False" }
                },
                CorrectAnswer = 2,
                Mark = 2,
                QuestionType = true
            },

            new Question
            {
                Title = "Polymorphism allows objects to behave in different ways.",
                choices = new()
                {
                    new Choice{ Option = 1, Answer = "True" },
                    new Choice{ Option = 2, Answer = "False" }
                },
                CorrectAnswer = 1,
                Mark = 2,
                QuestionType = true
            },

            new Question
            {
                Title = "The keyword 'base' is used to access members of the parent class.",
                choices = new()
                {
                    new Choice{ Option = 1, Answer = "True" },
                    new Choice{ Option = 2, Answer = "False" }
                },
                CorrectAnswer = 1,
                Mark = 2,
                QuestionType = true
            },

            new Question
            {
                Title = "All classes in C# inherit from System.Object.",
                choices = new()
                {
                    new Choice{ Option = 1, Answer = "True" },
                    new Choice{ Option = 2, Answer = "False" }
                },
                CorrectAnswer = 1,
                Mark = 2,
                QuestionType = true
            },

            new Question
            {
                Title = "Private members of a class can be accessed outside the class.",
                choices = new()
                {
                    new Choice{ Option = 1, Answer = "True" },
                    new Choice{ Option = 2, Answer = "False" }
                },
                CorrectAnswer = 2,
                Mark = 2,
                QuestionType = true
            },

        };
    }
}
