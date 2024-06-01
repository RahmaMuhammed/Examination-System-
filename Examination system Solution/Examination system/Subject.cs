using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    class Subject
    {
        string SubjectName;
        int SubjectId;
        public Exam exam { get; set; }
        public int TimeOfExam { get; private set; }
        public int NumOfQuestions { get; private set; }

        public Subject(int id , string name)
        {
            SubjectId = id;
            SubjectName = name;
        }
        public void ExamInfo()
        {
            Console.WriteLine("Please Enter 1 For Final exam or 2 For Practical Exam");
            int Choise = int.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter Time of Exam in minutes");
            TimeOfExam = int.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter Number of questions");
            NumOfQuestions = int.Parse(Console.ReadLine());

            Console.Clear();

            if (Choise == 1)
            {
                exam = new FinalExam(TimeOfExam, NumOfQuestions);
                exam.CreateExam();
            }
            else if (Choise == 2)
            {
                exam = new PracticalExam(TimeOfExam, NumOfQuestions);
                exam.CreateExam();
            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }
        }
    
    }
}
