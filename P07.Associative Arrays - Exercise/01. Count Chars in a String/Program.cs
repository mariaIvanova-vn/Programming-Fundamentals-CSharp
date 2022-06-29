using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> result = new Dictionary<char, int>();
            string input = Console.ReadLine();
            char[] charArray = input.ToCharArray();
            for (int i = 0; i < input.Length; i++)
            {
                char currChar = input[i];
                if (currChar == ' ')
                {
                    continue;
                }
                if (result.ContainsKey(currChar))
                {
                    result[currChar]++;
                }
                else
                {
                    result.Add(currChar, 1);
                }
            }
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
