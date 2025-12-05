using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizManagementSystem
{
    internal class Question
    {
        public string Title {  get; set; }
        public List<Choice>choices { get; set; } = new List<Choice>();
        public int CorrectAnswer { get; set; }
        public int Mark { get; set; }

       public bool QuestionType {  get; set; }

        public override string ToString()
        {
            string result = "";
            foreach (var item in choices)
            {
                result += $"{item.Option}. {item.Answer}\n";
            }
            return ($"{Title}\tMark: {Mark}\n" + $"{result}");
        }
    }
}
