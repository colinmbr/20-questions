using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20Questions
{
    class Questions
    {
        string question;
        string answer = "";

        public string getQuestion()
        {
            return question;
        }

        public string getAnswer()
        {
            return answer;
        }
        
        public void setQuestion(string q1)
        {
            question = q1;
        }

        public void setAnswer(string a1)
        {
            if (a1.Equals("yes", StringComparison.OrdinalIgnoreCase) || a1.Equals("no", StringComparison.OrdinalIgnoreCase))
                answer = a1;
            else Console.WriteLine("Enter yes or no.");
        }
    }
}
