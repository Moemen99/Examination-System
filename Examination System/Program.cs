using System.Diagnostics;

namespace Examination_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new(1, "C Sharp");

            subject.CreateExam();
            Console.Clear();
            Console.WriteLine("Do you Want to Start The Exam (Y|N): ");
            char c=char.Parse(Console.ReadLine());

            if (c == 'Y' || c== 'y')
            {
                Console.Clear() ;
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                subject.SubjectExam.ShowExam();
                Console.WriteLine($"Taken Time : {stopwatch.Elapsed}");
            }
            else
            {
                Console.WriteLine("Thank You");
            }
        }
    }
}