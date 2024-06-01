using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    abstract class Questions
    {
        protected String header {  get; set; }
        public String body { get; set; }
        public int mark { get; set; }

        public Questions(string header , string body , int mark)
        {
            this.header = header;
            this.body = body;
            this.mark = mark;
        }
        public override string ToString()
        {
            return $"{header}\n{body}   {mark} points";
        }
        public abstract Questions SetQuestion();
    }
}
