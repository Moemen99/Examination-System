using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    public class MCQQuestion : Question
    {
        public override string Header => "MCQ Question";


        public MCQQuestion() 
        {
            AnswerList = new Answer[3]; 
        }

        public override void AddQuestion()
        {
            Console.WriteLine(Header);

            //Body

            Console.WriteLine("Please Enter  Body Of Question");

            Body =Console.ReadLine();

            //Marks
            int mark;
            do
            {
                Console.WriteLine("Please enter Marks Of Question:");

            } while (!int.TryParse(Console.ReadLine(),out mark) || mark <1);

            Marks = mark;

            //Choices

            Console.WriteLine("Please Enter Answerses Of Question:");
            for(int i = 0; i < 3; i++)
            {
                AnswerList[i] = new Answer()
                {
                    AnswerId = i + 1,
                   
                };
                Console.WriteLine($"Enter answer number {i+1} : ");
                AnswerList[i].AnswerText = Console.ReadLine();

            }
            // right answer

            int RightAnswerId;
            do
            {
                Console.WriteLine("Please enter id of right Answer");
            }while(!int.TryParse(Console.ReadLine(), out RightAnswerId) || RightAnswerId<1 || RightAnswerId >3);
            RightAnswer.AnswerId = RightAnswerId;
            RightAnswer.AnswerText = AnswerList[RightAnswerId-1].AnswerText;

            Console.Clear();

        }
    }
}
