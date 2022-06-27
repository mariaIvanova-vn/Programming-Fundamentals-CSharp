using System;

namespace _01._SoftUni_Reception_Mid_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int empl1 = int.Parse(Console.ReadLine());
            int empl2 = int.Parse(Console.ReadLine());
            int empl3 = int.Parse(Console.ReadLine());
            int studentCount = int.Parse(Console.ReadLine());          
            
           int answeredStudentsForHour = empl1 + empl2 + empl3;
            int count = 0;
            while (studentCount>0)
            {
                studentCount -= answeredStudentsForHour;
                count++;
                if (count%4==0)
                {
                    count++;
                }
            }
                Console.WriteLine($"Time needed: {count}h.");            
        }
    }
}
