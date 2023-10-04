using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    public class FinalExam : Exam
    {
        public FinalExam(int time, int numberOfQuestions) : base(time, numberOfQuestions)
        {

        }

        public override void CreateListOfQuestions()
        {
            ListOfQuestions = new Question[NumberOfQuestions];
            for (int i = 0; i < ListOfQuestions.Length; i++)
            {
                int Choice;
                do
                {

                    Console.WriteLine("Enter 1 for MCQ or 2 for True/False Question :");
                } while (!int.TryParse(Console.ReadLine(),out Choice) || Choice<1 || Choice>2);
                Console.Clear();
                if (Choice == 1) 
                {
                    ListOfQuestions[i] = new MCQQuestion();
                    ListOfQuestions[i].AddQuestion();
                }
                else
                {
                    ListOfQuestions[i] = new TFQuestion();
                    ListOfQuestions[i].AddQuestion();
                }
            }

        }

        public override void ShowExam()
        {
            int TotalMarks = 0, Grade = 0;

            foreach (var Question in ListOfQuestions)
            {
                Console.WriteLine(Question);

                //Answers Choices of Question
                for (int i = 0; i < Question.AnswerList.Length; i++)
                {
                    Console.WriteLine(Question.AnswerList[i]);


                }
                Console.WriteLine("-----------------------------------");

                int UserAnswerId;
                if (Question.Header == "MCQ Question")
                {
                    do
                    {
                        Console.WriteLine("Enter Number Of Your Answer:");
                    } while (!int.TryParse(Console.ReadLine(), out UserAnswerId) || UserAnswerId < 1 || UserAnswerId > 3);
                    Question.UserAnswer.AnswerId = UserAnswerId;
                    Question.UserAnswer.AnswerText = Question.AnswerList[UserAnswerId - 1].AnswerText;
                    Console.WriteLine("---------------------------------------------");
                }
                else if(Question.Header == "True or False Question")
                {
                    do
                    {

                        Console.WriteLine("Enter Number Of Your Answer:");
                    } while (!int.TryParse(Console.ReadLine(), out UserAnswerId) || UserAnswerId < 1 || UserAnswerId > 3);

                    Question.UserAnswer.AnswerId = UserAnswerId;
                    Question.UserAnswer.AnswerText = Question.AnswerList[UserAnswerId - 1].AnswerText;
                    Console.WriteLine("---------------------------------------------");

                }
                Console.Clear();


                TotalMarks += Question.Marks;
            }
            for (int i = 0; i < ListOfQuestions.Length; i++)
            {
                if (ListOfQuestions[i].RightAnswer.AnswerId == ListOfQuestions[i].UserAnswer.AnswerId)
                {
                    Grade += ListOfQuestions[i].Marks;
                }

                Console.WriteLine($"Question {i + 1} : {ListOfQuestions[i].Body}");
                Console.WriteLine($"your answer: {ListOfQuestions[i].UserAnswer.AnswerText}");
                Console.WriteLine($"Right answer: {ListOfQuestions[i].RightAnswer.AnswerText}");

            }
            Console.WriteLine($"Your Grade is {Grade}/{TotalMarks}");
        }
    }
}
