using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    class TF_Question : Questions
    {
        public TF_Question(string header, string body, int mark) : base(header, body, mark){}
        public override Questions SetQuestion()
        {
            this.header = "T | F Question";
            Console.WriteLine(header);
            Console.WriteLine("Please, Enter the body of question");
            this.body = Console.ReadLine();
            Console.WriteLine("Please, Enter the mark of question");
            this.mark = int.Parse(Console.ReadLine());
            return this;
        }
    }
}
