using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Numbers_Mid_Exam             //90/100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
           List<int> result = new List<int>();
           
            double averageSum = numbers.Average();
            
            result = numbers.OrderByDescending(x => x)
                             .Where(num => num > averageSum)
                             .Take(5)
                             .ToList();
            if (numbers.Count <= 1)
            {
                Console.WriteLine("No");
                return;
            }

            Console.WriteLine(String.Join(" ",result));
        }
    }
}




