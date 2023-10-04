using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    public abstract class Exam
    {
        protected Exam(int time, int numberOfQuestions)
        {
            Time = time;
            NumberOfQuestions = numberOfQuestions;
        }

        public int Time {  get; set; }

        public int NumberOfQuestions { get; set; }

        public Question[] ListOfQuestions { get; set; }

        public abstract void ShowExam();
        public abstract void CreateListOfQuestions();
    }
}
