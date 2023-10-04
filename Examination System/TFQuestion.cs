using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    public class TFQuestion : Question
    {
        public override string Header => "True or False Question";

        public TFQuestion() 
        {
            AnswerList = new Answer[2];

            AnswerList[0] = new Answer(1,"True");
            AnswerList[1] = new Answer(2,"False");

        }
       

        public override void AddQuestion()
        {

            Console.WriteLine(Header);

            //Body

            Console.WriteLine("Please Enter  Body Of Question");

            Body = Console.ReadLine();

            //Marks
            int mark;
            do
            {
                Console.WriteLine("Please enter Marks Of Question:");

            } while (!int.TryParse(Console.ReadLine(), out mark));

            Marks = mark;
            // right answer

            int RightAnswerId;
            do
            {
                Console.WriteLine("Please enter id of right Answer");
            } while (!int.TryParse(Console.ReadLine(), out RightAnswerId) || RightAnswerId < 1 || RightAnswerId > 2);
            RightAnswer.AnswerId = RightAnswerId;
            RightAnswer.AnswerText = AnswerList[RightAnswerId - 1].AnswerText;

            Console.Clear();
        }
    }
}
