using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _2._Message_Translator_exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\!)(?<word>[A-Z]{1}[a-z]{2,})\1\:\[(?<string>[A-Za-z]{8,})\]";
            List<string> result = new List<string>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string text = Console.ReadLine();
                Match match = Regex.Match(text, pattern);
                if (match.Success)
                {
                    string wordToTranslate = match.Groups["string"].Value;
                    string command = match.Groups["word"].Value;
                    foreach (char item in wordToTranslate)
                    {
                        int currCharValue = (int)item;
                        result.Add(currCharValue.ToString());
                    }
                    Console.Write($"{command}: ");                   
                    Console.WriteLine(String.Join(" ",result));
                }
                else
                {
                    Console.WriteLine("The message is invalid");
                }
            }
        }
    }
}
