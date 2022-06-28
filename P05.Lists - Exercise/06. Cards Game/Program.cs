using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> second = Console.ReadLine().Split().Select(int.Parse).ToList();

            int sumFirst = first.Sum();
            int sumSecond = second.Sum();
            if (sumFirst>sumSecond)
            {
                int sum = 0;
                for (int i = 0; i < first.Count; i++)
                {
                    for (int j = 0; j < second.Count; j++)
                    {
                        first[i] += second[j];
                        sum += first[i];
                    }
                }
                Console.WriteLine($"First player wins! Sum: {sum}");               
            }
            else
            {
                int sum = 0;
                for (int i = 0; i < second.Count; i++)
                {
                    for (int j = 0; j < first.Count; j++)
                    {
                        second[i] += first[j];
                        sum += second[i];
                    }
                }
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
        }
    }
}
