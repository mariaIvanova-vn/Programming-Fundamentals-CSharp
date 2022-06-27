using System;

namespace _01_The_Bisquit_Factory__Mid_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numBisquitForWorkerPerDay = int.Parse(Console.ReadLine());
            int countOfWorkers = int.Parse(Console.ReadLine());
            int numOfBisquitsForMonth = int.Parse(Console.ReadLine());

            double bisqForDay = 0;

            for (int i = 1; i <= 30; i++)
            {
                if (i % 3 == 0)
                {
                    bisqForDay += Math.Floor((countOfWorkers * numBisquitForWorkerPerDay) * 0.75);
                }
                else
                {
                    bisqForDay += Math.Floor(countOfWorkers*1.0 * numBisquitForWorkerPerDay);
                }
                
            }
            Console.WriteLine($"You have produced {bisqForDay} bisquits for the past month.");
            if (bisqForDay>numOfBisquitsForMonth)
            {
                double diff = bisqForDay - numOfBisquitsForMonth;
                double percent = diff / numOfBisquitsForMonth * 100;
                Console.WriteLine($"You produce {percent:f2} percent more bisquits");
            }
            else
            {
                double diff = numOfBisquitsForMonth - bisqForDay;
                double percent = diff / numOfBisquitsForMonth * 100;
                Console.WriteLine($"You produce {percent:f2} percent less bisquits");
            }
        }
    }
}
