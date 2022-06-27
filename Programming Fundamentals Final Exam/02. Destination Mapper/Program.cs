using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;                // 100 / 100

namespace _02._Destination_Mapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([\=|\/])(?<name>[A-Z]{1}[A-z]{2,})\1";
            string input = Console.ReadLine();
            int points = 0;
            List<string> result = new List<string>();
            
            MatchCollection matches = Regex.Matches(input, pattern);
            foreach (Match item in matches)
            {
                string name = item.Groups["name"].Value;
                foreach (char ch in item.Value)
                {
                    if (char.IsLetter(ch))
                    {
                        points += 1;
                    }
                }               
                    result.Add(name);             
            }            
            Console.Write("Destinations: ");
            Console.WriteLine(string.Join(", ", result));

            Console.WriteLine($"Travel Points: {points}");
        }
    }
}
