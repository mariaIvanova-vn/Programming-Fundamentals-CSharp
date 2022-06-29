using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Dictionary<string, int> occurences = new Dictionary<string, int>();
            foreach (string word in words)
            {
                string lowerCaseWord = word.ToLower();
                if (occurences.ContainsKey(lowerCaseWord))
                {
                    occurences[lowerCaseWord]+=1;
                }
                else
                {
                    occurences.Add(word, 1);
                }
            }
            foreach (var item in occurences)
            {
                if (item.Value%2!=0)
                {
                    Console.Write($"{item.Key} ");
                }
            }
            Console.WriteLine();
        }
    }
}
