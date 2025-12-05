using System.Xml.Linq;

namespace QuizManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Name: ");
            string StudentName = Console.ReadLine();
            Console.Write("\nEnter the number of questions: ");
            int QuestionsNumber = int.Parse(Console.ReadLine());
            Student student = new Student
            {
                Name = StudentName
            };
            Exam.Run(QuestionsNumber, student);
            Console.WriteLine($"Student name: {student.Name}, Score: {student.Score}\n");
        }
    }
}
