using System;

namespace _01._Black_Flag_Mid_Exam     //100/100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int dailyPlunder = int.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());
            double totalPlaunder = 0;

            for (int i = 1; i <= days; i++)
            {
                totalPlaunder += dailyPlunder;
                if (i%3==0)
                {
                    totalPlaunder += dailyPlunder * 0.50;
                }
                if (i % 5 == 0)
                {
                    totalPlaunder -= totalPlaunder * 0.30;                   
                }
            }
            if (totalPlaunder>=expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {totalPlaunder:f2} plunder gained.");
            }
            else
            {
                double percent = totalPlaunder / expectedPlunder * 100;
                Console.WriteLine($"Collected only {percent:f2}% of the plunder.");
            }
        }
    }
}
