using System;

namespace _01._Guinea_Pig_Mid_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double kgFood = double.Parse(Console.ReadLine());
            double kgHay = double.Parse(Console.ReadLine());
            double kgCover = double.Parse(Console.ReadLine());
            double kgWeight = double.Parse(Console.ReadLine());

            double gramsFood = kgFood * 1000;
            double gramsHay = kgHay * 1000;
            double gramsCover = kgCover * 1000;
            double gramsWeight = kgWeight * 1000;

            for (int i = 1; i <= 30; i++)
            {
                gramsFood -= 300;
                double currFood = gramsFood;
                double currWeight = gramsWeight;
                if (i%2==0)
                {
                    gramsHay -= currFood * 0.05;
                }
                if (i%3==0)
                {
                    gramsCover -= currWeight / 3;
                }
                if (gramsFood<=0 || gramsHay<=0 || gramsCover<=0)
                {
                    Console.WriteLine("Merry must go to the pet store!");
                    return;
                }
            }
            Console.WriteLine($"Everything is fine! Puppy is happy! Food: {(gramsFood/1000):f2}, Hay: {(gramsHay/1000):f2}, Cover: {(gramsCover/1000):f2}.");
        }
    }
}


