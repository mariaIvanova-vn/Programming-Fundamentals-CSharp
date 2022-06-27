using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Mirror_Words_new
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([\@|\#]){1}(?<word1>[A-z]{3,})\1{2}(?<word2>[A-z]{3,})\1{1}";
            string text = Console.ReadLine();
            List<string> result = new List<string>();

            MatchCollection matches = Regex.Matches(text, pattern);
            if (matches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
            }
            foreach (Match item in matches)
            {
               
                string firstWord = item.Groups["word1"].Value;
                string secondWord =(string) item.Groups["word2"].Value.Reverse();
                if (firstWord==secondWord)
                {
                    result.Add(firstWord);
                    result.Add(secondWord.Reverse().ToString());
                }

            }
            if (result.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");
                string[] finalResult=result
            }
        }
    }
}
