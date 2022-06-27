using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Destination_Mapper_new
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> result = new List<string>();
            string pattern = @"([\=|\/])(?<name>[A-Z]{1}[A-z]{2,})\1";
            string text = Console.ReadLine();
            int travelPoints = 0;
           
            MatchCollection matches = Regex.Matches(text, pattern);
            foreach (Match item in matches)
            {
                string name = item.Groups["name"].Value;
                for (int i = 0; i < name.Length; i++)
                {
                    travelPoints++;
                }           
                    result.Add(name);    
            }
            Console.Write("Destinations: ");
            Console.WriteLine(string.Join(", ", result));   
            Console.WriteLine($"Travel Points: {travelPoints}");
        }
    }
}
