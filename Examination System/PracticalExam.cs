using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    public class PracticalExam : Exam
    {
        //MCQ
        public PracticalExam(int time, int numberOfQuestions) : base(time, numberOfQuestions)
        {
        }

        public override void CreateListOfQuestions()
        {
            ListOfQuestions = new MCQQuestion[NumberOfQuestions];
            for (int i = 0; i <ListOfQuestions.Length; i++)
            {
                ListOfQuestions[i] =new MCQQuestion();
                ListOfQuestions[i].AddQuestion();
                Console.Clear();
                
            }
        }

        public override void ShowExam()
        {
            //Answers Choices of Question
            foreach (var question in ListOfQuestions)
            {
                Console.WriteLine(question);
                for (int i = 0; i < question.AnswerList.Length; i++)
                 {
                    Console.WriteLine(question.AnswerList[i]);
                 }
                Console.WriteLine("-----------------------------------");

                int UserAnswerId;
                do
                {
                    Console.WriteLine("Enter Number Of Your Answer:");
                } while (!int.TryParse(Console.ReadLine(), out UserAnswerId) || UserAnswerId < 1 || UserAnswerId > 3);
                question.UserAnswer.AnswerId = UserAnswerId;
                question.UserAnswer.AnswerText = question.AnswerList[UserAnswerId - 1].AnswerText;
                Console.WriteLine("---------------------------------------------");
            }
            Console.Clear() ;
            Console.WriteLine("Right Answer:");

            for (int i = 0; i < ListOfQuestions.Length; i++)
            {
                Console.WriteLine($"Right answer of Question {i+1} : {ListOfQuestions[i].RightAnswer.AnswerText}");


            }
        }
    }
}
