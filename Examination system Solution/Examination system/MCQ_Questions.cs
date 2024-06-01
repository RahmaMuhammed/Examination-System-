using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    class MCQ_Questions : Questions
    {
        public MCQ_Questions(string header, string body, int mark) : base(header, body, mark) { }
        public override Questions SetQuestion()
        {
            this.header = "MCQ Question";
            Console.WriteLine(header);
            Console.WriteLine("Please, Enter the body of question");
            this.body = Console.ReadLine();
            Console.WriteLine("Please, Enter the mark of question");
            this.mark = int.Parse(Console.ReadLine());
            return this;
        }
    }
}
