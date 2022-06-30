using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02._Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder letters = new StringBuilder();
            StringBuilder nums = new StringBuilder();

            List<string> participants = Console.ReadLine().Split(", ").ToList();

            string input;
            while ((input = Console.ReadLine()) != "end of race")
            {
                foreach (var item in input)
                {
                    if (char.IsLetter(item))
                    {
                        letters.Append(item);
                    }
                    else if (char.IsDigit(item))
                    {
                        nums.Append(item);
                    }
                }
                if (!participants.Contains(letters.ToString()))
                {
                    break;
                }

            }
            Console.WriteLine($"1st place: { first racer}");
            Console.WriteLine($"2nd place: { second racer}");
            Console.WriteLine($"3rd place: { third racer}");
        }
    }
}