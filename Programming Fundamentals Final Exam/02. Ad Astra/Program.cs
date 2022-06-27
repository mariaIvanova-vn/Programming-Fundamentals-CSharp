using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;                  //   100 / 100

namespace _02._Ad_Astra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([\||\#])(?<name>[A-Za-z\s]+)\1(?<date>\d{2}\/\d{2}\/\d{2})\1(?<calories>\d+)\1";
            string text = Console.ReadLine();
            int total = 0;
            MatchCollection matches = Regex.Matches(text, pattern);
            
            foreach (Match item in matches)
            {
                if (item.Success)
                {
                    string name = item.Groups["name"].Value;
                    string date = item.Groups["date"].Value;
                    int calories = int.Parse(item.Groups["calories"].Value);                    
                    total += calories;                                                                             
                }               
            }
            int totalDays = Math.Abs(total / 2000);
            Console.WriteLine($"You have food to last you for: {totalDays} days!");
            foreach (Match item in matches)
            {
                if (item.Success)
                {
                    string name = item.Groups["name"].Value;
                    string date = item.Groups["date"].Value;
                    int calories = int.Parse(item.Groups["calories"].Value);

                    Console.WriteLine($"Item: {name}, Best before: {date}, Nutrition: {calories}");
                }
            }
        }
    }
}
