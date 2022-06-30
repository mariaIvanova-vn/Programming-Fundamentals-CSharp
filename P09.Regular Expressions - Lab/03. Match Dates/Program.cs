using System;
using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b(\d{2})(\.|-|\/)([A-Z][a-z]{2})\2(\d{4})\b";
            string input = Console.ReadLine();
            MatchCollection dates = Regex.Matches(input, regex);
            foreach (Match item in dates)
            {
                string day = item.Groups[1].Value;
                string month = item.Groups[3].Value;
                string year = item.Groups[4].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
