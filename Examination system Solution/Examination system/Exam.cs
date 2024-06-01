using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    abstract class Exam
    {
        // Attributes of Exam Class
        public int TimeOfExam { get; set; }
        public int NumOfQuestions { get; set; }
       // protected Subject subject { get; set; }

        // Common Atrributes between Final and Practical Classes
        protected int Choice;
        protected QuestionList questionList;
        protected List<Answers> answers;
        protected List<int> RightAnswers;
        protected int grade;
        protected int total;
        protected List<Questions> questions;

        // Constractors


        protected Exam(int timeOfExam, int numOfQuestions) : 
           this(timeOfExam, numOfQuestions, null, 0, null, null, null, 0, 0, null){ }

        protected Exam(int timeOfExam, int numOfQuestions, Subject subject, int choice, QuestionList questionList, List<Answers> answers, List<int> rightAnswers, int grade, int total, List<Questions> questions)
        {
            TimeOfExam = timeOfExam;
            NumOfQuestions = numOfQuestions;
           
            Choice = choice;
            this.questionList = questionList;
            this.answers = answers;
            RightAnswers = rightAnswers;
            this.grade = grade;
            this.total = total;
            this.questions = questions;
        }
        // Abstract Methods
        public abstract void CreateExam();
        public abstract void ShowExam();

       
        // Common Methods
        protected void DisplayQuestionAndOptions(int count , List<Answers> answers , List<Questions> questions)
        {
            Console.WriteLine(questions[count].ToString());
            int optionCount = 1;


            for (int i = 0; i < answers.Count; i++)
            {
                if (answers[i].AnswerId == count)
                {
                    Console.WriteLine($"{optionCount}- {answers[i].AnswerText}");
                    optionCount++;
                }
                else if (answers[i].AnswerId > count)
                {
                    break;
                }
            }
        }

        protected int GetUserAnswer()
        {
            Console.WriteLine("Enter the number of your answer");
            int userAnswer;


            while (!int.TryParse(Console.ReadLine(), out userAnswer))
            {
                Console.WriteLine("Invalid input. Please enter a valid option.");
            }

            return userAnswer;
        }

        protected void DisplayFinalAnswers(List<Questions> questions , List<Answers>answers,List<int> RightAnswers)
        {
            Console.WriteLine("Questions and Right Answers");
            Console.WriteLine("----------------------------------");
            for (int count = 0; count < questions.Count; count++)
            {
                string finalAnswer = "";
                int correctOption = 1;


                for (int i = 0; i < answers.Count; i++)
                {
                    if (answers[i].AnswerId == count)
                    {
                        if (RightAnswers[count] == correctOption)
                        {
                            finalAnswer = answers[i].AnswerText;
                            break;
                        }
                        correctOption++;
                    }
                }

                Console.WriteLine($"Q{count + 1})  {questions[count].body} : {finalAnswer}");
            }
            Console.WriteLine();
        }
    }
}
