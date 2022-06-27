using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Mirror_Words             // 100 / 100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\@|\#)(?<word1>[A-z]{3,})\1{2}(?<word2>[A-z]{3,})\1";
            string text = Console.ReadLine();

            MatchCollection matches = Regex.Matches(text, pattern);
            List<string[]> result = new List<string[]>();

            if (matches.Count==0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
            }
            foreach (Match item in matches)
            { 
                string word1 = item.Groups["word1"].Value;
                string word2 = item.Groups["word2"].Value;
                string reverseSecondWord = string.Join("", word2.Reverse());
                if (word1==reverseSecondWord)
                {
                    result.Add(new string[] { word1, word2 });  
                }
            }
            if (result.Count==0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                string[] messages = result.Select(word => $"{word[0]} <=> {word[1]}").ToArray();
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(string.Join(", ",messages));
            }                                     
        }
    }
}
