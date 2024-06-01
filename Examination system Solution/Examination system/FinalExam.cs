using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    class FinalExam : Exam
    {
        Answers trueAnswer;
        Answers falseAnswer;

        public FinalExam(int timeOfExam, int numOfQuestions) : base(timeOfExam, numOfQuestions)
        {
            questionList = new QuestionList();
            answers = new List<Answers>();
            RightAnswers = new List<int>();
        }

        public override void CreateExam()
        {
            for (int i = 0; i < NumOfQuestions; i++)
            {
                Console.WriteLine("Enter 1 For T | F Question or 2 For MCQ Question");
                Choice = int.Parse(Console.ReadLine());
                Console.Clear();

                if (Choice == 1)
                {
                    TF_Question question = new TF_Question("", "", 0);

                    questionList.AddQuestionList(question.SetQuestion());

                    Console.WriteLine("Enter the right answer True or False [ 1 For True | 2 For False] ");
                    int ans = int.Parse(Console.ReadLine());

                    RightAnswers.Add(ans);

                     trueAnswer = new Answers(i, "True");
                     falseAnswer = new Answers(i, "False");

                    answers.Add(trueAnswer);
                    answers.Add(falseAnswer);

                }
                else if (Choice == 2)
                {
                    MCQ_Questions question = new MCQ_Questions("", "", 0);

                    questionList.AddQuestionList(question.SetQuestion());

                    Console.WriteLine("Enter the choices of the question");
                    string choice;

                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write($"Enter the choice number {j + 1} : ");
                        choice = Console.ReadLine();
                        Answers answer = new Answers(i, choice);
                        answers.Add(answer);
                    }

                    Console.WriteLine("Enter the right answer [1, 2, or 3]");
                    int ans = int.Parse(Console.ReadLine());

                    RightAnswers.Add(ans);
                }
                Console.Clear();
            }


        }

       
        public override void ShowExam()
        {

            questions = questionList.GetQuestionList();

            for (int count = 0; count < questions.Count; count++)
            {
                DisplayQuestionAndOptions(count , answers , questions);
                int userAnswer = GetUserAnswer();

                if (userAnswer == RightAnswers[count])
                {
                    grade += questions[count].mark;
                }

                total += questions[count].mark;
                Console.WriteLine();
                Console.WriteLine("----------------------------------");
                Console.WriteLine();
            }
            Console.Clear();

            // Display the final answers and results
            DisplayFinalAnswers(questions , answers , RightAnswers);
            Console.WriteLine($"You gained {grade} marks out of {total}");
        }

    }

}
