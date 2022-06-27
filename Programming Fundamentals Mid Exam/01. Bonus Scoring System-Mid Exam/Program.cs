using System;

namespace _01._Bonus_Scoring_System_Mid_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            int numberOfLectures = int.Parse(Console.ReadLine());
            int additionalBonus = int.Parse(Console.ReadLine());

            int currAttend = 0;
            double maxBonus =0;
            
            for (int i = 0; i < numberOfStudents; i++)
            {
              int  attendanceOfEachStudent = int.Parse(Console.ReadLine());
                
                double totalBonus = (attendanceOfEachStudent*1.0 / (numberOfLectures*1.0) * (5 + (additionalBonus*1.0)));
                if (totalBonus > maxBonus)
                {
                    currAttend = attendanceOfEachStudent;
                    maxBonus = totalBonus;
                }
            }
            
            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
                Console.WriteLine($"The student has attended {currAttend} lectures.");
            }
            
        }
    }



       