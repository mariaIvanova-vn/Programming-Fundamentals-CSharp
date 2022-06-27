using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Emoji_Detector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\:\:|\*\*)(?<name>[A-Z][a-z]{2,})\1";
            string text = Console.ReadLine();
            List<string> result = new List<string>();
          //  int countOfAllEmojis = 0;
            int coolThreshold = 1;
            foreach (char ch in text)
            {
                if (char.IsDigit(ch))
                {
                    int currnum = int.Parse(ch.ToString());
                    coolThreshold *= currnum;
                }
            }
            MatchCollection matches = Regex.Matches(text, pattern);           
            foreach (Match item in matches)
            {               
                   // countOfAllEmojis++;
                    int currEmoji = 0;
                    string emoji = item.Groups["name"].Value;
                    for (int i = 0; i < emoji.Length; i++)
                    {
                        currEmoji += (int)emoji[i];
                    }
                    if (currEmoji>coolThreshold)
                    {
                        result.Add(item.ToString());
                    }                           
            }
            Console.WriteLine($"Cool threshold: {coolThreshold}");
            Console.WriteLine($"{matches.Count} emojis found in the text. The cool ones are:");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
