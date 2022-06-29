using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Word_Synonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pairCount = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> sinonymList = new Dictionary<string, List<string>>();
            for (int i = 0; i < pairCount; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (sinonymList.ContainsKey(word))
                {
                    sinonymList[word].Add(synonym);
                }
                else
                {
                    sinonymList.Add(word, new List<string>() { synonym });
                }
            }
            foreach (var item in sinonymList)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ",item.Value)}");
            }            
        }
    }
}
