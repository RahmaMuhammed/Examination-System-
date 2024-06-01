using System.Diagnostics;

namespace Examination_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject sub = new Subject(10,"C#");
            sub.ExamInfo();
            Console.Clear();
            Console.WriteLine("IF you want start the exam [y or n]");
            string choice = Console.ReadLine();
            Console.Clear();

            if(choice == "y")
            {
                if (sub.exam != null)
                {
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();
                    sub.exam.ShowExam();
                    Console.WriteLine($"The Elapsed Time {stopwatch.Elapsed}");
                }
            }
        }
    }
}
