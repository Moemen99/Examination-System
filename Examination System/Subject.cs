using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    public class Subject
    {
        public Subject(int subjectId, string subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
        }

        public int SubjectId { get; set; }
        public string SubjectName { get; set; }

        public Exam SubjectExam { get; set; }

        public void CreateExam()
        {
            int ExamType, Time, NumberOfQuestions;

            do
            {
                Console.WriteLine("Enter 1 For Practical Exam or 2 for Final Exam: ");
            }while (!int.TryParse(Console.ReadLine(),out ExamType )&& ExamType<1 || ExamType >2);

            do
            {
                Console.WriteLine("Enter Time For Exam (30 to 180 min): ");
            } while (!int.TryParse(Console.ReadLine(), out Time) || (Time < 30 || Time > 180));

            do
            {
                Console.WriteLine("Enter Number Of Questions: ");
            } while (!int.TryParse(Console.ReadLine(), out NumberOfQuestions));

            if (ExamType ==1)
            {
                SubjectExam = new PracticalExam(Time,NumberOfQuestions);
            }
            else
            {
                SubjectExam = new FinalExam(Time,NumberOfQuestions);
            }
            Console.Clear();
            SubjectExam.CreateListOfQuestions();
        }

    }
}
