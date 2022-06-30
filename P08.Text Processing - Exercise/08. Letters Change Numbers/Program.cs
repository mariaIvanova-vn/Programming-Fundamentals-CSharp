using System;
using System.Linq;

namespace _08._Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            decimal sum = 0;
            foreach (string word in words)
            {
                sum += CalculateWord(word);
            }
            Console.WriteLine($"{sum:f2}");
        }
        static int GetAlphabeticalPosition(char ch)
        {
            if (!Char.IsLetter(ch))
            {
                return -1;
            }
            char chCI = char.ToLowerInvariant(ch);
            return (int)chCI - 96;
        }
        static decimal CalculateWord(string word)
        {
            decimal sum = 0;
            char firstLetter = word[0];
            char lastLetter = word[word.Length - 1];
            int numSubStr = int.Parse(word.Substring(1, word.Length - 2));
            int firstLetterPosition = GetAlphabeticalPosition(firstLetter);
            int lasttLetterPosition = GetAlphabeticalPosition(lastLetter);
            if (char.IsUpper(firstLetter))
            {
                sum = (decimal)numSubStr / firstLetterPosition;
            }
            else if (char.IsLower(firstLetter))
            {
                sum = (decimal)numSubStr * firstLetterPosition;
            }
            if (char.IsUpper(lastLetter))
            {
                sum -= lasttLetterPosition;
            }
            else if (char.IsLower(lastLetter))
            {
                sum += lasttLetterPosition;
            }
            return sum;
        }
    }
}
