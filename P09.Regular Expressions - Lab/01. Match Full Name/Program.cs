using System;
using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            string input = Console.ReadLine();
            MatchCollection matches = Regex.Matches(input, regex);
            foreach (Match item in matches)
            {
                Console.Write(item.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
