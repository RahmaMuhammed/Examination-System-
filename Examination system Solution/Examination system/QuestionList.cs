using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    class QuestionList
    {
        List<Questions> questions;


        public QuestionList()
        {
            questions = new List<Questions>();
        }

        public void AddQuestionList(Questions question)
        {
            questions.Add(question);
        }

        public List<Questions> GetQuestionList()
        {
            return questions;
        }
    }
}
